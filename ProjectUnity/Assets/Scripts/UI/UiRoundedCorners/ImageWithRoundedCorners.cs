using UnityEngine;
using UnityEngine.UI;

namespace Nobi.UiRoundedCorners {
	[SLua.CustomLuaClass]
    [DisallowMultipleComponent]                     //You can only have one of these in every object.
    [RequireComponent(typeof(RectTransform))]
	public class ImageWithRoundedCorners : MonoBehaviour {
		private static readonly int Props = Shader.PropertyToID("_WidthHeightRadius");

        public float radius = 40f;          
        private Material material;

		[HideInInspector, SerializeField] private MaskableGraphic image;

        private void OnValidate() {
			Validate();
			Refresh();
		}

		private void OnDestroy() {
            image.material = null;      //This makes so that when the component is removed, the UI material returns to null
			
			if(material != null)
				DestroyHelper.Destroy(material);
			image = null;
			material = null;
		}

		private void OnEnable() {
            //You can only add either ImageWithRoundedCorners or ImageWithIndependentRoundedCorners
            //It will replace the other component when added into the object.
            var other = GetComponent<ImageWithIndependentRoundedCorners>();
            if (other != null)
            {
                radius = other.r.x;					//When it does, transfer the radius value to this script
                DestroyHelper.Destroy(other);
            }

            Validate();
			Refresh();
		}

		private void OnRectTransformDimensionsChange() {
			if (enabled && material != null) {
				Refresh();
			}
		}

		public void Validate() {
			if (material == null) {
                Shader shader = Shader.Find("UI/RoundedCorners/RoundedCorners");
#if true//!UNITY_EDITOR
                if (shader == null)
                {
                    const string assetPath = "Scripts/UI/UiRoundedCorners/RoundedCorners.shader";
					string abName = GameUtil.GetBundleNameByAssetName(assetPath);
                    shader = (Shader)FResourceLoader.inst.LoadAsset(abName, assetPath);
                }
#endif
                if (shader == null)
                {
                    UnityEngine.Debug.LogWarning("Failed to load shader: RoundedCorners");
                }
                if (shader != null)
                    material = new Material(shader);
            }

			if (image == null) {
				TryGetComponent(out image);
			}

			if (image != null) {
				image.material = material;
			}
		}

		public void Refresh() {
			if (material == null) return;
			var rect = ((RectTransform)transform).rect;

            //Multiply radius value by 2 to make the radius value appear consistent with ImageWithIndependentRoundedCorners script.
            //Right now, the ImageWithIndependentRoundedCorners appears to have double the radius than this.
            material.SetVector(Props, new Vector4(rect.width, rect.height, radius * 2, 0));   
        }
	}
}