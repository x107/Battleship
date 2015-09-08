
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using SwinGameSDK;
static class GameLogic
{
	public static void Main()
	{
		//Opens a new Graphics Window
		SwinGame.OpenGraphicsWindow("Battle Ships", 800, 600);

		//Load Resources
		SwinGame.ProcessEvents();

/*		LoadResources();
*/
		GameState CurrentState = new GameState ();
		//Game Loop
		while(!(SwinGame.WindowCloseRequested() || !(CurrentState==GameState.Quitting)))
		{
			GameController.StartGame ();
		}
		
		//Free Resources and Close Audio, to end the program.
		SwinGame.CloseAudio();
		SwinGame.ReleaseAllResources();
	}
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
