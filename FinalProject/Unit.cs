using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Unit
    {
        private int AttackPoint { get; set; }
        private int DefensePoint { get; set; }
        private int ExtraMovePoint { get; set; }
        private bool isGoaled = false;
        public int Point;
        private List<int> PointHistory;
        public List<Unit> Units;

        public Unit(int attack, int defense, int exMove)//공격, 방어, 이동력 초기값 요구
        {
            AttackPoint = attack;
            DefensePoint = defense;
            ExtraMovePoint = exMove;

            Units = new List<Unit>();
            Units.Add(this);
        }

        public void Move(int movePoint)//윷값을 받아서 실행
        {
            if (movePoint == 6)//백도를 우선 체크
            {
                foreach (Unit move in Units)//개별 유닛마다 실행
                {//PointHistory에 저장된 직전 칸으로 이동 및 끝 1개 삭제
                    move.Point = move.PointHistory.Last();
                    move.PointHistory.RemoveAt(move.PointHistory.Count);
                }
            }
            else
            {
                movePoint += ExtraMovePoint;//윷값에 이동력을 가산
                foreach (Unit move in Units)//개별 유닛마다 실행
                {
                    for (int i = movePoint; i > 0; i--)//윷 수와 같은 임의의 i바퀴
                    {
                        //현위치를 PointHistory에 추가하고 다음 1칸으로 이동
                    }
                }
            }
        }
        public void Battle(Unit defense) //이 메소드의 주체가 공격측, 매개변수 defense가 방어측
        {//공격측의 최대공격력이 방어측의 최대방어력보다 낮은 경우
            if (Units.Max(x => x.AttackPoint) > defense.Units.Max(x => x.DefensePoint))
            {
                foreach (Unit dead in defense.Units)//개별 사망 유닛마다 실행
                {
                    //Point를 시작점으로 강제수정 및 PointHistory에 clear로 초기화
                }
            }
            else//그 외
            {
                Move(6);//백도 취급해 실행
            }
        }

        public void UnitLink(Unit unit)//업힐 유닛(들)을 받아서 실행
        {
            Units.AddRange(unit.Units);//업히는 유닛의 리스트를 현 유닛에 추가
            unit.Units.Clear();
            unit.Units.Add(unit);//업히는 쪽은 리스트를 clear하고 다시 자신을 추가해 초기화
        }

        public void ChangeAttackPoint(int point)
        {
            foreach (Unit unit in Units)
            {
                AttackPoint = point;
            }
        }

        public void ChangeDefencePoint(int point)
        {
            foreach (Unit unit in Units)
            {
                DefensePoint = point;
            }
        }

        public void ChangeMovePoint(int point)
        {
            foreach (Unit unit in Units)
            {
                ExtraMovePoint = point;
            }
        }

        public void GoalUnit()
        {
            isGoaled = true;
        }
    }
}
