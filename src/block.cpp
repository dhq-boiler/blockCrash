#include "pch.h"
#include "block.h"


int BLOCK::gh[8]	 = {-1,-1,-1,-1,-1,-1,-1,-1};
int BLOCK::itemgh[5] = {-1,-1,-1,-1,-1};

BLOCK::BLOCK(char *filename,int x,int y)
{
	// �ŏ������ǂݍ��܂Ȃ��B
	// ��C�ɓǂ݂���΂�����
	if(gh[0]==-1){
		gh[0] = LoadGraph(TEXT("block1.bmp"));
		gh[1] = LoadGraph(TEXT("block2.bmp"));
		gh[2] = LoadGraph(TEXT("block3.bmp"));
		gh[3] = LoadGraph(TEXT("block4.bmp"));
		gh[4] = LoadGraph(TEXT("block1in.bmp"));
		gh[5] = LoadGraph(TEXT("block2in.bmp"));
		gh[6] = LoadGraph(TEXT("block3in.bmp"));
		gh[7] = LoadGraph(TEXT("block4in.bmp"));
	}
	if(itemgh[0]==-1){
		itemgh[0] = LoadGraph(TEXT("item_long.bmp"));
		itemgh[1] = LoadGraph(TEXT("item_powerup.bmp"));
		itemgh[2] = LoadGraph(TEXT("item_increse.bmp"));
		itemgh[3] = LoadGraph(TEXT("item_1up.bmp"));
		itemgh[4] = LoadGraph(TEXT("item_scoreup.bmp"));
	}

	GetGraphSize(gh[0],&width,&height);
	GetGraphSize(itemgh[0],&itemwidth,&itemheight);
	
	endflag = false;

	// �u���b�N�ɃA�C�e�������邩�ǂ����𔻒�
	// �^������
	int r = rand() % 5;
	if(r == 1){
		itemflag = true;
		it = (ItemType)(rand() % 5);
	}
	else{
		itemflag = false;
		it = (ItemType)0;
	}

	this->x=x;
	this->y=y;

	count=0;
	half = false;

}

int BLOCK::GetX()
{
	return x;
}
int BLOCK::GetY()
{
	return y;
}
int BLOCK::GetWidth()
{
	return width;
}
int BLOCK::GetHeight()
{
	return height;
}

void BLOCK::SetFlag(bool flag)
{
	endflag=flag;
}
bool BLOCK::GetFlag()
{
	return endflag;
}
void BLOCK::SetItemFlag(bool flag)
{
	itemflag=flag;
}
bool BLOCK::GetItemFlag()
{
	return itemflag;
}

void BLOCK::SetHalfFlag(bool flag){
	half = flag;
	if(half){
		width /=2;
	}
}

void BLOCK::Draw(int blockhandle)
{
	if(half){
		//�u���b�N�����ĂȂ��Ƃ������`��
		if(!endflag){
			DrawExtendGraph(x-width/2,y-height/2,x+width/2,y+height/2,gh[blockhandle],TRUE);
		}
		else if(itemflag){
			DrawExtendGraph(x-width/2,y-height/2,x+width/2,y+height/2,itemgh[it],TRUE);
		}
		else{
			if(count<20){
				//���ߓx���w��
				SetDrawBlendMode(DX_BLENDMODE_ALPHA,(255/40)*(20-count)); //���X�ɔ�������
				//�`��
				DrawExtendGraph(x-width/2,y-height/2,x+width/2,y+height/2,gh[blockhandle],TRUE);
				//�ݒ��߂�
				SetDrawBlendMode(DX_BLENDMODE_NOBLEND,0);
				++count;
			}
		}
	}
	else{
		//�u���b�N�����ĂȂ��Ƃ������`��
		if(!endflag){
			DrawGraph(x-width/2,y-height/2,gh[blockhandle],FALSE);
		}
		else if(itemflag){
			DrawGraph(x-itemwidth/2,y-itemheight/2,itemgh[it],FALSE);
		}
		else{
			if(count<20){
				//���ߓx���w��
				SetDrawBlendMode(DX_BLENDMODE_ALPHA,(255/40)*(20-count)); //���X�ɔ�������
				//�`��
				DrawGraph(x-width/2,y-height/2,gh[blockhandle],FALSE);
				//�ݒ��߂�
				SetDrawBlendMode(DX_BLENDMODE_NOBLEND,0);
				++count;
			}
		}
	}
	
}

void BLOCK::All(int blockhandle)
{

	Draw(blockhandle);

}
