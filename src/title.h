#include "pch.h"
class TITLE{
private:

	// 終了フラグ。終了ならtrue
	bool endflag;
	
	// タイトルグラフィックハンドル
	int titlegh;

	// 選択音と決定音のフラグ
	bool selectflag, decisionflag;

	// 選択音と決定音のサウンドハンドル
	int sh,dh;

private:
	void Draw();
	void KeyGet();
public:
	bool All();
	TITLE();
	~TITLE();
	void SetFlag(bool);
	bool GetFlag();

};