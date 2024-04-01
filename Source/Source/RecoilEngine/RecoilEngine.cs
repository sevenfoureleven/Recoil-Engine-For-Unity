using UnityEngine;

namespace RecoilEngineVariables
{
    [System.Serializable]
    public class RecoilPattern
    {
        public GameObject recoilObject;
        public AnimationCurve curve;
        public float maxIntensity = 0.2f;
        public float maxXRotation = 5f; // Maximum rotation on X-axis
        public float kickbackIntensity = 0.1f;
        public float zRotation = 2f; // Rotation on Z-axis
    }

    public class RecoilEngine
    {
        //Applying random.
        public void ApplyRandomization(ref RecoilPattern recoilPattern)
        {
            //Randomizing.
            if (recoilPattern != null)
            {
                float randomIntensity = Random.Range(0f, recoilPattern.maxIntensity);
                float randomXRotation = Random.Range(-recoilPattern.maxXRotation, recoilPattern.maxXRotation);
                float randomZRotation = Random.Range(-recoilPattern.zRotation, recoilPattern.zRotation);

                Keyframe[] modifiedKeys = recoilPattern.curve.keys;

                //modifying keyframes
                for (int i = 0; i < modifiedKeys.Length; i++)
                {
                    Keyframe keyframe = modifiedKeys[i];
                    float modifiedValue = keyframe.value + randomXRotation; // Directly add randomXRotation
                    modifiedValue = Mathf.Clamp(modifiedValue, recoilPattern.curve.Evaluate(keyframe.time - 0.01f), recoilPattern.curve.Evaluate(keyframe.time + 0.01f));
                    modifiedKeys[i].value = modifiedValue;
                }

                //Assigning modifications
                recoilPattern.curve.keys = modifiedKeys;
            }
        }

        //Apply Recoil functionaliity
        public void ApplyRecoil(RecoilPattern recoilPattern)
        {
            if (recoilPattern != null)
            {
                //Recoil calc.
                float recoilAmountZ = Random.Range(-recoilPattern.zRotation, recoilPattern.zRotation);
                //Def. kickback
                Vector3 kickback = Vector3.back * recoilPattern.kickbackIntensity;

                //Applying recoil to the recoil obkect
                Quaternion recoilRotation = Quaternion.Euler(recoilPattern.maxXRotation, 0f, recoilAmountZ); // Adjusted to directly use maxXRotation
                recoilPattern.recoilObject.transform.localRotation *= recoilRotation;
                //Applying kickback (I.e. moving the recoil object slightly backwards)
                recoilPattern.recoilObject.transform.Translate(kickback, Space.Self);
            }
        }

        //Hey! Will add more functionality later, as I update this tool for my own project. This may take a while, so I wholehearthedly recommend adding more to the system yourself!
    }
}