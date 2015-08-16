using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class MenuController : MonoBehaviour {

	public AudioSource sourceIntroMusic;
	public AudioSource sourceLoopMusic;
	
	public Image imageSplashBackground;
	
	public Image stageOneHeadphoneIcon;
	public Text stageOneText;
	
	public Text stageThreeText;
	
	public Text stageFourText;
	
	public Text stageFiveText;
	
	public Text stageSixText;
	
	int introStage = 0;
	
	// Use this for initialization
	void Awake () {
		sourceIntroMusic.Play();
		
		Invoke( "showStageOne", 5.6f );
		Invoke( "showStageTwo", 10.0f );
		Invoke( "showStageThree", 11.1f );
		Invoke( "showStageFour", 14.3f );
		Invoke( "showStageFive", 17.3f );
		Invoke( "showStageSix", 21.0f );
		Invoke( "hideSplashBackground", 23.0f );
		Invoke( "switchToLoop", 97.0f );
	}
	
	// Update is called once per frame
	void Update () {
		if(introStage == 2) {
			FadeText(stageOneText, false);
			FadeImage(stageOneHeadphoneIcon, false);
		} else if(introStage == 3) {
			FadeText(stageThreeText, true);
			ShiftAudio(sourceIntroMusic, -.7f);
		} else if(introStage == 4) {
			FadeText(stageFourText, true);
			ShiftAudio(sourceIntroMusic, .7f);
		} else if(introStage == 5) {
			FadeText(stageThreeText, false);
			FadeText(stageFourText, false);
			FadeText(stageFiveText, true);
			ShiftAudio(sourceIntroMusic, 0.0f);
		}else if(introStage == 6) {
			FadeText(stageFiveText, false);
			FadeText(stageSixText, true);
		}
	}
	
	//Button Functions
	public void skipButtonPressed ()
	{
		CancelInvoke("showStageOne");
		CancelInvoke("showStageThree");
		CancelInvoke("showStageFour");
		CancelInvoke("showStageFive");
		CancelInvoke("showStageSix");
		CancelInvoke("hideSplashBackground");
		CancelInvoke("switchToLoop");
		hideSplashBackground();
		switchToLoop();
	}
	
	//UI Functions

	//FadeDir (false = out, true = in)
	void FadeText(Text textObject, bool fadeDir)
	{
		bool doFade = fadeDir ? textObject.color.a < 1.0f : textObject.color.a > 0.0f;
		float modifier = fadeDir ? -1.0f : 1.0f; 
		if (doFade){
			Color color = textObject.color;
			color.a -= 1.0f * Time.deltaTime * modifier;
			textObject.color = color; 
		}
	}
	
	//FadeDir (false = out, true = in)
	void FadeImage(Image ImageObject, bool fadeDir)
	{
		bool doFade = fadeDir ? ImageObject.color.a < 1.0f : ImageObject.color.a > 0.0f;
		float modifier = fadeDir ? -1.0f : 1.0f;
		
		if (doFade){
			Color color = ImageObject.color;
			color.a -= 1.0f * Time.deltaTime * modifier;
			ImageObject.color = color; 
		}
	}
	
	//FadeDir (false = left, true = right)
	void ShiftAudio(AudioSource audioObject, float target)
	{
		float diff = target - audioObject.panStereo;
		bool doShift = Mathf.Abs(diff) > .005;
		
		float modifier = (diff > 0) ? -1.0f : 1.0f;
		
		if (doShift){
			audioObject.panStereo -= 1.0f * Time.deltaTime * modifier; 
		}
	}
	
	void hideSplashBackground ()
	{
		imageSplashBackground.gameObject.SetActive(false);
	}
	
	void switchToLoop ()
	{
		sourceIntroMusic.Stop ();
		sourceLoopMusic.Play ();
	}
	
	//Stage Functions
	
	void showStageOne ()
	{
		introStage = 1;
		stageOneHeadphoneIcon.gameObject.SetActive(true);
		stageOneText.gameObject.SetActive(true);
	}
	
	void showStageTwo ()
	{
		introStage = 2;
	}
	
	void showStageThree ()
	{
		stageThreeText.gameObject.SetActive(true);
		introStage = 3;
	}
	
	void showStageFour ()
	{
		stageFourText.gameObject.SetActive(true);
		introStage = 4;
	}
	
	void showStageFive ()
	{
		stageFiveText.gameObject.SetActive(true);
		introStage = 5;
	}
	
	void showStageSix ()
	{
		stageSixText.gameObject.SetActive(true);
		introStage = 6;
	}
}
