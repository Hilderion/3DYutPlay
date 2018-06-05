using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Encounter
    {
        public void Execute(Unit Moved, Player player1, Player player2)
        {
            //양 플레이어의 동일 위치 유닛들을 호출
            List<Unit> p1SameLocation = player1.Owned.FindAll(
                x => x.UnitPosition == Moved.UnitPosition);
            List<Unit> p2SameLocation = player2.Owned.FindAll(
                x => x.UnitPosition == Moved.UnitPosition);

            if (p1SameLocation != null)
            {
                //p1 유닛리스트와 움직인 유닛이 동일 플레이어면 업기, 아니면 전투
                if (p1SameLocation.First()._Player == Moved._Player)
                    player1.Owned.Add(MakeTeam(p1SameLocation, Moved));
                else
                    Battle(p1SameLocation, Moved);
            }
            else if (p2SameLocation != null)
            {
                //반복
                if (p2SameLocation.First()._Player == Moved._Player)
                    player2.Owned.Add(MakeTeam(p2SameLocation, Moved));
                else
                    Battle(p2SameLocation, Moved);
            }
            //완전히 비었으면 그냥 끝
            else
                return;
        }
        //전투 로직
        private void Battle(List<Unit> SameLocation, Unit Moved)
        {
            //칸의 전원의 최대방어보다 낮으면 있던 유닛들을 출발점으로
            if (SameLocation.Max()._Defense < Moved._Attack)
            {
                foreach (Unit unit in SameLocation)
                {
                    unit.UnitPosition = new List<double> { 0, 0, 0 };
                    unit.LocationHistory.Clear();
                }
            }
            //아니라면 들어온 유닛을 직전 칸으로
            else
            {
                Moved.UnitPosition = Moved.LocationHistory.Last();
                Moved.LocationHistory.Remove(Moved.LocationHistory.Last());
            }
        }
        //업기
        private UnitTeam MakeTeam(List<Unit> SameLocation, Unit Moved)
        {
            //Moved가 UnitTeam 객체일 경우는 위쪽 실행
            if (Moved.GetType().Equals("UnitTeam"))
            {
                UnitTeam team = (UnitTeam)Moved;
                return new UnitTeam(SameLocation, team.units);
            }
            //단일 유닛이면 아래쪽 실행
            else
                return new UnitTeam(SameLocation, Moved);
        }
    }
}
