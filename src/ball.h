#include "pch.h"

class BALL{
private:
	//x座標、y座標
	int x,y;

	//xとyの移動量
	int dx,dy;

	// 前の変化量
	int oldx,oldy;

	//画像の横、縦幅
	int width,height;

	//ゲームーオーバーフラグ
	bool endflag;

	//音を鳴らすかどうかのフラグ
	bool soundflag;

	//グラフィックハンドル
	int gh[3];

	// 貫通フラグ
	bool penetrate;

	// 貫通継続時間
	int penecount;

	// 小玉かどうか
	bool sball;

	// 加速
	int radius;

	int t;

private:
	void Draw();
	void KeyGet();
	void Destroy();
	void Move();

public:
	BALL();
	~BALL();
	bool All();
	int GetX();
	int GetY();
	int GetWidth();
	int GetHeight();
	void SetR( int r );
	void SetDX(int);
	void SetX( int mx);
	void SetY( int my);
	void SetDY(int);
	int GetDX();
	int GetDY();
	bool GetSoundflag();
	void PowerUp();
	void Increse( int mx, int my);
	void spchange(); // ゲームが進展しなくなったときの緊急処置
	bool isPene();
	int level; // 速度レベル
	void Reset();
	void LvUp( int inclv);
	// アクションカウント
	int m_actcount;
};
