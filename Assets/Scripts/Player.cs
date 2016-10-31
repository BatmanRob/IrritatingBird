using UnityEngine;
using System.Collections;

public class Player  {

		private const string key = "HIGH_SCORE";

		private Player(){
			//get highScore from the PlayerPrefs if exists
			if (PlayerPrefs.HasKey (key)) {
				_highScore = PlayerPrefs.GetInt (key);
			}

		}

		private static Player _instance = null;

		public static Player Instance{

			get{  
				if (_instance == null) {
					_instance = new Player ();
				}

				return _instance;
			}
		}

		public HUDController hud = null;
		private int _points = 0;
		public int Points{
			get{  
				return _points;
			}

			set{  
				_points = value;
				HighScore = _points;
				hud.UpdatePoints ();
			}
		}

		private int _highScore = 0;

		public int HighScore{
			get{  
				return _highScore;
			}

			set{  
				if (value > _highScore) {
					_highScore = value;
					PlayerPrefs.SetInt (key, _highScore);
				}
			}
		}

		private int _health = 200;
		public int Health{
			get{  
				return _health;
			}

			set{  
				_health = value;
				hud.UpdateHealth ();
				if (_health <= 0) {
					hud.GameOver ();
				}
			}
		}

	}
