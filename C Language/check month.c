#include<stdio.h>
int main()
{
	int month_no;
	printf("enter month no:");
	scanf("%d",&month_no);
	
	switch(month_no)
	{
		case 1:printf("'1'st month is \nJANUARY\n");break;
		case 2:printf("'2'st month is \nFEBRUARY\n");break;
		case 3:printf("'3'st month is \nMARCH\n");break;
		case 4:printf("'4'st month is \nAPRIL\n");break;
		case 5:printf("'5'st month is \nMAY\n");break;
		case 6:printf("'6'st month is \nJUNE\n");break;
		case 7:printf("'7'st month is \nJULY\n");break;
		case 8:printf("'8'st month is \nAUGUST\n");break;
		case 9:printf("'9'st month is \nSEPTEMBER\n");break;
		case 10:printf("'10'st month is \nOCTOMBER\n");break;
		case 11:printf("'11'st month is \nNOVEMBER\n");break;
		case 12:printf("'12'st month is \nDECEMBER\n");break;
		default:("month is NOT AVAILABLE");
		
	}
 } 
     

