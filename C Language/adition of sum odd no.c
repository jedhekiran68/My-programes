#include<stdio.h>
int main()
{
	int no;
	int sumeven=0,sumodd=0;
	printf("enter no:",no);
	scanf("%d",&no);
	for(no=1;no<100;no++)
	
	{
		 if(no%2!=0)
		 {
		 	printf("%d\n",no);
		 	scanf("%d",&no);
		 	sumodd=no+sumodd;
		 }
		 else
		 {
		 	printf("%d",no);
		 	scanf("%d",&no);
		 	sumeven=no+sumeven;
		 }
		 
	}
	printf("addition of odd no: %d\n",sumodd);
	printf("addition of even no: %d\n",sumeven);
	
}
