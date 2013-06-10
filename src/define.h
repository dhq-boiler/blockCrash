#include <windows.h>

#define MSG(m) {\
	MessageBox(NULL,m,"メッセージ",MB_OK);}


#define MSGPLUS(m,...) {\
	char buf[100];\
	sprintf(buf,m,__VA_ARGS__);\
	MessageBox(NULL,buf,"メッセージ",MB_OK);}


#define WIDTH 800
#define HEIGHT 600
#define MAX_SBALLCOUNT 20
#define MAX_BLOCKCOUNT 100

// キー押下状態格納変数
extern char key[256];

// 入力状態変数
extern bool RB, LB, EB;
extern int barx;

// スレッドによる複数操作防止変数
extern bool Key;
extern bool rB, lB, eB;

extern bool AT;