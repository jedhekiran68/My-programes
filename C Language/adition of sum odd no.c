#include<stdio.h>
int main()
{
	int no;
	int sumeven=0,sumodd=0;
	printf("enter no:",no);
	scanf("%d",&no);
	int i;
	for(i=1;i<100;i++)
	
	{
		 if(i%2==0)
		 {
		 	printf("%d\n",i);
		 	scanf("%d",&i);
		 	sumeven=i+sumeven;
		 }
		 else
		 {
		 	printf("%d",i);
		 	scanf("%d",&i);
		 	sumodd=no+sumodd;
		 }
		 
	}
	printf("addition of odd no: %d\n",sumodd);
	printf("addition of even no: %d\n",sumeven);
	
}
