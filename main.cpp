#include "pch.h"
#include <iostream>
#include <fstream>
#include <iomanip> 
#include <vector>
#include <algorithm>

using namespace std;
class Point {
public:
    Point() : x(0), y(0), h(0), g(0), parent(nullptr) {}
    Point(int x, int y, int h, int g, Point *parent){
        this->x = x;
        this->y = y;
        this->h = h;
        this->g = g;
        this->parent = parent;
    }

    int GetX() {
		return x;
	}

    int GetY() {
        return y;
    }

    int GetH() {
        return h;
    }

    int GetG() {
        return g;
    }

    Point *GetParent() {
		return parent;
	}

    void SetX(int nx) {
        x = nx;
    }

    void SetY(int ny) {
		y = ny;
	}

    void SetH(int nh) {
		h = nh;
	}

    void SetG(int ng) {
        g = ng;
    }

    void SetParent(Point *np) {
        parent = np;
    }

    bool operator==(const Point& other) const {
        return x == other.x && y == other.y;
    }

private:
    int x;
    int y;
    int h;
    int g;
    Point *parent;
};

class Grid {
public:
    Grid(double** G, int wym1, int wym2, Point start, Point goal, Point final) 
        : G(G), wym1(wym1), wym2(wym2), start(start), goal(goal), closedList(), openList(), neighbours() {
        this->findPath();
    }
    void printGrid() {
        for (int i = 0; i < wym2; i++) {
            for (int j = 0; j < wym1; j++) {
				cout << this->G[i][j] << " ";
			}
			cout << "\n";
		}
    }
    
    bool isWall(int i, int j) {
        if (G[i][j] == 5) {
			return true;
		}
        return false;
    }

    void getPath(Point current) {
        std::vector<Point> path;
        while (current.GetParent() != nullptr) {
			cout << current.GetX() << " " << current.GetY() << "\n";
			current = *current.GetParent();
            path.push_back(current);
		}   
        for (int i = 0; i < wym2; i++) {
            for (int j = 0; j < wym1; j++) {
                bool isPath = false;
                for (int k = 0; k < path.size(); k++) {
                    
                    if (path[k].GetX() == i && path[k].GetY() == j) {
                        cout << "---------" << "\n";
                        cout<< path[k].GetX() << " " << path[k].GetY() << "\n";
                        isPath = true;
                        break;
                    }
                }
                if (isPath) {
                    G[i][j] = 8;
                }
            }
        }    
    }
        
    void findPath(){
        bool foundFlag = false;
        openList.push_back(start);
        Point *minScore = nullptr;
        while (!openList.empty()) {
            neighbours.clear();
            auto minScore = std::min_element(openList.begin(), openList.end(), [](Point a, Point b) {return a.GetH() + a.GetG() < b.GetH() + b.GetG(); });
            
            if (minScore != openList.end() && minScore->GetX() == goal.GetX() && minScore->GetY() == goal.GetY()) {
                cout << minScore->GetX() << " " << minScore->GetY() << "\n";
                foundFlag = true;
                this->final = *minScore;
                break;
            }

            Point current = *minScore;
			openList.erase(minScore);
			closedList.push_back(current);

            int moves[4][2] = { {0, 1}, {0, -1}, {-1, 0}, {1, 0} };
            for (int i = 0; i < 4; i++) {
                int newX = current.GetX() + moves[i][0];
                int newY = current.GetY() + moves[i][1];
                if (newX >= 0 && newX < wym1 + 1 && newY >= 0 && newY < wym2 + 1) {
                    if (isWall(current.GetX(), current.GetY())) {
                        cout << "Wall\n";
                        closedList.push_back(current);
                    }
                    else {
                        neighbours.push_back(Point(newX, newY, 0, 0, nullptr));
                    }
                }
            }

            for (int i = 0; i < neighbours.size(); i++) {
                Point currentNeighbour = neighbours[i];
                bool isInClosedList = std::find(closedList.begin(), closedList.end(), currentNeighbour) != closedList.end();
                bool isInOpenList = std::find(openList.begin(), openList.end(), currentNeighbour) == openList.end();
               
                if (isInClosedList) {
					continue;
				}

                double tenative_gScore = current.GetG() + gScore(current, currentNeighbour);
                bool tenativeIsBetter = false;


                if (isInOpenList) {
                    addToOpenList(currentNeighbour, current);
                    tenativeIsBetter = true;
                }
                else if (tenative_gScore < currentNeighbour.GetG()) {
					tenativeIsBetter = true;
				}
                if (tenativeIsBetter) {
                    currentNeighbour.SetG(tenative_gScore);
                    currentNeighbour.SetH(heuristic(currentNeighbour, goal));
                }
			}
        }

        if (foundFlag) {
            if (&this->final != nullptr) { // dlaczego przekazany argument nie ma rodzica
                cout << "Path found FOUND FLAG\n";
                getPath(this->final);
            }    
        }
    }

    void addToOpenList(Point p, Point parent) {
        p.SetParent(new Point(parent.GetX(), parent.GetY(), 0, 0, parent.GetParent()));
        openList.push_back(p);
	}

    bool checkOpenList(Point p) {
        for (int i = 0; i < openList.size(); i++) {
            if (openList[i].GetX() == p.GetX() && openList[i].GetY() == p.GetY()) {
				return false;
			}
		}
		return true;
    }

    bool checkClosedList(Point p) {
        for (int i = 0; i < closedList.size(); i++) {
            if (closedList[i].GetX() == p.GetX() && closedList[i].GetY() == p.GetY()) {
                return false;
            }
        }
        return true;
    }

    Point move(Point p, int x, int y) {
		Point newPoint(p.GetX() + x, p.GetY() + y, p.GetH(), p.GetG(), &p);
		if(newPoint.GetX() < 0 || newPoint.GetX() > wym1 + 1 || newPoint.GetY() < 0 || newPoint.GetY() > wym2 + 1) {
            return Point();
        }
        return newPoint;
	}

    double heuristic(Point p, Point goal) {
        return std::sqrt(std::pow(p.GetX() - goal.GetX(), 2) + std::pow(p.GetY() - goal.GetY(), 2));
	}

    double gScore(Point start, Point p){
        return std::sqrt(std::pow(start.GetX() - p.GetX(), 2) + std::pow(start.GetY() - p.GetY(), 2));
    }


    double GetValue(int i, int j) {
        return G[i][j];
    }

    void setH(int i, int j, int h) {
		G[i][j] = h;
	}

private:
    double** G;
    int wym1;
    int wym2;
    Point start;
    Point goal;
    std::vector<Point> closedList;
    std::vector<Point> openList;
    std::vector<Point> neighbours;
    Point final;
};

int main(void) {
    cout << "Wczytywanie danych z pliku\n";

    string nazwap = "C:\\Users\\wynio\\Downloads\\grid.txt";
    int wym2 = 20;
    int wym1 = 20;

    //teraz deklarujemy dynamicznie tablice do, której wczytamyu nasz plik,
    int rows = wym2 + 1;
    double** G;
    G = new double* [rows];
    while (rows--) G[rows] = new double[wym1 + 1];

    cout << "\n\nNacisnij ENTER aby wczytac tablice o nazwie " << nazwap;
    getchar();

    std::ifstream plik(nazwap.c_str());

    for (unsigned int i = 0; i < wym2; i++)
    {
        for (unsigned int j = 0; j < wym1; j++)
        {
            plik >> G[i][j];
        }
    }

    plik.close();

    Point start(0, 0, 0, 0, nullptr);
    Point goal(19, 19, 0, 0, nullptr);
    Point final(0, 0, 0, 0, nullptr);
    Grid grid(G, wym1, wym2, start, goal, final);
    cout << "\nWypisujemy na ekran\n\n";
    grid.printGrid();
    //na koniec czyścimy pamięć po naszej tablicy
    for (int i = 0;i < wym2 + 1;i++)
    {
        delete[] G[i];
    }//czyscimy wiersze
    delete[] G;//zwalniamy tablice wskaznikow do wierszy

    cout << "\n\nNacisnij ENTER aby zakonczyc";
    getchar();


    return 0;
}
