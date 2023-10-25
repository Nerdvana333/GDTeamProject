using UnityEngine;

namespace Shapes {

	public class IMPanelSample : ImmediateModePanel {

		[Range( 0, 1 )]
		public float fillAmount = 1;
		public Gradient colorGradient;

		public override void DrawPanelShapes( Rect rect ) {

			if ( colorGradient == null ) return; 
			Draw.Rectangle( rect, 8f, Color.black );
			Rect fillRect = Inset( rect, 8 ); 
			fillRect.width *= fillAmount;
			Draw.Rectangle( fillRect, colorGradient.Evaluate( fillAmount ) );
			Draw.RectangleBorder( rect, 4f, 8f, Color.white );
			
			Rect Inset( Rect r, float amount ) {
				return new Rect( r.x + amount, r.y + amount, r.width - amount * 2, r.height - amount * 2 );
			}

		}

	}
	
}