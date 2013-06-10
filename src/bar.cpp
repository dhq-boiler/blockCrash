#include "pch.h"
#include "bar.h"

BAR::BAR( int barnum )
{
	gh[0] = LoadGraph(TEXT("bar.bmp")); // バー１
	gh[1] = LoadGraph(TEXT("barsecond.bmp")); // バー２
	gh[2] = LoadGraph(TEXT("barthird.bmp")); // バー３

	mbar = barnum-1;

	GetGraphSize(gh[mbar],&width,&height);

	//y座標は固定なのでここで設定
	y=540;

	//最初は真ん中
	x=WIDTH/2;

	// 拡大率の初期化
	ex = 2;

	//終了フラグは偽にしとく
	endflag=false;

	end = false;
}

void BAR::Draw(){

	DrawExtendGraph(x-width*ex/4,y-height/2,x+width*ex/4,y+height/2,gh[mbar],TRUE);
}

bool BAR::KeyGet()
{
	bool on = false;
	
	if(barx){ // バーの移動
		x = barx;
		on = true;
	}

	if(key[KEY_INPUT_LEFT] == 1){
		//左に移動。
		x-=SPEED;
		accel = -1;
		on = true;
	}
	if(key[KEY_INPUT_RIGHT] == 1){
		//右に移動
		x+=SPEED;
		accel = 1;
		on = true;
	}
	if(key[KEY_INPUT_ESCAPE] == 1){
		//エスケープキーが押されていれば終了フラグをtrueにする
		endflag=true;
	}

	//画面のはみ出し処理
	if(x<width*ex/4)
		x=width*ex/4;

	if(x>WIDTH-width*ex/4)
		x=WIDTH-width*ex/4;
	mx = x;
	return on;
}

int BAR::GetAcceleration()
{
	return accel;
}

void BAR::SetX( int vx )
{
	x = vx;
}
int BAR::GetX()
{
	return x;
}

int BAR::GetY()
{
	return y;
}

int BAR::GetWidth()
{
	return width;

}

int BAR::GetHeight()
{
	return height;
}

void BAR::ExtendWidth()
{
	++ex;
}

void BAR::Reset(){ // リセット
	ex = 2; 
}

void BAR::SetFlag( bool flag){
	end = flag;
}

bool BAR::All()
{
	
	if(!end){
		//キー処理
		if(!KeyGet())
			accel = 0;
	}

	//描画処理
	Draw();

	//終了フラグを返す。
	return endflag;

}


void BAR::Destroy(){

	
}


BAR::~BAR()
{
	Destroy();

}









	


