#include <windows.h>

#define MSG(m) {\
	MessageBox(NULL,m,"���b�Z�[�W",MB_OK);}


#define MSGPLUS(m,...) {\
	char buf[100];\
	sprintf(buf,m,__VA_ARGS__);\
	MessageBox(NULL,buf,"���b�Z�[�W",MB_OK);}


#define WIDTH 800
#define HEIGHT 600
#define MAX_SBALLCOUNT 20
#define MAX_BLOCKCOUNT 100

// �L�[������Ԋi�[�ϐ�
extern char key[256];

// ���͏�ԕϐ�
extern bool RB, LB, EB;
extern int barx;

// �X���b�h�ɂ�镡������h�~�ϐ�
extern bool Key;
extern bool rB, lB, eB;

extern bool AT;