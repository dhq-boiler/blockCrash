#include "pch.h"

class MESSAGE{
private:

	// �\���J�E���g
	int ct;

	// �I���t���O
	bool endflag;

	// �\�����b�Z�[�W
	char *mes;

private:
	void Draw();
	void KeyGet();
public:
	bool All();
	MESSAGE( int pattern, int count);
	~MESSAGE();
};