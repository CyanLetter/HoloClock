using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using DG.Tweening;

public class SevenSegmentDisplay : MonoBehaviour {

    public GameObject[] segments;
    public float onZPosition;
    public float offZPosition;

    public float segmentTransitionTime = 1f;

    List<Vector3> onPositions = new List<Vector3>();
    List<Vector3> offPositions = new List<Vector3>();

    int currentNumber = 0;
    int[] currentActiveSegments;

	// Use this for initialization
	void Start () {
        if (segments.Length != 7) {
            Debug.LogError("Seven Segment Display must include exactly 7 GameObject in segments array");
            return;
        }

        for (int i = 0; i < segments.Length; i++)
        {
            Vector3 currentOnPos = new Vector3(segments[i].transform.localPosition.x, segments[i].transform.localPosition.y, onZPosition);
            Vector3 currentOffPos = new Vector3(segments[i].transform.localPosition.x, segments[i].transform.localPosition.y, offZPosition);

            onPositions.Add(currentOnPos);
            offPositions.Add(currentOffPos);
        }

        SetNumber(currentNumber);
    }

    public void SetNumber(int number) {
        currentNumber = number;
        currentActiveSegments = SegmentMap.GetSegmentMap(currentNumber);

        for (int i = 0; i < segments.Length; i++) {
            Vector3 targetPos;
            if (currentActiveSegments.Contains(i)) {
                targetPos = onPositions[i];
            } else {
                targetPos = offPositions[i];
            }

            segments[i].transform.DOLocalMove(targetPos, segmentTransitionTime).SetEase(Ease.InOutSine);
        }
    }

    public void Increment() {
        currentNumber++;
        if (currentNumber > 9) {
            currentNumber = 0;
        }

        SetNumber(currentNumber);
    }

    public void Decrement()
    {
        currentNumber--;
        if (currentNumber < 0)
        {
            currentNumber = 9;
        }

        SetNumber(currentNumber);
    }
}
