#include "pch.h"
#define SPEED 8

class BAR{
private:
	//x���W�Ay���W
	int x,y;

	//�摜�̉��A�c��
	int width,height;

	//�I���t���O�B�I���Ȃ�true
	bool endflag;

	//�O���t�B�b�N�n���h��
	int gh[3];

	// �g�嗦
	int ex;
	
	// �I��
	bool end;

	// ���� -�Ȃ獶�C+�Ȃ�E
	int accel;

	// �o�[�̎��
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
	