# CIEN 프로그래밍 스터디 자료들
## 사용하는 유니티 버전: Unity 2018.4.9f1 LTS
---
## 1주: ./Unity-Projects/Week1 유니티 프로젝트 참고
### 유니티 적응하기
 - 유니티 소개
 - 유니티 설치
 - 화면 구성
 - 조작 방법
 - 책상 만들기
### 유니티 개념들
#### 씬(Scene)
#### 게임 오브젝트(GameObject)
 - Hierarchy 창
 - 기본 게임 오브젝트
 - Empty Gameobject
    - 부모 자식
 - Rotating
#### 컴포넌트(Component)
 - 돌 굴리기
#### 스크립트(Script)
 - Start()
 - Update()
 - Drag and Drop으로 초기화
 - Debug.Log("메시지")
 - 큐브를 화살표 키로 이동시키기
 - Frame과 Time.deltaTime
---
## 2주: ./Unity-Projects/Week2 유니티 프로젝트 참고
### 큐브 이동시키기
 - Transform 
 - Rigidbody-Velocity
 - 2가지 방법으로 큐브 이동
 - Find 함수 
 - tag란?
 - 게임 오브젝트들 구분하기
 - Find한 오브젝트로 이동하기
### 총알 구현하기
#### 총알 생성하기
 - 대충 총알 만들기
 - Velocity를 줘보자
 - 총알을 prefab화하기
 - Instantiate
 - Time.deltaTime을 이용해서 Timer 만들기
 - 3초마다 총알 발사!
#### 총알이 충돌했을 때
 - OnTriggerEnter(Collider)     : 물리적인 충돌하기
 - OnColliderEnter(Collision)   : 물리적인 탄성 충돌
 - GetComponent<컴포넌트>()      : 해당 게임오브젝트의 원하는 컴포넌트 추출 
#### 총알 구분하기
 - CompareTag("Target 태그명")
#### 총알 구현을 위해 필요한 추가적인 함수들
 - Destroy 함수
 - Destroy 나중에 하려면?
 - OnBecameInvisible
 
### 적 만들기
 - 적 자동 사격
 - Player 사망 구현
 - 총알을 쏘면서 목표지점까지 가기
### 2D 프로젝트로도 해보기
 - 시간 없으면 과제로
---
## 3주
 - 싱글턴 패턴
 - 코루틴 개념
 - 코루틴 사용
 - yield return new WaitForSecond(초);
 - 세이브 파일
 - 사운드
 - 앱 빌드하기
 - UI 특강 공지
---
# 나중에 ... 
## UI
간단한 실습 3 UI 만들어보기(20분)
### 1. 스테이지 선택
### 2. 메뉴창
 - Scene 설명
 - Camera 설명 및 조작
 - Button Click 했을 때. 함수 실행!
 - 타이틀 화면: press to start 구현
 - UI 숨겨보기/켜보기
 - 사망 화면
 - Scene 이동하기
### 간단한 실습 4: 타이머 만들어서 상단에 띄우기
 1. Text 바꾸는 법 알려준다
 2. 시킨다
