#include "pch.h"
#include "control.h"
#include "time.h"

void CONTROL::HitCheckBallAndBar( BALL *ball)
{ 

	//�ŏ��̓t���O��false�ɂ��Ƃ��B
	boundflag=false;

	//�{�[���N���X���ł̉��t���O���Z�b�g
	boundflag=ball->GetSoundflag();


	//�o�[�̍��W�擾
	bdx=bar->GetX();
	bdy=bar->GetY();

	//�{�[���̍��W�擾
	blx=ball->GetX();
	bly=ball->GetY();


	//�{�[���ƃo�[�̍����̔����𑫂������̂���
	//�o�[�̒��S�ƃ{�[���̒��S�̋����̐�Βl�̕��������������瓖����
	//���̋������傫����͏��O
	if(abs(bdy-bly)<blheight/2+bdheight/2){
		//���A�{�[�����o�[���ɂ���Γ�����
		if(bdx+bdwidth/2>blx &&
			bdx-bdwidth/2<blx){
				ball->SetR( 20 );
				//�o�[�̍��[�ɓ������Ă���΁A�t�����ɔ�΂��B
				if(blx<bdx-bdwidth/2*2/3){
					if(barnum == 3){
						ball->LvUp(1);
					}
					//�{�[���𔽓]
					ball->SetDX(-1*ball->GetDX());
					//Y�͒��˕Ԃ�����
					ball->SetDY(ball->GetDY()*-1);
					ball->SetY(ball->GetY()-5);
					//�o�E���h���t���O�𗧂Ă�B
					boundflag=true;

					//�E�[
				}else if(blx>bdx+bdwidth/2*2/3){
					if(barnum == 3){
						ball->LvUp(1);
					}
					//�{�[���𔽓]
					ball->SetDX(-1*ball->GetDX());
					//Y�͒��˕Ԃ�����
					ball->SetDY(ball->GetDY()*-1);
					ball->SetY(ball->GetY()-5);
					//�o�E���h���t���O�𗧂Ă�B
					boundflag=true;

				
					//����ȊO�͂�������
				}else{
					if(barnum == 3){
						ball->LvUp(1);
					}
					//x�͉����Ȃ�
					//Y�͒��˕Ԃ�����
					ball->SetDY(ball->GetDY()*-1);
					ball->SetY(ball->GetY()-5);
					//�o�E���h���t���O�𗧂Ă�B
					boundflag=true;
				}
		}
	}

}

void CONTROL::HitCheckBallAndBlock( BALL *ball)
{
	//�j�󉹃t���O
	demolishflag=false;

	//�{�[���̍��W�擾
	blx=ball->GetX();
	bly=ball->GetY();

	//�u���b�N�S�Ă����[�v
	for(int i=0;i<sumblock;++i){
		//���ĂȂ��z��Ώ�
		if(!block[i]->GetFlag()){
			bkx=block[i]->GetX();
			bky=block[i]->GetY();

			//�u���b�N�̏�Ƃ̓����蔻��
			if(blx<bkx+bkwidth/2 && blx>bkx-bkwidth/2 &&
				bly+blheight/2>bky-bkheight/2 && bly+blheight/2<bky+bkheight/2){
					
					vspeed = 0; // �i�܂Ȃ��Ȃ����Ƃ��p�J�E���g�̏�����

					//�t���O���I�t��
					block[i]->SetFlag(true);
					//�j�󉹃t���O�𗧂Ă�
					demolishflag=true;
					if(!ball->isPene()){ //�ђʏ�Ԃ��ƒ��˕Ԃ�Ȃ�
						//�{�[���͂������˕Ԃ�����
						ball->SetDY(ball->GetDY()*-1);
					}
					//�u���b�N�̉��Ƃ̓����蔻��
			}else if(blx<bkx+bkwidth/2 && blx>bkx-bkwidth/2 &&
				bly-blheight/2>bky-bkheight/2 && bly-blheight/2<bky+bkheight/2){

					vspeed = 0; // �i�܂Ȃ��Ȃ����Ƃ��p�J�E���g�̏�����

					//�t���O���I�t��
					block[i]->SetFlag(true);
					//�j�󉹃t���O�𗧂Ă�
					demolishflag=true;
					if(!ball->isPene()){ //�ђʏ�Ԃ��ƒ��˕Ԃ�Ȃ�
						//�{�[���͂������˕Ԃ�����
						ball->SetDY(ball->GetDY()*-1);
					}

					//�u���b�N�̍��Ƃ̓����蔻��
			}else if(blx+blwidth/2<bkx-bkwidth/2+blwidth && blx+blwidth/2>bkx-bkwidth/2 &&
				bly>bky-bkheight/2 && bly<bky+bkheight/2){

					vspeed = 0; // �i�܂Ȃ��Ȃ����Ƃ��p�J�E���g�̏�����

					//�t���O���I�t��
					block[i]->SetFlag(true);
					//�j�󉹃t���O�𗧂Ă�
					demolishflag=true;
					if(!ball->isPene()){ //�ђʏ�Ԃ��ƒ��˕Ԃ�Ȃ�
						//�{�[���͂������˕Ԃ�����
						ball->SetDX(ball->GetDX()*-1);
					}
					//�u���b�N�̉E�Ƃ̓����蔻��
			}else if(blx-blwidth/2<bkx+bkwidth/2 && blx-blwidth/2>bkx+bkwidth/2-blwidth &&
				bly>bky-bkheight/2 && bly<bky+bkheight/2){

					vspeed = 0; // �i�܂Ȃ��Ȃ����Ƃ��p�J�E���g�̏�����

					//�t���O���I�t��
					block[i]->SetFlag(true);
					//�j�󉹃t���O�𗧂Ă�
					demolishflag=true;
					if(!ball->isPene()){ //�ђʏ�Ԃ��ƒ��˕Ԃ�Ȃ�
						//�{�[���͂������˕Ԃ�����
						ball->SetDX(ball->GetDX()*-1);
					}

			}
			if( block[i]->GetFlag() ){
			mscore += 100 +50*ball->level;
			ball->SetR( 0 );
			}
		}
		
		//�A�C�e����Ώ�
		else if(block[i]->GetItemFlag()){
			bkx=block[i]->GetX();
			bky=block[i]->GetY();

			//�u���b�N�̏�Ƃ̓����蔻��
			if(blx<bkx+bkwidth/2 && blx>bkx-bkwidth/2 &&
				bly+blheight/2>bky-bkheight/2 && bly+blheight/2<bky+bkheight/2){

					vspeed = 0; // �i�܂Ȃ��Ȃ����Ƃ��p�J�E���g�̏�����
					// �A�C�e���t���O���I�t��
					block[i]->SetItemFlag(false);
					// �A�C�e���̌��ʂ��N����
					ItemEffect( block[i]->it, blx, bly);
					//�擾�t���O�𗧂Ă�
					demolishflag=true;
					//�{�[���͂��̂܂�

					//�u���b�N�̉��Ƃ̓����蔻��
			}else if(blx<bkx+bkwidth/2 && blx>bkx-bkwidth/2 &&
				bly-blheight/2>bky-bkheight/2 && bly-blheight/2<bky+bkheight/2){

					vspeed = 0; // �i�܂Ȃ��Ȃ����Ƃ��p�J�E���g�̏�����

					//�A�C�e���t���O���I�t��
					block[i]->SetItemFlag(false);
					// �A�C�e���̌��ʂ��N����
					ItemEffect( block[i]->it, blx, bly);
					//�擾�t���O�𗧂Ă�
					demolishflag=true;
					//�{�[���͂��̂܂�

					//�u���b�N�̍��Ƃ̓����蔻��
			}else if(blx+blwidth/2<bkx-bkwidth/2+blwidth && blx+blwidth/2>bkx-bkwidth/2 &&
				bly>bky-bkheight/2 && bly<bky+bkheight/2){

					vspeed = 0; // �i�܂Ȃ��Ȃ����Ƃ��p�J�E���g�̏�����

					//�A�C�e���t���O���I�t��
					block[i]->SetItemFlag(false);
					// �A�C�e���̌��ʂ��N����
					ItemEffect( block[i]->it, blx, bly);
					//�擾�t���O�𗧂Ă�
					demolishflag=true;
					//�{�[���͂��̂܂�

					//�u���b�N�̉E�Ƃ̓����蔻��
			}else if(blx-blwidth/2<bkx+bkwidth/2 && blx-blwidth/2>bkx+bkwidth/2-blwidth &&
				bly>bky-bkheight/2 && bly<bky+bkheight/2){

					vspeed = 0; // �i�܂Ȃ��Ȃ����Ƃ��p�J�E���g�̏�����

					//�A�C�e���t���O���I�t��
					block[i]->SetItemFlag(false);
					// �A�C�e���̌��ʂ��N����
					ItemEffect( block[i]->it, blx, bly);
					//�擾�t���O�𗧂Ă�
					demolishflag=true;
					//�{�[���͂��̂܂�

			}
			if( !block[i]->GetItemFlag() )
				mscore += 300;
		}
	}
}

void CONTROL::ItemEffect( enum BLOCK::ItemType it, int bx, int by ){
	int ct = 0;

	switch( it ){
	case BLOCK::ITEMTYPE_LONG:		if(barnum != 3){
									bar->ExtendWidth(); // �o�[��L�΂�

									bdwidth += exwidth; //�o�[�̕����X�V
									}
									break;
	case BLOCK::ITEMTYPE_POWERUP:	ball->PowerUp(); // �ђʔ\�͂̕t��
									break;
	case BLOCK::ITEMTYPE_INCRESE:	while(true){
										sball[sballcount] = new BALL; //���ʂ𑝂₷�i3�j
										sball[sballcount]->Increse( bx, by );
										++sballcount;
										++ct;
										if(ct == 3)
											break;
									}
									break;
	case BLOCK::ITEMTYPE_1UP:		mstock += 1; // �c�@�𑝂₷
									break;
	case BLOCK::ITEMTYPE_SCOREUP:	mscore += 2000; // �X�R�A�𑝂₷
									break;
	}
}

void CONTROL::SoundPlay()
{
	if(boundflag){

		PlaySoundMem(bh,DX_PLAYTYPE_BACK);
	}

	if(demolishflag){
		PlaySoundMem(dh,DX_PLAYTYPE_BACK);
	}

}


bool CONTROL::All()
{
	bool back, sballdrop;
	int itemhandle;
	int count = 0;

	for(int i=0;i<sumblock;++i){
		if(block[i]->GetFlag())
			++count;
		if(block[i]->itemflag == true)
			itemhandle = 4;
		else
			itemhandle = 0;
		switch( mstage ){
		case 1: if(i < 7)
					block[i]->All(0+itemhandle);
				else if(i > 6 && i<14)
					block[i]->All(1+itemhandle);
				else if(i > 13 && i<21)
					block[i]->All(2+itemhandle);
				else
					block[i]->All(3+itemhandle);
				break;
		default: if(i%4 ==0)
					block[i]->All(0+itemhandle);
				else if(i%4 ==1)
					block[i]->All(1+itemhandle);
				else if(i%4 ==2)
					block[i]->All(2+itemhandle);
				else 
					block[i]->All(3+itemhandle);
				break;

		}
	}

	if(count == sumblock)
		clear = true;

	if(AT){
		//�{�[���̍��W�擾
		bar->SetX(ball->GetX());
	}
	//�o�[�̏���
	bar->All();

	if(ball->m_actcount == 0 ){
		ball->SetX(bar->mx);
	}

	// �{�[���̓���
	++ballspup; // ���x�㏸�J�E���g
	switch(barnum){ // �o�[�ɂ��̑��x�㏸�̑������Ⴄ
	case 1:		if(ballspup%1500 == 0){ // �₳����
					ball->LvUp(1);
				}
				break;
	case 2:		if(ballspup%1000 == 0){ // �ӂ�
					ball->LvUp(1);
				}
				break;
	case 3:		if(ballspup%800 == 0){ // ���
					ball->LvUp(1);
				}
				break;
	}
	++vspeed; // �i�܂Ȃ��Ȃ����Ƃ��p�J�E���g�̑���
	if(vspeed == 1000){
		vspeed = 0;
		ball->spchange();
	}

	back = ball->All();

	//�{�[���ƃo�[�̓����蔻��
	HitCheckBallAndBar( ball );

	//�{�[���ƃu���b�N�̓����蔻��
	HitCheckBallAndBlock( ball );


	// ���ʂ�����Ε\���@// ��̋���
	for(int i = 0; i < sballcount; ++i){
		if(sball[i] == NULL)
			continue;
		sballdrop = sball[i]->All();
		//�{�[���ƃo�[�̓����蔻��
		HitCheckBallAndBar( sball[i]);
		//�{�[���ƃu���b�N�̓����蔻��
		HitCheckBallAndBlock( sball[i] );
		if(sballdrop)
			sball[i] = NULL;  
	}

	accel = bar->GetAcceleration(); // �f�o�b�N�p
	// ���_�A���x���A�c�@�g�̕\��
	DrawBox( 0, 0, 800, 30 , RGB(230,230,230), true);
	DrawFormatString( 20, 10, RGB(255,120,0), TEXT("SCORE: %d"), mscore);
	DrawFormatString( 220, 10, RGB(10,120,120), TEXT("LEVEL: %d"), ball->level);
	for(int i = 0; i<mstock; ++i)
		DrawGraph(540+18*i, 7, gh, TRUE);

	///���Đ�
	SoundPlay();
	
	if( back ){
		bar->SetFlag( true );
		ball->SetDX( 0 );
	}
	if( clear ){
		ball->SetDX(0);
		ball->SetDY(0);
		// ���ʂ�����Ε\��
		for(int i = 0; i < sballcount; ++i){
			if(sball[i] == NULL)
				continue;
			sball[i]->SetDX(0);
			sball[i]->SetDY(0);
		}
		vspeed = 0;
		bar->SetFlag( true );
	}

	return back;
}


int CONTROL::GetStage(){
	return mstage;
}
int CONTROL::GetScore(){
	return mscore;
}
int CONTROL::GetStock(){
	return mstock;
}
int CONTROL::GetBar(){
	return barnum;
}
void CONTROL::Reset(){ // ��������

	// �����Ă��c�@�� 1 �ȏ゠�����烊�Z�b�g
	// ���ʂ�����Ώ���
	for(int i = 0; i < sballcount; ++i){
		delete sball[i];
	}
	sballcount = 0;
	mstock -= 1; // �X�g�b�N�����炷
	bdwidth = bar->GetWidth();
	bar->Reset();
	ball->Reset();
	bar->SetFlag( false );

}


CONTROL::CONTROL( int mbar, int stage, int score, int stock )
{
	barnum = mbar;
	
	//�o�[�ƃ{�[���̃C���X�^���X�𐶐�
	bar = new BAR( barnum );
	ball = new BALL;
	ballspup = 0;


	boundflag=false;
	demolishflag=false;
	sballcount = 0;
	clear = false;
	mscore = score;
	mstock = stock;
	act = 0;
	mstage = stage;
	vspeed = 0;
	srand((unsigned int)time(NULL));
	
	//�o�[�̕��ƍ���
	bdwidth=bar->GetWidth();
	bdheight=bar->GetHeight();

	// �o�[���g�傷�钷��
	exwidth = (int)bdwidth/2;

	//�{�[���̕��ƍ���
	blwidth=ball->GetWidth();
	blheight=ball->GetHeight();

	//�����t�@�C���ǂݍ��݁B
	bh = LoadSoundMem(TEXT("bound.wav"));
	dh = LoadSoundMem(TEXT("demolish.wav"));

	// �c�@�\���̓ǂݍ���
	gh = LoadGraph(TEXT("ball_b.png")); // �ʏ�e
	
	switch( mstage ){
	case 1: sumblock = 28;
			//�u���b�N�̊Ԃ�5�s�N�Z�������āA��7��A�c4�s�Ŕz�u
			for(int i=0;i<sumblock;++i){
				if(i<7)
					block[i]= new BLOCK("block.bmp",80+(5+100)*i,50*1+10);
				else if(i>6 && i<14)
					block[i]= new BLOCK("block2.bmp",80+(5+100)*(i-7),50*2+10);
				else if(i>13 && i<21)
					block[i]= new BLOCK("block3.bmp",80+(5+100)*(i-14),50*3+10);
				else
					block[i]= new BLOCK("block4.bmp",80+(5+100)*(i-21),50*4+10);
			}
			break;
	case 2: sumblock = 48;
			//�u���b�N�̏㉺�Ԃ�30�s�N�Z�������āA��4��A�c12�s�Ŕz�u
			for(int i=0;i<sumblock;++i){
				if(i<4)
					block[i]= new BLOCK("block.bmp",50+(8+225)*i,30*1+15);
				else if(i>3 && i<8)
					block[i]= new BLOCK("block.bmp",50+(8+225)*(i-4),30*2+15);
				else if(i>7 && i<12)
					block[i]= new BLOCK("block.bmp",50+(8+225)*(i-8),30*3+15);
				else if(i>11 && i<16)
					block[i]= new BLOCK("block.bmp",50+(8+225)*(i-12),30*4+15);
				else if(i>15 && i<20)
					block[i]= new BLOCK("block.bmp",50+(8+225)*(i-16),30*5+15);
				else if(i>19 && i<24)
					block[i]= new BLOCK("block.bmp",50+(8+225)*(i-20),30*6+15);
				else if(i>23 && i<28)
					block[i]= new BLOCK("block.bmp",50+(8+225)*(i-24),30*7+15);
				else if(i>27 && i<32)
					block[i]= new BLOCK("block.bmp",50+(8+225)*(i-28),30*8+15);
				else if(i>31 && i<36)
					block[i]= new BLOCK("block.bmp",50+(8+225)*(i-32),30*9+15);
				else if(i>35 && i<40)
					block[i]= new BLOCK("block.bmp",50+(8+225)*(i-36),30*10+15);
				else if(i>39 && i<44)
					block[i]= new BLOCK("block.bmp",50+(8+225)*(i-40),30*11+15);
				else
					block[i]= new BLOCK("block.bmp",50+(8+225)*(i-44),30*12+15);
			}
			break;
	case 3: sumblock = 48;
			//�u���b�N�̏㉺�Ԃ�5�s�N�Z�������āA��3��A�c8�s�Ŕz�u
			for(int i=0;i<sumblock;++i){
				if(i<4)
					block[i]= new BLOCK("block.bmp",55+(8+180)*i,30*1+15);
				else if(i>3 && i<8)
					block[i]= new BLOCK("block.bmp",145+(8+180)*(i-4),30*2+15);
				else if(i>7 && i<12)
					block[i]= new BLOCK("block.bmp",55+(8+180)*(i-8),30*3+15);
				else if(i>11 && i<16)
					block[i]= new BLOCK("block.bmp",145+(8+180)*(i-12),30*4+15);
				else if(i>15 && i<20)
					block[i]= new BLOCK("block.bmp",55+(8+180)*(i-16),30*5+15);
				else if(i>19 && i<24)
					block[i]= new BLOCK("block.bmp",145+(8+180)*(i-20),30*6+15);
				else if(i>23 && i<28)
					block[i]= new BLOCK("block.bmp",55+(8+180)*(i-24),30*7+15);
				else if(i>27 && i<32)
					block[i]= new BLOCK("block.bmp",145+(8+180)*(i-28),30*8+15);
				else if(i>31 && i<36)
					block[i]= new BLOCK("block.bmp",55+(8+180)*(i-32),30*9+15);
				else if(i>35 && i<40)
					block[i]= new BLOCK("block.bmp",145+(8+180)*(i-36),30*10+15);
				else if(i>39 && i<44)
					block[i]= new BLOCK("block.bmp",55+(8+180)*(i-40),30*11+15);
				else
					block[i]= new BLOCK("block.bmp",145+(8+180)*(i-44),30*12+15);
			}
			break;
	case 4: sumblock = 44;
			//�u���b�N�̏㉺�Ԃ�5�s�N�Z�������āA��3��A�c8�s�Ŕz�u
			for(int i=0;i<sumblock;++i){
				if(i<1)
					block[i]= new BLOCK("block.bmp",400,28*1+15);
				else if(i>0 && i<3)
					block[i]= new BLOCK("block.bmp",350+100*(i-1),28*2+15);
				else if(i>2 && i<5)
					block[i]= new BLOCK("block.bmp",300+200*(i-3),28*3+15);
				else if(i>4 && i<7)
					block[i]= new BLOCK("block.bmp",250+300*(i-5),28*4+15);
				else if(i>6 && i<9)
					block[i]= new BLOCK("block.bmp",200+400*(i-7),28*5+15);
				else if(i>8 && i<11)
					block[i]= new BLOCK("block.bmp",150+500*(i-9),28*6+15);
				else if(i>10 && i<13)
					block[i]= new BLOCK("block.bmp",100+600*(i-11),28*7+15);
				else if(i>12 && i<15)
					block[i]= new BLOCK("block.bmp",50+700*(i-13),28*8+15);
				else if(i>14 && i<17)
					block[i]= new BLOCK("block.bmp",100+600*(i-15),28*9+15);
				else if(i>16 && i<19)
					block[i]= new BLOCK("block.bmp",150+500*(i-17),28*10+15);
				else if(i>18 && i<21)
					block[i]= new BLOCK("block.bmp",200+400*(i-19),28*11+15);
				else if(i>20 && i<23)
					block[i]= new BLOCK("block.bmp",250+300*(i-21),28*12+15);
				else if(i>22 && i<25)
					block[i]= new BLOCK("block.bmp",300+200*(i-23),28*13+15);
				else if(i>24 && i<27)
					block[i]= new BLOCK("block.bmp",350+100*(i-25),28*14+15);
				else if(i>26 && i<28)
					block[i]= new BLOCK("block.bmp",400,28*15+15);
				else if(i>27 && i<29)
					block[i]= new BLOCK("block.bmp",400,28*4+15);
				else if(i>28 && i<31)
					block[i]= new BLOCK("block.bmp",350+100*(i-29),28*5+15);
				else if(i>30 && i<33)
					block[i]= new BLOCK("block.bmp",300+200*(i-31),28*6+15);
				else if(i>32 && i<35)
					block[i]= new BLOCK("block.bmp",250+300*(i-33),28*7+15);
				else if(i>34 && i<37)
					block[i]= new BLOCK("block.bmp",200+400*(i-35),28*8+15);
				else if(i>36 && i<39)
					block[i]= new BLOCK("block.bmp",250+300*(i-37),28*9+15);
				else if(i>38 && i<41)
					block[i]= new BLOCK("block.bmp",300+200*(i-39),28*10+15);
				else if(i>40 && i<43)
					block[i]= new BLOCK("block.bmp",350+100*(i-41),28*11+15);
				else
					block[i]= new BLOCK("block.bmp",400,28*12+15);
			}
			break;
		case 5: sumblock = 64;
			//�u���b�N�̏㉺�Ԃ�5�s�N�Z�������āA��3��A�c8�s�Ŕz�u
			for(int i=0;i<sumblock;++i){
				if(i<4)
					block[i]= new BLOCK("block.bmp",50+50*i, 50);
				else if(i>3 && i<16)
					block[i]= new BLOCK("block.bmp",125, 50+28*(i-3));
				else if(i>15 && i<20)
					block[i]= new BLOCK("block.bmp",50+50*(i-16),50+28*13 );

				else if(i>19 && i<21)
					block[i]= new BLOCK("block.bmp",375,50);
				else if(i>20 && i<23)
					block[i]= new BLOCK("block.bmp",325+100*(i-21),50+28*1);
				else if(i>22 && i<25)
					block[i]= new BLOCK("block.bmp",275+200*(i-23),50+28*2);
				else if(i>24 && i<27)
					block[i]= new BLOCK("block.bmp",250+250*(i-25),50+28*3);
				else if(i>26 && i<29)
					block[i]= new BLOCK("block.bmp",250+250*(i-27),50+28*4);
				else if(i>28 && i<33)
					block[i]= new BLOCK("block.bmp",250,50+28*(i-24));
				else if(i>32 && i<35)
					block[i]= new BLOCK("block.bmp",250+250*(i-33),50+28*9);
				else if(i>34 && i<37)
					block[i]= new BLOCK("block.bmp",250+250*(i-35),50+28*10);
				else if(i>36 && i<39)
					block[i]= new BLOCK("block.bmp",275+200*(i-37),50+28*11);
				else if(i>38 && i<41)
					block[i]= new BLOCK("block.bmp",325+100*(i-39),50+28*12);
				else if(i>40 && i<42)
					block[i]= new BLOCK("block.bmp",375,50+28*13);

				else if(i>41 && i<44)
					block[i]= new BLOCK("block.bmp",550+50*(i-42),50);
				else if(i>43 && i<55)
					block[i]= new BLOCK("block.bmp",575,50+28*(i-43));
				else if(i>54 && i<57)
					block[i]= new BLOCK("block.bmp",575+175*(i-55),50+28*11);
				else if(i>56 && i<59)
					block[i]= new BLOCK("block.bmp",575+175*(i-57),50+28*12);
				else if(i>58 && i<64)
					block[i]= new BLOCK("block.bmp",550+50*(i-59),50+28*13);

				block[i]->SetHalfFlag(true);
			}
			break;
	}

	bkwidth=block[0]->GetWidth();
	bkheight=block[0]->GetHeight();
}

CONTROL::~CONTROL()
{
	delete ball;
	delete bar;
	// ���ʂ�����Ε\��
	for(int i = 0; i < sballcount; ++i){
		delete sball[i];
	}
	for(int i=0;i<sumblock;++i){
		delete block[i];
	}
}
