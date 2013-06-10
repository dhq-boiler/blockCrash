#include "pch.h"
#include "control.h"
#include "time.h"

void CONTROL::HitCheckBallAndBar( BALL *ball)
{ 

	//最初はフラグをfalseにしとく。
	boundflag=false;

	//ボールクラス内での音フラグをセット
	boundflag=ball->GetSoundflag();


	//バーの座標取得
	bdx=bar->GetX();
	bdy=bar->GetY();

	//ボールの座標取得
	blx=ball->GetX();
	bly=ball->GetY();


	//ボールとバーの高さの半分を足したものよりも
	//バーの中心とボールの中心の距離の絶対値の方が小さかったら当たり
	//その距離より大きいやつは除外
	if(abs(bdy-bly)<blheight/2+bdheight/2){
		//且つ、ボールがバー内にあれば当たり
		if(bdx+bdwidth/2>blx &&
			bdx-bdwidth/2<blx){
				ball->SetR( 20 );
				//バーの左端に当たっていれば、逆方向に飛ばす。
				if(blx<bdx-bdwidth/2*2/3){
					if(barnum == 3){
						ball->LvUp(1);
					}
					//ボールを反転
					ball->SetDX(-1*ball->GetDX());
					//Yは跳ね返すだけ
					ball->SetDY(ball->GetDY()*-1);
					ball->SetY(ball->GetY()-5);
					//バウンド音フラグを立てる。
					boundflag=true;

					//右端
				}else if(blx>bdx+bdwidth/2*2/3){
					if(barnum == 3){
						ball->LvUp(1);
					}
					//ボールを反転
					ball->SetDX(-1*ball->GetDX());
					//Yは跳ね返すだけ
					ball->SetDY(ball->GetDY()*-1);
					ball->SetY(ball->GetY()-5);
					//バウンド音フラグを立てる。
					boundflag=true;

				
					//それ以外はただ反射
				}else{
					if(barnum == 3){
						ball->LvUp(1);
					}
					//xは何もなし
					//Yは跳ね返すだけ
					ball->SetDY(ball->GetDY()*-1);
					ball->SetY(ball->GetY()-5);
					//バウンド音フラグを立てる。
					boundflag=true;
				}
		}
	}

}

void CONTROL::HitCheckBallAndBlock( BALL *ball)
{
	//破壊音フラグ
	demolishflag=false;

	//ボールの座標取得
	blx=ball->GetX();
	bly=ball->GetY();

	//ブロック全てをループ
	for(int i=0;i<sumblock;++i){
		//壊れてない奴を対象
		if(!block[i]->GetFlag()){
			bkx=block[i]->GetX();
			bky=block[i]->GetY();

			//ブロックの上との当たり判定
			if(blx<bkx+bkwidth/2 && blx>bkx-bkwidth/2 &&
				bly+blheight/2>bky-bkheight/2 && bly+blheight/2<bky+bkheight/2){
					
					vspeed = 0; // 進まなくなったとき用カウントの初期化

					//フラグをオフに
					block[i]->SetFlag(true);
					//破壊音フラグを立てる
					demolishflag=true;
					if(!ball->isPene()){ //貫通状態だと跳ね返らない
						//ボールはただ跳ね返すだけ
						ball->SetDY(ball->GetDY()*-1);
					}
					//ブロックの下との当たり判定
			}else if(blx<bkx+bkwidth/2 && blx>bkx-bkwidth/2 &&
				bly-blheight/2>bky-bkheight/2 && bly-blheight/2<bky+bkheight/2){

					vspeed = 0; // 進まなくなったとき用カウントの初期化

					//フラグをオフに
					block[i]->SetFlag(true);
					//破壊音フラグを立てる
					demolishflag=true;
					if(!ball->isPene()){ //貫通状態だと跳ね返らない
						//ボールはただ跳ね返すだけ
						ball->SetDY(ball->GetDY()*-1);
					}

					//ブロックの左との当たり判定
			}else if(blx+blwidth/2<bkx-bkwidth/2+blwidth && blx+blwidth/2>bkx-bkwidth/2 &&
				bly>bky-bkheight/2 && bly<bky+bkheight/2){

					vspeed = 0; // 進まなくなったとき用カウントの初期化

					//フラグをオフに
					block[i]->SetFlag(true);
					//破壊音フラグを立てる
					demolishflag=true;
					if(!ball->isPene()){ //貫通状態だと跳ね返らない
						//ボールはただ跳ね返すだけ
						ball->SetDX(ball->GetDX()*-1);
					}
					//ブロックの右との当たり判定
			}else if(blx-blwidth/2<bkx+bkwidth/2 && blx-blwidth/2>bkx+bkwidth/2-blwidth &&
				bly>bky-bkheight/2 && bly<bky+bkheight/2){

					vspeed = 0; // 進まなくなったとき用カウントの初期化

					//フラグをオフに
					block[i]->SetFlag(true);
					//破壊音フラグを立てる
					demolishflag=true;
					if(!ball->isPene()){ //貫通状態だと跳ね返らない
						//ボールはただ跳ね返すだけ
						ball->SetDX(ball->GetDX()*-1);
					}

			}
			if( block[i]->GetFlag() ){
			mscore += 100 +50*ball->level;
			ball->SetR( 0 );
			}
		}
		
		//アイテムを対象
		else if(block[i]->GetItemFlag()){
			bkx=block[i]->GetX();
			bky=block[i]->GetY();

			//ブロックの上との当たり判定
			if(blx<bkx+bkwidth/2 && blx>bkx-bkwidth/2 &&
				bly+blheight/2>bky-bkheight/2 && bly+blheight/2<bky+bkheight/2){

					vspeed = 0; // 進まなくなったとき用カウントの初期化
					// アイテムフラグをオフに
					block[i]->SetItemFlag(false);
					// アイテムの効果を起こす
					ItemEffect( block[i]->it, blx, bly);
					//取得フラグを立てる
					demolishflag=true;
					//ボールはそのまま

					//ブロックの下との当たり判定
			}else if(blx<bkx+bkwidth/2 && blx>bkx-bkwidth/2 &&
				bly-blheight/2>bky-bkheight/2 && bly-blheight/2<bky+bkheight/2){

					vspeed = 0; // 進まなくなったとき用カウントの初期化

					//アイテムフラグをオフに
					block[i]->SetItemFlag(false);
					// アイテムの効果を起こす
					ItemEffect( block[i]->it, blx, bly);
					//取得フラグを立てる
					demolishflag=true;
					//ボールはそのまま

					//ブロックの左との当たり判定
			}else if(blx+blwidth/2<bkx-bkwidth/2+blwidth && blx+blwidth/2>bkx-bkwidth/2 &&
				bly>bky-bkheight/2 && bly<bky+bkheight/2){

					vspeed = 0; // 進まなくなったとき用カウントの初期化

					//アイテムフラグをオフに
					block[i]->SetItemFlag(false);
					// アイテムの効果を起こす
					ItemEffect( block[i]->it, blx, bly);
					//取得フラグを立てる
					demolishflag=true;
					//ボールはそのまま

					//ブロックの右との当たり判定
			}else if(blx-blwidth/2<bkx+bkwidth/2 && blx-blwidth/2>bkx+bkwidth/2-blwidth &&
				bly>bky-bkheight/2 && bly<bky+bkheight/2){

					vspeed = 0; // 進まなくなったとき用カウントの初期化

					//アイテムフラグをオフに
					block[i]->SetItemFlag(false);
					// アイテムの効果を起こす
					ItemEffect( block[i]->it, blx, bly);
					//取得フラグを立てる
					demolishflag=true;
					//ボールはそのまま

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
									bar->ExtendWidth(); // バーを伸ばす

									bdwidth += exwidth; //バーの幅を更新
									}
									break;
	case BLOCK::ITEMTYPE_POWERUP:	ball->PowerUp(); // 貫通能力の付加
									break;
	case BLOCK::ITEMTYPE_INCRESE:	while(true){
										sball[sballcount] = new BALL; //小玉を増やす（3個）
										sball[sballcount]->Increse( bx, by );
										++sballcount;
										++ct;
										if(ct == 3)
											break;
									}
									break;
	case BLOCK::ITEMTYPE_1UP:		mstock += 1; // 残機を増やす
									break;
	case BLOCK::ITEMTYPE_SCOREUP:	mscore += 2000; // スコアを増やす
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
		//ボールの座標取得
		bar->SetX(ball->GetX());
	}
	//バーの処理
	bar->All();

	if(ball->m_actcount == 0 ){
		ball->SetX(bar->mx);
	}

	// ボールの動き
	++ballspup; // 速度上昇カウント
	switch(barnum){ // バーによりの速度上昇の早さが違う
	case 1:		if(ballspup%1500 == 0){ // やさしい
					ball->LvUp(1);
				}
				break;
	case 2:		if(ballspup%1000 == 0){ // ふつう
					ball->LvUp(1);
				}
				break;
	case 3:		if(ballspup%800 == 0){ // 難しい
					ball->LvUp(1);
				}
				break;
	}
	++vspeed; // 進まなくなったとき用カウントの増加
	if(vspeed == 1000){
		vspeed = 0;
		ball->spchange();
	}

	back = ball->All();

	//ボールとバーの当たり判定
	HitCheckBallAndBar( ball );

	//ボールとブロックの当たり判定
	HitCheckBallAndBlock( ball );


	// 小玉があれば表示　// 謎の挙動
	for(int i = 0; i < sballcount; ++i){
		if(sball[i] == NULL)
			continue;
		sballdrop = sball[i]->All();
		//ボールとバーの当たり判定
		HitCheckBallAndBar( sball[i]);
		//ボールとブロックの当たり判定
		HitCheckBallAndBlock( sball[i] );
		if(sballdrop)
			sball[i] = NULL;  
	}

	accel = bar->GetAcceleration(); // デバック用
	// 得点、レベル、残機枠の表示
	DrawBox( 0, 0, 800, 30 , RGB(230,230,230), true);
	DrawFormatString( 20, 10, RGB(255,120,0), TEXT("SCORE: %d"), mscore);
	DrawFormatString( 220, 10, RGB(10,120,120), TEXT("LEVEL: %d"), ball->level);
	for(int i = 0; i<mstock; ++i)
		DrawGraph(540+18*i, 7, gh, TRUE);

	///音再生
	SoundPlay();
	
	if( back ){
		bar->SetFlag( true );
		ball->SetDX( 0 );
	}
	if( clear ){
		ball->SetDX(0);
		ball->SetDY(0);
		// 小玉があれば表示
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
void CONTROL::Reset(){ // 落ちたら

	// 落ちても残機が 1 以上あったらリセット
	// 小玉があれば消去
	for(int i = 0; i < sballcount; ++i){
		delete sball[i];
	}
	sballcount = 0;
	mstock -= 1; // ストックを減らす
	bdwidth = bar->GetWidth();
	bar->Reset();
	ball->Reset();
	bar->SetFlag( false );

}


CONTROL::CONTROL( int mbar, int stage, int score, int stock )
{
	barnum = mbar;
	
	//バーとボールのインスタンスを生成
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
	
	//バーの幅と高さ
	bdwidth=bar->GetWidth();
	bdheight=bar->GetHeight();

	// バーが拡大する長さ
	exwidth = (int)bdwidth/2;

	//ボールの幅と高さ
	blwidth=ball->GetWidth();
	blheight=ball->GetHeight();

	//音声ファイル読み込み。
	bh = LoadSoundMem(TEXT("bound.wav"));
	dh = LoadSoundMem(TEXT("demolish.wav"));

	// 残機表示の読み込み
	gh = LoadGraph(TEXT("ball_b.png")); // 通常弾
	
	switch( mstage ){
	case 1: sumblock = 28;
			//ブロックの間を5ピクセルあけて、横7列、縦4行で配置
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
			//ブロックの上下間を30ピクセルあけて、横4列、縦12行で配置
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
			//ブロックの上下間を5ピクセルあけて、横3列、縦8行で配置
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
			//ブロックの上下間を5ピクセルあけて、横3列、縦8行で配置
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
			//ブロックの上下間を5ピクセルあけて、横3列、縦8行で配置
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
	// 小玉があれば表示
	for(int i = 0; i < sballcount; ++i){
		delete sball[i];
	}
	for(int i=0;i<sumblock;++i){
		delete block[i];
	}
}
