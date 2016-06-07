#include <stdio.h>
#include <stdlib.h>

int main()
{
	char name[5];//index:0~4
	int i;
	char std0[5];
	char std1[5];

	//printf("----------------->01\n");
	//printf("name[%d]:%d\n",0,&name[0]);//&:取址運算子
	//printf("name[%d]:%d\n",1,&name[1]);
	//printf("name[%d]:%d\n",2,&name[2]);
	//printf("name[%d]:%d\n",3,&name[3]);
	//printf("name[%d]:%d\n",4,&name[4]);

	//printf("----------------->02\n");
	//printf("name[%d]:%d\t%d\n",0,&name[0],sizeof(name[0]));//sizeof:大小運算子
	//printf("name[%d]:%d\t%d\n",1,&name[1],sizeof(name[1]));
	//printf("name[%d]:%d\t%d\n",2,&name[2],sizeof(name[2]));
	//printf("name[%d]:%d\t%d\n",3,&name[3],sizeof(name[3]));
	//printf("name[%d]:%d\t%d\n",4,&name[4],sizeof(name[4]));

	//printf("----------------->03\n");
	//printf("name[%d]:%d\t%d\t%c\n",0,&name[0],sizeof(name[0]),name[0]);
	//printf("name[%d]:%d\t%d\t%c\n",1,&name[1],sizeof(name[1]),name[0]);
	//printf("name[%d]:%d\t%d\t%c\n",2,&name[2],sizeof(name[2]),name[0]);
	//printf("name[%d]:%d\t%d\t%c\n",3,&name[3],sizeof(name[3]),name[0]);
	//printf("name[%d]:%d\t%d\t%c\n",4,&name[4],sizeof(name[4]),name[0]);

	//printf("----------------->04\n");
	//for(i=0;i<=4;i=i+1)
	//{
	//	printf("name[%d]:%d\t%d\t%c\n",i,&name[i],sizeof(name[i]),name[i]);
	//}

	//printf("----------------->05\n");
	//scanf("%c",&name[0]);
	//for(i=0;i<=4;i=i+1)
	//{
	//	printf("name[%d]:%d\t%d\t%c\n",i,&name[i],sizeof(name[i]),name[i]);
	//}

	//printf("----------------->06\n");
	//scanf("%c",&name[0]);
	//scanf("%c",&name[1]);
	//scanf("%c",&name[2]);
	//scanf("%c",&name[3]);
	//scanf("%c",&name[4]);
	//for(i=0;i<=4;i=i+1)
	//{
	//	printf("name[%d]:%d\t%d\t%c\n",i,&name[i],sizeof(name[i]),name[i]);
	//}

	//printf("----------------->07\n");
	//for(i=0;i<=4;i=i+1)
	//{
	//	scanf("%c",&name[i]);
	//}

	//for(i=0;i<=4;i=i+1)
	//{
	//	printf("name[%d]:%d\t%d\t%c\n",i,&name[i],sizeof(name[i]),name[i]);
	//}


	//printf("----------------->08\n");
	//for(i=0;i<=4;i=i+1)
	//{
	//	scanf("%c",&name[i]);
	//	if(name[i]=='#')
	//		break;
	//}

	//for(i=0;i<=4;i=i+1)
	//{
	//	printf("name[%d]:%d\t%d\t%c\n",i,&name[i],sizeof(name[i]),name[i]);
	//}

	//printf("----------------->09\n");
	//for(i=0;i<=4;i=i+1)
	//{
	//	scanf("%c",&name[i]);
	//	if(name[i]=='#')
	//		break;
	//}

	//for(i=0;i<=4;i=i+1)
	//{
	//	if(name[i]=='#')
	//		break;
	//	printf("name[%d]:%d\t%d\t%c\n",i,&name[i],sizeof(name[i]),name[i]);
	//}

	//printf("----------------->10\n");
	//for(i=0;i<=4;i=i+1)
	//{
	//	scanf("%c",&name[i]);
	//	if(name[i]=='\n')
	//		break;
	//}

	//for(i=0;i<=4;i=i+1)
	//{
	//	if(name[i]=='\n')
	//		break;
	//	printf("name[%d]:%d\t%d\t%c\n",i,&name[i],sizeof(name[i]),name[i]);
	//}

	//printf("----------------->11\n");
	//for(i=0;i<=4;i=i+1)
	//{
	//	scanf("%c",&name[i]);
	//	if(name[i]=='\n')
	//	{
	//		name[i] = '\0';
	//		break;
	//	}
	//}

	//for(i=0;i<=4;i=i+1)
	//{
	//	if(name[i]=='\0')
	//		break;
	//	printf("name[%d]:%d\t%d\t%c\n",i,&name[i],sizeof(name[i]),name[i]);
	//}

	//printf("----------------->12\n");
	//for(i=0;i<=4;i=i+1)
	//{
	//	scanf("%c",&name[i]);
	//	if(name[i]=='\n')
	//	{
	//		name[i] = '\0';//NULL:空字元
	//		break;
	//	}
	//}

	//for(i=0;i<=4;i=i+1)
	//{
	//	if(name[i]=='\0')
	//		break;
	//	printf("name[%d]:%d\t%d\t%c\n",i,&name[i],sizeof(name[i]),name[i]);
	//}

	//printf("%s\n",name);
	//printf("%d\n",name);
	//printf("%s\n",&name[0]);
	//printf("%d\n",&name[0]);

	//printf("----------------->13\n");
	//scanf("%s",name);
	//printf("%s\n",name);
	////scanf("%s",&name[0]);
	////printf("%s\n",&name[0]);

	//printf("----------------->14\n");
	//gets(name);
	//puts(name);

	printf("----------------->15\n");
	gets(std0);
	gets(std1);
	puts(std0);
	puts(std1);

	system("pause");
	return 0;
}