#include "pch.h"
#define SPEED 8

class BAR{
private:
	//x座標、y座標
	int x,y;

	//画像の横、縦幅
	int width,height;

	//終了フラグ。終了ならtrue
	bool endflag;

	//グラフィックハンドル
	int gh[3];

	// 拡大率
	int ex;
	
	// 終了
	bool end;

	// 加速 -なら左，+なら右
	int accel;

	// バーの種類
	int mbar;

private:
	void Draw();
	bool KeyGet();
	void Destroy();

public:
	BAR( int barnum );
	~BAR();
	bool All();
	void SetX( int vx );
	int GetX();
	int GetY();
	int GetWidth();
	int GetHeight();
	int GetAcceleration();
	void SetFlag( bool flag );
	void ExtendWidth();
	void Reset();
	int mx;
};
	