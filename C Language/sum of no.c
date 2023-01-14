#include<stdio.h>
int main()
{
	int num, sum=0;
	printf("enter digit whose u have a has sum:");
	scanf("%d",&num);
	while(num!=0);
	{
		sum+=num%10;
		num=num/10;
	}
	printf("sum of that no:=%d",sum);
	return 0;
}
