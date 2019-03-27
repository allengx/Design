﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Skill:MonoBehaviour{
	// 1000:无法行动
	// 1001:普攻
	// 1002:防御
	//。。。。
	protected int skillType;			//技能类型  0 友方  1  di方
	protected int skillID;			//技能ID
	protected int power;			//技能加成
	protected float multiple;		//倍率
	protected int costBlue;			//技能耗蓝
	protected string skillName;		//技能名称
	protected int targetNumber;		//目标数目
	public Skill(string skillName,int skillID,int costBlue,int power,float multiple){
		this.skillName = skillName;
		this.skillID = skillID;
		this.costBlue = costBlue;
		this.power = power;
		this.multiple = multiple;
	}

	//技能施放
	public void Use(Person me, List<Person> targets)
    {
		//待添加
		// if id=1000...
		// else if id =1001 ...
		// ...
	}


	//技能效果
	//加血
	public void AddBlood(Person me, List<Person> targets){
		//待添加
	}
	//加增益buff
	public void AddGainBuff(Person me, List<Person> targets){
		//待添加
	}
	//复活
	public void Resurgence(Person me, List<Person> targets){
		//待添加
	}
	//造成injury
	public void Injury(Person me, List<Person> targets){
		//待添加
	}
	//加sun益debuff
	public void AddDeBuff(Person me, List<Person> targets){
		//待添加
	}
		
	//get、set
	//技能名称
	public string GetSkillName(){
		return this.skillName;
	}
	public void SetSkillName(string skillName){
		this.skillName = skillName;
	}

	//技能ID
	public int GetSkillID(){
		return this.skillID;
	}
	public void SetSkillID(int skillID){
		this.skillID = skillID;
	}

	//耗蓝
	public int GetCostBlue(){
		return this.costBlue;
	}
	public void SetCostBlue(int costBlue){
		this.costBlue = costBlue;
	}

	//技能加成
	public int GetPower(){
		return this.power;
	}
	public void SetPower(int power){
		this.power = power;
	}

	//技能倍率
	public float GetMultiple(){
		return this.multiple;
	}
	public void SetMultiple(float multiple){
		this.multiple = multiple;
	}

	//目标数目
	public int GetTargetNumber(){
		return this.targetNumber;
	}
	public void SetTargetNumber(int targetNumber){
		this.targetNumber = targetNumber;
	}

	//技能类型
	public int GetSkillType(){
		return this.skillType;
	}
	public void SetSkillType(int skillType){
		this.skillType = skillType;
	}
}