#include "pch.h"
#include "main.h"
#include <time.h>

char key[256];

MAIN::MAIN(){
#ifdef _DEBUG
	_CrtSetDbgFlag(_CRTDBG_ALLOC_MEM_DF | _CRTDBG_LEAK_CHECK_DF);
#endif

	ChangeWindowMode(TRUE);

	dxlib = true;

	//DXライブラリ初期化
	if(DxLib_Init() ==-1){
		dxlib = false;
	}
	// 画面の大きさを変更
	SetGraphMode(WIDTH,HEIGHT,16);
	//裏画面に描画
	SetDrawScreen(DX_SCREEN_BACK);

	//キーボードの状態を取得
	title = new TITLE;
	barselect = new BARSELECT;
	stageselect = new STAGESELECT;
	m_actcount = 0;
	act = 0;
	stock = 0;
	keycheck = true;
	automode = false;
	c = 0;

}
MAIN::~MAIN(){
}

void MAIN::ATMode(){
	if(AT){
		if( c < 15){
			++c; // 待ち
		}
		else{
			c = 0;
			///* 乱数系列の変更 */
			srand((unsigned) time(NULL));

			// 疑似乱数
			int r = rand() % 3;

			if(r == 0)
				RB = true;
			if ( r == 1)
				LB = true;
			if ( r == 2)
				EB = true; 
		}
	}
}

void MAIN::KeyCheck(){

}
void MAIN::ReStart(){
	RB = LB = EB = rB = lB = eB = false;
	delete title;
	delete barselect;
	delete stageselect;

	title = new TITLE;
	barselect = new BARSELECT;
	stageselect = new STAGESELECT;
	act = 0;
	stock = 0;
	keycheck = true;
	automode = false;

	switch(m_actcount){
	case 0:		break;
	case 1:		barselect->SetFlag( false );
				break;
	case 2: 	barselect->SetFlag( false );
				stageselect->SetFlag( false );
				delete control;
				break;

	}
	m_actcount = 0;
}

bool MAIN::All(){
	while(ScreenFlip()==0 && ProcessMessage()==0 && ClearDrawScreen()==0 && dxlib == true){
		if( AT ) {// 自動化状態
			ATMode();
			automode = true;
			Key = true;
		}
		if( automode && AT == false){ // 自動化解除
			ReStart();
		}


		if( Key == true){
			if(keycheck){
			rB = RB;
			lB = LB;
			eB = EB;
			RB = LB = EB = false;
			keycheck = false;
			}
		}
		if(m_actcount == 0){
			if(title->All()){ // 選択終了でtrueを返す
				m_actcount = 1;
			}
			rB = lB = eB = false;
		}
		if(m_actcount == 1){
			if(barselect->All()){ // 選択終了でtrueを返す
				stageselect->SetValue( barselect->mbar, 0, 0, 2);
				m_actcount = 2;
			}
			rB = lB = eB = false;
		}
		if(m_actcount == 2){
				if(stageselect->All()){
					m_actcount = 3;
					stock = stageselect->mstock;
					control = new CONTROL( stageselect->mbar, stageselect->mstage, stageselect->mscore, stock);
				}
				rB = lB = eB = false;
		}
		if(m_actcount == 3){
			// 残機がなくなるとtrueを返す
			if(control->All()){
				stock = control->GetStock();
				if( stock >1 ){
					if(act == 0){
						message = new MESSAGE( 1, 50);
						++act;
					}
					if(message->All()){ // ミス
						control->Reset();
						--stock;
						act = 0;
						delete message;
					}
				}
				else{
					if(act == 0){
						message = new MESSAGE( 3, 200);
						++act;
					}
					if(message->All()){ // ゲームオーバー
						m_actcount = 0;
						act = 0;
						stageselect->Reset();
						stageselect->SetFlag( false );
						delete message;
						delete control;
					}
				}
			}
			else if(control->clear){
				if(act == 0){
					message = new MESSAGE( 2, 200);
					++act;
				}
				if(message->All()){ // クリア
					if(AT){
						m_actcount = 1;
						barselect->SetFlag( false );
					}
					else{
						m_actcount = 2;
						stageselect->SetValue( control->GetBar(), control->GetStage(), control->GetScore(), control->GetStock());
					}
					act = 0;
					stageselect->SetFlag( false );
					delete message;
					delete control;
				}
			}
		}
		keycheck = true;
		rB = lB = eB = false;
	}

	//DXライブラリ終了
	DxLib_End();

	delete stageselect;
	delete barselect;

	return 0;
}
