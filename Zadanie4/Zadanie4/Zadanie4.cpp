// Zadanie4.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include "pch.h"
#include <iostream>
#include <list>
#include <string>
#include <vector>

class Tree
{
private:
	std::string _name;
	std::list<Tree *> _branches;

public:
	Tree(std::string name)
	{
		_name = name;
	}

	~Tree()
	{
		for (std::list<Tree *>::iterator it = this->_branches.begin(); it != _branches.end(); ++it)
		{
			Tree * tree = *it;
			tree->~Tree();
			delete tree;
			printf("destroyed");
		}
	}

	Tree * AddSub(std::string name)
	{
		Tree * branch = new Tree(name);
		_branches.push_back(branch);
		return branch;
	}
	int GetChilds()
	{
		int count = 0;
		for (unsigned int i = 0; i < this->_branches.size(); i++)
		{
			count++;
		}
		return count;
	}
	int GetAllChilds()
	{
		int count = 0;

		for (std::list<Tree *>::iterator it = this->_branches.begin(); it != _branches.end(); ++it)
		{
			Tree * tree = *it;
			count++;
			count += tree->GetAllChilds();
		}
		return count;
	}

	void Printf(bool show = false, int count = 1, std::string iterator = "1")
	{
		if (show)
		{
			printf("%s.%s\n", iterator.c_str(), this->_name.c_str());
			count++;
			int i = 1;
			for (std::list<Tree *>::iterator it = this->_branches.begin(); it != _branches.end(); ++it)
			{
				Tree * tree = *it;
				iterator = iterator + "." + std::to_string(i);
				printf("%*s", count, "");
				tree->Printf(true, count, iterator);
				iterator = std::to_string(i);
				i++;
			}
		}
		else
		{
			printf("%s\n", this->_name.c_str());
			count++;
			for (std::list<Tree *>::iterator it = this->_branches.begin(); it != _branches.end(); ++it)
			{
				printf("%*s", count, "");
				Tree * tree = *it;
				tree->Printf(false, count);

			}
		}
	}
};

int main()
{
	Tree * root = new Tree("root");
	Tree * branch = root->AddSub("branch");
	Tree * branch2 = root->AddSub("branch2");
	Tree * branchofbranch = branch->AddSub("branch3");
	Tree * anotherone = branchofbranch->AddSub("brunch1");
	Tree * anotherone2 = anotherone->AddSub("brunch2");
	Tree * anotherone3 = anotherone2->AddSub("brunch3");
	Tree * anotherone4 = branch2->AddSub("branch22");
	//printf("%d", root->GetChilds());
	//printf("\n%d", root->GetAllChilds());
	//root->Printf(true);
	delete(root);
}

// Uruchomienie programu: Ctrl + F5 lub menu Debugowanie > Uruchom bez debugowania
// Debugowanie programu: F5 lub menu Debugowanie > Rozpocznij debugowanie

// Porady dotyczące rozpoczynania pracy:
//   1. Użyj okna Eksploratora rozwiązań, aby dodać pliki i zarządzać nimi
//   2. Użyj okna programu Team Explorer, aby nawiązać połączenie z kontrolą źródła
//   3. Użyj okna Dane wyjściowe, aby sprawdzić dane wyjściowe kompilacji i inne komunikaty
//   4. Użyj okna Lista błędów, aby zobaczyć błędy
//   5. Wybierz pozycję Projekt > Dodaj nowy element, aby utworzyć nowe pliki kodu, lub wybierz pozycję Projekt > Dodaj istniejący element, aby dodać istniejące pliku kodu do projektu
//   6. Aby w przyszłości ponownie otworzyć ten projekt, przejdź do pozycji Plik > Otwórz > Projekt i wybierz plik sln
