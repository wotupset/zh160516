#include <stdio.h>
#include <stdlib.h>

int main(){
	//印出字串 
	printf("ㄏㄏ\n");//最簡單的輸出字串 
	printf("%dㄏ%dㄏ\n",1,2);//printf後面可以接輸出用的變數 
	//
	/*
%c	以字元 方式輸出
%d	10 進位整數輸出
%o	以8進 位整數方式輸出
%u	無號整數輸出
%x, %X	將整 數以16進位方式輸出
%f	浮點 數輸出
%e, %E	使用科學記號顯示浮點數
%g, %G	浮點數輸出，取%f或%e（%f或%E），看哪個表示精簡
%%	顯示 %
%s	字串輸出
	*/
	printf("%dㄏ%dㄏ\n",1,sizeof(12));//後面也可以放函式 
	printf("%dㄏ%dㄏ%d\n",1,sizeof(1235467890));//
	//
	int a;
	printf("輸入=");//
	scanf("%d",&a);
	printf("%d\n",a);//
	//
/*
字串輸出超麻煩 
*/
	//
	system("pause");
	return 0;
} 
