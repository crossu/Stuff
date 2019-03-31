// Zadanie4.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include "pch.h"
#include <iostream>
#include <list>

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

	std::string GetName()
	{
		return _name;
	}

	std::list<Tree *> GetBranches()
	{
		return _branches;
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
		for (unsigned int i = 0; i < _branches.size(); i++)
		{
			count++;
		}
		return count;
	}
	int GetAllChilds()
	{
		int count = 0;
		for (std::list<Tree *>::iterator it = _branches.begin(); it != _branches.end(); ++it)
		{
			Tree * tree = *it;
			count++;
			for (unsigned int j = 0; j < tree->_branches.size(); j++)
			{
				count++;
			}
		}
		return count;
	}

	void Delete(Tree * tree)
	{
		for (std::list<Tree *>::iterator it = _branches.begin(); it != _branches.end(); ++it)
		{
			Tree * tree = *it;
			tree->_branches.clear();
		}
		tree->_branches.clear();
	}
	void Printf(bool show = false)
	{
		//glowny problem tutaj, nie jestem w stanie z pointera iteratora uzyskac obiektu w liscie
		if (show)
		{
 			printf("%s", "1."+_name);
			int count = 0;
			for (std::list<Tree *>::iterator it = _branches.begin(); it != _branches.end(); ++it)
			{
				count++;
				Tree * tree = *it;
				//spodziewalem sie ze tree bedzie moglo wyciagnac wartosc _name ale zwraca zupelnie inne wartosci
				printf("%s\n", tree->_name);
				for (std::list<Tree *>::iterator jt = _branches.begin(); jt != _branches.end(); ++jt)
				{
					Tree * tree2 = *jt;
					printf("%s\n", tree2->GetName());
				}
			}

		}
		else
		{
			printf("%s", this->GetName());
			for (std::list<Tree *>::iterator it = _branches.begin(); it != _branches.end(); ++it)
			{
				Tree * tree = *it;
				printf("%s\n", tree->_name);
				for (std::list<Tree *>::iterator jt = _branches.begin(); jt != _branches.end(); ++jt)
				{
					Tree * tree2 = *jt;
					printf("%s\n", tree2->GetName());
				}
			}
		}
	}
};

void Delete(Tree * tree)
{
	//tutaj dostaje blad C2228 po lewej .begin musi byc typ struct/union
	for (std::list<Tree *>::iterator it = tree->GetBranches.begin(); it != tree->GetBranches.end(); ++it)
	{
		Tree * tree1 = *it;
		tree1->GetBranches.clear();
	}
	tree->GetBranches.clear();
};

int main()
{
	Tree * root = new Tree("root");
	Tree * branch = root->AddSub("branch");
	Tree * branch2 = root->AddSub("branch2");
	Tree * branchofbranch = branch->AddSub("branch3");
	Delete(root);
	printf("%d", root->GetChilds());
	printf("\n%d", root->GetAllChilds());
	printf("\n");
	root->Printf();
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
