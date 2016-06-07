#include <stdio.h>
#include <stdlib.h>
int main()
{
	//char name[5];//index:0~4
	int i;
	////
	//printf("------------->01\n");
	//printf("name[%d]:%d\t%d\n",0,&name[0],sizeof(name[0]));
	//printf("name[%d]:%d\t%d\n",1,&name[1],sizeof(name[1]));
	//printf("name[%d]:%d\t%d\n",2,&name[2],sizeof(name[2]));

	////
	//printf("------------->02\n");
	//for (int i = 0; i < 5; i++ ){ 
	//	printf("name[%d]:%d\t%d\t%c\n",i,&name[i],sizeof(name[i]),name[i]);
	//}
	////
	//printf("------------->03\n");
	//for (int i = 0; i < 5; i++ ){ 
	//	scanf("%c",&name[i]);
	//	printf("name[%d]:%d\t%d\t%c\n",i,&name[i],sizeof(name[i]),name[i]);
	//	if(&name[i] == "#"){break;}
	//}
	////
	//printf("------------->04\n");
	//for (int i = 0; i < 5; i++ ){ 
	//	scanf("%c",&name[i]);
	//	//if(name[i] == '#'){break;}
	//	if(name[i] == '\n'){
	//		name[i] = '\0';
	//		break;
	//	}
	//	printf("name[%d]:%d\t%d\t%c\n",i,&name[i],sizeof(name[i]),name[i]);
	//}
	////

	//printf("------------->05\n");
	//for (int i = 0; i < 5; i++ ){ 
	//	scanf("%c",&name[i]);
	//	if(name[i] == '\n')
	//	{
	//		name[i] = '\0';
	//		//有\0 name可以當成字串操作
	//		//字元陣列當成字元字串
	//		break;
	//	}
	//}
	//printf("%s\n",name);
	//printf("%d\n",name);
	//printf("%s\n",&name[0]);
	//printf("%d\n",&name[0]);
	//printf("%s\n",&name[1]);
	//printf("%d\n",&name[1]);
	////
	//printf("------------->06\n");
	//for (int i = 0; i < 5; i++ ){ 
	//	scanf("%s",name);
	//	if(name[i] == '\n')
	//	{
	//		name[i] = '\0';
	//		//有\0 name可以當成字串操作
	//		//字元陣列當成字元字串
	//		break;
	//	}
	//}
	//printf("%s\n",name);
	//printf("%d\n",name);
	//printf("%s\n",&name[0]);
	//printf("%d\n",&name[0]);
	//printf("%s\n",&name[1]);
	//printf("%d\n",&name[1]);
	////
	//printf("------------->07\n");
	////scanf("%s",name);
	////printf("%s\n",name);//=	printf("%s\n",&name[0]);
	//gets(name);
	//puts(name);

	printf("------------->08\n");
	char std0[5];//index:0~4
	char std1[5];//index:0~4
	gets(std0);
	gets(std1);
	puts(std0);
	puts(std1);

	system("pause");
	return 0;
}