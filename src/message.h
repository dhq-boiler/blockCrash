#include "pch.h"

class MESSAGE{
private:

	// 表示カウント
	int ct;

	// 終了フラグ
	bool endflag;

	// 表示メッセージ
	char *mes;

private:
	void Draw();
	void KeyGet();
public:
	bool All();
	MESSAGE( int pattern, int count);
	~MESSAGE();
};