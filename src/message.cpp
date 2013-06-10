#include "pch.h"
#include "message.h"

MESSAGE::MESSAGE( int pattern, int count)
{
	ct = count;
	endflag = false;
	switch( pattern ){
	case 1: mes = "BALL FAILED!!";
			break;
	case 2: mes = "CLEAR!!";
			break;
	case 3: mes = "GAME OVER!!";
			break;
	}
}


MESSAGE::~MESSAGE()
{
}

void MESSAGE::Draw(){
	
	if(ct > 0){
		SetDrawBlendMode( DX_BLENDMODE_ALPHA, 128 );
		DrawBox( 0, 0, WIDTH, HEIGHT, RGB(30,30,30), true);
		// 描画する文字列のサイズを設定
		SetFontSize( 32 );
		// 文字列の描画
		SetDrawBlendMode( DX_BLENDMODE_NOBLEND, 0);
		DrawFormatString( 250, 300,RGB(255,255,255), mes);
		SetFontSize( 16 );
		--ct;
	}
	else
		endflag = true;
}

void MESSAGE::KeyGet()
{

	if(key[KEY_INPUT_A] == 1){
		// 演出スキップボタン
		endflag = true;
	}
}


bool MESSAGE::All()
{
	//キー処理
	KeyGet();

	//描画処理
	Draw();

	return endflag;
}