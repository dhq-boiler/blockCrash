
/* BEGIN FORWARD DECLARATION */

class MAIN;

/* END FORWARD DECLARATION */

class GAME{
private:
	
	// �o�[��x���W
	int vx;

	// �I���t���O
	int endflag;

	MAIN *main;

private:
public:
	// �Q�[���𐧌䂷��֐��Q
	// �Q�[���X�^�[�g
	bool GameStart();
	
	// ������
	void RButton();
	// �E����
	void LButton();

	// �o�[��x���W�X�V // (50 <= vx <= 750)�͈̔͂ɂ��邱��
	void BarMove( int vx );

	// ����{�^��
	void EnterButton();

	// �I�[�g���[�h // �f�o�b�N�p
	void Auto( bool on);

	// �L�[���͏I�� // �X���b�h�p
	void KeyEnd();

	//bool All();
	GAME();
	~GAME();
};
