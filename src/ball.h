#include "pch.h"

class BALL{
private:
	//x���W�Ay���W
	int x,y;

	//x��y�̈ړ���
	int dx,dy;

	// �O�̕ω���
	int oldx,oldy;

	//�摜�̉��A�c��
	int width,height;

	//�Q�[���[�I�[�o�[�t���O
	bool endflag;

	//����炷���ǂ����̃t���O
	bool soundflag;

	//�O���t�B�b�N�n���h��
	int gh[3];

	// �ђʃt���O
	bool penetrate;

	// �ђʌp������
	int penecount;

	// ���ʂ��ǂ���
	bool sball;

	// ����
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
	void spchange(); // �Q�[�����i�W���Ȃ��Ȃ����Ƃ��ً̋}���u
	bool isPene();
	int level; // ���x���x��
	void Reset();
	void LvUp( int inclv);
	// �A�N�V�����J�E���g
	int m_actcount;
};
