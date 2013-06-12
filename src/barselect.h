#include "pch.h"
class BARSELECT{
private:

	// 終了フラグ。終了ならtrue
	bool endflag;
	
	// バーグラフィックハンドル
	int bargh[3];

	// バーセレクトグラフィックハンドル
	int bselectgh;

	// 選択音と決定音のフラグ
	bool selectflag, decisionflag;

	// 選択音と決定音のサウンドハンドル
	int sh,dh;

	// キー入力の遊び
	int keycount;

	// オート入力の遊び
	int autocount;


private:
	void Draw();
	void KeyGet();
	
public:
	bool All();
	BARSELECT();
	
	~BARSELECT();
	void SetFlag(bool);
	bool GetFlag();
	void Reset();
	//void SetValue(int bar, int stage, int score, int stock);

	// 選択バー種類
	int mbar;
};