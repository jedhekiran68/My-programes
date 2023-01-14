#include<stdio.h>
#include<string.h>
int main()
{
	int a,square,*p;
	printf("enter no:");
	scanf("&d",&a);
	p=&a;
	square=a*a;
	printf("square:&d",square);
}
