// prime.cpp : 定义 DLL 应用程序的导出函数。
//

#include "stdafx.h"
#include "prime.h"

#include <cstdio>
#include <memory.h>

int prime[10000000], count_prime = 0;
bool a[10000001];

void __stdcall prime_produce()
{
	memset(a, 1, sizeof(a));
	for (int i = 2; i <= 10000000; i++)
	{
		if (a[i] == 1)
		{
			for (int j = i + i; j <= 10000000; j += i) a[j] = 0;
		}
	}
	for (int i = 1000000; i <= 10000000; i++)
	{
		if (a[i] == 1) prime[count_prime] = i, count_prime++;
	}
	FILE *fp;
	fopen_s(&fp,"prime_data.txt", "w");
	fprintf_s(fp, "%d\n", count_prime);
	for (int i = 0; i<count_prime; i++)
	{
		fprintf_s(fp, "%d\n", prime[i]);
	}
	fclose(fp);
}
