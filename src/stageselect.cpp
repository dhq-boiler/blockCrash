#include "pch.h"
#include "stageselect.h"

STAGESELECT::STAGESELECT()
{

	mstage = 1;
	keycount = 8;
	
	bargh[0] = LoadGraph(TEXT("bar.bmp")); // バー１
	bargh[1] = LoadGraph(TEXT("barsecond.bmp")); // バー２
	bargh[2] = LoadGraph(TEXT("barthird.bmp")); // バー３

	ballgh = LoadGraph(TEXT("ball_b.png")); // 残機表示

	stagegh[0] = LoadGraph(TEXT("stage1mini.png")); // ステージ１
	stagegh[1] = LoadGraph(TEXT("stage2mini.png")); // ステージ２
	stagegh[2] = LoadGraph(TEXT("stage3mini.png")); // ステージ３
	stagegh[3] = LoadGraph(TEXT("stage4mini.png")); // ステージ４
	stagegh[4] = LoadGraph(TEXT("stage5mini.png")); // ステージ５
	stagegh[5] = LoadGraph(TEXT("ball_a.png")); // ステージ５

	sdetailgh[0] = LoadGraph(TEXT("stage1.png")); // ステージ１詳細
	sdetailgh[1] = LoadGraph(TEXT("stage2.png")); // ステージ２詳細
	sdetailgh[2] = LoadGraph(TEXT("stage3.png")); // ステージ３詳細
	sdetailgh[3] = LoadGraph(TEXT("stage4.png")); // ステージ４詳細
	sdetailgh[4] = LoadGraph(TEXT("stage5.png")); // ステージ５詳細
	sdetailgh[5] = LoadGraph(TEXT("ball_a.png")); // ステージ６詳細

	sselectgh = LoadGraph(TEXT("stageselect.png")); // ステージセレクトタイトル
	cleargh = LoadGraph(TEXT("clearstar.png")); // クリア表示

	selectflag = false;
	decisionflag = false;

	endflag = false;

	//音声ファイル読み込み。
	sh = LoadSoundMem(TEXT("bound.wav"));
	dh = LoadSoundMem(TEXT("demolish.wav"));

	for(int i =0; i < 6; ++i){
		clear[i] = false;
	}
	mscore = 0;
	mstock = 2;
	mbar = 1;
	
	entercount = 0;
	// オート入力の遊び
	autocount = 0;

}


STAGESELECT::~STAGESELECT()
{
}

void STAGESELECT::SetValue(int bar, int stage, int score, int stock){
	mbar = bar;
	clear[stage-1] = true;
	mscore = score;
	mstock = stock;
}

void STAGESELECT::Reset(){
	for(int i = 0; i < 5; ++i){
		clear[i] = false;
	}
	mscore = 0;
	mstock = 2;
}

void STAGESELECT::Draw(){

	DrawGraph(0, 0 ,sselectgh,TRUE); // ステージタイトル表示
	DrawGraph(400, 320 ,sdetailgh[mstage-1],TRUE); // ステージタイトル表示

	switch(mstage){ // ステージ詳細表示
	case 1: DrawString( 40, 340, TEXT("オナジミサン"), RGB(255,120,0));
			break;
	case 2: DrawString( 40, 340, TEXT("４つの塔"), RGB(255,120,0));
			break;
	case 3: DrawString( 40, 340, TEXT("クロスクロス"), RGB(255,120,0));
			break;
	case 4: DrawString( 40, 340, TEXT("円環の理"), RGB(255,120,0));
			break;
	case 5: DrawString( 40, 340, TEXT("製作は私達です。"), RGB(255,120,0));
			break;
	// 追加ステージ：時間あったら追加しよう
	/*case 6: DrawString( 40, 340, TEXT("プレイありがとうございます。"), RGB(255,120,0));
			break;*/
	}
	for (int i = 0; i < 5; ++i){
		DrawGraph(60+i*120, 200 ,stagegh[i],TRUE); // ステージタイトル表示
	}
	if(clear[mstage-1]){
			DrawGraph(700, 320 ,cleargh,TRUE); // ステージタイトル表示
	}

	DrawBox( 60+(mstage-1)*120, 200, 160+(mstage-1)*120, 270 , RGB(255,20,30), false); // 選択枠表示
	DrawBox( 400, 320, 750, 578 , RGB(255,20,30), false); // 詳細枠表示
	
	DrawGraph(40, 460 , bargh[mbar-1], TRUE); // 選択バー表示

	DrawFormatString( 40, 500, RGB(255,120,0), TEXT("SCORE: %d"), mscore);
	DrawFormatString( 40, 540, RGB(255,120,0), TEXT("STOCK: %d"), mstock);
	
}

void STAGESELECT::KeyGet()
{
	if(rB){ // 右ボタン
		if(AT){ // オートモードの場合
			++autocount;
		}
		++mstage;
		if(mstage > 5){
			mstage = 1;
		}
		rB = false;
	}
	if(lB){ // 左ボタン
		if(AT){ // オートモードの場合
			++autocount;
		}
		--mstage;
		if(mstage < 1){
			mstage = 5;
		}
		lB = false;
	}
	if(AT){ // オートモードの場合
		if(eB && autocount > 10){ // 決定ボタン
			endflag = true;
			eB = false;
			autocount =0;
		}
	}
	else if (eB){ // 決定ボタン
		endflag = true;
		eB = false;
	}

}


bool STAGESELECT::All()
{
	//キー処理
	KeyGet();

	//描画処理
	Draw();

	return endflag;
}

void STAGESELECT::SetFlag( bool flag){
	endflag = flag;
}
bool STAGESELECT::GetFlag(){
	return endflag;
}