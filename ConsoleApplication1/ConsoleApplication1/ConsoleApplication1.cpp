// ConsoleApplication1.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include "pch.h"
#include <iostream>
#include <stdint.h>
#include <string>
#include <vector>

uint32_t GetBitsFromUint32(uint32_t inputValue, uint8_t bitOffset, uint8_t bitLength)
{
	uint32_t temp = 0;
	for (int i = 0; i < bitLength; i++)
	{
		temp <<= 1;
		temp += 1;
	}
	uint32_t value = (inputValue >> bitOffset) & temp;
	//uint32_t value = 0;
	return value;
}

int GetBitsFromUint32(const char* inputValue, uint8_t bitOffset, uint8_t bitLength)
{
	uint32_t temp;
	temp = std::strtoul(inputValue, NULL, 16);
	return GetBitsFromUint32(temp, bitOffset, bitLength);
}

std::vector<bool> ConvertToBinary(int number)
{
	std::vector<bool> vektor;
	while (number != 0)
	{
		if (number % 2 == 0)
		{
			vektor.push_back(false);
		}
		if (number % 2 == 1)
		{
			vektor.push_back(true);
		}
		number = number / 2;
	}
	return vektor;
}
std::vector<bool> GetBitsVector(std::string inputValue)
{
	//tutaj troche musialem podejzec rozwiazanie
	std::vector<bool> vektor;
	int temp = 1;
	if (inputValue.at(1) == 'x')
	{
		int temp = std::strtol(inputValue.c_str(), NULL, 0);
		return ConvertToBinary(temp);
	}
	else
	{
		int temp = std::stoi(inputValue);
		return ConvertToBinary(temp);
	}
}

void DisplayVector(std::vector<bool> vector)
{
	for (int i = 0; i < vector.size(); i++)
	{
		std::cout << vector[i];
	}
}

int main()
{
	std::cout << std::hex << GetBitsFromUint32(0xABCDEF12, 4, 12);
	std::cout << "\n";
	std::cout << std::hex << GetBitsFromUint32("0xABCDEF12", 4, 12);
	std::cout << "\n";
	DisplayVector(GetBitsVector("123"));
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
