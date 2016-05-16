#include <stdio.h>
 
int main(void)
{
    int a = 22; //宣告a的內容
    int *aPtr=&a;//宣告為指標型態 指向 a的參考位置

    
    printf("%d\n",  a);//a的內容 
    printf("%d\n", &a);//a的參考位置 
    aPtr=&a;//指標 指向 a的參考位置 
    printf("%d\n",  aPtr);//傳回 a的參考位置 
    printf("%d\n", *aPtr);//傳回 a的內容 
    
    return 0;
}
