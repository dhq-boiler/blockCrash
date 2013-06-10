#include "pch.h"
#include "bar.h"
#include "ball.h"
#include "block.h"

class CONTROL{
private:
	//バークラスのポインタ
	BAR *bar;
	//ボールクラスのポインタ
	BALL *ball;

	//ボールクラスのポインタ（小玉）
	BALL *sball[MAX_SBALLCOUNT];
	
	//ブロッククラスのポインタ
	BLOCK *block[MAX_BLOCKCOUNT];

	//ボールとバーとブロックの座標
	int bdx,bdy,blx,bly,bkx,bky;

	
	//ボールとバーとブロックの画像の幅と高さ
	int bdwidth,bdheight,blwidth,blheight,bkwidth,bkheight;

	// バーが拡大するサイズ (元のバーの幅の半分)
	int exwidth;

	//バウンド音とぶつかり音のフラグ
	bool boundflag,demolishflag;

	//バウンド音とぶつかり音のサウンドハンドル
	int bh,dh;

	// 小玉の数
	int sballcount;

	// レベル,得点,残機
	int mlevel,mscore,mstock;

	// 残機を示すグラフィックハンドル
	int gh;

	// 表示カウント
	int act;

	// ブロック数
	int sumblock;

	// ステージ数
	int mstage;

	// 加速度
	int accel;

	// バーの種類
	int barnum;

	// 速度上昇カウント
	int ballspup;

	// 速度変更カウント // 進まなくなったとき用
	int vspeed;

private:
	void HitCheckBallAndBar( BALL *ball);
	void HitCheckBallAndBlock( BALL *ball);
	void SoundPlay();
	void ItemEffect( enum BLOCK::ItemType it, int bx, int by);
public:
	bool All();
	void Reset();
	int GetStage();
	int GetScore();
	int GetStock();
	int GetBar();

	// クリアハンドル
	bool clear;
	CONTROL( int mbar, int stage, int score, int stock );
	~CONTROL();
};


	