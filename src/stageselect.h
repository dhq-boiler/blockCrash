#include "pch.h"
class STAGESELECT{
private:

	// 終了フラグ。終了ならtrue
	bool endflag;

	// グラフィックハンドル
	int bargh[3], ballgh;
	
	// ステージグラフィックハンドル
	int stagegh[6];

	// ステージ詳細グラフィックハンドル
	int sdetailgh[6];

	// ステージクリアハンドル 
	bool clear[6];

	// ステージセレクトグラフィックハンドル
	int sselectgh;

	// クリア表示グラフィックハンドル
	int cleargh;

	// 選択音と決定音のフラグ
	bool selectflag, decisionflag;

	// 選択音と決定音のサウンドハンドル
	int sh,dh;

	// キー入力の遊び
	int keycount;

	// 決定入力の遊び //なおそう
	int entercount;

	// オート入力の遊び
	int autocount;

private:
	void Draw();
	void KeyGet();
	//void SoundPlay();
public:
	bool All();
	STAGESELECT();
	~STAGESELECT();
	void SetFlag(bool);
	bool GetFlag();
	void Reset();
	void SetValue(int bar, int stage, int score, int stock);

	// 得点,残機
	int mscore,mstock;
	// 選択ステージ数
	int mstage;

	// 選択バー
	int mbar;
};