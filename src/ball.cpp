#include "pch.h"
#include "ball.h"


BALL::BALL()
{
	gh[0] = LoadGraph(TEXT("ball_a.png")); // 通常弾
	gh[1] = LoadGraph(TEXT("ball2.bmp")); // 貫通弾
	gh[2] = LoadGraph(TEXT("ball3.bmp")); // 小玉

	GetGraphSize(gh[0],&width,&height);

	//y座標は固定なのでここで設定
	y=540-height+2;

	//最初は真ん中
	x=WIDTH/2+30;

	dx = 0;
	dy = 0;

	radius = 60;

	m_actcount = 0;
	oldy = y;

	endflag=false;

	soundflag=false;

	penetrate = false;
	penecount = 0;

	sball = false;

	level = 1;
	t = 1;
}

void BALL::Draw(){

	if(penetrate)
		DrawGraph(x-width/2,y-height/2,gh[1],TRUE);
	else if(sball)
		DrawGraph(x-width/2,y-height/2,gh[2],TRUE);
	else
		DrawGraph(x-width/2,y-height/2,gh[0],TRUE);
	//++count;
}

void BALL::Move(){

	//まず音はOFFにしとく
	soundflag=false;

	//移動量を加算
	x+=dx;
	y+=dy;

	//画面はみ出し処理
	if(x<width/2){
		x=width/2;
		dx*=-1;
		//当たったのでサウンドフラグを立てる
		soundflag=true;
	}
	if(x>WIDTH-width/2){
		x=WIDTH-width/2;
		dx*=-1;
		//当たったのでサウンドフラグを立てる
		soundflag=true;
	}

	if(y<height/2+30){
		y=height/2+30;
		dy*=-1;
		//当たったのでサウンドフラグを立てる
		soundflag=true;
	}

	//下にはみ出たらゲームオーバー
	if(y>HEIGHT){
		endflag=true;
	}

}

void BALL::LvUp( int inclv){ // 速度上昇
	if(level < 20){
		level += inclv;
		if(dx < 0)
			--dx;
		else
			++dx;
		if(dy < 0)
			--dy;
		else
			++dy;
	}
}
void BALL::SetR( int r )
{
	radius = r;
}
int BALL::GetX()
{
	return x;
}

void BALL::SetX(int mx){
	x = mx;
	oldx = x;
}

void BALL::SetY(int my){
	y = my;
	oldy = y;
}

int BALL::GetY()
{
	return y;
}

void BALL::SetDX(int mdx)
{
	dx = mdx;
	oldx = x;
}

void BALL::SetDY(int y)
{
	dy= y;
	oldx = x;
}

int BALL::GetDX()
{
	return dx;
}


int BALL::GetDY()
{
	return dy;
}


int BALL::GetWidth()
{
	return width;
}

int BALL::GetHeight()
{
	return height;
}

bool BALL::GetSoundflag()
{
	return soundflag;
}

void BALL::PowerUp()
{
	if(!sball) // 小玉は貫通化しない
		penetrate = true;
	penecount = 150;
}

bool BALL::isPene()
{
	return penetrate;
}
void BALL::Increse( int mx, int my)
{
	sball = true;
	int r = rand() % 7;
	x = mx;
	y = my;
	dx+= r  -  3;
	dy+= (6 - r)- 2;
	if( dy == 0 )
		dy = -1;

}

void BALL::Reset(){ //リセット
	penetrate = false;
	//y座標は固定なのでここで設定
	y=540-height+2;

	//最初は真ん中
	x=WIDTH/2+30;
	
	oldy = y;

	dx = 0;
	dy = 0;

	m_actcount = 0;

	endflag = false;
	radius = 1;
	level = 1;
}

void BALL::KeyGet()
{
	if(eB) { // 決定ボタン
		if(m_actcount == 0){ // 一番最初
			//最初の係数
			dx=3;
			dy=-3;
			m_actcount = 1;
		}
	}
}
void BALL::spchange(){ // 操作が進展しなくなったとき用
	// 疑似乱数
	int r = rand() % 5;
	dx+= r -  6;
	dy+= (10 - r)- 6;
}

bool BALL::All()
{
	if(m_actcount != 0 || sball){
		Move();
	}
	//キー処理
	KeyGet();

	if(penecount > 0){
		--penecount;
		if(penecount == 0)
			penetrate = false;
	}

	//描画処理
	Draw();

	return endflag;

}


void BALL::Destroy(){


}


BALL::~BALL()
{
	Destroy();

}









	


