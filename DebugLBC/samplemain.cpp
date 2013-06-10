#include <boost\thread\thread.hpp>
#include <boost\bind\bind.hpp>
#include "game.h"

int count,actcount = 0;

void ct(GAME *game);

int main()
{
	while(true){
		if(actcount == 0){
			GAME *game = new GAME;
			boost::thread th(boost::bind(&GAME::GameStart, game));
			boost::thread th2(boost::bind(&ct, game));
			++actcount;
		}
	}
}
void ct(GAME *game){ // オートモード　// 解除にはAuto(false)を行う
	game->Auto( true );
}