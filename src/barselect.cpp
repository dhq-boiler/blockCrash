#include "pch.h"
#include "barselect.h"


BARSELECT::BARSELECT()
{

	mbar = 1;
	keycount = 8; // キーボード入力の場合に必要

	bargh[0] = LoadGraph(TEXT("bar.bmp")); // バー１
	bargh[1] = LoadGraph(TEXT("barsecond.bmp")); // バー２
	bargh[2] = LoadGraph(TEXT("barthird.bmp")); // バー３

	bselectgh = LoadGraph(TEXT("barselect.png")); // バーセレクトタイトル

	selectflag = false;
	decisionflag = false;

	endflag = false;

	autocount = 0;

	//音声ファイル読み込み。
	sh = LoadSoundMem(TEXT("bound.wav"));
	dh = LoadSoundMem(TEXT("demolish.wav"));

}


BARSELECT::~BARSELECT()
{
}

void BARSELECT::Reset(){
	mbar = 1;
}

void BARSELECT::Draw(){

	DrawGraph(30, 0 ,bselectgh,TRUE); // バータイトル表示

	switch(mbar){ // バー詳細表示
	case 1: DrawString( 440, 240, TEXT("BAR NAME："), RGB(255,180,0));
			DrawString( 560, 240, TEXT("ノーマルバー"), RGB(255,255,128));
			DrawString( 440, 300, TEXT("BALL SPEED："), RGB(255,180,0));
			DrawString( 570, 300, TEXT("★"), RGB(255,180,128));
			DrawString( 440, 360, TEXT("TECHNICAL："), RGB(255,180,0));
			DrawString( 570, 360, TEXT("★"), RGB(255,180,128));
			DrawString( 440, 420, TEXT("DIFFICULTY："), RGB(255,180,0));
			DrawString( 570, 420, TEXT("★"), RGB(255,180,128));
			break;
	case 2: DrawString( 440, 240, TEXT("BAR NAME："), RGB(255,180,0));
			DrawString( 560, 240, TEXT("２号機"), RGB(255,255,128));
			DrawString( 440, 300, TEXT("BALL SPEED："), RGB(255,180,0));
			DrawString( 570, 300, TEXT("★　★　★"), RGB(255,180,128));
			DrawString( 440, 360, TEXT("TECHNICAL："), RGB(255,180,0));
			DrawString( 570, 360, TEXT("★　★"), RGB(255,180,128));
			DrawString( 440, 420, TEXT("DIFFICULTY："), RGB(255,180,0));
			DrawString( 570, 420, TEXT("★　★"), RGB(255,180,128));
			break;
	case 3: DrawString( 440, 240, TEXT("BAR NAME："), RGB(255,180,0));
			DrawString( 560, 240, TEXT("３つめ"), RGB(255,255,128));
			DrawString( 440, 300, TEXT("BALL SPEED："), RGB(255,180,0));
			DrawString( 570, 300, TEXT("★　★　★　★　★"), RGB(255,0,128));
			DrawString( 440, 360, TEXT("TECHNICAL："), RGB(255,180,0));
			DrawString( 570, 360, TEXT("★　★　★"), RGB(255,0,128));
			DrawString( 440, 420, TEXT("DIFFICULTY："), RGB(255,180,0));
			DrawString( 570, 420, TEXT("★　★　★　★　★"), RGB(255,0,128));
			break;
	}
	for (int i = 0; i < 3; ++i){
		if(i == 2)
			DrawGraph(125, 200+i*120 ,bargh[i],TRUE); // ミニバー種類表示
		else
			DrawGraph(100, 200+i*120 ,bargh[i],TRUE); // バー種類表示
	}

	DrawBox( 80, 190+(mbar-1)*120, 220, 224+(mbar-1)*120, RGB(255,20,30), false); // 選択枠表示
	DrawBox( 400, 220, 750, 478 , RGB(255,20,30), false); // 詳細枠表示
	
}

void BARSELECT::KeyGet()
{
	if(rB){ // 右ボタン
		if(AT){ // オートモードの場合
			++autocount;
		}
		++mbar;
		if(mbar > 3){
			mbar = 1;
		}
		rB = false;
	}
	if(lB){ // 左ボタン
		if(AT){ // オートモードの場合
			++autocount;
		}
		--mbar;
		if(mbar < 1){
			mbar = 3;
		}
		lB = false;
	}
	if(AT){ // オートモードの場合
		if(eB && autocount > 10){ // 決定ボタン
			endflag = true;
			eB = false;
			autocount = 0;
		}
	}
	else if (eB){ // 決定ボタン
		endflag = true;
		eB = false;
	}
}


bool BARSELECT::All()
{
	//キー処理
	KeyGet();

	//描画処理
	Draw();

	return endflag;
}

void BARSELECT::SetFlag( bool flag){
	endflag = flag;
}
bool BARSELECT::GetFlag(){
	return endflag;
}