#include "pch.h"
#include "title.h"


TITLE::TITLE()
{
	titlegh = LoadGraph(TEXT("title.png")); // タイトル

	selectflag = false;
	decisionflag = false;

	endflag = false;

	//音声ファイル読み込み。
	sh = LoadSoundMem(TEXT("bound.wav"));
	dh = LoadSoundMem(TEXT("demolish.wav"));

}


TITLE::~TITLE()
{
}

void TITLE::Draw(){

	DrawGraph(0, 0 ,titlegh,TRUE); // タイトル表示
	
}

void TITLE::KeyGet()
{
	if(rB || lB || eB){ // ボタンon
		endflag = true;
	}
}


bool TITLE::All()
{
	//キー処理
	KeyGet();

	//描画処理
	Draw();

	return endflag;
}

void TITLE::SetFlag( bool flag){
	endflag = flag;
}
bool TITLE::GetFlag(){
	return endflag;
}