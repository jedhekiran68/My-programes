/*#include<stdio.h>
int main()
{
	int a=45,b=70;
	int *p,*q;
	
	p=&a;
	q=&b;
	
	if(*p>*q)
	{
		printf("largest no is:%d",*p);
	}
	else
	{
		printf("largest no is:%d",*q);
		
	}
}*/


#include<stdio.h>
int main()
{
	int a , b;
	int *p,*q,*large;
	printf("enter value of a and b:");
	scanf("%d%d",&a,&b);
	p=&a;
	q=&b;
	if(*p>*q)
	{
		large=p;
	}
	else
	{
		large=q;
	}
	printf("the largest no is:%d",large);
}
