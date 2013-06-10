#include "pch.h"

class BLOCK{
private:
	//座標
	int x,y;

	//縦、横幅
	int width,height,itemwidth,itemheight;

	//ブロックが壊れてるか壊れてないかのフラグ。
	bool endflag;

	//グラフィックハンドル。
	static	int gh[8];

	// アイテムのグラフィックハンドル
	static int itemgh[5];

	// ブロックサイズを半分にするかどうか
	bool half;

	//フェード描画用カウント
	int count;

private:
	void Draw(int blockhandle);
public:
	int GetX();
	int GetY();
	int GetWidth();
	int GetHeight();
	void SetFlag(bool);
	bool GetFlag();
	void SetItemFlag(bool);
	bool GetItemFlag();
	void SetHalfFlag(bool flag);

	BLOCK(char *,int,int);
	void All(int blockhandle);

	
	// アイテム種類
	enum ItemType{
		ITEMTYPE_LONG,
		ITEMTYPE_POWERUP,
		ITEMTYPE_INCRESE,
		ITEMTYPE_1UP,
		ITEMTYPE_SCOREUP
	};


	// アイテムが入っているかどうかのフラグ
	bool itemflag;
	enum ItemType it;
};
