#include "pch.h"
#include <iostream>
#include <fstream>
#include <iomanip> 

using namespace std;
class Point {
public:
    Point(int x, int y, int h, int g) {
        this->x = x;
        this->y = y;
        this->h = h;
        this->g = g;
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

private:
    int x;
    int y;
    int h;
    int g;
};

class Grid {
public:
    Grid(double** G, int wym1, int wym2) {
        this->G = G;
        this->wym1 = wym1;
        this->wym2 = wym2;

        for (int i = 0; i < wym2 + 1; i++) {
            for (int j = 0; j < wym1 + 1; j++) {
                this->G[i][j] = G[i][j];
            }
        }
    }

    double GetValue(int i, int j) {
        return G[i][j];
    }

private:
    double** G;
    int wym1;
    int wym2;
};
int main(void) {

    cout << "Wczytywanie danych z pliku\n";

    string nazwap = "C:\\Users\\wynio\\Downloads\\wczytaj\\grid.txt";
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
    Grid grid(G, wym1, wym2);
    cout << "\nWypisujemy na ekran\n\n";
    for (int i = 0; i < wym2; i++)
    {
        for (int j = 0; j < wym1; j++)
        {
            std::cout << " " << grid.GetValue(i, j);
        }cout << "\n";
    }

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
