
/* BEGIN FORWARD DECLARATION */

class MAIN;

/* END FORWARD DECLARATION */

class GAME{
private:
	
	// バーのx座標
	int vx;

	// 終了フラグ
	int endflag;

	MAIN *main;

private:
public:
	// ゲームを制御する関数群
	// ゲームスタート
	bool GameStart();
	
	// 左入力
	void RButton();
	// 右入力
	void LButton();

	// バーのx座標更新 // (50 <= vx <= 750)の範囲にすること
	void BarMove( int vx );

	// 決定ボタン
	void EnterButton();

	// オートモード // デバック用
	void Auto( bool on);

	// キー入力終了 // スレッド用
	void KeyEnd();

	//bool All();
	GAME();
	~GAME();
};
