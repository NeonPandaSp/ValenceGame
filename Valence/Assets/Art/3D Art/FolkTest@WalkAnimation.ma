//Maya ASCII 2016 scene
//Name: FolkTest@WalkAnimation.ma
//Last modified: Sat, Jan 16, 2016 06:49:04 PM
//Codeset: 949
requires maya "2016";
requires "stereoCamera" "10.0";
requires "stereoCamera" "10.0";
currentUnit -l meter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2016";
fileInfo "version" "2016";
fileInfo "cutIdentifier" "201502261600-953408";
fileInfo "osv" "Microsoft Windows 8 Home Premium Edition, 64-bit  (Build 9200)\n";
fileInfo "license" "student";
createNode transform -n "ctrl_Global";
	rename -uid "6135364C-4325-4255-4CC4-0C88C5F611AD";
	setAttr ".rp" -type "double3" 1.2118426289325096e-016 0 4.0394754297750311e-017 ;
	setAttr ".sp" -type "double3" 1.2118426289325096e-016 0 4.0394754297750311e-017 ;
createNode nurbsCurve -n "ctrl_GlobalShape" -p "ctrl_Global";
	rename -uid "703C750E-4CCE-D322-6E3C-1790A0970EFE";
	setAttr -k off ".v";
	setAttr ".cc" -type "nurbsCurve" 
		3 16 2 no 3
		21 -2 -1 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18
		19
		0.22322159510008543 5.8044086617135588e-017 -0.53890460230518267
		-3.4295181589027287e-017 6.2826466627483709e-017 -0.19533535039760991
		-0.22322159510008577 5.8044086617135588e-017 -0.53890460230518267
		-0.13812295087160045 4.4425020590284054e-017 -0.13812295087160031
		-0.53890460230518267 2.4042647892376224e-017 -0.22322159510008571
		-0.19533535039760991 -2.8980332155736401e-033 9.0103480907893654e-018
		-0.53890460230518245 -2.4042647892376227e-017 0.22322159510008577
		-0.13812295087160045 -4.4425020590284073e-017 0.13812295087160031
		-0.22322159510008568 -5.80440866171356e-017 0.53890460230518278
		-6.5841107648875604e-017 -6.2826466627483709e-017 0.19533535039760991
		0.22322159510008591 -5.8044086617135588e-017 0.53890460230518267
		0.13812295087160045 -4.4425020590284029e-017 0.13812295087160009
		0.53890460230518289 -2.4042647892376209e-017 0.2232215951000856
		0.19533535039760977 1.0793273227319644e-032 -3.3557637743602482e-017
		0.53890460230518267 2.4042647892376243e-017 -0.22322159510008593
		0.13812295087160045 4.442502059028406e-017 -0.13812295087160031
		0.22322159510008543 5.8044086617135588e-017 -0.53890460230518267
		-3.4295181589027287e-017 6.2826466627483709e-017 -0.19533535039760991
		-0.22322159510008577 5.8044086617135588e-017 -0.53890460230518267
		;
createNode transform -n "grp_CtrlCurves";
	rename -uid "C03DB6CD-4373-DAFC-FC9F-138BCA9C25B4";
createNode transform -n "ctrl_Hips" -p "grp_CtrlCurves";
	rename -uid "FB762918-420F-7E27-6BD5-25AD134ED2DB";
	setAttr -l on -k off ".sx";
	setAttr -l on -k off ".sy";
	setAttr -l on -k off ".sz";
	setAttr ".rp" -type "double3" 0 0.7782531644513685 -0.08445372926995981 ;
	setAttr ".sp" -type "double3" 0 0.7782531644513685 -0.08445372926995981 ;
createNode transform -n "ctrl_Chest" -p "ctrl_Hips";
	rename -uid "14E8E7B2-4431-DCA6-4BE8-13B67381605A";
	setAttr -l on -k off ".rx";
	setAttr -l on -k off ".rz";
	setAttr -l on -k off ".sx";
	setAttr -l on -k off ".sy";
	setAttr -l on -k off ".sz";
	setAttr ".rp" -type "double3" 0 1.0418062230380898 -0.032463546369090913 ;
	setAttr ".sp" -type "double3" 0 1.0418062230380898 -0.032463546369090913 ;
createNode nurbsCurve -n "ctrl_ChestShape" -p "ctrl_Chest";
	rename -uid "0A2874A7-48D6-4277-89A4-D5990BFF1B1A";
	setAttr -k off ".v";
	setAttr ".cc" -type "nurbsCurve" 
		1 16 0 no 3
		17 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16
		17
		0.16623503759457356 1.1302657971238339 0.14319866410173154
		0.16623503759457356 1.1302657971238339 -0.12341123339731405
		-0.16623503759457353 1.1302657971238339 -0.12341123339731405
		-0.16623503759457353 1.1302657971238339 0.14319866410173154
		0.16623503759457356 1.1302657971238339 0.14319866410173154
		0.14037624859466519 0.9799245548613249 0.12316457802982492
		0.14037624859466519 0.9799245548613249 -0.092081877533060921
		0.16623503759457356 1.1302657971238339 -0.12341123339731405
		0.16623503759457356 1.1302657971238339 0.14319866410173154
		0.14037624859466519 0.9799245548613249 0.12316457802982492
		-0.14037624859466569 0.9799245548613249 0.12316457802982492
		-0.16623503759457353 1.1302657971238339 0.14319866410173154
		-0.16623503759457353 1.1302657971238339 -0.12341123339731405
		-0.14037624859466569 0.9799245548613249 -0.092081877533060921
		-0.14037624859466569 0.9799245548613249 0.12316457802982492
		-0.14037624859466569 0.9799245548613249 -0.092081877533060921
		0.14037624859466519 0.9799245548613249 -0.092081877533060921
		;
createNode transform -n "ctrl_HipSway" -p "ctrl_Hips";
	rename -uid "C7FB8F28-4C8E-B864-8A05-1AB63343480F";
	setAttr -l on -k off ".rx";
	setAttr -l on -k off ".ry";
	setAttr -l on -k off ".rz";
	setAttr -l on -k off ".sx";
	setAttr -l on -k off ".sy";
	setAttr -l on -k off ".sz";
	setAttr ".rp" -type "double3" -1.4371062079986738e-017 0.81180106868513646 -0.0099347205180570081 ;
	setAttr ".sp" -type "double3" -1.4371062079986738e-017 0.81180106868513646 -0.0099347205180570081 ;
createNode nurbsCurve -n "ctrl_HipSwayShape" -p "ctrl_HipSway";
	rename -uid "3927F655-4F41-9124-06D6-07A08548650C";
	setAttr -k off ".v";
	setAttr ".cc" -type "nurbsCurve" 
		3 8 2 no 3
		13 -2 -1 0 1 2 3 4 5 6 7 8 9 10
		11
		0.041548320652626175 0.81180106868513646 -0.051483041170687686
		-6.9418660427373355e-017 0.81180106868513646 -0.49243575146693774
		-0.04154832065262596 0.81180106868513646 -0.051483041170687686
		-0.48250103094888069 0.81180106868513646 -0.0099347205180571468
		-0.04154832065262596 0.81180106868513646 0.031613600134573761
		-1.5975803925210663e-016 0.81180106868513646 0.47256631043082381
		0.041548320652626175 0.81180106868513646 0.031613600134573761
		0.48250103094888069 0.81180106868513646 -0.0099347205180567496
		0.041548320652626175 0.81180106868513646 -0.051483041170687686
		-6.9418660427373355e-017 0.81180106868513646 -0.49243575146693774
		-0.04154832065262596 0.81180106868513646 -0.051483041170687686
		;
createNode transform -n "ctrl_Back" -p "ctrl_Hips";
	rename -uid "AD938C0E-4053-8185-1743-F09D8378EB59";
	setAttr -l on -k off ".sx";
	setAttr -l on -k off ".sy";
	setAttr -l on -k off ".sz";
	setAttr ".rp" -type "double3" -1.3760101355253795e-017 1.2295396147065538 -0.022482010183932352 ;
	setAttr ".sp" -type "double3" -1.3760101355253795e-017 1.2295396147065538 -0.022482010183932175 ;
createNode transform -n "ctrl_Neck" -p "ctrl_Back";
	rename -uid "852935D1-4B00-6265-4327-3D93D407ED6E";
	setAttr -av ".v";
	setAttr ".r" -type "double3" -6.402193049160716 -12.6 0 ;
	setAttr -l on -k off ".sx";
	setAttr -l on -k off ".sy";
	setAttr -l on -k off ".sz";
	setAttr ".rp" -type "double3" 6.9892762081742461e-019 1.2654724050024253 -0.014177184100863535 ;
	setAttr ".sp" -type "double3" 6.9892762081742461e-019 1.2654724050024253 -0.014177184100863535 ;
createNode nurbsCurve -n "ctrl_NeckShape" -p "ctrl_Neck";
	rename -uid "F1407FF3-4CF7-A1ED-F96F-399CE3EC2831";
	setAttr -k off ".v";
	setAttr ".cc" -type "nurbsCurve" 
		3 8 2 no 3
		13 -2 -1 0 1 2 3 4 5 6 7 8 9 10
		11
		0.079108086433096719 1.2856279573786589 -0.090674524234460277
		-1.2064755324434786e-017 1.2939766605300163 -0.12236076000326382
		-0.079108086433096636 1.2856279573786589 -0.090674524234460332
		-0.11187572872706833 1.2654724050024253 -0.014177184100863566
		-0.079108086433096664 1.245316852626192 0.062320156032733234
		-3.3011412824610165e-017 1.2369681494748348 0.094006391801536776
		0.079108086433096594 1.245316852626192 0.062320156032733269
		0.11187572872706833 1.2654724050024253 -0.014177184100863478
		0.079108086433096719 1.2856279573786589 -0.090674524234460277
		-1.2064755324434786e-017 1.2939766605300163 -0.12236076000326382
		-0.079108086433096636 1.2856279573786589 -0.090674524234460332
		;
createNode transform -n "ctrl_L_Arm" -p "grp_CtrlCurves";
	rename -uid "664BE580-46D4-A14E-B141-FBB37277E746";
	setAttr -l on -k off ".rx";
	setAttr -l on -k off ".ry";
	setAttr -l on -k off ".rz";
	setAttr -l on -k off ".sx";
	setAttr -l on -k off ".sy";
	setAttr -l on -k off ".sz";
	setAttr ".rp" -type "double3" 0.5978277688759136 1.1825420512278944 -0.013187224558169779 ;
	setAttr ".sp" -type "double3" 0.5978277688759136 1.1825420512278944 -0.013187224558169779 ;
createNode nurbsCurve -n "ctrl_L_ArmShape" -p "ctrl_L_Arm";
	rename -uid "806C4F1F-4A1A-D2C8-951B-A085C551E0F7";
	setAttr -k off ".v";
	setAttr ".cc" -type "nurbsCurve" 
		1 16 0 no 3
		17 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16
		17
		0.62762137028963072 1.2257454493726523 0.030016173586588337
		0.62762137028963072 1.2257454493726523 -0.056390622702927974
		0.56803416746219637 1.2257454493726523 -0.056390622702927974
		0.56803416746219637 1.2257454493726523 0.030016173586588337
		0.62762137028963072 1.2257454493726523 0.030016173586588337
		0.62762137028963072 1.139338653083136 0.030016173586588337
		0.62762137028963072 1.139338653083136 -0.056390622702927974
		0.62762137028963072 1.2257454493726523 -0.056390622702927974
		0.62762137028963072 1.2257454493726523 0.030016173586588337
		0.62762137028963072 1.139338653083136 0.030016173586588337
		0.56803416746219637 1.139338653083136 0.030016173586588337
		0.56803416746219637 1.2257454493726523 0.030016173586588337
		0.56803416746219637 1.2257454493726523 -0.056390622702927974
		0.56803416746219637 1.139338653083136 -0.056390622702927974
		0.56803416746219637 1.139338653083136 0.030016173586588337
		0.56803416746219637 1.139338653083136 -0.056390622702927974
		0.62762137028963072 1.139338653083136 -0.056390622702927974
		;
createNode transform -n "ctrl_R_Arm" -p "grp_CtrlCurves";
	rename -uid "D2727971-4316-8499-EEC8-06A055F64A2A";
	setAttr -l on -k off ".rx";
	setAttr -l on -k off ".ry";
	setAttr -l on -k off ".rz";
	setAttr -l on -k off ".sx";
	setAttr -l on -k off ".sy";
	setAttr -l on -k off ".sz";
	setAttr ".rp" -type "double3" 0.5978277688759136 1.1825420512278944 -0.013187224558169779 ;
	setAttr ".sp" -type "double3" 0.5978277688759136 1.1825420512278944 -0.013187224558169779 ;
createNode nurbsCurve -n "ctrl_R_ArmShape" -p "ctrl_R_Arm";
	rename -uid "0B65792E-4AD2-DFC6-1C9A-55BFFC714A7A";
	setAttr -k off ".v";
	setAttr ".cc" -type "nurbsCurve" 
		1 16 0 no 3
		17 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16
		17
		0.62762137028963072 1.2257454493726525 0.030016173586588354
		0.62762137028963072 1.2257454493726525 -0.056390622702927919
		0.56803416746219637 1.2257454493726525 -0.056390622702927919
		0.56803416746219637 1.2257454493726525 0.030016173586588354
		0.62762137028963072 1.2257454493726525 0.030016173586588354
		0.62762137028963072 1.1393386530831362 0.030016173586588354
		0.62762137028963072 1.1393386530831362 -0.056390622702927919
		0.62762137028963072 1.2257454493726525 -0.056390622702927919
		0.62762137028963072 1.2257454493726525 0.030016173586588354
		0.62762137028963072 1.1393386530831362 0.030016173586588354
		0.56803416746219637 1.1393386530831362 0.030016173586588354
		0.56803416746219637 1.2257454493726525 0.030016173586588354
		0.56803416746219637 1.2257454493726525 -0.056390622702927919
		0.56803416746219637 1.1393386530831362 -0.056390622702927919
		0.56803416746219637 1.1393386530831362 0.030016173586588354
		0.56803416746219637 1.1393386530831362 -0.056390622702927919
		0.62762137028963072 1.1393386530831362 -0.056390622702927919
		;
createNode transform -n "ctrl_L_Wrist" -p "grp_CtrlCurves";
	rename -uid "C078F732-421E-ED5C-B4C2-DF88B2AE7FBA";
	addAttr -ci true -sn "FingerRoll" -ln "FingerRoll" -min 0 -max 10 -at "double";
	setAttr -k off ".tx";
	setAttr -k off ".ty";
	setAttr -k off ".tz";
	setAttr -l on -k off ".sx";
	setAttr -l on -k off ".sy";
	setAttr -l on -k off ".sz";
	setAttr ".rp" -type "double3" 0.59782760765397469 1.18254205125972 -0.013187226257516298 ;
	setAttr ".sp" -type "double3" 0.59782760765397469 1.18254205125972 -0.013187226257516298 ;
	setAttr -k on ".FingerRoll";
createNode nurbsCurve -n "ctrl_L_WristShape" -p "ctrl_L_Wrist";
	rename -uid "F7039ECD-4C42-B639-FD2D-03A1451E4C83";
	setAttr -k off ".v";
	setAttr ".cc" -type "nurbsCurve" 
		3 8 2 no 3
		13 -2 -1 0 1 2 3 4 5 6 7 8 9 10
		11
		0.59782760765397469 1.2362986510002778 -0.066943825998074177
		0.59782760765397469 1.18254205125972 -0.089210538677675477
		0.59782760765397469 1.1287854515191615 -0.066943825998074344
		0.59782760765397469 1.1065187388395608 -0.013187226257516187
		0.59782760765397469 1.1287854515191615 0.040569373483041953
		0.59782760765397469 1.18254205125972 0.062836086162643079
		0.59782760765397469 1.2362986510002778 0.040569373483041953
		0.59782760765397469 1.258565363679879 -0.013187226257516187
		0.59782760765397469 1.2362986510002778 -0.066943825998074177
		0.59782760765397469 1.18254205125972 -0.089210538677675477
		0.59782760765397469 1.1287854515191615 -0.066943825998074344
		;
createNode pointConstraint -n "ctrl_L_Wrist_pointConstraint1" -p "ctrl_L_Wrist";
	rename -uid "40628D94-481B-CB84-B6E1-87BEDC42CA4C";
	addAttr -dcb 0 -ci true -k true -sn "w0" -ln "ctrl_L_ArmW0" -dv 1 -min 0 -at "double";
	setAttr -k on ".nds";
	setAttr -k off ".v";
	setAttr -k off ".tx";
	setAttr -k off ".ty";
	setAttr -k off ".tz";
	setAttr -k off ".rx";
	setAttr -k off ".ry";
	setAttr -k off ".rz";
	setAttr -k off ".sx";
	setAttr -k off ".sy";
	setAttr -k off ".sz";
	setAttr ".erp" yes;
	setAttr ".rst" -type "double3" 1.6122193883916226e-007 -3.1825777568883495e-011 
		1.6993465190573433e-009 ;
	setAttr -k on ".w0";
createNode transform -n "ctrl_R_Wrist" -p "grp_CtrlCurves";
	rename -uid "2E6C8ABC-4644-B977-C24F-9AA89F088B1B";
	addAttr -ci true -sn "FingerRoll" -ln "FingerRoll" -min 0 -max 10 -at "double";
	addAttr -ci true -k true -sn "blendUnitConversion15" -ln "blendUnitConversion15" 
		-dv 1 -smn 0 -smx 1 -at "double";
	setAttr -k off ".tx";
	setAttr -k off ".ty";
	setAttr -k off ".tz";
	setAttr -l on -k off ".sx";
	setAttr -l on -k off ".sy";
	setAttr -l on -k off ".sz";
	setAttr ".rp" -type "double3" -0.59367624935807028 1.1825419419723344 -0.013187181187813346 ;
	setAttr ".sp" -type "double3" -0.59367624935807028 1.1825419419723344 -0.013187181187813346 ;
	setAttr -k on ".FingerRoll";
	setAttr -k on ".blendUnitConversion15";
createNode nurbsCurve -n "ctrl_R_WristShape" -p "ctrl_R_Wrist";
	rename -uid "98A218CD-48EC-FBA0-BD63-3DB0AC75B284";
	setAttr -k off ".v";
	setAttr ".cc" -type "nurbsCurve" 
		3 8 2 no 3
		13 -2 -1 0 1 2 3 4 5 6 7 8 9 10
		11
		-0.59367624935807028 1.23670509378051 -0.067350332995988554
		-0.59367624935807028 1.1825419419723344 -0.089785445055807767
		-0.59367624935807028 1.1283787901641589 -0.067350332995988707
		-0.59367624935807028 1.1059436781043397 -0.013187181187813235
		-0.59367624935807028 1.1283787901641589 0.040975970620362227
		-0.59367624935807028 1.1825419419723344 0.063411082680181308
		-0.59367624935807028 1.2367050937805097 0.040975970620362227
		-0.59367624935807028 1.2591402058403289 -0.013187181187813235
		-0.59367624935807028 1.23670509378051 -0.067350332995988554
		-0.59367624935807028 1.1825419419723344 -0.089785445055807767
		-0.59367624935807028 1.1283787901641589 -0.067350332995988707
		;
createNode pointConstraint -n "ctrl_R_Wrist_pointConstraint1" -p "ctrl_R_Wrist";
	rename -uid "7EF40E46-428D-AF64-CD6B-0D8189728ADE";
	addAttr -dcb 0 -ci true -k true -sn "w0" -ln "ctrl_R_ArmW0" -dv 1 -min 0 -at "double";
	setAttr -k on ".nds";
	setAttr -k off ".v";
	setAttr -k off ".tx";
	setAttr -k off ".ty";
	setAttr -k off ".tz";
	setAttr -k off ".rx";
	setAttr -k off ".ry";
	setAttr -k off ".rz";
	setAttr -k off ".sx";
	setAttr -k off ".sy";
	setAttr -k off ".sz";
	setAttr ".erp" yes;
	setAttr ".rst" -type "double3" -1.6123526009437227e-007 -3.1783287113285044e-011 
		1.7003102570356533e-009 ;
	setAttr -k on ".w0";
createNode parentConstraint -n "grp_CtrlCurves_parentConstraint1" -p "grp_CtrlCurves";
	rename -uid "EC598FCB-4C5D-6638-72E3-2FB0939419F8";
	addAttr -dcb 0 -ci true -k true -sn "w0" -ln "ctrl_GlobalW0" -dv 1 -min 0 -at "double";
	setAttr -k on ".nds";
	setAttr -k off ".v";
	setAttr -k off ".tx";
	setAttr -k off ".ty";
	setAttr -k off ".tz";
	setAttr -k off ".rx";
	setAttr -k off ".ry";
	setAttr -k off ".rz";
	setAttr -k off ".sx";
	setAttr -k off ".sy";
	setAttr -k off ".sz";
	setAttr ".erp" yes;
	setAttr ".tg[0].tot" -type "double3" -1.2118426289325096e-016 0 -4.0394754297750311e-017 ;
	setAttr -k on ".w0";
createNode scaleConstraint -n "grp_CtrlCurves_scaleConstraint1" -p "grp_CtrlCurves";
	rename -uid "0FED0C6C-48C9-CD15-8DA2-D2A402BDE3FF";
	addAttr -dcb 0 -ci true -k true -sn "w0" -ln "ctrl_GlobalW0" -dv 1 -min 0 -at "double";
	setAttr -k on ".nds";
	setAttr -k off ".v";
	setAttr -k off ".tx";
	setAttr -k off ".ty";
	setAttr -k off ".tz";
	setAttr -k off ".rx";
	setAttr -k off ".ry";
	setAttr -k off ".rz";
	setAttr -k off ".sx";
	setAttr -k off ".sy";
	setAttr -k off ".sz";
	setAttr ".erp" yes;
	setAttr -k on ".w0";
createNode transform -n "grp_Root";
	rename -uid "AFAAB7ED-42CA-3292-18A1-D48A182CB03D";
createNode joint -n "jnt_Root" -p "grp_Root";
	rename -uid "E8A33369-4502-B22F-5C9E-1899D8152B01";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" -89.999999999999929 -73.393019421382988 89.999999999999929 ;
	setAttr ".bps" -type "matrix" 3.3306690738754696e-016 0.28580512163411204 0.95828776077319833 0
		 -1.1102230246251565e-016 0.95828776077319822 -0.28580512163411204 0 -1 -5.5511151231257827e-017 3.3306690738754696e-016 0
		 0 77.825316445136849 -8.4453729269959812 1;
	setAttr ".radi" 0.90680743006326536;
createNode joint -n "jnt_Hip" -p "jnt_Root";
	rename -uid "136A6ACF-46B2-130C-4DB1-4FBDA2757F72";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 1;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 180 0 76.459504922508813 ;
	setAttr ".bps" -type "matrix" -3.2172632800510542e-017 0.99799828438954541 -0.063241002170460331 0
		 2.2703518717347471e-016 0.063241002170460248 0.99799828438954552 0 1 6.206236516116009e-017 -2.1077758069603543e-016 0
		 5.9164567891575885e-030 81.180106868513647 -0.9934720518056972 1;
	setAttr ".radi" 0.88059120702329763;
createNode joint -n "jnt_Spine1" -p "jnt_Hip";
	rename -uid "7656D1A6-4F93-D142-834E-04980501F440";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 2;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 0 -4.4050736754665216 ;
	setAttr ".bps" -type "matrix" -4.1934808168033972e-017 0.99434199099507958 -0.10622619706993795 0
		 2.2543630226767247e-016 0.10622619706993786 0.99434199099507969 0 1 6.206236516116009e-017 -2.1077758069603543e-016 0
		 -2.5052845511766968e-017 92.527913419780432 -2.743760129417371 1;
	setAttr ".radi" 0.92254325630085532;
createNode joint -n "jnt_Spine2" -p "jnt_Spine1";
	rename -uid "E1E927A5-4293-580A-A837-3493C67C061B";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 3;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 180 8.8278125961003216e-032 8.2254075096631087 ;
	setAttr ".bps" -type "matrix" -1.0025889317404639e-017 0.99955413236729307 0.029858607929170985 0
		 -1.0658198061969628e-016 0.029858607929171083 -0.99955413236729318 0 -1 -5.7515874256271256e-017 8.8397323926120351e-017 0
		 3.8297858107207136e-017 104.15252188517933 -3.3594766501677706 1;
	setAttr ".radi" 1.0342001621272492;
createNode joint -n "jnt_Spine3" -p "jnt_Spine2";
	rename -uid "CC699896-4E59-E27B-498A-6ABF6287E8F0";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 4;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 0 -0.54810433950777471 ;
	setAttr ".bps" -type "matrix" -1.5229932342002602e-017 0.99981767894128115 -0.019094734260243964 0
		 -1.0596360795235404e-016 -0.01909473426024386 -0.99981767894128126 0 -1 -5.7515874256271256e-017 8.8397323926120351e-017 0
		 8.8489223078622326e-017 114.78071664840968 -2.8837888213171947 1;
	setAttr ".radi" 1.1268309826233487;
createNode joint -n "jnt_NeckBase" -p "jnt_Spine3";
	rename -uid "65592575-4314-D9BC-4471-2B826F523E78";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 5;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 0 -35.567944973265462 ;
	setAttr ".bps" -type "matrix" 4.9247209786362103e-017 0.82438480235095324 0.56602976746172973 0
		 -9.5052350721485079e-017 0.56602976746172984 -0.82438480235095335 0 -1 -5.7515874256271256e-017 8.8397323926120351e-017 0
		 7.5799955799995482e-017 122.93237025102488 -2.2500503271601078 1;
	setAttr ".radi" 0.67954175129900818;
createNode joint -n "jnt_NeckBase" -p "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase";
	rename -uid "28DA629D-464A-5965-6252-10849A60D801";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 6;
	setAttr ".bps" -type "matrix" 4.9247209786362103e-017 0.82438480235095324 0.56602976746172973 0
		 -9.5052350721485079e-017 0.56602976746172984 -0.82438480235095335 0 -1 -5.7515874256271256e-017 8.8397323926120351e-017 0
		 7.3367000000000069e-017 124.42099999999999 -1.9072400000000018 1;
	setAttr ".radi" 0.67954175129900818;
createNode joint -n "jnt_Head" -p "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase|jnt_NeckBase";
	rename -uid "EA9A24F9-49E0-A595-D93D-A5A727038A99";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 7;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 180 0 44.106819671811969 ;
	setAttr ".bps" -type "matrix" -3.0794634425351797e-017 0.98589985411793135 -0.16733642057317399 0
		 -1.9936988338112459e-017 0.16733642057317372 0.98589985411793135 0 1 7.8008675439842514e-017 3.2340586136416348e-017 0
		 6.9892762081742456e-017 126.54724050024252 -1.4177184100863536 1;
	setAttr ".radi" 1.4273925051387493;
createNode joint -n "jnt_HeadTop" -p "jnt_Head";
	rename -uid "3B22C1F2-489E-9388-0684-348763A13A1F";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" -180 0 170.1740648525066 ;
	setAttr ".bps" -type "matrix" 2.6940542966061076e-017 -0.94288055864713582 0.33313098343634417 0
		 -1.4736448228501351e-016 0.33313098343634384 0.94288055864713571 0 -1 -1.1880545469605538e-016 -1.4781015194896466e-016 0
		 4.3018688706272475e-017 145.2223226962472 -4.2888977860495103 1;
	setAttr ".radi" 1.2627200627368855;
createNode joint -n "jnt_ChinBase" -p "jnt_HeadTop";
	rename -uid "7CAF66BE-4BDA-53B4-4153-BE9E0EA90324";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 1;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 0 78.377474857543817 ;
	setAttr ".bps" -type "matrix" -1.3891541602155533e-016 0.13634494762197857 0.99066142311990757 0
		 -5.6076650096046715e-017 0.99066142311990757 -0.13634494762197893 0 -1 -1.1880545469605538e-016 -1.4781015194896466e-016 0
		 6.1123397095242914e-017 132.66221247527966 0.90754177477793796 1;
	setAttr ".radi" 0.61089450466229178;
createNode joint -n "jnt_ChinTip" -p "jnt_ChinBase";
	rename -uid "28DFBAA3-4523-E0FA-5739-93973F1DADC6";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 2;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 5.4403320310051262 89.999999999999986 0 ;
	setAttr ".bps" -type "matrix" 1 1.8622886926227079e-016 5.8680611744534029e-016 0
		 -1.0368896535342911e-016 0.99912570235780063 -0.041807067441189116 0 -5.7706230125980301e-016 0.041807067441188756 0.99912570235780063 0
		 6.0861308192179447e-017 130.30271373502055 4.3951295190987469 1;
	setAttr ".radi" 0.61089450466229178;
createNode orientConstraint -n "jnt_Head_orientConstraint1" -p "jnt_Head";
	rename -uid "551A82A9-4044-2DE0-8DE1-4BB0A9D1BF00";
	addAttr -dcb 0 -ci true -k true -sn "w0" -ln "ctrl_NeckW0" -dv 1 -min 0 -at "double";
	setAttr -k on ".nds";
	setAttr -k off ".v";
	setAttr -k off ".tx";
	setAttr -k off ".ty";
	setAttr -k off ".tz";
	setAttr -k off ".rx";
	setAttr -k off ".ry";
	setAttr -k off ".rz";
	setAttr -k off ".sx";
	setAttr -k off ".sy";
	setAttr -k off ".sz";
	setAttr ".erp" yes;
	setAttr ".lr" -type "double3" -120.3192519004328 -87.139774047023735 33.838442418422105 ;
	setAttr ".o" -type "double3" 89.999999999999972 9.6329888767423633 89.999999999999972 ;
	setAttr ".rsrr" -type "double3" -2.8624992133171654e-014 -2.8624992133171654e-014 
		-9.541664044390544e-015 ;
	setAttr -k on ".w0";
createNode ikEffector -n "effector10" -p "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase|jnt_NeckBase";
	rename -uid "092F72F0-46FE-A428-E349-F59C3B339477";
	setAttr ".v" no;
	setAttr ".hd" yes;
createNode joint -n "jnt_L_Shoulder" -p "jnt_Spine3";
	rename -uid "A4AFAADB-4362-683C-5116-EF8724DA1DA0";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 5;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 7.1568841159611691e-013 89.236101539070106 -88.698047327422401 ;
	setAttr ".bps" -type "matrix" 0.99994348737371985 -0.00046321293366893558 0.010621087169482769 0
		 -0.009995453496827603 -0.38125889121106288 0.92441427335470339 0 0.0036211832702070785 -0.92446819485923337 -0.38124197529316539 0
		 12.009215802351315 118.26404811401375 -1.8127335181305508 1;
	setAttr ".radi" 1.7236505828780895;
createNode joint -n "jnt_L_Elbow" -p "jnt_L_Shoulder";
	rename -uid "06EEC873-4EF3-CF31-563D-D9A28CB95B36";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 6;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 -0.036269898392305315 0 ;
	setAttr ".bps" -type "matrix" 0.99994117534847216 -0.0028734081524441207 0.010458937245530531 0
		 -0.010764447507462062 -0.38125797218692786 0.92440601756683272 0 0.0013313574184164647 -0.92446422438594222 -0.38126647547079612 0
		 36.239074247602801 118.90109696446321 -1.5900558128398907 1;
	setAttr ".radi" 1.6658441162388513;
createNode joint -n "jnt_L_Forearm" -p "jnt_L_Elbow";
	rename -uid "9AF2F2B8-474C-4B7F-D986-71B6A09CEF12";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 7;
	setAttr ".bps" -type "matrix" 0.99994117534847216 -0.0028734081524441207 0.010458937245530531 0
		 -0.010764447507462062 -0.38125797218692786 0.92440601756683272 0 0.0013313574184164647 -0.92446422438594222 -0.38126647547079612 0
		 48.244866887962786 118.57122780394401 -1.451718999256105 1;
	setAttr ".radi" 1.6658441162388513;
createNode joint -n "jnt_L_Wrist" -p "jnt_L_Forearm";
	rename -uid "BB38FC1E-42DD-AFDF-1657-A582BA74350F";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 0.800168359322187 0 ;
	setAttr ".bps" -type "matrix" 0.99966348440449238 0.022124079066168478 -0.013544115834695274 0
		 -0.021965988400625573 0.99969011593827228 0.011711850789195344 0 0.013799032641939163 -0.011410399677430849 0.99983968188772587 0
		 59.78276076539747 118.25420512597199 -1.3187226257516298 1;
	setAttr ".radi" 1.6658441162388513;
createNode joint -n "jnt_L_Thumb1" -p "jnt_L_Wrist";
	rename -uid "8350BC7F-4E6D-8BFE-465C-4BA82C04A5B1";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 1;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 -38.047042531826172 0 ;
	setAttr ".bps" -type "matrix" 0.7957444511133227 0.010390499317273209 0.60554339732697537 0
		 -0.021965988400625573 0.99969011593827228 0.011711850789195344 0 -0.60523405710182976 -0.022620999519529048 0.79572610017819412 0
		 62.892988886641042 118.10867103184044 0.54163188986851352 1;
	setAttr ".radi" 0.52449474571475085;
createNode joint -n "jnt_L_Thumb2" -p "jnt_L_Thumb1";
	rename -uid "38E17E0F-407A-0316-C9E9-5A9C94670FB0";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 2;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 1.9487585647182144 0 ;
	setAttr ".bps" -type "matrix" 0.81586562891353909 0.01115373268925432 0.57813395489679775 0
		 -0.021965988400625573 0.99969011593827228 0.011711850789195344 0 -0.57782416954563209 -0.02225458025713916 0.81585780792150286 0
		 64.021399132507185 118.1176845693486 1.8886352200213221 1;
	setAttr ".radi" 0.5257905318851025;
createNode joint -n "jnt_L_Thumb3" -p "jnt_L_Thumb2";
	rename -uid "91C81E38-47C9-D37E-069D-6B94E02E2088";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 3;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 13.962792089007626 0 ;
	setAttr ".bps" -type "matrix" 0.93118313779056239 0.016194015437448878 0.36419186942947368 0
		 -0.021965988400625573 0.99969011593827228 0.011711850789195344 0 -0.36388935028124508 -0.018905712346707699 0.93125029653286961 0
		 65.623738590375183 118.14162019050272 2.8508030499917929 1;
	setAttr ".radi" 0.53138725787967622;
createNode joint -n "jnt_L_Thumb4" -p "jnt_L_Thumb3";
	rename -uid "6B57DFDA-4327-82AC-05C7-DDB70F00325C";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 4;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 22.135491878100314 0 ;
	setAttr ".bps" -type "matrix" 0.99966348440449238 0.022124079066168478 -0.013544115834694948 0
		 -0.021965988400625573 0.99969011593827228 0.011711850789195344 0 0.013799032641938935 -0.01141039967743086 0.99983968188772576 0
		 67.119982576893818 118.16764106355393 3.4359939458082449 1;
	setAttr ".radi" 0.53138725787967622;
createNode joint -n "jnt_L_Index1" -p "jnt_L_Wrist";
	rename -uid "D068D4E4-4B52-2A2B-DC1E-8A8E274A7AB3";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 1;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 -0.76389846092988178 0 ;
	setAttr ".bps" -type "matrix" 0.99975860802387317 0.021969987602803141 -0.00021290115248836887 0
		 -0.021965988400625573 0.99969011593827228 0.011711850789195344 0 0.00047014439445892953 -0.011704347058143169 0.99993139125851616 0
		 67.098554628568678 118.20677103642481 0.055782406839286924 1;
	setAttr ".radi" 0.54614774330956795;
createNode joint -n "jnt_L_Index2" -p "jnt_L_Index1";
	rename -uid "AB67D4F3-4C75-CF49-CD7E-E1A2C91AEE9D";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 2;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 0.019839258040475462 0 ;
	setAttr ".bps" -type "matrix" 0.99975838529785088 0.021974039037251942 -0.00055913775027717136 0
		 -0.021965988400625573 0.99969011593827228 0.011711850789195344 0 0.00081632114884023685 -0.011696739020518329 0.99993125759527524 0
		 68.990287573141799 118.24834242076351 0.055379557470584984 1;
	setAttr ".radi" 0.54875720226357472;
createNode joint -n "jnt_L_Index3" -p "jnt_L_Index2";
	rename -uid "19793495-48F6-147D-C373-F19ECD4034E0";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 3;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 -0.33686498377100732 0 ;
	setAttr ".bps" -type "matrix" 0.99974590528664875 0.021904889798381851 0.0053198369806252456 0
		 -0.021965988400625573 0.99969011593827228 0.011711850789195344 0 -0.0050616416470616026 -0.011825730347235856 0.99991726252005075 0
		 70.932457446701974 118.29103005134124 0.054293354534203579 1;
	setAttr ".radi" 0.51744481990007052;
createNode joint -n "jnt_L_Index4" -p "jnt_L_Index3";
	rename -uid "5735AD72-43BB-2459-D94E-FCB8B0DC4CC0";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 4;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 1.080924186660416 0 ;
	setAttr ".bps" -type "matrix" 0.99966348440449238 0.022124079066168478 -0.013544115834695301 0
		 -0.021965988400625573 0.99969011593827228 0.011711850789195344 0 0.013799032641939189 -0.011410399677430849 0.99983968188772576 0
		 72.269384172417418 118.32032272705058 0.061407394409980963 1;
	setAttr ".radi" 0.51744481990007052;
createNode joint -n "jnt_L_Middle1" -p "jnt_L_Wrist";
	rename -uid "F39319D7-495C-B475-C0D3-8AB95ACA7E44";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 1;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 -4.2053570017085118 0 ;
	setAttr ".bps" -type "matrix" 0.9979839186970425 0.021227771681252016 0.059812036677777763 0
		 -0.021965988400625573 0.99969011593827228 0.011711850789195344 0 -0.05954488538639395 -0.013002069249678044 0.99814094837329903 0
		 67.661173934002477 118.23400034942421 -1.2132216301536283 1;
	setAttr ".radi" 0.53724468510576395;
createNode joint -n "jnt_L_Middle2" -p "jnt_L_Middle1";
	rename -uid "EBB6631F-4A71-2FD6-EB7A-A88A7DDEC8BD";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 2;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 2.4696524127800012 0 ;
	setAttr ".bps" -type "matrix" 0.99962277859745863 0.021768317036452173 0.016746369233272843 0
		 -0.021965988400625573 0.99969011593827228 0.011711850789195344 0 -0.016486232519292883 -0.012075283380744924 0.99979117403015494 0
		 69.377770057354283 118.27051347342625 -1.1103411043582827 1;
	setAttr ".radi" 0.53443499443201181;
createNode joint -n "jnt_L_Middle3" -p "jnt_L_Middle2";
	rename -uid "8AFD813A-45A0-61F0-75D3-5B81C22247A1";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 3;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 2.5314281416676994 0 ;
	setAttr ".bps" -type "matrix" 0.99937544544275048 0.022280407983986943 -0.027428132750365538 0
		 -0.021965988400625573 0.99969011593827228 0.011711850789195344 0 0.027680578023013994 -0.011102050053565753 0.99955516610386286 0
		 71.042884929043979 118.3067739000643 -1.082445953253133 1;
	setAttr ".radi" 0.54223357840833364;
createNode joint -n "jnt_L_Middle4" -p "jnt_L_Middle3";
	rename -uid "76550758-457E-9F7C-6F89-E9943490B40F";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 4;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 -0.79572355273918405 0 ;
	setAttr ".bps" -type "matrix" 0.99966348440449238 0.022124079066168482 -0.01354411583469535 0
		 -0.021965988400625573 0.99969011593827228 0.011711850789195344 0 0.013799032641939213 -0.011410399677430847 0.99983968188772587 0
		 72.858266265019807 118.34724661429448 -1.132269591108898 1;
	setAttr ".radi" 0.54223357840833364;
createNode joint -n "jnt_L_Ring1" -p "jnt_L_Wrist";
	rename -uid "8D668E91-433D-C100-67A4-8794EA0304B3";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 1;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".bps" -type "matrix" 0.99966348440449238 0.022124079066168478 -0.013544115834695274 0
		 -0.021965988400625573 0.99969011593827228 0.011711850789195344 0 0.013799032641939163 -0.011410399677430849 0.99983968188772587 0
		 67.646553416551853 118.24609003367463 -2.2725838257638911 1;
	setAttr ".radi" 0.52395672333965582;
createNode joint -n "jnt_L_Ring2" -p "jnt_L_Ring1";
	rename -uid "94943362-4632-C4F6-3A5B-099AEEF33D02";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 2;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".bps" -type "matrix" 0.99966348440449238 0.022124079066168478 -0.013544115834695274 0
		 -0.021965988400625573 0.99969011593827228 0.011711850789195344 0 0.013799032641939163 -0.011410399677430849 0.99983968188772587 0
		 69.109224357176615 118.27846117460658 -2.2924010792266061 1;
	setAttr ".radi" 0.52917609308246105;
createNode joint -n "jnt_L_Ring3" -p "jnt_L_Ring2";
	rename -uid "0777DFA5-433A-D1CE-7452-F8A5CCE73522";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 3;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 -3.9182488640673938 0 ;
	setAttr ".bps" -type "matrix" 0.99826976618192276 0.021292658034086545 0.05480964003652361 0
		 -0.021965988400625573 0.99969011593827228 0.011711850789195344 0 -0.054543278968846691 -0.012895534466172311 0.99842813257147323 0
		 70.672769155775484 118.31306480801658 -2.3135850398246802 1;
	setAttr ".radi" 0.54375253036477733;
createNode joint -n "jnt_L_Ring4" -p "jnt_L_Ring3";
	rename -uid "A861AEC5-426F-8D68-9CE5-40958A42947B";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 4;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 3.9182488640673938 0 ;
	setAttr ".bps" -type "matrix" 0.99966348440449238 0.022124079066168478 -0.013544115834695274 0
		 -0.021965988400625573 0.99969011593827228 0.011711850789195344 0 0.013799032641939171 -0.011410399677430849 0.99983968188772598 0
		 72.515457601594932 118.35236854761621 -2.212412897948532 1;
	setAttr ".radi" 0.54375253036477733;
createNode joint -n "jnt_L_Pinky1" -p "jnt_L_Wrist";
	rename -uid "117C960E-4669-45BC-7D11-79BFD7C44DB8";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 1;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 2.8624052261117798 0 ;
	setAttr ".bps" -type "matrix" 0.99772715233349307 0.022666283881122386 -0.063456828407347246 0
		 -0.021965988400625573 0.99969011593827228 0.011711850789195344 0 0.063702628282377161 -0.010291339579722347 0.99791585991984966 0
		 66.851204822476845 118.24001435234503 -3.2456853128172378 1;
	setAttr ".radi" 0.52666421030558319;
createNode joint -n "jnt_L_Pinky2" -p "jnt_L_Pinky1";
	rename -uid "14E4AFD9-4164-E5C2-0AEA-159C0D8E9A1E";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 2;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 -2.8624052261117789 0 ;
	setAttr ".bps" -type "matrix" 0.99966348440449238 0.022124079066168475 -0.013544115834695301 0
		 -0.021965988400625573 0.99969011593827228 0.011711850789195344 0 0.013799032641939192 -0.011410399677430849 0.99983968188772587 0
		 68.363268369413618 118.27436528839102 -3.3418546481055085 1;
	setAttr ".radi" 0.52395672333965504;
createNode joint -n "jnt_L_Pinky3" -p "jnt_L_Pinky2";
	rename -uid "BE386EF0-487F-7619-7B69-E99C18C7F7E4";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 3;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 1.8476102659947131 0 ;
	setAttr ".bps" -type "matrix" 0.99869887502534882 0.022480463125497233 -0.045773199590658377 0
		 -0.021965988400625573 0.99969011593827228 0.011711850789195344 0 0.0460223030354487 -0.01069115863636619 0.99888319975376816 0
		 69.825939310038365 118.30673642932297 -3.361671901568223 1;
	setAttr ".radi" 0.52921817382965775;
createNode joint -n "jnt_L_Pinky4" -p "jnt_L_Pinky3";
	rename -uid "37E6250C-4693-FCC5-57D6-17877ADF0769";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 4;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 -1.8476102659947131 0 ;
	setAttr ".bps" -type "matrix" 0.99966348440449238 0.022124079066168475 -0.013544115834695294 0
		 -0.021965988400625573 0.99969011593827228 0.011711850789195344 0 0.013799032641939206 -0.011410399677430849 0.99983968188772587 0
		 71.388787893520544 118.34191576198299 -3.433301681004882 1;
	setAttr ".radi" 0.52921817382965775;
createNode orientConstraint -n "jnt_L_Wrist_orientConstraint1" -p "jnt_L_Wrist";
	rename -uid "11CD97C3-4C2E-D5C3-7C17-348902B0F697";
	addAttr -dcb 0 -ci true -k true -sn "w0" -ln "ctrl_L_WristW0" -dv 1 -min 0 -at "double";
	setAttr -k on ".nds";
	setAttr -k off ".v";
	setAttr -k off ".tx";
	setAttr -k off ".ty";
	setAttr -k off ".tz";
	setAttr -k off ".rx";
	setAttr -k off ".ry";
	setAttr -k off ".rz";
	setAttr -k off ".sx";
	setAttr -k off ".sy";
	setAttr -k off ".sz";
	setAttr ".erp" yes;
	setAttr ".lr" -type "double3" -109.65893405240728 7.8948564022030503 -48.962821448059216 ;
	setAttr ".o" -type "double3" 0.67111652373093822 0.77604440245942619 1.2678361021402207 ;
	setAttr ".rsrr" -type "double3" -111.73184682576674 -2.981770013872047e-016 -1.8175016790210783 ;
	setAttr -k on ".w0";
createNode ikEffector -n "effector7" -p "jnt_L_Elbow";
	rename -uid "506900C6-48DB-5937-06DF-FBBDCB2AC3EE";
	setAttr ".v" no;
	setAttr ".rp" -type "double3" 0.11539517101119742 0.0011961101833266952 0.0025773012613432879 ;
	setAttr ".sp" -type "double3" 0.11539517101119742 0.0011961101833266952 0.0025773012613432879 ;
	setAttr ".hd" yes;
createNode joint -n "jnt_R_Shoulder" -p "jnt_Spine3";
	rename -uid "404D49B7-451A-639D-8378-FB94385F341F";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 5;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 89.236101539070106 91.301952672578551 ;
	setAttr ".bps" -type "matrix" 0.99994348518170073 0.00046292518664811107 -0.01062130608472869 0
		 -0.0099956502551027653 0.38123232163841664 -0.92442522894724199 0 0.0036212454558608724 0.924479152084272 0.38121540360128936 0
		 -11.594056743042241 118.26403433316331 -1.812737386575908 1;
	setAttr ".radi" 1.7236505828780895;
createNode joint -n "jnt_R_Elbow" -p "jnt_R_Shoulder";
	rename -uid "8AD8DFB4-4377-A72A-AD48-5BB97060D860";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 6;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 -0.036269898392305308 0 ;
	setAttr ".bps" -type "matrix" 0.99994117346392597 0.0028731953669253549 -0.010459175874334158 0
		 -0.01076462524981902 0.38123140286359869 -0.92441697318573923 0 0.001331335726905229 0.92447518204602785 0.38123990521211998 0
		 -35.823895684444544 118.90107365996577 -1.590055258393376 1;
	setAttr ".radi" 1.6658441162388513;
createNode joint -n "jnt_R_Forearm" -p "jnt_R_Elbow";
	rename -uid "FCD8791E-4569-2389-9439-F1A1C834EAE1";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 7;
	setAttr ".bps" -type "matrix" 0.99994117346392597 0.0028731953669253549 -0.010459175874334158 0
		 -0.01076462524981902 0.38123140286359869 -0.92441697318573923 0 0.001331335726905229 0.92447518204602785 0.38123990521211998 0
		 -47.829723494175681 118.5712137505183 -1.451713703804884 1;
	setAttr ".radi" 1.6658441162388513;
createNode joint -n "jnt_R_Wrist" -p "jnt_R_Forearm";
	rename -uid "CFB8AB54-44D3-5919-B0FF-76ABD8D70502";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 0.80016835932200714 0 ;
	setAttr ".pa" -type "double3" -110.97460203503726 0 -1.484318062725001 ;
	setAttr ".bps" -type "matrix" 0.99976842055981274 -0.019909288733387341 0.0081685661818908066 0
		 -0.019700646004710158 -0.99949647218931104 -0.024873412072310142 0 0.0086596650243768603 0.024706725870751456 -0.99965723520535454 0
		 -59.367624935807044 118.25419419723345 -1.3187181187813346 1;
	setAttr ".radi" 1.6658441162388513;
createNode joint -n "jnt_R_Thumb1" -p "jnt_R_Wrist";
	rename -uid "17832847-4659-BCD1-2AE7-38BDB0071B0D";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 1;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 -38.047042531826001 0 ;
	setAttr ".bps" -type "matrix" 0.79265965413802397 -0.00045170517138026257 -0.60966422616406346 0
		 -0.019700646004710158 -0.99949647218931104 -0.024873412072310142 0 -0.60934600782214465 0.031726929311863633 -0.79226942684143453 0
		 -62.46798747635566 118.076570215301 0.55531862695401535 1;
	setAttr ".radi" 0.52449474571475085;
createNode joint -n "jnt_R_Thumb2" -p "jnt_R_Thumb1";
	rename -uid "44D0976A-43DA-9E3B-DBB3-1892CF681278";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 2;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 1.9487585647182144 0 ;
	setAttr ".bps" -type "matrix" 0.81292244581006656 -0.0015303402330466009 -0.58236994698984113 0
		 -0.019700646004710158 -0.99949647218931104 -0.024873412072310142 0 -0.58203864274219475 0.031693219146892646 -0.81254326544186628 0
		 -63.589427152951458 118.06501057518825 1.9080444009223447 1;
	setAttr ".radi" 0.5257905318851025;
createNode joint -n "jnt_R_Thumb3" -p "jnt_R_Thumb2";
	rename -uid "CF27BE8F-4CA2-B90B-93BE-6F9E8D3421D1";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 3;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 13.962792089007626 0 ;
	setAttr ".bps" -type "matrix" 0.92934383556505207 -0.0091324345032129037 -0.36910247078187086 0
		 -0.019700646004710158 -0.99949647218931104 -0.024873412072310142 0 -0.36868946261621638 0.030387509295208288 -0.92905579995746201 0
		 -65.365638500806625 118.07389041627519 2.958046751936366 1;
	setAttr ".radi" 0.53138725787967622;
createNode joint -n "jnt_R_Thumb4" -p "jnt_R_Thumb3";
	rename -uid "7B2FE295-4BE5-8247-7A7E-3386481C8E40";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 4;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 22.135491878100314 0 ;
	setAttr ".bps" -type "matrix" 0.99976842055981263 -0.019909288733387411 0.008168566181893655 0
		 -0.019700646004710158 -0.99949647218931104 -0.024873412072310142 0 0.0086596650243795925 0.024706725870751404 -0.99965723520535454 0
		 -67.216455896810686 118.09165640301654 3.7100648992942258 1;
	setAttr ".radi" 0.53138725787967622;
createNode joint -n "jnt_R_Index1" -p "jnt_R_Wrist";
	rename -uid "AC284A0D-484B-8F6E-2323-66B77664D60D";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 1;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 -0.76389846092940461 0 ;
	setAttr ".bps" -type "matrix" 0.99979501604150167 -0.019578125521292272 -0.005159738331145412 0
		 -0.019700646004710158 -0.99949647218931104 -0.024873412072310142 0 -0.0046701654757053401 0.024969963600181073 -0.99967729316626752 0
		 -66.676198084379237 118.17104174720272 0.092193772081997416 1;
	setAttr ".radi" 0.54614774330956795;
createNode joint -n "jnt_R_Index2" -p "jnt_R_Index1";
	rename -uid "4B1D5B31-4D1B-55F3-A1E2-ED84A16FE2B6";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 2;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 0.019839258040475458 0 ;
	setAttr ".bps" -type "matrix" 0.99979657319887916 -0.019586770456381571 -0.0048135893953756455 0
		 -0.019700646004710158 -0.99949647218931104 -0.024873412072310142 0 -0.0043239758065185584 0.024963182974349674 -0.99967901985037888 0
		 -68.567978393447973 118.20808684491276 0.10195719793837903 1;
	setAttr ".radi" 0.54875720226357472;
createNode joint -n "jnt_R_Index3" -p "jnt_R_Index2";
	rename -uid "E4BA52E6-4E18-DD51-5C32-80AF500CAF81";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 3;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 -0.33686498377100732 0 ;
	setAttr ".bps" -type "matrix" 0.9997538708239041 -0.019439664155844024 -0.010690988267157166 0
		 -0.019700646004710158 -0.99949647218931104 -0.024873412072310142 0 -0.010202074280145327 0.025077909375181902 -0.99963344088808515 0
		 -70.510247003425178 118.24613737405717 0.11130761137395748 1;
	setAttr ".radi" 0.51744481990007052;
createNode joint -n "jnt_R_Index4" -p "jnt_R_Index3";
	rename -uid "48B119BF-4733-4BB6-39C4-08803EE0A31E";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 4;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 1.0809241866598989 0 ;
	setAttr ".bps" -type "matrix" 0.99976842055981274 -0.019909288733387324 0.0081685661818901474 0
		 -0.019700646004710158 -0.99949647218931104 -0.024873412072310142 0 0.0086596650243762046 0.024706725870751466 -0.99965723520535454 0
		 -71.847155839083214 118.27213281652016 0.1256045914612901 1;
	setAttr ".radi" 0.51744481990007052;
createNode joint -n "jnt_R_Middle1" -p "jnt_R_Wrist";
	rename -uid "C113C14B-4AB4-198B-2129-D5B0302C4F47";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 1;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 -4.2053570017082498 0 ;
	setAttr ".bps" -type "matrix" 0.99771169508122393 -0.018043905607115916 -0.065159734258146501 0
		 -0.019700646004710158 -0.99949647218931104 -0.024873412072310142 0 -0.064678111020250798 0.026100182979499096 -0.9975647960926094 0
		 -67.245340831860389 118.2137570069697 -1.1734657827860999 1;
	setAttr ".radi" 0.53724468510576395;
createNode joint -n "jnt_R_Middle2" -p "jnt_R_Middle1";
	rename -uid "FC408D8F-4C5E-4F3B-526F-AC81DEDDACB7";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 2;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 2.4696524127798534 0 ;
	setAttr ".bps" -type "matrix" 0.9995719996492608 -0.019151808787737881 -0.022113926321122045 0
		 -0.019700646004710158 -0.99949647218931104 -0.024873412072310142 0 -0.021626420512308391 0.025298424877445821 -0.99944599035392889 0
		 -68.961435910634876 118.24479289446163 -1.0613813775657173 1;
	setAttr ".radi" 0.53443499443201181;
createNode joint -n "jnt_R_Middle3" -p "jnt_R_Middle2";
	rename -uid "59355171-4A93-C31C-2AAD-C4A82AB8A27F";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 3;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 2.5314281416676989 0 ;
	setAttr ".bps" -type "matrix" 0.99955174470051789 -0.020250484626255186 0.02205056776031564 0
		 -0.019700646004710158 -0.99949647218931104 -0.024873412072310142 0 0.022543163334979598 0.024427852003883723 -0.99944739022788454 0
		 -70.626487210967426 118.27669540588252 -1.0245493327424615 1;
	setAttr ".radi" 0.54223357840833364;
createNode joint -n "jnt_R_Middle4" -p "jnt_R_Middle3";
	rename -uid "9960AB0C-4FBD-29C2-1361-11B99BFE5E11";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 4;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 -0.79572355273881734 0 ;
	setAttr ".bps" -type "matrix" 0.99976842055981252 -0.019909288733387556 0.0081685661818992599 0
		 -0.019700646004710158 -0.99949647218931104 -0.024873412072310142 0 0.0086596650243853084 0.024706725870751289 -0.99965723520535454 0
		 -72.4421481964783 118.31347975063544 -1.0645972549705154 1;
	setAttr ".radi" 0.54223357840833364;
createNode joint -n "jnt_R_Ring1" -p "jnt_R_Wrist";
	rename -uid "E11806E5-465F-CE8A-EFC0-88917FFFF9E9";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 1;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".bps" -type "matrix" 0.99976842055981274 -0.019909288733387341 0.0081685661818908066 0
		 -0.019700646004710158 -0.99949647218931104 -0.024873412072310142 0 0.0086596650243768603 0.024706725870751456 -0.99965723520535454 0
		 -67.236165656977093 118.23993452423153 -2.2326326132032293 1;
	setAttr ".radi" 0.52395672333965582;
createNode joint -n "jnt_R_Ring2" -p "jnt_R_Ring1";
	rename -uid "EF46F3DE-4F1A-BD8F-898F-D49ECC28E347";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 2;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".bps" -type "matrix" 0.99976842055981274 -0.019909288733387341 0.0081685661818908066 0
		 -0.019700646004710158 -0.99949647218931104 -0.024873412072310142 0 0.0086596650243768603 0.024706725870751456 -0.99965723520535454 0
		 -68.698926833098156 118.26906380457736 -2.2445840423839583 1;
	setAttr ".radi" 0.52917609308246105;
createNode joint -n "jnt_R_Ring3" -p "jnt_R_Ring2";
	rename -uid "2F888FF7-40EE-1FFD-8D56-6C89E3564301";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 3;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 -3.9182488640672157 0 ;
	setAttr ".bps" -type "matrix" 0.99802326837905853 -0.018174466074745661 -0.060160157553646204 0
		 -0.019700646004710158 -0.99949647218931104 -0.024873412072310142 0 -0.05967780425735119 0.026009437979698107 -0.99787878463017832 0
		 -70.262664619695755 118.30020392308525 -2.2573604967490586 1;
	setAttr ".radi" 0.54375253036477733;
createNode joint -n "jnt_R_Ring4" -p "jnt_R_Ring3";
	rename -uid "BA61309E-4328-866C-2250-26B289811072";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 4;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 3.918248864067301 0 ;
	setAttr ".bps" -type "matrix" 0.99976842055981274 -0.019909288733387379 0.0081685661818923436 0
		 -0.019700646004710158 -0.99949647218931104 -0.024873412072310142 0 0.0086596650243783921 0.024706725870751425 -0.99965723520535454 0
		 -72.10493047314489 118.33375236281532 -2.1463069645808308 1;
	setAttr ".radi" 0.54375253036477733;
createNode joint -n "jnt_R_Pinky1" -p "jnt_R_Wrist";
	rename -uid "2B7AECBB-4B45-77F0-2307-3FB5DAC9CA65";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 1;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 2.86240522611191 0 ;
	setAttr ".bps" -type "matrix" 0.99808860533547172 -0.021118243700336336 0.058078874666320092 0
		 -0.019700646004710158 -0.99949647218931104 -0.024873412072310142 0 0.058574913115513952 0.023681677815033466 -0.99800208300853521 0
		 -66.445726963823034 118.24867118176108 -3.2097567484491578 1;
	setAttr ".radi" 0.52666421030558319;
createNode joint -n "jnt_R_Pinky2" -p "jnt_R_Pinky1";
	rename -uid "E3A58434-49C1-4EB6-5F0A-5597B2F4B8D3";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 2;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 -2.862405226111659 0 ;
	setAttr ".bps" -type "matrix" 0.99976842055981274 -0.019909288733387452 0.0081685661818952024 0
		 -0.019700646004710158 -0.99949647218931104 -0.024873412072310142 0 0.0086596650243812578 0.024706725870751373 -0.99965723520535443 0
		 -67.958421058575382 118.2806776771307 -3.2977755666390327 1;
	setAttr ".radi" 0.52395672333965504;
createNode joint -n "jnt_R_Pinky3" -p "jnt_R_Pinky2";
	rename -uid "E022DB67-4819-A533-92E7-B78A42BF21A6";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 3;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 1.8476102659945155 0 ;
	setAttr ".bps" -type "matrix" 0.99896945648825508 -0.02069551499251519 0.040394562291907896 0
		 -0.019700646004710158 -0.99949647218931104 -0.024873412072310142 0 0.040888990578850759 0.024051979966656024 -0.99887416259963724 0
		 -69.421182234696445 118.30980695747652 -3.3097269958197617 1;
	setAttr ".radi" 0.52921817382965775;
createNode joint -n "jnt_R_Pinky4" -p "jnt_R_Pinky3";
	rename -uid "1CFA61D2-4998-9F7C-76AB-CF973CA1497A";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 4;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 -1.8476102659947131 0 ;
	setAttr ".bps" -type "matrix" 0.99976842055981274 -0.019909288733387369 0.0081685661818917538 0
		 -0.019700646004710158 -0.99949647218931104 -0.024873412072310142 0 0.0086596650243778092 0.024706725870751439 -0.99965723520535454 0
		 -70.984483141193579 118.3421935303046 -3.3729361577009733 1;
	setAttr ".radi" 0.52921817382965775;
createNode orientConstraint -n "jnt_R_Wrist_orientConstraint1" -p "jnt_R_Wrist";
	rename -uid "A70BC4CF-4F43-E6FB-5087-DCAD0DC81F78";
	addAttr -dcb 0 -ci true -k true -sn "w0" -ln "ctrl_L_Wrist1W0" -dv 1 -min 0 -at "double";
	setAttr -k on ".nds";
	setAttr -k off ".v";
	setAttr -k off ".tx";
	setAttr -k off ".ty";
	setAttr -k off ".tz";
	setAttr -k off ".rx";
	setAttr -k off ".ry";
	setAttr -k off ".rz";
	setAttr -k off ".sx";
	setAttr -k off ".sy";
	setAttr -k off ".sz";
	setAttr ".erp" yes;
	setAttr ".lr" -type "double3" 127.65254057712342 -18.56448125795481 20.228354169631931 ;
	setAttr ".o" -type "double3" -178.57466390885284 -0.46802957190983813 -1.1408316575129192 ;
	setAttr ".rsrr" -type "double3" -110.97460203503726 0 -1.484318062725001 ;
	setAttr -k on ".w0";
createNode ikEffector -n "effector8" -p "jnt_R_Elbow";
	rename -uid "7499A8BD-4C99-B57A-1DCB-E3AB7675D288";
	setAttr ".v" no;
	setAttr ".rp" -type "double3" -0.1153952459018199 -0.0011960000000000549 -0.0025773430540991437 ;
	setAttr ".sp" -type "double3" -0.1153952459018199 -0.0011960000000000549 -0.0025773430540991437 ;
	setAttr ".hd" yes;
createNode ikEffector -n "effector9" -p "jnt_Spine3";
	rename -uid "01566134-4EFC-DB60-B1DC-76B94CDB5D4F";
	setAttr ".v" no;
	setAttr ".hd" yes;
createNode joint -n "jnt_L_Hip" -p "jnt_Hip";
	rename -uid "D88032C7-42F9-796F-08DB-4BB417EC4413";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 2;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" -179.99999999999997 0 177.81268274986357 ;
	setAttr ".bps" -type "matrix" 0.0023878387860499345 -0.99524119159977409 0.097412877839604478 0
		 0.023913875547712293 0.097442128477130657 0.99495384724827074 0 -0.99971117067992199 -4.6269949388266855e-005 0.02403275008964682 0
		 8.9351204020901704 79.640089249631487 -3.4672836223272121 1;
	setAttr ".radi" 2;
createNode joint -n "jnt_L_Knee" -p "jnt_L_Hip";
	rename -uid "CDA59CE8-4C4A-1EF8-E583-CA80FD63EAD6";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 3;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 180 -8.8278125961003194e-032 -9.5478174222988521 ;
	setAttr ".bps" -type "matrix" -0.0018845137203051176 -0.99676808790554883 -0.080310818331991787 0
		 -0.023958794331468861 0.080332912260218686 -0.99648010486008975 0 0.99971117067992199 4.6269949388275305e-005 -0.024032750089646941 0
		 8.9886354800153256 47.077945796606379 -1.3038619465685199 1;
	setAttr ".radi" 2;
createNode joint -n "jnt_L_Ankle" -p "jnt_L_Knee";
	rename -uid "E4C0C945-4216-0F95-C014-9FAE6811DB8A";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 4;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 180 -3.5311250384401269e-031 -33.604021741952685 ;
	setAttr ".bps" -type "matrix" 2.005340338229189e-015 -0.87198381262069513 0.48953470819491129 0
		 -5.0653925498522767e-016 0.48953470819491096 0.87198381262069524 0 -0.99999999999999978 -2.0385304772344015e-015 5.0653925498522767e-016 0
		 8.9351204020901758 9.2643053524289627 -3.6027772278001167 1;
	setAttr ".radi" 0.88477022615768786;
createNode joint -n "jnt_L_Ball" -p "jnt_L_Ankle";
	rename -uid "F099D4A9-470E-8E2A-0256-24AA412B6549";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 5;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 0 56.234390095757455 ;
	setAttr ".bps" -type "matrix" 6.9346631398659544e-016 -0.077686639666523172 0.99697782624154918 0
		 -1.9486088269162675e-015 0.99697782624154896 0.07768663966652295 0 -0.99999999999999978 -2.0385304772344015e-015 5.0653925498522767e-016 0
		 8.9351204020901918 1.7468086870027619 -0.38434612454123318 1;
	setAttr ".radi" 0.96399995200394462;
createNode joint -n "jnt_L_Toe" -p "jnt_L_Ball";
	rename -uid "662F22C0-4399-419A-198C-B78E0DC2C109";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 6;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" -4.4556028333264805 89.999999999999972 0 ;
	setAttr ".bps" -type "matrix" 0.99999999999999978 2.0195735517761802e-015 -1.7393987431459864e-016 0
		 -1.9618983605478159e-015 0.99999999999999856 5.563489445525871e-008 0 2.0692287019513066e-016 -5.563489470505889e-008 0.99999999999999889 0
		 8.9351204020901971 0.97222111109783871 10.624290973623783 1;
	setAttr ".radi" 0.96399995200394462;
createNode ikEffector -n "effector3" -p "jnt_L_Ball";
	rename -uid "1DE31D80-43FA-C095-154B-60A52DC499CB";
	setAttr ".v" no;
	setAttr ".hd" yes;
createNode ikEffector -n "effector2" -p "jnt_L_Ankle";
	rename -uid "A2D24366-4F9B-5D12-BAF4-B2A175DEE702";
	setAttr ".v" no;
	setAttr ".hd" yes;
createNode ikEffector -n "effector1" -p "jnt_L_Knee";
	rename -uid "E6CFA57F-4394-2651-2E0F-55BF6B614818";
	setAttr ".v" no;
	setAttr ".hd" yes;
createNode joint -n "jnt_R_Hip" -p "jnt_Hip";
	rename -uid "B2DB21F7-4208-0D59-B947-08AC6E4BC71C";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 2;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" -180 0 -2.1873172501364548 ;
	setAttr ".bps" -type "matrix" -0.0040196171343077972 0.99524109108551295 -0.097360224388665317 0
		 -0.040255893673119693 -0.097443134944656784 -0.99442661794460052 0 -0.99918131773100738 -7.7891431320731806e-005 0.04045600363670223 0
		 -8.9351200000000013 79.640084587415188 -3.4672829514936523 1;
	setAttr ".radi" 2;
createNode joint -n "jnt_R_Knee" -p "jnt_R_Hip";
	rename -uid "5733A95A-4266-6014-CA9F-5790241FB427";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 3;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 179.99999914622634 0 -9.5478174222989036 ;
	setAttr ".bps" -type "matrix" 0.0031723315504745245 0.99676816712053751 0.080269280099537099 0
		 0.04033149399509689 -0.080331904921078279 0.9959518842011772 0 0.99918131833249257 7.7890403319334705e-005 -0.040455988783216532 0
		 -8.8450343716008373 47.077899783666531 -1.3050436335236655 1;
	setAttr ".radi" 2;
createNode joint -n "jnt_R_Ankle" -p "jnt_R_Knee";
	rename -uid "0B0BED49-4287-E495-7D26-C9A1BC74CFF2";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 4;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 179.99999985731941 5.9242447492918327e-024 -33.604021741952707 ;
	setAttr ".bps" -type "matrix" 8.9942047490354504e-009 0.87198381711254469 -0.48953470019380285 0
		 1.481958399746075e-008 -0.48953470019380257 -0.87198381711254513 0 -1.0000000000000002 5.8810033690234916e-010 -1.7325412764168657e-008 0
		 -8.935119993584836 9.2643204755625845 -3.602779998045166 1;
	setAttr ".radi" 0.88477022615768786;
createNode joint -n "jnt_R_Ball" -p "jnt_R_Ankle";
	rename -uid "8D76F548-463E-A141-3014-18B6FC305983";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 5;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" 0 0 56.234390095757441 ;
	setAttr ".bps" -type "matrix" 1.731873987498707e-008 0.077686648814545789 -0.99697782552871583 0
		 7.5963021786876495e-010 -0.99697782552871517 -0.077686648814545844 0 -1.0000000000000002 5.8810033690234916e-010 -1.7325412764168657e-008 0
		 -8.9351199997301531 1.746820267159209 -0.38720704123566341 1;
	setAttr ".radi" 0.96399995200394462;
createNode joint -n "jnt_R_Toe" -p "jnt_R_Ball";
	rename -uid "63A6FDD8-4D78-2A8A-7621-D192FC4E25A2";
	addAttr -ci true -sn "liw" -ln "lockInfluenceWeights" -min 0 -max 1 -at "bool";
	setAttr ".uoc" 1;
	setAttr ".oc" 6;
	setAttr ".mnrl" -type "double3" -360 -360 -360 ;
	setAttr ".mxrl" -type "double3" 360 360 360 ;
	setAttr ".jo" -type "double3" -4.4556028333263518 89.99999902418979 0 ;
	setAttr ".bps" -type "matrix" 1.0000000000000004 7.3498881646821349e-010 3.4578274825883244e-010 0
		 7.3498881276957723e-010 -0.99999999999999778 -6.4810650295790984e-008 0 3.457826391896159e-010 6.4810650300944174e-008 -0.99999999999999878 0
		 -8.9351200035091747 0.97221955368165769 10.621439908561994 1;
	setAttr ".radi" 0.96399995200394462;
createNode ikEffector -n "effector4" -p "jnt_R_Ball";
	rename -uid "236A6853-4AD3-C209-8822-87BA410E265D";
	setAttr ".v" no;
	setAttr ".t" -type "double3" -0.1103555303162201 -0.00082965154536410071 -1.8740587393040187e-009 ;
	setAttr ".hd" yes;
createNode ikEffector -n "effector5" -p "jnt_R_Ankle";
	rename -uid "D48C81F8-4B98-3EAF-0211-B09DAA552A5C";
	setAttr ".v" no;
	setAttr ".t" -type "double3" -0.085774712947172413 0.00077796542278790075 -6.9579556338794649e-010 ;
	setAttr ".hd" yes;
createNode ikEffector -n "effector6" -p "jnt_R_Knee";
	rename -uid "489F757F-43F3-3A4E-092E-7CB5FFB38A7B";
	setAttr ".v" no;
	setAttr ".t" -type "double3" -0.37876095564505391 0.0074556870833941396 1.1109841935308395e-010 ;
	setAttr ".hd" yes;
createNode transform -n "curve_Spine" -p "jnt_Root";
	rename -uid "58EBDFC2-4FDE-19A4-0624-978D7866FF81";
	setAttr ".t" -type "double3" 0.059907158593834726 -0.094628928453607805 3.0459013559704044e-017 ;
	setAttr ".r" -type "double3" 16.606980578617023 89.999999999999986 0 ;
createNode nurbsCurve -n "curve_SpineShape" -p "curve_Spine";
	rename -uid "E164453C-4C6B-9BC3-2C4D-B1972390D03C";
	setAttr -k off ".v";
	setAttr -s 10 ".iog[0].og";
	setAttr ".tw" yes;
createNode nurbsCurve -n "curve_SpineShapeOrig" -p "curve_Spine";
	rename -uid "1E7AC68B-4F3A-F672-D3C5-9EA9A0E6DB3C";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr ".cc" -type "nurbsCurve" 
		3 1 0 no 3
		6 0 0 0 41.937984505041953 41.937984505041953 41.937984505041953
		4
		2.7610131682735399e-032 0.10710787543727802 -0.0099347205180570324
		2.7610131682735405e-032 0.24792790017058733 -0.031950259046698556
		1.0168910106364606e-032 0.38256707127016853 -0.041884806382208123
		1.0168910106364606e-032 0.52434337174375489 -0.02255061164355187
		;
createNode transform -n "grp_SpineClutser" -p "jnt_Root";
	rename -uid "5F87C484-43D3-EBE0-6DCC-908966B5721C";
	setAttr ".t" -type "double3" 0.059907158593834726 -0.094628928453607805 3.0459013559704044e-017 ;
	setAttr ".r" -type "double3" 16.606980578617023 89.999999999999986 0 ;
createNode transform -n "clusterHips" -p "grp_SpineClutser";
	rename -uid "0778B44B-41D9-3AEE-EC53-7F9FD4DF2AF8";
	setAttr ".rp" -type "double3" -1.4371062079986754e-017 0.10710787543727802 -0.0099347205180570462 ;
	setAttr ".sp" -type "double3" -1.4371062079986754e-017 0.10710787543727802 -0.0099347205180570462 ;
createNode clusterHandle -n "clusterHipsShape" -p "clusterHips";
	rename -uid "CFD855FE-4832-FA72-8E65-2389BBFC3FD7";
	setAttr ".ihi" 0;
	setAttr -k off ".v";
	setAttr ".or" -type "double3" -1.4371062079986754e-017 0.10710787543727802 -0.223 ;
createNode pointConstraint -n "clusterHips_pointConstraint1" -p "clusterHips";
	rename -uid "F8FF8C2E-4949-F632-8CE4-98B0453C9203";
	addAttr -dcb 0 -ci true -k true -sn "w0" -ln "ctrl_HipSwayW0" -dv 1 -min 0 -at "double";
	setAttr -k on ".nds";
	setAttr -k off ".v";
	setAttr -k off ".tx";
	setAttr -k off ".ty";
	setAttr -k off ".tz";
	setAttr -k off ".rx";
	setAttr -k off ".ry";
	setAttr -k off ".rz";
	setAttr -k off ".sx";
	setAttr -k off ".sy";
	setAttr -k off ".sz";
	setAttr ".erp" yes;
	setAttr ".rst" -type "double3" 1.43710620799868e-017 1.7763568394002505e-017 5.2180482157382361e-017 ;
	setAttr -k on ".w0";
createNode transform -n "clusterAbs" -p "grp_SpineClutser";
	rename -uid "D1F6AEBD-4E8A-BA85-B70E-E591CF06FB51";
	setAttr ".rp" -type "double3" -1.4042469198015048e-017 0.22095153562258674 -0.02487604654931105 ;
	setAttr ".sp" -type "double3" -1.4042469198015048e-017 0.22095153562258674 -0.02487604654931105 ;
createNode clusterHandle -n "clusterAbsShape" -p "clusterAbs";
	rename -uid "248ACD5D-4BB0-2205-A2DF-1BB146818DDA";
	setAttr ".ihi" 0;
	setAttr -k off ".v";
	setAttr ".or" -type "double3" -3.4419205001430823e-017 0.24792790017058733 -0.223 ;
createNode transform -n "clusterChest" -p "grp_SpineClutser";
	rename -uid "F651C4EC-4FF5-5DD5-D100-4B9FBE9ABB1D";
	setAttr ".rp" -type "double3" -1.3697736627371199e-017 0.44348443547637517 -0.030565037501305025 ;
	setAttr ".sp" -type "double3" -1.3697736627371199e-017 0.44348443547637517 -0.030565037501305025 ;
createNode clusterHandle -n "clusterChestShape" -p "clusterChest";
	rename -uid "0678FC5B-4539-23A0-564A-1FB4D05D3BAC";
	setAttr ".ihi" 0;
	setAttr -k off ".v";
	setAttr ".or" -type "double3" -5.2155157937332126e-017 0.38256707127016853 -0.223 ;
createNode pointConstraint -n "clusterChest_pointConstraint1" -p "clusterChest";
	rename -uid "E8EE4588-4126-732B-561D-039073D1BBB2";
	addAttr -dcb 0 -ci true -k true -sn "w0" -ln "ctrl_ChestW0" -dv 1 -min 0 -at "double";
	setAttr -k on ".nds";
	setAttr -k off ".v";
	setAttr -k off ".tx";
	setAttr -k off ".ty";
	setAttr -k off ".tz";
	setAttr -k off ".rx";
	setAttr -k off ".ry";
	setAttr -k off ".rz";
	setAttr -k off ".sx";
	setAttr -k off ".sy";
	setAttr -k off ".sz";
	setAttr ".erp" yes;
	setAttr ".rst" -type "double3" 5.9083414214127576e-017 -0.10637140568614385 -0.0018985088677858819 ;
	setAttr -k on ".w0";
createNode transform -n "clusterNeckbase" -p "grp_SpineClutser";
	rename -uid "87C2BBC4-4254-6F40-EEC7-6D95CB1C646B";
	setAttr ".rp" -type "double3" -6.699184832815226e-017 0.52434337174375489 -0.022550611643551859 ;
	setAttr ".sp" -type "double3" -6.699184832815226e-017 0.52434337174375489 -0.022550611643551859 ;
createNode clusterHandle -n "clusterNeckbaseShape" -p "clusterNeckbase";
	rename -uid "72D1AF57-4037-BF11-3FA2-F08250779109";
	setAttr ".ihi" 0;
	setAttr -k off ".v";
	setAttr ".or" -type "double3" -6.699184832815226e-017 0.52434337174375489 -0.223 ;
createNode pointConstraint -n "clusterNeckbase_pointConstraint1" -p "clusterNeckbase";
	rename -uid "4769B0E7-45EB-E759-D222-7D951B9F1215";
	addAttr -dcb 0 -ci true -k true -sn "w0" -ln "ctrl_BackW0" -dv 1 -min 0 -at "double";
	setAttr -k on ".nds";
	setAttr -k off ".v";
	setAttr -k off ".tx";
	setAttr -k off ".ty";
	setAttr -k off ".tz";
	setAttr -k off ".rx";
	setAttr -k off ".ry";
	setAttr -k off ".rz";
	setAttr -k off ".sx";
	setAttr -k off ".sy";
	setAttr -k off ".sz";
	setAttr ".erp" yes;
	setAttr ".rst" -type "double3" 1.2027623874601873e-016 0.00050304971494036016 6.8601459619501708e-005 ;
	setAttr -k on ".w0";
createNode parentConstraint -n "jnt_Root_parentConstraint1" -p "jnt_Root";
	rename -uid "2E35655A-4A2C-78F8-616C-5EB2BBD7A7A4";
	addAttr -dcb 0 -ci true -k true -sn "w0" -ln "ctrl_HipsW0" -dv 1 -min 0 -at "double";
	setAttr -k on ".nds";
	setAttr -k off ".v";
	setAttr -k off ".tx";
	setAttr -k off ".ty";
	setAttr -k off ".tz";
	setAttr -k off ".rx";
	setAttr -k off ".ry";
	setAttr -k off ".rz";
	setAttr -k off ".sx";
	setAttr -k off ".sy";
	setAttr -k off ".sz";
	setAttr ".erp" yes;
	setAttr ".tg[0].tor" -type "double3" -89.999999999999929 -73.393019421382988 89.999999999999929 ;
	setAttr ".lr" -type "double3" -3.1799800335188202 -10.534855863141265 -3.2073573050967634 ;
	setAttr ".rst" -type "double3" 0 0.7782531644513685 -0.08445372926995981 ;
	setAttr -k on ".w0";
createNode scaleConstraint -n "grp_Root_scaleConstraint1" -p "grp_Root";
	rename -uid "BDD016C6-44F5-6B67-4888-D797E9FDC12E";
	addAttr -dcb 0 -ci true -k true -sn "w0" -ln "ctrl_GlobalW0" -dv 1 -min 0 -at "double";
	setAttr -k on ".nds";
	setAttr -k off ".v";
	setAttr -k off ".tx";
	setAttr -k off ".ty";
	setAttr -k off ".tz";
	setAttr -k off ".rx";
	setAttr -k off ".ry";
	setAttr -k off ".rz";
	setAttr -k off ".sx";
	setAttr -k off ".sy";
	setAttr -k off ".sz";
	setAttr ".erp" yes;
	setAttr -k on ".w0";
createNode displayLayer -n "SkeletonLayer";
	rename -uid "28049AD0-475D-048F-D446-B3BFBB46F22D";
	setAttr ".v" no;
	setAttr ".c" 17;
	setAttr ".do" 4;
createNode displayLayerManager -n "layerManager";
	rename -uid "35B71835-4D2E-EA53-0FB6-BEAA0FBA97DB";
	setAttr ".cdl" 10;
	setAttr -s 12 ".dli[1:11]"  5 3 2 4 0 6 7 8 
		9 1 10;
	setAttr -s 6 ".dli";
createNode animCurveTL -n "jnt_Root_translateX";
	rename -uid "95486E7C-4394-21DE-C5A7-CDBA113A305F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTL -n "jnt_Root_translateY";
	rename -uid "8D43D873-48D3-5D3A-7B24-7AB7CCCAC82B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.75548170720527807 2 0.75447073407563836
		 3 0.75426703393257855 4 0.75903822528950515 5 0.76832357932363149 6 0.77699410964504712
		 7 0.78080376385256844 8 0.78126342612030975 9 0.77909091973513156 10 0.77366381901444403
		 11 0.76458705426713847 12 0.75671352457761776 13 0.75348670680793606 14 0.75310170943272636
		 15 0.75533541303045926 16 0.76203560446832896 17 0.77263376201823786 18 0.77899715692756877
		 19 0.77479347732862869 20 0.7644319159668086 21 0.75594615771040197 22 0.75382636111400536
		 23 0.75460760034424268;
createNode animCurveTL -n "jnt_Root_translateZ";
	rename -uid "1075104A-4926-431D-818D-21AB33E8D0AC";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.08445372926995981 2 -0.08445372926995981
		 3 -0.08445372926995981 4 -0.08445372926995981 5 -0.08445372926995981 6 -0.08445372926995981
		 7 -0.08445372926995981 8 -0.08445372926995981 9 -0.08445372926995981 10 -0.08445372926995981
		 11 -0.08445372926995981 12 -0.08445372926995981 13 -0.08445372926995981 14 -0.08445372926995981
		 15 -0.08445372926995981 16 -0.08445372926995981 17 -0.08445372926995981 18 -0.08445372926995981
		 19 -0.08445372926995981 20 -0.08445372926995981 21 -0.08445372926995981 22 -0.08445372926995981
		 23 -0.08445372926995981;
createNode animCurveTA -n "jnt_Root_rotateX";
	rename -uid "FFAEF0E3-4A63-A4AB-DC0D-44BF5B0D3A99";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 3.439484268662194 2 2.4448108738970036
		 3 1.5188631713620631 4 0.88148897768922618 5 0.36666392639706996 6 -0.092554774334766388
		 7 -0.5304016565144265 8 -0.98097095215036345 9 -1.4787018074957523 10 -2.1892206093608446
		 11 -3.1799800335188202 12 -3.7571548095490157 13 -3.2085444723731795 14 -1.811294073228942
		 15 -0.55256954564784111 16 -0.10475622705501064 17 -0.080738547423046189 18 -0.029084893874803015
		 19 0.26762993161494786 20 0.65477759428989102 21 1.1564060271569132 22 1.822063070341319
		 23 2.6204310325745572;
createNode animCurveTA -n "jnt_Root_rotateY";
	rename -uid "FA5AD624-4179-D92B-40CA-359124C02F5A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 11.373675325213306 2 8.1357226515607852
		 3 5.0770316959769559 4 2.9539665656929066 5 1.2304977375048447 6 -0.31040406026344231
		 7 -1.7797982842986975 8 -3.2887673048327239 9 -4.9483333742512494 10 -7.2986728810400594
		 11 -10.534855863141265 12 -12.391820651426782 13 -10.625192698944351 14 -6.0413726439045448
		 15 -1.8504689828802887 16 -0.35441708747798778 17 -0.27263292875150091 18 -0.09752496604783939
		 19 0.89795829909523894 20 2.1958879914985112 21 3.8714335232641774 22 6.0824550947181901
		 23 8.7119756356411191;
createNode animCurveTA -n "jnt_Root_rotateZ";
	rename -uid "12F8FE7E-4910-DD40-019E-44A073F648DF";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -3.1573899503275471 2 -3.331313394209745
		 3 -3.4331929485145074 4 -3.4782307521703704 5 -3.4974193429386946 6 -3.5010875924680627
		 7 -3.4933064256333646 8 -3.4736217992147682 9 -3.4371490338193422 10 -3.3613336694597682
		 11 -3.2073573050967634 12 -3.0906041942596727 13 -3.212073079465485 14 -3.4221768661033489
		 15 -3.4939635717363293 16 -3.4937294402278547 17 -3.4954183846823326 18 -3.4997446824995322
		 19 -3.4976768062887253 20 -3.4859436353173874 21 -3.4606094315096407 22 -3.4076892497804407
		 23 -3.3067834891494297;
createNode animCurveTU -n "jnt_Root_scaleX";
	rename -uid "E6A0F696-4A5B-6AD3-1CF1-5BA3BD8D7BC9";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_Root_scaleY";
	rename -uid "B19EC5B9-4608-E0D9-3126-9CAA6CDF834F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_Root_scaleZ";
	rename -uid "906BDED6-41E5-CF7E-413C-BBAEE4C79652";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_Root_visibility";
	rename -uid "772E82E2-4272-EA7A-4D18-5B9412C90EDA";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "ctrl_Global_translateX";
	rename -uid "2D12385C-4DCA-E458-0FFA-92A21287C470";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 6 ".ktv[0:5]"  1 0 3.444 0 6.396 0 12.264 0 21.084 0 24.008 0;
createNode animCurveTL -n "ctrl_Global_translateY";
	rename -uid "3810E79F-4E68-8949-C3A3-9D986267D16C";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 6 ".ktv[0:5]"  1 0 3.444 0 6.396 0 12.264 0 21.084 0 24.008 0;
createNode animCurveTL -n "ctrl_Global_translateZ";
	rename -uid "CB4E7BDC-40F2-016C-7459-3BB2664E47D5";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 6 ".ktv[0:5]"  1 0 3.444 0 6.396 0 12.264 0 21.084 0 24.008 0;
createNode animCurveTA -n "ctrl_Global_rotateX";
	rename -uid "E5CCF56E-4947-D71C-45C1-4997FE53C102";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 6 ".ktv[0:5]"  1 0 3.444 0 6.396 0 12.264 0 21.084 0 24.008 0;
createNode animCurveTA -n "ctrl_Global_rotateY";
	rename -uid "B4F2FAF5-4CC2-C918-412E-5EACFA904AFA";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 6 ".ktv[0:5]"  1 0 3.444 0 6.396 0 12.264 0 21.084 0 24.008 0;
createNode animCurveTA -n "ctrl_Global_rotateZ";
	rename -uid "1C50EFF5-417C-7E79-A556-10810D68710F";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 6 ".ktv[0:5]"  1 0 3.444 0 6.396 0 12.264 0 21.084 0 24.008 0;
createNode animCurveTU -n "ctrl_Global_scaleX";
	rename -uid "786C70AD-43D8-856C-4C82-1094265943D2";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 6 ".ktv[0:5]"  1 1 3.444 1 6.396 1 12.264 1 21.084 1 24.008 1;
createNode animCurveTU -n "ctrl_Global_scaleY";
	rename -uid "06592D92-4472-C90D-A733-D186F7FEA1C5";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 6 ".ktv[0:5]"  1 1 3.444 1 6.396 1 12.264 1 21.084 1 24.008 1;
createNode animCurveTU -n "ctrl_Global_scaleZ";
	rename -uid "35E96D74-42BE-B6E4-DB6A-00AE6EBF1E5E";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 6 ".ktv[0:5]"  1 1 3.444 1 6.396 1 12.264 1 21.084 1 24.008 1;
createNode animCurveTU -n "ctrl_Global_visibility";
	rename -uid "A6C89E80-40AB-C2D4-1633-DB9DC9626006";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 6 ".ktv[0:5]"  1 1 3.444 1 6.396 1 12.264 1 21.084 1 24.008 1;
createNode animCurveTU -n "jnt_Hip_scaleX";
	rename -uid "DA77B467-4C6F-5CDE-9811-95944445553F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_Hip_scaleY";
	rename -uid "1C952F84-4146-9599-48F3-11A5150376D9";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_Hip_scaleZ";
	rename -uid "A01060A6-4296-E065-D7BD-9AABE7110160";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_Hip_visibility";
	rename -uid "60A7C494-46E8-612B-0E49-43A971AD9DED";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_Hip_translateX";
	rename -uid "B255E460-4265-4146-C8E7-2F8C64E40BE0";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.080998816882000849 2 0.080998816882000849
		 3 0.080998816882000849 4 0.080998816882000849 5 0.080998816882000849 6 0.080998816882000849
		 7 0.080998816882000849 8 0.080998816882000849 9 0.080998816882000849 10 0.080998816882000849
		 11 0.080998816882000849 12 0.080998816882000849 13 0.080998816882000849 14 0.080998816882000849
		 15 0.080998816882000849 16 0.080998816882000849 17 0.080998816882000849 18 0.080998816882000849
		 19 0.080998816882000849 20 0.080998816882000849 21 0.080998816882000849 22 0.080998816882000849
		 23 0.080998816882000849;
createNode animCurveTL -n "jnt_Hip_translateY";
	rename -uid "174DD98A-4A44-BAA3-5BE9-71AB80BDEE09";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.010850631666419872 2 0.010850631666419872
		 3 0.010850631666419872 4 0.010850631666419872 5 0.010850631666419872 6 0.010850631666419872
		 7 0.010850631666419872 8 0.010850631666419872 9 0.010850631666419872 10 0.010850631666419872
		 11 0.010850631666419872 12 0.010850631666419872 13 0.010850631666419872 14 0.010850631666419872
		 15 0.010850631666419872 16 0.010850631666419872 17 0.010850631666419872 18 0.010850631666419872
		 19 0.010850631666419872 20 0.010850631666419872 21 0.010850631666419872 22 0.010850631666419872
		 23 0.010850631666419872;
createNode animCurveTL -n "jnt_Hip_translateZ";
	rename -uid "5E9C1F36-4072-7423-8751-64B70BDDC00A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 3.9968028886505634e-017 2 3.9968028886505634e-017
		 3 3.9968028886505634e-017 4 3.9968028886505634e-017 5 3.9968028886505634e-017 6 3.9968028886505634e-017
		 7 3.9968028886505634e-017 8 3.9968028886505634e-017 9 3.9968028886505634e-017 10 3.9968028886505634e-017
		 11 3.9968028886505634e-017 12 3.9968028886505634e-017 13 3.9968028886505634e-017
		 14 3.9968028886505634e-017 15 3.9968028886505634e-017 16 3.9968028886505634e-017
		 17 3.9968028886505634e-017 18 3.9968028886505634e-017 19 3.9968028886505634e-017
		 20 3.9968028886505634e-017 21 3.9968028886505634e-017 22 3.9968028886505634e-017
		 23 3.9968028886505634e-017;
createNode animCurveTA -n "jnt_Hip_rotateX";
	rename -uid "D08B7D2E-4012-8C8F-91AA-A5B6A632C64B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -2.401472990454156e-016 2 -2.401472990454156e-016
		 3 -2.401472990454156e-016 4 -2.401472990454156e-016 5 -2.401472990454156e-016 6 -2.401472990454156e-016
		 7 -2.401472990454156e-016 8 -2.401472990454156e-016 9 -2.401472990454156e-016 10 -2.401472990454156e-016
		 11 -2.401472990454156e-016 12 -2.401472990454156e-016 13 -2.401472990454156e-016
		 14 -2.401472990454156e-016 15 -2.401472990454156e-016 16 -2.401472990454156e-016
		 17 -2.401472990454156e-016 18 -2.401472990454156e-016 19 -2.401472990454156e-016
		 20 -2.401472990454156e-016 21 -2.401472990454156e-016 22 -2.401472990454156e-016
		 23 -2.401472990454156e-016;
createNode animCurveTA -n "jnt_Hip_rotateY";
	rename -uid "F48BAABE-4098-B743-56E3-7A964F2E8DFD";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -2.8228084036170611e-015 2 -2.8228084036170611e-015
		 3 -2.8228084036170611e-015 4 -2.8228084036170611e-015 5 -2.8228084036170611e-015
		 6 -2.8228084036170611e-015 7 -2.8228084036170611e-015 8 -2.8228084036170611e-015
		 9 -2.8228084036170611e-015 10 -2.8228084036170611e-015 11 -2.8228084036170611e-015
		 12 -2.8228084036170611e-015 13 -2.8228084036170611e-015 14 -2.8228084036170611e-015
		 15 -2.8228084036170611e-015 16 -2.8228084036170611e-015 17 -2.8228084036170611e-015
		 18 -2.8228084036170611e-015 19 -2.8228084036170611e-015 20 -2.8228084036170611e-015
		 21 -2.8228084036170611e-015 22 -2.8228084036170611e-015 23 -2.8228084036170611e-015;
createNode animCurveTA -n "jnt_Hip_rotateZ";
	rename -uid "7B8B55B5-4A7A-201D-6BA7-FAB7526FE085";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.55937665338389908 2 -0.55937665338389908
		 3 -0.55937665338389908 4 -0.55937665338389908 5 -0.55937665338389908 6 -0.55937665338389908
		 7 -0.55937665338389908 8 -0.55937665338389908 9 -0.55937665338389908 10 -0.55937665338389908
		 11 -0.55937665338389908 12 -0.55937665338389908 13 -0.55937665338389908 14 -0.55937665338389908
		 15 -0.55937665338389908 16 -0.55937665338389908 17 -0.55937665338389908 18 -0.55937665338389908
		 19 -0.55937665338389908 20 -0.55937665338389908 21 -0.55937665338389908 22 -0.55937665338389908
		 23 -0.55937665338389908;
createNode animCurveTU -n "jnt_Spine1_scaleX";
	rename -uid "51C4BFA6-4698-4D40-5F7C-29A5FFEB4860";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_Spine1_scaleY";
	rename -uid "711D5211-4416-593B-3F41-E5B2ECFD7D32";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_Spine1_scaleZ";
	rename -uid "4B850DF6-4FEB-D0C7-7870-23AD4C00B0FD";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_Spine1_visibility";
	rename -uid "B9474DDB-479B-332D-41EF-97859F1986D6";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_Spine1_translateX";
	rename -uid "E1EDE18F-4643-312F-B7F6-E6B3B8056834";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.11435781441863858 2 0.11435781441863858
		 3 0.11435781441863858 4 0.11435781441863858 5 0.11435781441863858 6 0.11435781441863858
		 7 0.11435781441863858 8 0.11435781441863858 9 0.11435781441863858 10 0.11435781441863858
		 11 0.11435781441863858 12 0.11435781441863858 13 0.11435781441863858 14 0.11435781441863858
		 15 0.11435781441863858 16 0.11435781441863858 17 0.11435781441863858 18 0.11435781441863858
		 19 0.11435781441863858 20 0.11435781441863858 21 0.11435781441863858 22 0.11435781441863858
		 23 0.11435781441863858;
createNode animCurveTL -n "jnt_Spine1_translateY";
	rename -uid "51B1D329-4FEC-3CBD-7A74-FEB1072C2A73";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.010291378399052992 2 -0.010291378399052992
		 3 -0.010291378399052992 4 -0.010291378399052992 5 -0.010291378399052992 6 -0.010291378399052992
		 7 -0.010291378399052992 8 -0.010291378399052992 9 -0.010291378399052992 10 -0.010291378399052992
		 11 -0.010291378399052992 12 -0.010291378399052992 13 -0.010291378399052992 14 -0.010291378399052992
		 15 -0.010291378399052992 16 -0.010291378399052992 17 -0.010291378399052992 18 -0.010291378399052992
		 19 -0.010291378399052992 20 -0.010291378399052992 21 -0.010291378399052992 22 -0.010291378399052992
		 23 -0.010291378399052992;
createNode animCurveTL -n "jnt_Spine1_translateZ";
	rename -uid "404E7E0B-466F-6AC0-4C1F-C6BE65686FC5";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 5.7651685371441104e-018 2 5.7651685371441104e-018
		 3 5.7651685371441104e-018 4 5.7651685371441104e-018 5 5.7651685371441104e-018 6 5.7651685371441104e-018
		 7 5.7651685371441104e-018 8 5.7651685371441104e-018 9 5.7651685371441104e-018 10 5.7651685371441104e-018
		 11 5.7651685371441104e-018 12 5.7651685371441104e-018 13 5.7651685371441104e-018
		 14 5.7651685371441104e-018 15 5.7651685371441104e-018 16 5.7651685371441104e-018
		 17 5.7651685371441104e-018 18 5.7651685371441104e-018 19 5.7651685371441104e-018
		 20 5.7651685371441104e-018 21 5.7651685371441104e-018 22 5.7651685371441104e-018
		 23 5.7651685371441104e-018;
createNode animCurveTA -n "jnt_Spine1_rotateX";
	rename -uid "05B33B14-498A-109D-C524-05A09704E089";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 2.3425485593096875e-016 2 2.3425485593096875e-016
		 3 2.3425485593096875e-016 4 2.3425485593096875e-016 5 2.3425485593096875e-016 6 2.3425485593096875e-016
		 7 2.3425485593096875e-016 8 2.3425485593096875e-016 9 2.3425485593096875e-016 10 2.3425485593096875e-016
		 11 2.3425485593096875e-016 12 2.3425485593096875e-016 13 2.3425485593096875e-016
		 14 2.3425485593096875e-016 15 2.3425485593096875e-016 16 2.3425485593096875e-016
		 17 2.3425485593096875e-016 18 2.3425485593096875e-016 19 2.3425485593096875e-016
		 20 2.3425485593096875e-016 21 2.3425485593096875e-016 22 2.3425485593096875e-016
		 23 2.3425485593096875e-016;
createNode animCurveTA -n "jnt_Spine1_rotateY";
	rename -uid "CA318638-401C-EBAB-420E-DDB586421D8E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -1.041669102988144e-014 2 -1.041669102988144e-014
		 3 -1.041669102988144e-014 4 -1.041669102988144e-014 5 -1.041669102988144e-014 6 -1.041669102988144e-014
		 7 -1.041669102988144e-014 8 -1.041669102988144e-014 9 -1.041669102988144e-014 10 -1.041669102988144e-014
		 11 -1.041669102988144e-014 12 -1.041669102988144e-014 13 -1.041669102988144e-014
		 14 -1.041669102988144e-014 15 -1.041669102988144e-014 16 -1.041669102988144e-014
		 17 -1.041669102988144e-014 18 -1.041669102988144e-014 19 -1.041669102988144e-014
		 20 -1.041669102988144e-014 21 -1.041669102988144e-014 22 -1.041669102988144e-014
		 23 -1.041669102988144e-014;
createNode animCurveTA -n "jnt_Spine1_rotateZ";
	rename -uid "1DDB4E2B-42D7-5388-F646-3FB8AE747827";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1.9331182179733439 2 1.9331182179733439
		 3 1.9331182179733439 4 1.9331182179733439 5 1.9331182179733439 6 1.9331182179733439
		 7 1.9331182179733439 8 1.9331182179733439 9 1.9331182179733439 10 1.9331182179733439
		 11 1.9331182179733439 12 1.9331182179733439 13 1.9331182179733439 14 1.9331182179733439
		 15 1.9331182179733439 16 1.9331182179733439 17 1.9331182179733439 18 1.9331182179733439
		 19 1.9331182179733439 20 1.9331182179733439 21 1.9331182179733439 22 1.9331182179733439
		 23 1.9331182179733439;
createNode animCurveTU -n "jnt_Spine2_scaleX";
	rename -uid "B8D1BDB2-47FA-39F5-E8D6-5BA2BCAA51CF";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_Spine2_scaleY";
	rename -uid "D6CCB9F4-4DA0-8F0D-28BD-4B9A91A6F7A0";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_Spine2_scaleZ";
	rename -uid "E6BB15B5-4528-A353-D7FD-C4AC47F5B2EA";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_Spine2_visibility";
	rename -uid "4EB03848-4518-2C24-5F8E-B58ACA0158FE";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_Spine2_translateX";
	rename -uid "59F3C354-4502-9F20-27BA-938B703093DE";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.11624241550495437 2 0.11624241550495437
		 3 0.11624241550495437 4 0.11624241550495437 5 0.11624241550495437 6 0.11624241550495437
		 7 0.11624241550495437 8 0.11624241550495437 9 0.11624241550495437 10 0.11624241550495437
		 11 0.11624241550495437 12 0.11624241550495437 13 0.11624241550495437 14 0.11624241550495437
		 15 0.11624241550495437 16 0.11624241550495437 17 0.11624241550495437 18 0.11624241550495437
		 19 0.11624241550495437 20 0.11624241550495437 21 0.11624241550495437 22 0.11624241550495437
		 23 0.11624241550495437;
createNode animCurveTL -n "jnt_Spine2_translateY";
	rename -uid "6A25BE2F-4B68-13B8-C44B-BCA26E981760";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.0062260515857481616 2 0.0062260515857481616
		 3 0.0062260515857481616 4 0.0062260515857481616 5 0.0062260515857481616 6 0.0062260515857481616
		 7 0.0062260515857481616 8 0.0062260515857481616 9 0.0062260515857481616 10 0.0062260515857481616
		 11 0.0062260515857481616 12 0.0062260515857481616 13 0.0062260515857481616 14 0.0062260515857481616
		 15 0.0062260515857481616 16 0.0062260515857481616 17 0.0062260515857481616 18 0.0062260515857481616
		 19 0.0062260515857481616 20 0.0062260515857481616 21 0.0062260515857481616 22 0.0062260515857481616
		 23 0.0062260515857481616;
createNode animCurveTL -n "jnt_Spine2_translateZ";
	rename -uid "26000DD3-477E-D48C-49A0-DC8C38A96E1A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 4.1045323841600566e-018 2 4.1045323841600566e-018
		 3 4.1045323841600566e-018 4 4.1045323841600566e-018 5 4.1045323841600566e-018 6 4.1045323841600566e-018
		 7 4.1045323841600566e-018 8 4.1045323841600566e-018 9 4.1045323841600566e-018 10 4.1045323841600566e-018
		 11 4.1045323841600566e-018 12 4.1045323841600566e-018 13 4.1045323841600566e-018
		 14 4.1045323841600566e-018 15 4.1045323841600566e-018 16 4.1045323841600566e-018
		 17 4.1045323841600566e-018 18 4.1045323841600566e-018 19 4.1045323841600566e-018
		 20 4.1045323841600566e-018 21 4.1045323841600566e-018 22 4.1045323841600566e-018
		 23 4.1045323841600566e-018;
createNode animCurveTA -n "jnt_Spine2_rotateX";
	rename -uid "85742E5C-42D5-BC3F-0FFE-0F90545487B9";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 2.8576453432346732e-016 2 2.8576453432346732e-016
		 3 2.8576453432346732e-016 4 2.8576453432346732e-016 5 2.8576453432346732e-016 6 2.8576453432346732e-016
		 7 2.8576453432346732e-016 8 2.8576453432346732e-016 9 2.8576453432346732e-016 10 2.8576453432346732e-016
		 11 2.8576453432346732e-016 12 2.8576453432346732e-016 13 2.8576453432346732e-016
		 14 2.8576453432346732e-016 15 2.8576453432346732e-016 16 2.8576453432346732e-016
		 17 2.8576453432346732e-016 18 2.8576453432346732e-016 19 2.8576453432346732e-016
		 20 2.8576453432346732e-016 21 2.8576453432346732e-016 22 2.8576453432346732e-016
		 23 2.8576453432346732e-016;
createNode animCurveTA -n "jnt_Spine2_rotateY";
	rename -uid "294FAD60-48C3-9CBD-630D-01A6B42506DA";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1.5445415045836411e-014 2 1.5445415045836411e-014
		 3 1.5445415045836411e-014 4 1.5445415045836411e-014 5 1.5445415045836411e-014 6 1.5445415045836411e-014
		 7 1.5445415045836411e-014 8 1.5445415045836411e-014 9 1.5445415045836411e-014 10 1.5445415045836411e-014
		 11 1.5445415045836411e-014 12 1.5445415045836411e-014 13 1.5445415045836411e-014
		 14 1.5445415045836411e-014 15 1.5445415045836411e-014 16 1.5445415045836411e-014
		 17 1.5445415045836411e-014 18 1.5445415045836411e-014 19 1.5445415045836411e-014
		 20 1.5445415045836411e-014 21 1.5445415045836411e-014 22 1.5445415045836411e-014
		 23 1.5445415045836411e-014;
createNode animCurveTA -n "jnt_Spine2_rotateZ";
	rename -uid "B2431C6F-416C-9BEE-0F14-5BA6F2D1FBCB";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.41656337650786096 2 0.41656337650786096
		 3 0.41656337650786096 4 0.41656337650786096 5 0.41656337650786096 6 0.41656337650786096
		 7 0.41656337650786096 8 0.41656337650786096 9 0.41656337650786096 10 0.41656337650786096
		 11 0.41656337650786096 12 0.41656337650786096 13 0.41656337650786096 14 0.41656337650786096
		 15 0.41656337650786096 16 0.41656337650786096 17 0.41656337650786096 18 0.41656337650786096
		 19 0.41656337650786096 20 0.41656337650786096 21 0.41656337650786096 22 0.41656337650786096
		 23 0.41656337650786096;
createNode animCurveTU -n "jnt_Spine3_scaleX";
	rename -uid "F8CAC348-4338-E4B3-F82B-8F90FB4C6F3F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_Spine3_scaleY";
	rename -uid "D8648300-41CB-3FDE-F8EC-C78C0460AF91";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_Spine3_scaleZ";
	rename -uid "CF2AD854-4079-31D3-E454-ABA62F477853";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_Spine3_visibility";
	rename -uid "ECC8037B-43B4-15FF-0FEA-E9AF93122D70";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_Spine3_translateX";
	rename -uid "6CC14806-47C7-51EF-8C51-6998906CC9DD";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.10637659371569648 2 0.10637659371569648
		 3 0.10637659371569648 4 0.10637659371569648 5 0.10637659371569648 6 0.10637659371569648
		 7 0.10637659371569648 8 0.10637659371569648 9 0.10637659371569648 10 0.10637659371569648
		 11 0.10637659371569648 12 0.10637659371569648 13 0.10637659371569648 14 0.10637659371569648
		 15 0.10637659371569648 16 0.10637659371569648 17 0.10637659371569648 18 0.10637659371569648
		 19 0.10637659371569648 20 0.10637659371569648 21 0.10637659371569648 22 0.10637659371569648
		 23 0.10637659371569648;
createNode animCurveTL -n "jnt_Spine3_translateY";
	rename -uid "5CAE4E57-49FC-4D97-6A80-158B58849B6E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.0015813263461425552 2 -0.0015813263461425552
		 3 -0.0015813263461425552 4 -0.0015813263461425552 5 -0.0015813263461425552 6 -0.0015813263461425552
		 7 -0.0015813263461425552 8 -0.0015813263461425552 9 -0.0015813263461425552 10 -0.0015813263461425552
		 11 -0.0015813263461425552 12 -0.0015813263461425552 13 -0.0015813263461425552 14 -0.0015813263461425552
		 15 -0.0015813263461425552 16 -0.0015813263461425552 17 -0.0015813263461425552 18 -0.0015813263461425552
		 19 -0.0015813263461425552 20 -0.0015813263461425552 21 -0.0015813263461425552 22 -0.0015813263461425552
		 23 -0.0015813263461425552;
createNode animCurveTL -n "jnt_Spine3_translateZ";
	rename -uid "68890F53-42C6-5FF7-33CC-EEB622892E95";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -1.3998927102922657e-018 2 -1.3998927102922657e-018
		 3 -1.3998927102922657e-018 4 -1.3998927102922657e-018 5 -1.3998927102922657e-018
		 6 -1.3998927102922657e-018 7 -1.3998927102922657e-018 8 -1.3998927102922657e-018
		 9 -1.3998927102922657e-018 10 -1.3998927102922657e-018 11 -1.3998927102922657e-018
		 12 -1.3998927102922657e-018 13 -1.3998927102922657e-018 14 -1.3998927102922657e-018
		 15 -1.3998927102922657e-018 16 -1.3998927102922657e-018 17 -1.3998927102922657e-018
		 18 -1.3998927102922657e-018 19 -1.3998927102922657e-018 20 -1.3998927102922657e-018
		 21 -1.3998927102922657e-018 22 -1.3998927102922657e-018 23 -1.3998927102922657e-018;
createNode animCurveTA -n "jnt_Spine3_rotateX";
	rename -uid "1F329487-42F5-B67C-5189-C6BA1DB2B327";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1.6539253192653937e-015 2 1.6539253192653937e-015
		 3 1.6539253192653937e-015 4 1.6539253192653937e-015 5 1.6539253192653937e-015 6 1.6539253192653937e-015
		 7 1.6539253192653937e-015 8 1.6539253192653937e-015 9 1.6539253192653937e-015 10 1.6539253192653937e-015
		 11 1.6539253192653937e-015 12 1.6539253192653937e-015 13 1.6539253192653937e-015
		 14 1.6539253192653937e-015 15 1.6539253192653937e-015 16 1.6539253192653937e-015
		 17 1.6539253192653937e-015 18 1.6539253192653937e-015 19 1.6539253192653937e-015
		 20 1.6539253192653937e-015 21 1.6539253192653937e-015 22 1.6539253192653937e-015
		 23 1.6539253192653937e-015;
createNode animCurveTA -n "jnt_Spine3_rotateY";
	rename -uid "4B461FCC-4372-7E72-6739-2A815CAE353F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1.3062514433537918e-014 2 1.3062514433537918e-014
		 3 1.3062514433537918e-014 4 1.3062514433537918e-014 5 1.3062514433537918e-014 6 1.3062514433537918e-014
		 7 1.3062514433537918e-014 8 1.3062514433537918e-014 9 1.3062514433537918e-014 10 1.3062514433537918e-014
		 11 1.3062514433537918e-014 12 1.3062514433537918e-014 13 1.3062514433537918e-014
		 14 1.3062514433537918e-014 15 1.3062514433537918e-014 16 1.3062514433537918e-014
		 17 1.3062514433537918e-014 18 1.3062514433537918e-014 19 1.3062514433537918e-014
		 20 1.3062514433537918e-014 21 1.3062514433537918e-014 22 1.3062514433537918e-014
		 23 1.3062514433537918e-014;
createNode animCurveTA -n "jnt_Spine3_rotateZ";
	rename -uid "EDF7CB02-4F7C-2894-C9A7-548224D045A9";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 3.3532450388557993 2 3.3532450388557993
		 3 3.3532450388557993 4 3.3532450388557993 5 3.3532450388557993 6 3.3532450388557993
		 7 3.3532450388557993 8 3.3532450388557993 9 3.3532450388557993 10 3.3532450388557993
		 11 3.3532450388557993 12 3.3532450388557993 13 3.3532450388557993 14 3.3532450388557993
		 15 3.3532450388557993 16 3.3532450388557993 17 3.3532450388557993 18 3.3532450388557993
		 19 3.3532450388557993 20 3.3532450388557993 21 3.3532450388557993 22 3.3532450388557993
		 23 3.3532450388557993;
createNode animCurveTU -n "jnt_NeckBase_scaleX";
	rename -uid "27D3F2F6-4005-E71E-6708-35823A5A8D46";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_NeckBase_scaleY";
	rename -uid "3E31D31A-4D3B-A3C0-F16E-B1BE63C0A97A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_NeckBase_scaleZ";
	rename -uid "696399A2-44BA-34FD-67AC-6E9C2C87C08E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_NeckBase_translateX";
	rename -uid "35BBE4EE-4324-8BA9-B60C-5C8FADB17B8F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.081380663163636416 2 0.081380663163636416
		 3 0.081380663163636416 4 0.081380663163636416 5 0.081380663163636416 6 0.081380663163636416
		 7 0.081380663163636416 8 0.081380663163636416 9 0.081380663163636416 10 0.081380663163636416
		 11 0.081380663163636416 12 0.081380663163636416 13 0.081380663163636416 14 0.081380663163636416
		 15 0.081380663163636416 16 0.081380663163636416 17 0.081380663163636416 18 0.081380663163636416
		 19 0.081380663163636416 20 0.081380663163636416 21 0.081380663163636416 22 0.081380663163636416
		 23 0.081380663163636416;
createNode animCurveTL -n "jnt_NeckBase_translateY";
	rename -uid "E48B3FAF-4ACE-8F52-2545-6AB7ECB50EC4";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.0078927660960737851 2 -0.0078927660960737851
		 3 -0.0078927660960737851 4 -0.0078927660960737851 5 -0.0078927660960737851 6 -0.0078927660960737851
		 7 -0.0078927660960737851 8 -0.0078927660960737851 9 -0.0078927660960737851 10 -0.0078927660960737851
		 11 -0.0078927660960737851 12 -0.0078927660960737851 13 -0.0078927660960737851 14 -0.0078927660960737851
		 15 -0.0078927660960737851 16 -0.0078927660960737851 17 -0.0078927660960737851 18 -0.0078927660960737851
		 19 -0.0078927660960737851 20 -0.0078927660960737851 21 -0.0078927660960737851 22 -0.0078927660960737851
		 23 -0.0078927660960737851;
createNode animCurveTL -n "jnt_NeckBase_translateZ";
	rename -uid "267A37CE-46AC-E7E7-758A-17B6D8477679";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -2.7618334887922321e-019 2 -2.7618334887922321e-019
		 3 -2.7618334887922321e-019 4 -2.7618334887922321e-019 5 -2.7618334887922321e-019
		 6 -2.7618334887922321e-019 7 -2.7618334887922321e-019 8 -2.7618334887922321e-019
		 9 -2.7618334887922321e-019 10 -2.7618334887922321e-019 11 -2.7618334887922321e-019
		 12 -2.7618334887922321e-019 13 -2.7618334887922321e-019 14 -2.7618334887922321e-019
		 15 -2.7618334887922321e-019 16 -2.7618334887922321e-019 17 -2.7618334887922321e-019
		 18 -2.7618334887922321e-019 19 -2.7618334887922321e-019 20 -2.7618334887922321e-019
		 21 -2.7618334887922321e-019 22 -2.7618334887922321e-019 23 -2.7618334887922321e-019;
createNode animCurveTU -n "jnt_NeckBase_visibility";
	rename -uid "09149B79-4B3C-0D7F-8561-23A480703520";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTA -n "jnt_NeckBase_rotateX";
	rename -uid "DD618C5B-44A1-04D8-F9E5-D1A2FEA6EBD0";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_NeckBase_rotateY";
	rename -uid "D91AF8EE-4E3B-00F9-02B9-4299324A5B49";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_NeckBase_rotateZ";
	rename -uid "4FCB8BF7-43FC-0B86-B9F2-CA8EAA9DD71D";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_NeckBase_scaleX1";
	rename -uid "BAA6E53E-491F-4FCD-9C04-F4842965EF01";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_NeckBase_scaleY1";
	rename -uid "18A4A2B6-4F42-18BA-DF14-5DA974EDC1D5";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_NeckBase_scaleZ1";
	rename -uid "01D0E1BB-4F27-6BF1-D81C-AFBBD92C776B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_NeckBase_visibility1";
	rename -uid "5D8056F4-4689-AC0F-0B13-9FA71DF4EFF5";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_NeckBase_translateX1";
	rename -uid "7982DFC9-4EC9-7E72-03F8-2A9439DCC48D";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.014212445911485077 2 0.014212445911485077
		 3 0.014212445911485077 4 0.014212445911485077 5 0.014212445911485077 6 0.014212445911485077
		 7 0.014212445911485077 8 0.014212445911485077 9 0.014212445911485077 10 0.014212445911485077
		 11 0.014212445911485077 12 0.014212445911485077 13 0.014212445911485077 14 0.014212445911485077
		 15 0.014212445911485077 16 0.014212445911485077 17 0.014212445911485077 18 0.014212445911485077
		 19 0.014212445911485077 20 0.014212445911485077 21 0.014212445911485077 22 0.014212445911485077
		 23 0.014212445911485077;
createNode animCurveTL -n "jnt_NeckBase_translateY1";
	rename -uid "852ABA4D-454E-557B-0E94-3CAD329E68D6";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.0056000112684924377 2 0.0056000112684924377
		 3 0.0056000112684924377 4 0.0056000112684924377 5 0.0056000112684924377 6 0.0056000112684924377
		 7 0.0056000112684924377 8 0.0056000112684924377 9 0.0056000112684924377 10 0.0056000112684924377
		 11 0.0056000112684924377 12 0.0056000112684924377 13 0.0056000112684924377 14 0.0056000112684924377
		 15 0.0056000112684924377 16 0.0056000112684924377 17 0.0056000112684924377 18 0.0056000112684924377
		 19 0.0056000112684924377 20 0.0056000112684924377 21 0.0056000112684924377 22 0.0056000112684924377
		 23 0.0056000112684924377;
createNode animCurveTL -n "jnt_NeckBase_translateZ1";
	rename -uid "E7589D2B-45AE-5CF5-92BF-A9ADF16B5C53";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1.9195862824317237e-019 2 1.9195862824317237e-019
		 3 1.9195862824317237e-019 4 1.9195862824317237e-019 5 1.9195862824317237e-019 6 1.9195862824317237e-019
		 7 1.9195862824317237e-019 8 1.9195862824317237e-019 9 1.9195862824317237e-019 10 1.9195862824317237e-019
		 11 1.9195862824317237e-019 12 1.9195862824317237e-019 13 1.9195862824317237e-019
		 14 1.9195862824317237e-019 15 1.9195862824317237e-019 16 1.9195862824317237e-019
		 17 1.9195862824317237e-019 18 1.9195862824317237e-019 19 1.9195862824317237e-019
		 20 1.9195862824317237e-019 21 1.9195862824317237e-019 22 1.9195862824317237e-019
		 23 1.9195862824317237e-019;
createNode animCurveTA -n "jnt_NeckBase_rotateX1";
	rename -uid "64CC7CE5-4DF9-BFE2-B8FF-36BEB41C6AB6";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -10.934192036119095 2 -10.934192036119095
		 3 -10.934192036119095 4 -10.934192036119095 5 -10.934192036119095 6 -10.934192036119095
		 7 -10.934192036119095 8 -10.934192036119095 9 -10.934192036119095 10 -10.934192036119095
		 11 -10.934192036119095 12 -10.934192036119095 13 -10.934192036119095 14 -10.934192036119095
		 15 -10.934192036119095 16 -10.934192036119095 17 -10.934192036119095 18 -10.934192036119095
		 19 -10.934192036119095 20 -10.934192036119095 21 -10.934192036119095 22 -10.934192036119095
		 23 -10.934192036119095;
createNode animCurveTA -n "jnt_NeckBase_rotateY1";
	rename -uid "F5224B87-4544-B4AC-8DF2-2C8BD306773F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -4.2749358045509931 2 -4.2749358045509931
		 3 -4.2749358045509931 4 -4.2749358045509931 5 -4.2749358045509931 6 -4.2749358045509931
		 7 -4.2749358045509931 8 -4.2749358045509931 9 -4.2749358045509931 10 -4.2749358045509931
		 11 -4.2749358045509931 12 -4.2749358045509931 13 -4.2749358045509931 14 -4.2749358045509931
		 15 -4.2749358045509931 16 -4.2749358045509931 17 -4.2749358045509931 18 -4.2749358045509931
		 19 -4.2749358045509931 20 -4.2749358045509931 21 -4.2749358045509931 22 -4.2749358045509931
		 23 -4.2749358045509931;
createNode animCurveTA -n "jnt_NeckBase_rotateZ1";
	rename -uid "5FB00308-423F-6430-D86E-D799D5F5A804";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.40934002610919801 2 0.40934002610919801
		 3 0.40934002610919801 4 0.40934002610919801 5 0.40934002610919801 6 0.40934002610919801
		 7 0.40934002610919801 8 0.40934002610919801 9 0.40934002610919801 10 0.40934002610919801
		 11 0.40934002610919801 12 0.40934002610919801 13 0.40934002610919801 14 0.40934002610919801
		 15 0.40934002610919801 16 0.40934002610919801 17 0.40934002610919801 18 0.40934002610919801
		 19 0.40934002610919801 20 0.40934002610919801 21 0.40934002610919801 22 0.40934002610919801
		 23 0.40934002610919801;
createNode animCurveTA -n "jnt_Head_rotateX";
	rename -uid "71E5F364-42A8-5F1D-48E3-0F8F349EDA06";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -1.8375877071767599 2 -1.837587707176753
		 3 -1.837587707176751 4 -1.8375877071767455 5 -1.8375877071767455 6 -1.837587707176751
		 7 -1.8375877071767268 8 -1.837587707176739 9 -1.8375877071767619 10 -1.8375877071767344
		 11 -1.8375877071767479 12 -1.8375877071767268 13 -1.8375877071767621 14 -1.837587707176751
		 15 -1.837587707176751 16 -1.8375877071767464 17 -1.8375877071767459 18 -1.8375877071767581
		 19 -1.8375877071767581 20 -1.837587707176751 21 -1.8375877071767674 22 -1.8375877071767284
		 23 -1.837587707176757;
createNode animCurveTA -n "jnt_Head_rotateY";
	rename -uid "B2D42FCE-42A0-9684-9F53-DEBD88672DF9";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 2.1922162219152046 2 2.1922162219152432
		 3 2.1922162219152348 4 2.1922162219152375 5 2.1922162219152375 6 2.1922162219152348
		 7 2.1922162219152281 8 2.192216221915221 9 2.1922162219151988 10 2.1922162219152312
		 11 2.1922162219152264 12 2.1922162219152281 13 2.1922162219152219 14 2.1922162219152348
		 15 2.1922162219152348 16 2.1922162219152366 17 2.1922162219152206 18 2.1922162219152139
		 19 2.1922162219152139 20 2.1922162219152348 21 2.1922162219152259 22 2.1922162219152215
		 23 2.1922162219152068;
createNode animCurveTA -n "jnt_Head_rotateZ";
	rename -uid "60876E2B-4C19-2D3F-C597-809B5CB71663";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -6.1489599918022195 2 -6.1489599918024247
		 3 -6.1489599918023332 4 -6.1489599918023785 5 -6.1489599918023785 6 -6.1489599918023332
		 7 -6.1489599918024229 8 -6.14895999180243 9 -6.1489599918023492 10 -6.1489599918021671
		 11 -6.1489599918022266 12 -6.1489599918024229 13 -6.1489599918022977 14 -6.1489599918023332
		 15 -6.1489599918023332 16 -6.14895999180243 17 -6.1489599918024425 18 -6.1489599918024229
		 19 -6.1489599918024229 20 -6.1489599918023332 21 -6.1489599918022231 22 -6.1489599918022151
		 23 -6.1489599918024265;
createNode animCurveTU -n "jnt_Head_scaleX";
	rename -uid "012FB370-431F-1496-CB39-7EAA15241B4B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_Head_scaleY";
	rename -uid "EA20D920-49AE-9143-19FF-8E896FF5FA59";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_Head_scaleZ";
	rename -uid "835829D7-487B-AF90-0699-439F53FDDEC2";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_Head_translateX";
	rename -uid "915787BE-478E-94BD-28C4-D682A39376B7";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.020299241462493449 2 0.020299241462493449
		 3 0.020299241462493449 4 0.020299241462493449 5 0.020299241462493449 6 0.020299241462493449
		 7 0.020299241462493449 8 0.020299241462493449 9 0.020299241462493449 10 0.020299241462493449
		 11 0.020299241462493449 12 0.020299241462493449 13 0.020299241462493449 14 0.020299241462493449
		 15 0.020299241462493449 16 0.020299241462493449 17 0.020299241462493449 18 0.020299241462493449
		 19 0.020299241462493449 20 0.020299241462493449 21 0.020299241462493449 22 0.020299241462493449
		 23 0.020299241462493449;
createNode animCurveTL -n "jnt_Head_translateY";
	rename -uid "C58A1A16-4C1B-1DD2-8780-09B66B9902CE";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.0079996125677250125 2 0.0079996125677250125
		 3 0.0079996125677250125 4 0.0079996125677250125 5 0.0079996125677250125 6 0.0079996125677250125
		 7 0.0079996125677250125 8 0.0079996125677250125 9 0.0079996125677250125 10 0.0079996125677250125
		 11 0.0079996125677250125 12 0.0079996125677250125 13 0.0079996125677250125 14 0.0079996125677250125
		 15 0.0079996125677250125 16 0.0079996125677250125 17 0.0079996125677250125 18 0.0079996125677250125
		 19 0.0079996125677250125 20 0.0079996125677250125 21 0.0079996125677250125 22 0.0079996125677250125
		 23 0.0079996125677250125;
createNode animCurveTL -n "jnt_Head_translateZ";
	rename -uid "E557CA8D-4B48-EA03-8218-3F9502BC705E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 2.7404140256661324e-019 2 2.7404140256661324e-019
		 3 2.7404140256661324e-019 4 2.7404140256661324e-019 5 2.7404140256661324e-019 6 2.7404140256661324e-019
		 7 2.7404140256661324e-019 8 2.7404140256661324e-019 9 2.7404140256661324e-019 10 2.7404140256661324e-019
		 11 2.7404140256661324e-019 12 2.7404140256661324e-019 13 2.7404140256661324e-019
		 14 2.7404140256661324e-019 15 2.7404140256661324e-019 16 2.7404140256661324e-019
		 17 2.7404140256661324e-019 18 2.7404140256661324e-019 19 2.7404140256661324e-019
		 20 2.7404140256661324e-019 21 2.7404140256661324e-019 22 2.7404140256661324e-019
		 23 2.7404140256661324e-019;
createNode animCurveTU -n "jnt_Head_visibility";
	rename -uid "644BFF66-4A5B-98FE-825B-C29492B081F7";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_HeadTop_scaleX";
	rename -uid "E23CCBF1-4601-D6E1-2E9A-B5A37C46D32B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_HeadTop_scaleY";
	rename -uid "29E95CBF-4BC0-9638-549B-A795F7A4679F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_HeadTop_scaleZ";
	rename -uid "3B1AA29D-4924-171B-93F5-9BB51D1E09BB";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_HeadTop_visibility";
	rename -uid "AA5F777C-40C4-0363-63F8-899FC7D8C647";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_HeadTop_translateX";
	rename -uid "F84D0DCE-4251-BFA7-B768-4CAEFC6A4742";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.18892213692278567 2 0.18892213692278567
		 3 0.18892213692278567 4 0.18892213692278567 5 0.18892213692278567 6 0.18892213692278567
		 7 0.18892213692278567 8 0.18892213692278567 9 0.18892213692278567 10 0.18892213692278567
		 11 0.18892213692278567 12 0.18892213692278567 13 0.18892213692278567 14 0.18892213692278567
		 15 0.18892213692278567 16 0.18892213692278567 17 0.18892213692278567 18 0.18892213692278567
		 19 0.18892213692278567 20 0.18892213692278567 21 0.18892213692278567 22 0.18892213692278567
		 23 0.18892213692278567;
createNode animCurveTL -n "jnt_HeadTop_translateY";
	rename -uid "3BE91B4C-492C-8AA6-87BF-27877858CA43";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.0029432608068074174 2 0.0029432608068074174
		 3 0.0029432608068074174 4 0.0029432608068074174 5 0.0029432608068074174 6 0.0029432608068074174
		 7 0.0029432608068074174 8 0.0029432608068074174 9 0.0029432608068074174 10 0.0029432608068074174
		 11 0.0029432608068074174 12 0.0029432608068074174 13 0.0029432608068074174 14 0.0029432608068074174
		 15 0.0029432608068074174 16 0.0029432608068074174 17 0.0029432608068074174 18 0.0029432608068074174
		 19 0.0029432608068074174 20 0.0029432608068074174 21 0.0029432608068074174 22 0.0029432608068074174
		 23 0.0029432608068074174;
createNode animCurveTL -n "jnt_HeadTop_translateZ";
	rename -uid "A16B0B79-4E55-8EB9-19FF-F2B2CA4E5834";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 5.6077271640200855e-018 2 5.6077271640200855e-018
		 3 5.6077271640200855e-018 4 5.6077271640200855e-018 5 5.6077271640200855e-018 6 5.6077271640200855e-018
		 7 5.6077271640200855e-018 8 5.6077271640200855e-018 9 5.6077271640200855e-018 10 5.6077271640200855e-018
		 11 5.6077271640200855e-018 12 5.6077271640200855e-018 13 5.6077271640200855e-018
		 14 5.6077271640200855e-018 15 5.6077271640200855e-018 16 5.6077271640200855e-018
		 17 5.6077271640200855e-018 18 5.6077271640200855e-018 19 5.6077271640200855e-018
		 20 5.6077271640200855e-018 21 5.6077271640200855e-018 22 5.6077271640200855e-018
		 23 5.6077271640200855e-018;
createNode animCurveTA -n "jnt_HeadTop_rotateX";
	rename -uid "560BFC33-4F76-272E-7AF2-AE9C7BDB61BD";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_HeadTop_rotateY";
	rename -uid "5C097E40-4C5E-310D-2FAE-95A6D1520FAE";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_HeadTop_rotateZ";
	rename -uid "53D747C6-4098-8E78-5969-10B1BD14CEA3";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_ChinBase_scaleX";
	rename -uid "9C2EBC55-4C10-93C2-37EC-198C32B32438";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_ChinBase_scaleY";
	rename -uid "475AF925-4B00-1427-1B3E-6E904B017D8C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_ChinBase_scaleZ";
	rename -uid "3329F7F9-4CA2-ADEF-CEFD-E6829F63B098";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_ChinBase_visibility";
	rename -uid "860FF175-437E-D3CC-AB43-768E956F51F4";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_ChinBase_translateX";
	rename -uid "2AED5905-4B54-82E3-17F4-7BB3A84FC6E5";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.13573778763081437 2 0.13573778763081437
		 3 0.13573778763081437 4 0.13573778763081437 5 0.13573778763081437 6 0.13573778763081437
		 7 0.13573778763081437 8 0.13573778763081437 9 0.13573778763081437 10 0.13573778763081437
		 11 0.13573778763081437 12 0.13573778763081437 13 0.13573778763081437 14 0.13573778763081437
		 15 0.13573778763081437 16 0.13573778763081437 17 0.13573778763081437 18 0.13573778763081437
		 19 0.13573778763081437 20 0.13573778763081437 21 0.13573778763081437 22 0.13573778763081437
		 23 0.13573778763081437;
createNode animCurveTL -n "jnt_ChinBase_translateY";
	rename -uid "158F5A97-4657-3A6E-45DE-8EB16B046F16";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.0071545996610926652 2 0.0071545996610926652
		 3 0.0071545996610926652 4 0.0071545996610926652 5 0.0071545996610926652 6 0.0071545996610926652
		 7 0.0071545996610926652 8 0.0071545996610926652 9 0.0071545996610926652 10 0.0071545996610926652
		 11 0.0071545996610926652 12 0.0071545996610926652 13 0.0071545996610926652 14 0.0071545996610926652
		 15 0.0071545996610926652 16 0.0071545996610926652 17 0.0071545996610926652 18 0.0071545996610926652
		 19 0.0071545996610926652 20 0.0071545996610926652 21 0.0071545996610926652 22 0.0071545996610926652
		 23 0.0071545996610926652;
createNode animCurveTL -n "jnt_ChinBase_translateZ";
	rename -uid "9117C44F-4A03-B163-B0B4-18A4734C211D";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 2.4214687408828707e-018 2 2.4214687408828707e-018
		 3 2.4214687408828707e-018 4 2.4214687408828707e-018 5 2.4214687408828707e-018 6 2.4214687408828707e-018
		 7 2.4214687408828707e-018 8 2.4214687408828707e-018 9 2.4214687408828707e-018 10 2.4214687408828707e-018
		 11 2.4214687408828707e-018 12 2.4214687408828707e-018 13 2.4214687408828707e-018
		 14 2.4214687408828707e-018 15 2.4214687408828707e-018 16 2.4214687408828707e-018
		 17 2.4214687408828707e-018 18 2.4214687408828707e-018 19 2.4214687408828707e-018
		 20 2.4214687408828707e-018 21 2.4214687408828707e-018 22 2.4214687408828707e-018
		 23 2.4214687408828707e-018;
createNode animCurveTA -n "jnt_ChinBase_rotateX";
	rename -uid "ACE73241-4100-F8A2-6834-F1953790F870";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_ChinBase_rotateY";
	rename -uid "E6D22B33-4E25-5885-893B-41A9F5E6DAFC";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_ChinBase_rotateZ";
	rename -uid "25D87535-4494-DFEF-FBA4-8DA3B43217D9";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_ChinTip_visibility";
	rename -uid "783A627E-40EA-A4FD-2257-F68298D51EFF";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_ChinTip_translateX";
	rename -uid "205F4A89-44CF-8014-B349-22A22F30C0F1";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.031333129058896458 2 0.031333129058896458
		 3 0.031333129058896458 4 0.031333129058896458 5 0.031333129058896458 6 0.031333129058896458
		 7 0.031333129058896458 8 0.031333129058896458 9 0.031333129058896458 10 0.031333129058896458
		 11 0.031333129058896458 12 0.031333129058896458 13 0.031333129058896458 14 0.031333129058896458
		 15 0.031333129058896458 16 0.031333129058896458 17 0.031333129058896458 18 0.031333129058896458
		 19 0.031333129058896458 20 0.031333129058896458 21 0.031333129058896458 22 0.031333129058896458
		 23 0.031333129058896458;
createNode animCurveTL -n "jnt_ChinTip_translateY";
	rename -uid "E48F3ED5-4D12-AFE1-EDC8-7E80DDE194E9";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.028129793482011833 2 -0.028129793482011833
		 3 -0.028129793482011833 4 -0.028129793482011833 5 -0.028129793482011833 6 -0.028129793482011833
		 7 -0.028129793482011833 8 -0.028129793482011833 9 -0.028129793482011833 10 -0.028129793482011833
		 11 -0.028129793482011833 12 -0.028129793482011833 13 -0.028129793482011833 14 -0.028129793482011833
		 15 -0.028129793482011833 16 -0.028129793482011833 17 -0.028129793482011833 18 -0.028129793482011833
		 19 -0.028129793482011833 20 -0.028129793482011833 21 -0.028129793482011833 22 -0.028129793482011833
		 23 -0.028129793482011833;
createNode animCurveTL -n "jnt_ChinTip_translateZ";
	rename -uid "131C3EA6-430D-2EF7-CBAF-60B5ECE2C58E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -2.7726091830782184e-018 2 -2.7726091830782184e-018
		 3 -2.7726091830782184e-018 4 -2.7726091830782184e-018 5 -2.7726091830782184e-018
		 6 -2.7726091830782184e-018 7 -2.7726091830782184e-018 8 -2.7726091830782184e-018
		 9 -2.7726091830782184e-018 10 -2.7726091830782184e-018 11 -2.7726091830782184e-018
		 12 -2.7726091830782184e-018 13 -2.7726091830782184e-018 14 -2.7726091830782184e-018
		 15 -2.7726091830782184e-018 16 -2.7726091830782184e-018 17 -2.7726091830782184e-018
		 18 -2.7726091830782184e-018 19 -2.7726091830782184e-018 20 -2.7726091830782184e-018
		 21 -2.7726091830782184e-018 22 -2.7726091830782184e-018 23 -2.7726091830782184e-018;
createNode animCurveTA -n "jnt_ChinTip_rotateX";
	rename -uid "436E6795-4FD5-852A-9CCB-0BB8840B8108";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_ChinTip_rotateY";
	rename -uid "10C9CEA3-4283-145B-5EED-92B8001DED35";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_ChinTip_rotateZ";
	rename -uid "555773C5-45C5-C8CD-2C58-078B73EDFF0C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_ChinTip_scaleX";
	rename -uid "B07790BE-47B2-2C57-81F5-0D9F387747D1";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_ChinTip_scaleY";
	rename -uid "111B4EC2-463A-1E43-72B9-999D27BFCA43";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_ChinTip_scaleZ";
	rename -uid "8330E50E-44AA-4309-7CA9-9595FC304D2E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode displayLayer -n "bodyControls";
	rename -uid "E35518A5-4D21-3C38-6388-07B781709BB9";
	setAttr ".c" 14;
	setAttr ".do" 5;
createNode animCurveTL -n "ctrl_Back_translateX";
	rename -uid "1C6576F4-4F08-2AAD-A9F2-03AA6207CEA2";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 3 ".ktv[0:2]"  1 0 12.264 0 24.008 0;
createNode animCurveTL -n "ctrl_Back_translateY";
	rename -uid "A8B0F1C5-431C-45CC-24CE-998C0350629D";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 3 ".ktv[0:2]"  1 0 12.264 0 24.008 0;
createNode animCurveTL -n "ctrl_Back_translateZ";
	rename -uid "C9C74722-469D-31A8-E61B-A2817A077733";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 3 ".ktv[0:2]"  1 0 12.264 0 24.008 0;
createNode animCurveTU -n "ctrl_Back_visibility";
	rename -uid "6439731E-4B35-05E2-5245-DE8C9B620FF1";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 3 ".ktv[0:2]"  1 1 12.264 1 24.008 1;
createNode animCurveTA -n "ctrl_Back_rotateX";
	rename -uid "9E1AACDE-4D05-BFE0-A240-36A76880B2F6";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 3 ".ktv[0:2]"  1 0 12.264 0 24.008 0;
createNode animCurveTA -n "ctrl_Back_rotateY";
	rename -uid "EBFC7EF4-42B2-83B8-F9E3-1B8EF5906821";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 3 ".ktv[0:2]"  1 0 12.264 0 24.008 0;
createNode animCurveTA -n "ctrl_Back_rotateZ";
	rename -uid "07D087F2-497F-055F-132B-69A53C6A00BE";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 3 ".ktv[0:2]"  1 0 12.264 0 24.008 0;
createNode animCurveTL -n "ctrl_Hips_translateX";
	rename -uid "A70B1D8F-4562-94E4-3C6F-28AFE035D729";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 7 ".ktv[0:6]"  1 0 3.444 0 12.264 0 15.2 0 18.12 0 21.084 0
		 24.008 0;
createNode animCurveTL -n "ctrl_Hips_translateY";
	rename -uid "72AB9B46-4BD8-4789-0E21-C192D2D08CE7";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 9 ".ktv[0:8]"  1 -0.022771457246090421 3.444 -0.022680246805152859
		 6.396 0.00082852369290620015 9.308 -0.0002991458563204236 12.264 -0.022771457246090421
		 15.2 -0.022162610774871656 18.12 0.00082852369290620015 21.084 -0.022680246805152859
		 24.008 -0.022771457246090421;
createNode animCurveTL -n "ctrl_Hips_translateZ";
	rename -uid "6B46A486-4ED4-9CDF-F375-A5A831438E2F";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 7 ".ktv[0:6]"  1 0 3.444 0 12.264 0 15.2 0 18.12 0 21.084 0
		 24.008 0;
createNode animCurveTA -n "ctrl_Hips_rotateX";
	rename -uid "7A90E55F-421C-1C68-15EF-568FD02C319A";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 8 ".ktv[0:7]"  1 3.5763560353200368 3.444 3.5094366056378017
		 9.308 3.5179501517361795 12.264 3.5903644451984835 15.2 3.5010503332023131 18.12 3.5
		 21.084 3.5094366056378017 24.008 3.5763560353200368;
createNode animCurveTA -n "ctrl_Hips_rotateY";
	rename -uid "55BFCDC4-4923-5500-7886-E985C138A29C";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 8 ".ktv[0:7]"  1 11.853330787203307 3.444 4.2000394930445086
		 9.308 -5.7365625215273708 12.264 -12.873815441176369 15.2 -1.4026278865065829 18.12 0
		 21.084 4.2000394930445086 24.008 11.853330787203307;
createNode animCurveTA -n "ctrl_Hips_rotateZ";
	rename -uid "1C80648F-4C66-184A-C332-D69AACB61B18";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 8 ".ktv[0:7]"  1 0.73552402135822414 3.444 0.25734740567195297
		 9.308 -0.35131573817085227 12.264 -0.80094632130989518 15.2 -0.085805570298137138
		 18.12 0 21.084 0.25734740567195297 24.008 0.73552402135822414;
createNode animCurveTU -n "ctrl_Hips_visibility";
	rename -uid "15D3AE75-4F94-AEBA-DEF0-6E8B2C712ADB";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 7 ".ktv[0:6]"  1 1 3.444 1 12.264 1 15.2 1 18.12 1 21.084 1
		 24.008 1;
createNode animCurveTU -n "jnt_L_Shoulder_scaleX";
	rename -uid "850052B3-477B-BF9E-08BF-248FAE754E58";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Shoulder_scaleY";
	rename -uid "D9B510A5-4845-752D-2CC2-69B686ED271F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Shoulder_scaleZ";
	rename -uid "5421872C-4068-AA7F-C417-6692B65C5171";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Shoulder_visibility";
	rename -uid "A84817FE-455A-079E-0789-C2901E023F62";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Shoulder_translateX";
	rename -uid "2A12F88F-4BB9-81BC-34BA-84A6E30C16F5";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.034622448645310153 2 0.034622448645310153
		 3 0.034622448645310153 4 0.034622448645310153 5 0.034622448645310153 6 0.034622448645310153
		 7 0.034622448645310153 8 0.034622448645310153 9 0.034622448645310153 10 0.034622448645310153
		 11 0.034622448645310153 12 0.034622448645310153 13 0.034622448645310153 14 0.034622448645310153
		 15 0.034622448645310153 16 0.034622448645310153 17 0.034622448645310153 18 0.034622448645310153
		 19 0.034622448645310153 20 0.034622448645310153 21 0.034622448645310153 22 0.034622448645310153
		 23 0.034622448645310153;
createNode animCurveTL -n "jnt_L_Shoulder_translateY";
	rename -uid "513E30B8-4040-6EE6-8C99-E69178CAF62E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.011373733159258772 2 -0.011373733159258772
		 3 -0.011373733159258772 4 -0.011373733159258772 5 -0.011373733159258772 6 -0.011373733159258772
		 7 -0.011373733159258772 8 -0.011373733159258772 9 -0.011373733159258772 10 -0.011373733159258772
		 11 -0.011373733159258772 12 -0.011373733159258772 13 -0.011373733159258772 14 -0.011373733159258772
		 15 -0.011373733159258772 16 -0.011373733159258772 17 -0.011373733159258772 18 -0.011373733159258772
		 19 -0.011373733159258772 20 -0.011373733159258772 21 -0.011373733159258772 22 -0.011373733159258772
		 23 -0.011373733159258772;
createNode animCurveTL -n "jnt_L_Shoulder_translateZ";
	rename -uid "A87C4755-43B4-762B-02B2-0280EEE85F48";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.12009215802351315 2 -0.12009215802351315
		 3 -0.12009215802351315 4 -0.12009215802351315 5 -0.12009215802351315 6 -0.12009215802351315
		 7 -0.12009215802351315 8 -0.12009215802351315 9 -0.12009215802351315 10 -0.12009215802351315
		 11 -0.12009215802351315 12 -0.12009215802351315 13 -0.12009215802351315 14 -0.12009215802351315
		 15 -0.12009215802351315 16 -0.12009215802351315 17 -0.12009215802351315 18 -0.12009215802351315
		 19 -0.12009215802351315 20 -0.12009215802351315 21 -0.12009215802351315 22 -0.12009215802351315
		 23 -0.12009215802351315;
createNode animCurveTA -n "jnt_L_Shoulder_rotateX";
	rename -uid "68F08F9F-4B22-8499-16B6-6A8E4004C30D";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 76.134910511699886 2 76.134910511699886
		 3 76.134910511699886 4 76.134910511699886 5 76.134910511699886 6 76.134910511699886
		 7 76.134910511699886 8 76.134910511699886 9 76.134910511699886 10 76.134910511699886
		 11 76.134910511699886 12 76.134910511699886 13 76.134910511699886 14 76.134910511699886
		 15 76.134910511699886 16 76.134910511699886 17 76.134910511699886 18 76.134910511699886
		 19 76.134910511699886 20 76.134910511699886 21 76.134910511699886 22 76.134910511699886
		 23 76.134910511699886;
createNode animCurveTA -n "jnt_L_Shoulder_rotateY";
	rename -uid "65023842-4792-193F-25C1-529B40D618BD";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -8.2172112831147963 2 -8.2172112831147963
		 3 -8.2172112831147963 4 -8.2172112831147963 5 -8.2172112831147963 6 -8.2172112831147963
		 7 -8.2172112831147963 8 -8.2172112831147963 9 -8.2172112831147963 10 -8.2172112831147963
		 11 -8.2172112831147963 12 -8.2172112831147963 13 -8.2172112831147963 14 -8.2172112831147963
		 15 -8.2172112831147963 16 -8.2172112831147963 17 -8.2172112831147963 18 -8.2172112831147963
		 19 -8.2172112831147963 20 -8.2172112831147963 21 -8.2172112831147963 22 -8.2172112831147963
		 23 -8.2172112831147963;
createNode animCurveTA -n "jnt_L_Shoulder_rotateZ";
	rename -uid "89CCE03A-4D7D-FE7F-94CF-CEBF8501AFCA";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -63.990426319873762 2 -63.990426319873762
		 3 -63.990426319873762 4 -63.990426319873762 5 -63.990426319873762 6 -63.990426319873762
		 7 -63.990426319873762 8 -63.990426319873762 9 -63.990426319873762 10 -63.990426319873762
		 11 -63.990426319873762 12 -63.990426319873762 13 -63.990426319873762 14 -63.990426319873762
		 15 -63.990426319873762 16 -63.990426319873762 17 -63.990426319873762 18 -63.990426319873762
		 19 -63.990426319873762 20 -63.990426319873762 21 -63.990426319873762 22 -63.990426319873762
		 23 -63.990426319873762;
createNode animCurveTU -n "jnt_L_Elbow_scaleX";
	rename -uid "438BF6A3-48B4-68D6-7208-84BF13B95898";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Elbow_scaleY";
	rename -uid "C54E51FB-4093-9E5A-6A53-08A83FDC0054";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Elbow_scaleZ";
	rename -uid "980990B2-463C-39F9-E0BB-D6BA44CF5A3A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Elbow_visibility";
	rename -uid "FB0427DE-4BCE-42DD-4ABF-879789236D27";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Elbow_translateX";
	rename -uid "A3A8C1FC-4514-A6BA-1DC2-0FACB40B0576";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.24230559142368027 2 0.24230559142368027
		 3 0.24230559142368027 4 0.24230559142368027 5 0.24230559142368027 6 0.24230559142368027
		 7 0.24230559142368027 8 0.24230559142368027 9 0.24230559142368027 10 0.24230559142368027
		 11 0.24230559142368027 12 0.24230559142368027 13 0.24230559142368027 14 0.24230559142368027
		 15 0.24230559142368027 16 0.24230559142368027 17 0.24230559142368027 18 0.24230559142368027
		 19 0.24230559142368027 20 0.24230559142368027 21 0.24230559142368027 22 0.24230559142368027
		 23 0.24230559142368027;
createNode animCurveTL -n "jnt_L_Elbow_translateY";
	rename -uid "4F1C4D54-4258-A656-52A0-2881BFAC4BE5";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.0027922251256531183 2 -0.0027922251256531183
		 3 -0.0027922251256531183 4 -0.0027922251256531183 5 -0.0027922251256531183 6 -0.0027922251256531183
		 7 -0.0027922251256531183 8 -0.0027922251256531183 9 -0.0027922251256531183 10 -0.0027922251256531183
		 11 -0.0027922251256531183 12 -0.0027922251256531183 13 -0.0027922251256531183 14 -0.0027922251256531183
		 15 -0.0027922251256531183 16 -0.0027922251256531183 17 -0.0027922251256531183 18 -0.0027922251256531183
		 19 -0.0027922251256531183 20 -0.0027922251256531183 21 -0.0027922251256531183 22 -0.0027922251256531183
		 23 -0.0027922251256531183;
createNode animCurveTL -n "jnt_L_Elbow_translateZ";
	rename -uid "9F8EF7C3-4215-94CF-7701-33AEE9D2208C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.005860847309894961 2 -0.005860847309894961
		 3 -0.005860847309894961 4 -0.005860847309894961 5 -0.005860847309894961 6 -0.005860847309894961
		 7 -0.005860847309894961 8 -0.005860847309894961 9 -0.005860847309894961 10 -0.005860847309894961
		 11 -0.005860847309894961 12 -0.005860847309894961 13 -0.005860847309894961 14 -0.005860847309894961
		 15 -0.005860847309894961 16 -0.005860847309894961 17 -0.005860847309894961 18 -0.005860847309894961
		 19 -0.005860847309894961 20 -0.005860847309894961 21 -0.005860847309894961 22 -0.005860847309894961
		 23 -0.005860847309894961;
createNode animCurveTA -n "jnt_L_Elbow_rotateX";
	rename -uid "06E4AA9D-4814-3196-AD3D-E8B08658E405";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.00012821624343797101 2 -0.00012821624343797101
		 3 -0.00012821624343797101 4 -0.00012821624343797101 5 -0.00012821624343797101 6 -0.00012821624343797101
		 7 -0.00012821624343797101 8 -0.00012821624343797101 9 -0.00012821624343797101 10 -0.00012821624343797101
		 11 -0.00012821624343797101 12 -0.00012821624343797101 13 -0.00012821624343797101
		 14 -0.00012821624343797101 15 -0.00012821624343797101 16 -0.00012821624343797101
		 17 -0.00012821624343797101 18 -0.00012821624343797101 19 -0.00012821624343797101
		 20 -0.00012821624343797101 21 -0.00012821624343797101 22 -0.00012821624343797101
		 23 -0.00012821624343797101;
createNode animCurveTA -n "jnt_L_Elbow_rotateY";
	rename -uid "6EAEC129-4186-8C94-5DF3-5788E50C9DD3";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -38.188670036611697 2 -38.188670036611697
		 3 -38.188670036611697 4 -38.188670036611697 5 -38.188670036611697 6 -38.188670036611697
		 7 -38.188670036611697 8 -38.188670036611697 9 -38.188670036611697 10 -38.188670036611697
		 11 -38.188670036611697 12 -38.188670036611697 13 -38.188670036611697 14 -38.188670036611697
		 15 -38.188670036611697 16 -38.188670036611697 17 -38.188670036611697 18 -38.188670036611697
		 19 -38.188670036611697 20 -38.188670036611697 21 -38.188670036611697 22 -38.188670036611697
		 23 -38.188670036611697;
createNode animCurveTA -n "jnt_L_Elbow_rotateZ";
	rename -uid "DC10800A-4C84-AA89-9C82-A0BA89FEEBC0";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 17.724671387247049 2 17.724671387247049
		 3 17.724671387247049 4 17.724671387247049 5 17.724671387247049 6 17.724671387247049
		 7 17.724671387247049 8 17.724671387247049 9 17.724671387247049 10 17.724671387247049
		 11 17.724671387247049 12 17.724671387247049 13 17.724671387247049 14 17.724671387247049
		 15 17.724671387247049 16 17.724671387247049 17 17.724671387247049 18 17.724671387247049
		 19 17.724671387247049 20 17.724671387247049 21 17.724671387247049 22 17.724671387247049
		 23 17.724671387247049;
createNode animCurveTA -n "jnt_L_Forearm_rotateX";
	rename -uid "D5D17631-4705-34AE-4363-798F776B4571";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_L_Forearm_rotateY";
	rename -uid "B58A654F-44A2-96EC-FF66-C8BEBDA016D2";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_L_Forearm_rotateZ";
	rename -uid "684197AA-4625-3FF1-F5D9-A5984B6E1369";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_L_Forearm_scaleX";
	rename -uid "B7499C69-4C84-CF4C-C314-A2B8900D8793";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Forearm_scaleY";
	rename -uid "109DC04B-4169-6BD0-112F-6699C9B97E6F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Forearm_scaleZ";
	rename -uid "87116FF1-4300-F330-F7E2-7E9243CDF0A9";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Forearm_translateX";
	rename -uid "19175DD2-4056-1C1D-0D3F-038FCE6BFA56";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.12007481108578688 2 0.12007481108578688
		 3 0.12007481108578688 4 0.12007481108578688 5 0.12007481108578688 6 0.12007481108578688
		 7 0.12007481108578688 8 0.12007481108578688 9 0.12007481108578688 10 0.12007481108578688
		 11 0.12007481108578688 12 0.12007481108578688 13 0.12007481108578688 14 0.12007481108578688
		 15 0.12007481108578688 16 0.12007481108578688 17 0.12007481108578688 18 0.12007481108578688
		 19 0.12007481108578688 20 0.12007481108578688 21 0.12007481108578688 22 0.12007481108578688
		 23 0.12007481108578688;
createNode animCurveTL -n "jnt_L_Forearm_translateY";
	rename -uid "367587F6-44FD-B83B-40DA-D3863CED4530";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.0012440890549179785 2 0.0012440890549179785
		 3 0.0012440890549179785 4 0.0012440890549179785 5 0.0012440890549179785 6 0.0012440890549179785
		 7 0.0012440890549179785 8 0.0012440890549179785 9 0.0012440890549179785 10 0.0012440890549179785
		 11 0.0012440890549179785 12 0.0012440890549179785 13 0.0012440890549179785 14 0.0012440890549179785
		 15 0.0012440890549179785 16 0.0012440890549179785 17 0.0012440890549179785 18 0.0012440890549179785
		 19 0.0012440890549179785 20 0.0012440890549179785 21 0.0012440890549179785 22 0.0012440890549179785
		 23 0.0012440890549179785;
createNode animCurveTL -n "jnt_L_Forearm_translateZ";
	rename -uid "47DA6831-47DD-25D2-AE2A-1EB18C73434A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.0026819304938098523 2 0.0026819304938098523
		 3 0.0026819304938098523 4 0.0026819304938098523 5 0.0026819304938098523 6 0.0026819304938098523
		 7 0.0026819304938098523 8 0.0026819304938098523 9 0.0026819304938098523 10 0.0026819304938098523
		 11 0.0026819304938098523 12 0.0026819304938098523 13 0.0026819304938098523 14 0.0026819304938098523
		 15 0.0026819304938098523 16 0.0026819304938098523 17 0.0026819304938098523 18 0.0026819304938098523
		 19 0.0026819304938098523 20 0.0026819304938098523 21 0.0026819304938098523 22 0.0026819304938098523
		 23 0.0026819304938098523;
createNode animCurveTU -n "jnt_L_Forearm_visibility";
	rename -uid "459FCB87-4B85-A6D9-0946-79B93E5B598D";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Wrist_translateX";
	rename -uid "4942FE14-43BD-08F0-64C9-709CD852203A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.11539517101119735 2 0.11539517101119735
		 3 0.11539517101119735 4 0.11539517101119735 5 0.11539517101119735 6 0.11539517101119735
		 7 0.11539517101119735 8 0.11539517101119735 9 0.11539517101119735 10 0.11539517101119735
		 11 0.11539517101119735 12 0.11539517101119735 13 0.11539517101119735 14 0.11539517101119735
		 15 0.11539517101119735 16 0.11539517101119735 17 0.11539517101119735 18 0.11539517101119735
		 19 0.11539517101119735 20 0.11539517101119735 21 0.11539517101119735 22 0.11539517101119735
		 23 0.11539517101119735;
createNode animCurveTL -n "jnt_L_Wrist_translateY";
	rename -uid "F6DD6705-474D-0BCA-5DCA-14ACB05894F4";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.001196110183326698 2 0.001196110183326698
		 3 0.001196110183326698 4 0.001196110183326698 5 0.001196110183326698 6 0.001196110183326698
		 7 0.001196110183326698 8 0.001196110183326698 9 0.001196110183326698 10 0.001196110183326698
		 11 0.001196110183326698 12 0.001196110183326698 13 0.001196110183326698 14 0.001196110183326698
		 15 0.001196110183326698 16 0.001196110183326698 17 0.001196110183326698 18 0.001196110183326698
		 19 0.001196110183326698 20 0.001196110183326698 21 0.001196110183326698 22 0.001196110183326698
		 23 0.001196110183326698;
createNode animCurveTL -n "jnt_L_Wrist_translateZ";
	rename -uid "4AEF9ACD-4810-93D5-0B80-749ABB5D40CE";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.0025773012613432887 2 0.0025773012613432887
		 3 0.0025773012613432887 4 0.0025773012613432887 5 0.0025773012613432887 6 0.0025773012613432887
		 7 0.0025773012613432887 8 0.0025773012613432887 9 0.0025773012613432887 10 0.0025773012613432887
		 11 0.0025773012613432887 12 0.0025773012613432887 13 0.0025773012613432887 14 0.0025773012613432887
		 15 0.0025773012613432887 16 0.0025773012613432887 17 0.0025773012613432887 18 0.0025773012613432887
		 19 0.0025773012613432887 20 0.0025773012613432887 21 0.0025773012613432887 22 0.0025773012613432887
		 23 0.0025773012613432887;
createNode animCurveTA -n "jnt_L_Wrist_rotateX";
	rename -uid "DAEA4A45-4A45-BB6B-BDD0-97BE35EA471D";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -76.366447397149244 2 -79.448079960491839
		 3 -82.513623054347249 4 -84.912733370195895 5 -87.183986126607209 6 -89.638608178303784
		 7 -92.589062965283617 8 -96.329016885197348 9 -100.41021564367709 10 -104.76832295842806
		 11 -109.16670538803568 12 -111.38564936231458 13 -109.54455755889055 14 -104.18446637118447
		 15 -98.190566326084635 16 -94.383768790103787 17 -92.036003899797464 18 -90.074146953749135
		 19 -87.988051672532094 20 -85.9879206228551 21 -83.911429028348991 22 -81.538135965396108
		 23 -78.921213280009837;
createNode animCurveTA -n "jnt_L_Wrist_rotateY";
	rename -uid "2DDA82FA-4AF6-4046-68C2-15854173B097";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 7.9848103150518943 2 10.465707200394959
		 3 12.545082529952964 4 13.915492189842082 5 14.935217605499826 6 15.675445017575655
		 7 16.025062290449082 8 15.631097568096402 9 14.234566609639971 10 11.860486101221007
		 11 8.8259329795803403 12 6.8500530395407893 13 7.9499528808379685 14 11.092807602669644
		 15 13.618033920127251 16 14.8108548126273 17 15.41477715296339 18 15.571183535784357
		 19 15.14730093443238 20 14.410756619553615 21 13.367019400176527 22 11.92327005133855
		 23 10.087142122219184;
createNode animCurveTA -n "jnt_L_Wrist_rotateZ";
	rename -uid "2702303C-430E-CF98-3722-9380B132ED88";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 5.3007542915347683 2 2.8589695219203337
		 3 0.60866814819636994 4 -1.8147928416024901 5 -4.8497617348368678 6 -8.966027416714514
		 7 -14.967262995659231 8 -23.726759044050514 9 -33.665522739140286 10 -43.035356528825901
		 11 -50.134009938681132 12 -53.586337359534696 13 -52.479264864821253 14 -46.9739194929939
		 15 -38.245265609321635 16 -28.254508978326371 17 -18.815936810805947 18 -11.552561987347115
		 19 -6.9183113105192682 20 -3.5376755339742711 21 -0.99732595392650936 22 1.0868976029591801
		 23 3.0620791313338973;
createNode animCurveTU -n "jnt_L_Wrist_scaleX";
	rename -uid "00B1EB57-41E5-DFED-E589-4CB6DD9638E6";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Wrist_scaleY";
	rename -uid "64C807D2-4291-FA9F-E18C-0C95878B5410";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Wrist_scaleZ";
	rename -uid "4178A40C-4A03-0629-D301-BBAC3AF84D64";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Wrist_visibility";
	rename -uid "6BE135F0-4C8C-D180-77CC-1E9705726070";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTA -n "jnt_L_Thumb1_rotateX";
	rename -uid "98EFC801-4676-D0C0-ED79-05A54C138197";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 22.5 2 22.5 3 22.5 4 22.5 5 22.5 6 22.5
		 7 22.5 8 22.5 9 22.5 10 22.5 11 22.5 12 22.5 13 22.5 14 22.5 15 22.5 16 22.5 17 22.5
		 18 22.5 19 22.5 20 22.5 21 22.5 22 22.5 23 22.5;
createNode animCurveTA -n "jnt_L_Thumb1_rotateY";
	rename -uid "33C30FAE-42CE-859F-F8F5-F481BEE96F47";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 19 2 19 3 19 4 19 5 19 6 19 7 19 8 19
		 9 19 10 19 11 19 12 19 13 19 14 19 15 19 16 19 17 19 18 19 19 19 20 19 21 19 22 19
		 23 19;
createNode animCurveTA -n "jnt_L_Thumb1_rotateZ";
	rename -uid "1EEE7943-4DF3-BA1D-2321-2CA5994224B6";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -7.4999999999999991 2 -7.4999999999999991
		 3 -7.4999999999999991 4 -7.4999999999999991 5 -7.4999999999999991 6 -7.4999999999999991
		 7 -7.4999999999999991 8 -7.4999999999999991 9 -7.4999999999999991 10 -7.4999999999999991
		 11 -7.4999999999999991 12 -7.4999999999999991 13 -7.4999999999999991 14 -7.4999999999999991
		 15 -7.4999999999999991 16 -7.4999999999999991 17 -7.4999999999999991 18 -7.4999999999999991
		 19 -7.4999999999999991 20 -7.4999999999999991 21 -7.4999999999999991 22 -7.4999999999999991
		 23 -7.4999999999999991;
createNode animCurveTU -n "jnt_L_Thumb1_scaleX";
	rename -uid "44C02CAD-443A-6078-4591-CD9647DBE2EA";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Thumb1_scaleY";
	rename -uid "95C4D52B-4A7A-10DD-588B-57B28A43DD81";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Thumb1_scaleZ";
	rename -uid "1AED2989-45F6-3F29-C882-D9BEBF10DD59";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Thumb1_visibility";
	rename -uid "45470EE6-495D-C67D-CA90-799FD9ED0268";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Thumb1_translateX";
	rename -uid "40213045-4068-C2C4-48A7-AA8C5215AF1C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.030807648161166414 2 0.030807648161166414
		 3 0.030807648161166414 4 0.030807648161166414 5 0.030807648161166414 6 0.030807648161166414
		 7 0.030807648161166414 8 0.030807648161166414 9 0.030807648161166414 10 0.030807648161166414
		 11 0.030807648161166414 12 0.030807648161166414 13 0.030807648161166414 14 0.030807648161166414
		 15 0.030807648161166414 16 0.030807648161166414 17 0.030807648161166414 18 0.030807648161166414
		 19 0.030807648161166414 20 0.030807648161166414 21 0.030807648161166414 22 0.030807648161166414
		 23 0.030807648161166414;
createNode animCurveTL -n "jnt_L_Thumb1_translateY";
	rename -uid "0F32D635-4C6A-BB10-A29C-61ACDF06F737";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.0019202003576792492 2 -0.0019202003576792492
		 3 -0.0019202003576792492 4 -0.0019202003576792492 5 -0.0019202003576792492 6 -0.0019202003576792492
		 7 -0.0019202003576792492 8 -0.0019202003576792492 9 -0.0019202003576792492 10 -0.0019202003576792492
		 11 -0.0019202003576792492 12 -0.0019202003576792492 13 -0.0019202003576792492 14 -0.0019202003576792492
		 15 -0.0019202003576792492 16 -0.0019202003576792492 17 -0.0019202003576792492 18 -0.0019202003576792492
		 19 -0.0019202003576792492 20 -0.0019202003576792492 21 -0.0019202003576792492 22 -0.0019202003576792492
		 23 -0.0019202003576792492;
createNode animCurveTL -n "jnt_L_Thumb1_translateZ";
	rename -uid "ACE66119-4170-2EDF-7A34-B3AE5E7E36D8";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.01904635008645688 2 0.01904635008645688
		 3 0.01904635008645688 4 0.01904635008645688 5 0.01904635008645688 6 0.01904635008645688
		 7 0.01904635008645688 8 0.01904635008645688 9 0.01904635008645688 10 0.01904635008645688
		 11 0.01904635008645688 12 0.01904635008645688 13 0.01904635008645688 14 0.01904635008645688
		 15 0.01904635008645688 16 0.01904635008645688 17 0.01904635008645688 18 0.01904635008645688
		 19 0.01904635008645688 20 0.01904635008645688 21 0.01904635008645688 22 0.01904635008645688
		 23 0.01904635008645688;
createNode animCurveTA -n "jnt_L_Thumb2_rotateX";
	rename -uid "CA329925-40B2-7D62-9F4A-D6AC386C32AE";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 2.511585363252911 2 2.511585363252911
		 3 2.511585363252911 4 2.511585363252911 5 2.511585363252911 6 2.511585363252911 7 2.511585363252911
		 8 2.511585363252911 9 2.511585363252911 10 2.511585363252911 11 2.511585363252911
		 12 2.511585363252911 13 2.511585363252911 14 2.511585363252911 15 2.511585363252911
		 16 2.511585363252911 17 2.511585363252911 18 2.511585363252911 19 2.511585363252911
		 20 2.511585363252911 21 2.511585363252911 22 2.511585363252911 23 2.511585363252911;
createNode animCurveTA -n "jnt_L_Thumb2_rotateY";
	rename -uid "9C4ED386-4F5D-3383-9680-7D8C02BBED8B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -15.316028903331203 2 -15.316028903331203
		 3 -15.316028903331203 4 -15.316028903331203 5 -15.316028903331203 6 -15.316028903331203
		 7 -15.316028903331203 8 -15.316028903331203 9 -15.316028903331203 10 -15.316028903331203
		 11 -15.316028903331203 12 -15.316028903331203 13 -15.316028903331203 14 -15.316028903331203
		 15 -15.316028903331203 16 -15.316028903331203 17 -15.316028903331203 18 -15.316028903331203
		 19 -15.316028903331203 20 -15.316028903331203 21 -15.316028903331203 22 -15.316028903331203
		 23 -15.316028903331203;
createNode animCurveTA -n "jnt_L_Thumb2_rotateZ";
	rename -uid "A33EA1A7-4652-5377-5567-D7B20FEEA017";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -46.151595090924047 2 -46.151595090924047
		 3 -46.151595090924047 4 -46.151595090924047 5 -46.151595090924047 6 -46.151595090924047
		 7 -46.151595090924047 8 -46.151595090924047 9 -46.151595090924047 10 -46.151595090924047
		 11 -46.151595090924047 12 -46.151595090924047 13 -46.151595090924047 14 -46.151595090924047
		 15 -46.151595090924047 16 -46.151595090924047 17 -46.151595090924047 18 -46.151595090924047
		 19 -46.151595090924047 20 -46.151595090924047 21 -46.151595090924047 22 -46.151595090924047
		 23 -46.151595090924047;
createNode animCurveTU -n "jnt_L_Thumb2_scaleX";
	rename -uid "2075BB96-43B4-CF61-F6BC-34AE540C4BA8";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Thumb2_scaleY";
	rename -uid "967C8C6C-46B2-ADB9-BF4B-D2B5FF7FD033";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Thumb2_scaleZ";
	rename -uid "FAD6FC91-480B-E5B8-B702-1C95DBA093E7";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Thumb2_visibility";
	rename -uid "0242BC1D-4E3D-B4E1-8D41-00A08E792153";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Thumb2_translateX";
	rename -uid "0E97B6F1-4680-6C3D-D877-FCBA3CF4BB8B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.017136888196342039 2 0.017136888196342039
		 3 0.017136888196342039 4 0.017136888196342039 5 0.017136888196342039 6 0.017136888196342039
		 7 0.017136888196342039 8 0.017136888196342039 9 0.017136888196342039 10 0.017136888196342039
		 11 0.017136888196342039 12 0.017136888196342039 13 0.017136888196342039 14 0.017136888196342039
		 15 0.017136888196342039 16 0.017136888196342039 17 0.017136888196342039 18 0.017136888196342039
		 19 0.017136888196342039 20 0.017136888196342039 21 0.017136888196342039 22 0.017136888196342039
		 23 0.017136888196342039;
createNode animCurveTL -n "jnt_L_Thumb2_translateY";
	rename -uid "2B7E39FF-40AC-D536-C6D5-469C7D222951";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTL -n "jnt_L_Thumb2_translateZ";
	rename -uid "9832FEC3-4B2A-C736-4F37-CDA177A683A6";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.0038868950042105738 2 0.0038868950042105738
		 3 0.0038868950042105738 4 0.0038868950042105738 5 0.0038868950042105738 6 0.0038868950042105738
		 7 0.0038868950042105738 8 0.0038868950042105738 9 0.0038868950042105738 10 0.0038868950042105738
		 11 0.0038868950042105738 12 0.0038868950042105738 13 0.0038868950042105738 14 0.0038868950042105738
		 15 0.0038868950042105738 16 0.0038868950042105738 17 0.0038868950042105738 18 0.0038868950042105738
		 19 0.0038868950042105738 20 0.0038868950042105738 21 0.0038868950042105738 22 0.0038868950042105738
		 23 0.0038868950042105738;
createNode animCurveTA -n "jnt_L_Thumb3_rotateX";
	rename -uid "F61204CE-4130-ABB4-8EBB-529C47A16CAE";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -32.437083054984285 2 -32.437083054984285
		 3 -32.437083054984285 4 -32.437083054984285 5 -32.437083054984285 6 -32.437083054984285
		 7 -32.437083054984285 8 -32.437083054984285 9 -32.437083054984285 10 -32.437083054984285
		 11 -32.437083054984285 12 -32.437083054984285 13 -32.437083054984285 14 -32.437083054984285
		 15 -32.437083054984285 16 -32.437083054984285 17 -32.437083054984285 18 -32.437083054984285
		 19 -32.437083054984285 20 -32.437083054984285 21 -32.437083054984285 22 -32.437083054984285
		 23 -32.437083054984285;
createNode animCurveTA -n "jnt_L_Thumb3_rotateY";
	rename -uid "671DD357-4214-931A-B575-DD9C227D3467";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 16.909382412863984 2 16.909382412863984
		 3 16.909382412863984 4 16.909382412863984 5 16.909382412863984 6 16.909382412863984
		 7 16.909382412863984 8 16.909382412863984 9 16.909382412863984 10 16.909382412863984
		 11 16.909382412863984 12 16.909382412863984 13 16.909382412863984 14 16.909382412863984
		 15 16.909382412863984 16 16.909382412863984 17 16.909382412863984 18 16.909382412863984
		 19 16.909382412863984 20 16.909382412863984 21 16.909382412863984 22 16.909382412863984
		 23 16.909382412863984;
createNode animCurveTA -n "jnt_L_Thumb3_rotateZ";
	rename -uid "D1849A75-44F7-6B21-8836-EE9418B0C7D8";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.74644959473941053 2 -0.74644959473941053
		 3 -0.74644959473941053 4 -0.74644959473941053 5 -0.74644959473941053 6 -0.74644959473941053
		 7 -0.74644959473941053 8 -0.74644959473941053 9 -0.74644959473941053 10 -0.74644959473941053
		 11 -0.74644959473941053 12 -0.74644959473941053 13 -0.74644959473941053 14 -0.74644959473941053
		 15 -0.74644959473941053 16 -0.74644959473941053 17 -0.74644959473941053 18 -0.74644959473941053
		 19 -0.74644959473941053 20 -0.74644959473941053 21 -0.74644959473941053 22 -0.74644959473941053
		 23 -0.74644959473941053;
createNode animCurveTU -n "jnt_L_Thumb3_scaleX";
	rename -uid "7AFCE209-464D-83CA-6BC3-15BA80E856C3";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Thumb3_scaleY";
	rename -uid "FDDB88C0-4C24-887E-09FF-CBB6264A5DB2";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Thumb3_scaleZ";
	rename -uid "7675DC5B-43F8-845F-AEC2-CF80E23EDB5C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Thumb3_visibility";
	rename -uid "91AEE2A6-4CB6-9A15-EC78-3DB00C12E558";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Thumb3_translateX";
	rename -uid "11F518C7-4B9C-BE21-0F87-4EA9FFC9D200";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.018638225538618595 2 0.018638225538618595
		 3 0.018638225538618595 4 0.018638225538618595 5 0.018638225538618595 6 0.018638225538618595
		 7 0.018638225538618595 8 0.018638225538618595 9 0.018638225538618595 10 0.018638225538618595
		 11 0.018638225538618595 12 0.018638225538618595 13 0.018638225538618595 14 0.018638225538618595
		 15 0.018638225538618595 16 0.018638225538618595 17 0.018638225538618595 18 0.018638225538618595
		 19 0.018638225538618595 20 0.018638225538618595 21 0.018638225538618595 22 0.018638225538618595
		 23 0.018638225538618595;
createNode animCurveTL -n "jnt_L_Thumb3_translateY";
	rename -uid "05E19052-4E84-0403-DD97-6495E37DA710";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTL -n "jnt_L_Thumb3_translateZ";
	rename -uid "64836383-4FB7-9B02-7D8D-8A97515C4A33";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.0014141100716245933 2 -0.0014141100716245933
		 3 -0.0014141100716245933 4 -0.0014141100716245933 5 -0.0014141100716245933 6 -0.0014141100716245933
		 7 -0.0014141100716245933 8 -0.0014141100716245933 9 -0.0014141100716245933 10 -0.0014141100716245933
		 11 -0.0014141100716245933 12 -0.0014141100716245933 13 -0.0014141100716245933 14 -0.0014141100716245933
		 15 -0.0014141100716245933 16 -0.0014141100716245933 17 -0.0014141100716245933 18 -0.0014141100716245933
		 19 -0.0014141100716245933 20 -0.0014141100716245933 21 -0.0014141100716245933 22 -0.0014141100716245933
		 23 -0.0014141100716245933;
createNode animCurveTA -n "jnt_L_Thumb4_rotateX";
	rename -uid "092E1D7B-4262-D382-102E-C290E2215CCD";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -32.22702215334639 2 -32.22702215334639
		 3 -32.22702215334639 4 -32.22702215334639 5 -32.22702215334639 6 -32.22702215334639
		 7 -32.22702215334639 8 -32.22702215334639 9 -32.22702215334639 10 -32.22702215334639
		 11 -32.22702215334639 12 -32.22702215334639 13 -32.22702215334639 14 -32.22702215334639
		 15 -32.22702215334639 16 -32.22702215334639 17 -32.22702215334639 18 -32.22702215334639
		 19 -32.22702215334639 20 -32.22702215334639 21 -32.22702215334639 22 -32.22702215334639
		 23 -32.22702215334639;
createNode animCurveTA -n "jnt_L_Thumb4_rotateY";
	rename -uid "14783A41-4897-1B63-7C1C-F6BC01042EC6";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 15.777696367059802 2 15.777696367059802
		 3 15.777696367059802 4 15.777696367059802 5 15.777696367059802 6 15.777696367059802
		 7 15.777696367059802 8 15.777696367059802 9 15.777696367059802 10 15.777696367059802
		 11 15.777696367059802 12 15.777696367059802 13 15.777696367059802 14 15.777696367059802
		 15 15.777696367059802 16 15.777696367059802 17 15.777696367059802 18 15.777696367059802
		 19 15.777696367059802 20 15.777696367059802 21 15.777696367059802 22 15.777696367059802
		 23 15.777696367059802;
createNode animCurveTA -n "jnt_L_Thumb4_rotateZ";
	rename -uid "03ACEEED-4D7A-82BA-C456-60BCFB5F5461";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_L_Thumb4_visibility";
	rename -uid "529DE3C6-43D6-A3D8-8F1E-9197A89B0AD3";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Thumb4_translateX";
	rename -uid "369C5D20-40BD-927A-BCDA-5982CF01ECCC";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.016068203190070726 2 0.016068203190070726
		 3 0.016068203190070726 4 0.016068203190070726 5 0.016068203190070726 6 0.016068203190070726
		 7 0.016068203190070726 8 0.016068203190070726 9 0.016068203190070726 10 0.016068203190070726
		 11 0.016068203190070726 12 0.016068203190070726 13 0.016068203190070726 14 0.016068203190070726
		 15 0.016068203190070726 16 0.016068203190070726 17 0.016068203190070726 18 0.016068203190070726
		 19 0.016068203190070726 20 0.016068203190070726 21 0.016068203190070726 22 0.016068203190070726
		 23 0.016068203190070726;
createNode animCurveTL -n "jnt_L_Thumb4_translateY";
	rename -uid "F2E55BE4-4FD2-D995-C254-DAA996BC845B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTL -n "jnt_L_Thumb4_translateZ";
	rename -uid "6C53B558-480C-F180-760C-88AA162308F6";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 3.4416913763379853e-017 2 3.4416913763379853e-017
		 3 3.4416913763379853e-017 4 3.4416913763379853e-017 5 3.4416913763379853e-017 6 3.4416913763379853e-017
		 7 3.4416913763379853e-017 8 3.4416913763379853e-017 9 3.4416913763379853e-017 10 3.4416913763379853e-017
		 11 3.4416913763379853e-017 12 3.4416913763379853e-017 13 3.4416913763379853e-017
		 14 3.4416913763379853e-017 15 3.4416913763379853e-017 16 3.4416913763379853e-017
		 17 3.4416913763379853e-017 18 3.4416913763379853e-017 19 3.4416913763379853e-017
		 20 3.4416913763379853e-017 21 3.4416913763379853e-017 22 3.4416913763379853e-017
		 23 3.4416913763379853e-017;
createNode animCurveTU -n "jnt_L_Thumb4_scaleX";
	rename -uid "A88A0DF3-4D2F-17E2-EA86-53965969D715";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Thumb4_scaleY";
	rename -uid "9122F031-48AA-4100-7E27-25BA8D6920BB";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Thumb4_scaleZ";
	rename -uid "9DB3A033-4996-DC04-F80C-BFB1472736EB";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTA -n "jnt_L_Index1_rotateZ";
	rename -uid "33F2DB8A-47C6-BFCC-CCAD-2DB0C1C0AF54";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_L_Index1_rotateX";
	rename -uid "C8F2E827-485B-D834-CA08-9B8EE0AC7FD2";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_L_Index1_rotateY";
	rename -uid "3DCCBB5C-43DD-4C4D-C44B-EDBC3CD28967";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_L_Index1_scaleX";
	rename -uid "71B69E95-40DE-FE7A-1948-54A8C8D90853";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Index1_scaleY";
	rename -uid "6D1F6D6B-4F04-D5D2-B971-DBB597FD7E38";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Index1_scaleZ";
	rename -uid "49E194C9-4624-AAA7-D1FB-8496383C17C1";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Index1_visibility";
	rename -uid "9B745562-4AB9-77F9-DACB-BD9A3DDE52C4";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Index1_translateX";
	rename -uid "B60720B2-427E-B456-32FB-3D918313C1A3";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.07293666093518375 2 0.07293666093518375
		 3 0.07293666093518375 4 0.07293666093518375 5 0.07293666093518375 6 0.07293666093518375
		 7 0.07293666093518375 8 0.07293666093518375 9 0.07293666093518375 10 0.07293666093518375
		 11 0.07293666093518375 12 0.07293666093518375 13 0.07293666093518375 14 0.07293666093518375
		 15 0.07293666093518375 16 0.07293666093518375 17 0.07293666093518375 18 0.07293666093518375
		 19 0.07293666093518375 20 0.07293666093518375 21 0.07293666093518375 22 0.07293666093518375
		 23 0.07293666093518375;
createNode animCurveTL -n "jnt_L_Index1_translateY";
	rename -uid "4B4F13C8-4909-706F-3593-9784F3BFF04E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.0019202003576792492 2 -0.0019202003576792492
		 3 -0.0019202003576792492 4 -0.0019202003576792492 5 -0.0019202003576792492 6 -0.0019202003576792492
		 7 -0.0019202003576792492 8 -0.0019202003576792492 9 -0.0019202003576792492 10 -0.0019202003576792492
		 11 -0.0019202003576792492 12 -0.0019202003576792492 13 -0.0019202003576792492 14 -0.0019202003576792492
		 15 -0.0019202003576792492 16 -0.0019202003576792492 17 -0.0019202003576792492 18 -0.0019202003576792492
		 19 -0.0019202003576792492 20 -0.0019202003576792492 21 -0.0019202003576792492 22 -0.0019202003576792492
		 23 -0.0019202003576792492;
createNode animCurveTL -n "jnt_L_Index1_translateZ";
	rename -uid "E784A363-46C2-A302-86CE-7A99DCEC5B68";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.014757767947784457 2 0.014757767947784457
		 3 0.014757767947784457 4 0.014757767947784457 5 0.014757767947784457 6 0.014757767947784457
		 7 0.014757767947784457 8 0.014757767947784457 9 0.014757767947784457 10 0.014757767947784457
		 11 0.014757767947784457 12 0.014757767947784457 13 0.014757767947784457 14 0.014757767947784457
		 15 0.014757767947784457 16 0.014757767947784457 17 0.014757767947784457 18 0.014757767947784457
		 19 0.014757767947784457 20 0.014757767947784457 21 0.014757767947784457 22 0.014757767947784457
		 23 0.014757767947784457;
createNode animCurveTA -n "jnt_L_Index2_rotateZ";
	rename -uid "39AFBDD5-4E28-42B9-5DE5-08967D38E5A4";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_L_Index2_rotateX";
	rename -uid "920E1048-40ED-71E3-E226-73B0BE2BAE61";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_L_Index2_rotateY";
	rename -uid "283B71EB-4C02-3F91-56EB-67B6B905109C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_L_Index2_scaleX";
	rename -uid "0503EED3-4A61-AEE2-BA16-67B2F8D8A4C3";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Index2_scaleY";
	rename -uid "3CA3B509-4A8D-A4FE-0D97-2EACA6686829";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Index2_scaleZ";
	rename -uid "3A209D1E-4916-8148-6BFE-9191A254FFCB";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Index2_visibility";
	rename -uid "00193ADD-49B9-0A5C-9496-0B96D907C7E9";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Index2_translateX";
	rename -uid "45DF3FA2-4D7E-8816-D5E2-8DA4CDA3F25B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.018921897039849797 2 0.018921897039849797
		 3 0.018921897039849797 4 0.018921897039849797 5 0.018921897039849797 6 0.018921897039849797
		 7 0.018921897039849797 8 0.018921897039849797 9 0.018921897039849797 10 0.018921897039849797
		 11 0.018921897039849797 12 0.018921897039849797 13 0.018921897039849797 14 0.018921897039849797
		 15 0.018921897039849797 16 0.018921897039849797 17 0.018921897039849797 18 0.018921897039849797
		 19 0.018921897039849797 20 0.018921897039849797 21 0.018921897039849797 22 0.018921897039849797
		 23 0.018921897039849797;
createNode animCurveTL -n "jnt_L_Index2_translateY";
	rename -uid "410AB269-4707-9AD9-9B71-BCA239452B52";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTL -n "jnt_L_Index2_translateZ";
	rename -uid "C8AB9D43-4585-A6C4-641A-6AB9BF8336D2";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 3.0878077872387168e-017 2 3.0878077872387168e-017
		 3 3.0878077872387168e-017 4 3.0878077872387168e-017 5 3.0878077872387168e-017 6 3.0878077872387168e-017
		 7 3.0878077872387168e-017 8 3.0878077872387168e-017 9 3.0878077872387168e-017 10 3.0878077872387168e-017
		 11 3.0878077872387168e-017 12 3.0878077872387168e-017 13 3.0878077872387168e-017
		 14 3.0878077872387168e-017 15 3.0878077872387168e-017 16 3.0878077872387168e-017
		 17 3.0878077872387168e-017 18 3.0878077872387168e-017 19 3.0878077872387168e-017
		 20 3.0878077872387168e-017 21 3.0878077872387168e-017 22 3.0878077872387168e-017
		 23 3.0878077872387168e-017;
createNode animCurveTA -n "jnt_L_Index3_rotateZ";
	rename -uid "02C1DA90-4B37-97D8-72FA-D28A5AD39C37";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_L_Index3_rotateX";
	rename -uid "A67D2A73-42F7-DF41-F1AC-9B8E196C8119";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_L_Index3_rotateY";
	rename -uid "98EE9D79-494F-09DC-DDC6-51A2B30E4F67";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_L_Index3_scaleX";
	rename -uid "98FB56D7-41A9-BA1C-06E5-0FA3E191427A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Index3_scaleY";
	rename -uid "75D06DDF-4A9B-9D52-5696-60AACBC80306";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Index3_scaleZ";
	rename -uid "D5E33BAF-435A-502C-2067-5C8CD50EDBC2";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Index3_visibility";
	rename -uid "AC9D2751-452B-8619-FFB6-579F2484023E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Index3_translateX";
	rename -uid "3CCDDC08-4354-A484-FD6E-EB8309BEC4BE";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.019426392437624444 2 0.019426392437624444
		 3 0.019426392437624444 4 0.019426392437624444 5 0.019426392437624444 6 0.019426392437624444
		 7 0.019426392437624444 8 0.019426392437624444 9 0.019426392437624444 10 0.019426392437624444
		 11 0.019426392437624444 12 0.019426392437624444 13 0.019426392437624444 14 0.019426392437624444
		 15 0.019426392437624444 16 0.019426392437624444 17 0.019426392437624444 18 0.019426392437624444
		 19 0.019426392437624444 20 0.019426392437624444 21 0.019426392437624444 22 0.019426392437624444
		 23 0.019426392437624444;
createNode animCurveTL -n "jnt_L_Index3_translateY";
	rename -uid "FECF3152-4D7B-D668-730D-839AD19CD76B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTL -n "jnt_L_Index3_translateZ";
	rename -uid "ED6DF7B8-4351-FB16-072E-BE84F4B07EAF";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -2.3928775627624077e-016 2 -2.3928775627624077e-016
		 3 -2.3928775627624077e-016 4 -2.3928775627624077e-016 5 -2.3928775627624077e-016
		 6 -2.3928775627624077e-016 7 -2.3928775627624077e-016 8 -2.3928775627624077e-016
		 9 -2.3928775627624077e-016 10 -2.3928775627624077e-016 11 -2.3928775627624077e-016
		 12 -2.3928775627624077e-016 13 -2.3928775627624077e-016 14 -2.3928775627624077e-016
		 15 -2.3928775627624077e-016 16 -2.3928775627624077e-016 17 -2.3928775627624077e-016
		 18 -2.3928775627624077e-016 19 -2.3928775627624077e-016 20 -2.3928775627624077e-016
		 21 -2.3928775627624077e-016 22 -2.3928775627624077e-016 23 -2.3928775627624077e-016;
createNode animCurveTA -n "jnt_L_Index4_rotateZ";
	rename -uid "06A7EF94-4764-F755-5305-5C86AFEE0BBA";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_L_Index4_rotateX";
	rename -uid "77013A11-4882-DB08-8F8D-37B38381735B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_L_Index4_rotateY";
	rename -uid "2CE3E678-43B2-6A1C-3D90-EF861380DA52";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_L_Index4_visibility";
	rename -uid "BCBEFB69-4322-0253-6317-C6B90BAC6337";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Index4_translateX";
	rename -uid "D032B56C-4753-0B28-8B40-58869C781C94";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.013372665180680308 2 0.013372665180680308
		 3 0.013372665180680308 4 0.013372665180680308 5 0.013372665180680308 6 0.013372665180680308
		 7 0.013372665180680308 8 0.013372665180680308 9 0.013372665180680308 10 0.013372665180680308
		 11 0.013372665180680308 12 0.013372665180680308 13 0.013372665180680308 14 0.013372665180680308
		 15 0.013372665180680308 16 0.013372665180680308 17 0.013372665180680308 18 0.013372665180680308
		 19 0.013372665180680308 20 0.013372665180680308 21 0.013372665180680308 22 0.013372665180680308
		 23 0.013372665180680308;
createNode animCurveTL -n "jnt_L_Index4_translateY";
	rename -uid "1072A48F-4428-D41C-410A-6BBBFB01F1DF";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTL -n "jnt_L_Index4_translateZ";
	rename -uid "04C21CB4-4828-73E0-CABE-4D948B54AFDE";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 7.1193051454088162e-017 2 7.1193051454088162e-017
		 3 7.1193051454088162e-017 4 7.1193051454088162e-017 5 7.1193051454088162e-017 6 7.1193051454088162e-017
		 7 7.1193051454088162e-017 8 7.1193051454088162e-017 9 7.1193051454088162e-017 10 7.1193051454088162e-017
		 11 7.1193051454088162e-017 12 7.1193051454088162e-017 13 7.1193051454088162e-017
		 14 7.1193051454088162e-017 15 7.1193051454088162e-017 16 7.1193051454088162e-017
		 17 7.1193051454088162e-017 18 7.1193051454088162e-017 19 7.1193051454088162e-017
		 20 7.1193051454088162e-017 21 7.1193051454088162e-017 22 7.1193051454088162e-017
		 23 7.1193051454088162e-017;
createNode animCurveTU -n "jnt_L_Index4_scaleX";
	rename -uid "52D28D89-4AEE-51FD-468D-F28C471FA059";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Index4_scaleY";
	rename -uid "AC3AA7FC-482F-9635-FDFC-E4AC10C1A29B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Index4_scaleZ";
	rename -uid "AF58622F-43F8-C6AC-5091-3492487762AD";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTA -n "jnt_L_Middle1_rotateZ";
	rename -uid "15687FCB-42EB-B0D0-DB8B-19BA71842648";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_L_Middle1_rotateX";
	rename -uid "ABAA6A5D-4E02-E7F7-AF3B-2493DD463533";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_L_Middle1_rotateY";
	rename -uid "1BCAEBD2-4E53-05E5-F094-BCAB7F949160";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_L_Middle1_scaleX";
	rename -uid "1493299A-446D-C995-3102-86A75716C3AB";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Middle1_scaleY";
	rename -uid "F92FE765-4EC6-14DF-502A-0CB11B13021C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Middle1_scaleZ";
	rename -uid "F4C75970-42F2-97B5-2458-D396337E301A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Middle1_visibility";
	rename -uid "1FCB3565-43E2-703A-9BE4-9D9F70AB18B8";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Middle1_translateX";
	rename -uid "24BBAB2C-4986-9E2A-972D-B3A19D5E2E17";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.078738860299270005 2 0.078738860299270005
		 3 0.078738860299270005 4 0.078738860299270005 5 0.078738860299270005 6 0.078738860299270005
		 7 0.078738860299270005 8 0.078738860299270005 9 0.078738860299270005 10 0.078738860299270005
		 11 0.078738860299270005 12 0.078738860299270005 13 0.078738860299270005 14 0.078738860299270005
		 15 0.078738860299270005 16 0.078738860299270005 17 0.078738860299270005 18 0.078738860299270005
		 19 0.078738860299270005 20 0.078738860299270005 21 0.078738860299270005 22 0.078738860299270005
		 23 0.078738860299270005;
createNode animCurveTL -n "jnt_L_Middle1_translateY";
	rename -uid "3C7A755D-43D1-CE10-E512-1F8AA9256C46";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.0019202003576792492 2 -0.0019202003576792492
		 3 -0.0019202003576792492 4 -0.0019202003576792492 5 -0.0019202003576792492 6 -0.0019202003576792492
		 7 -0.0019202003576792492 8 -0.0019202003576792492 9 -0.0019202003576792492 10 -0.0019202003576792492
		 11 -0.0019202003576792492 12 -0.0019202003576792492 13 -0.0019202003576792492 14 -0.0019202003576792492
		 15 -0.0019202003576792492 16 -0.0019202003576792492 17 -0.0019202003576792492 18 -0.0019202003576792492
		 19 -0.0019202003576792492 20 -0.0019202003576792492 21 -0.0019202003576792492 22 -0.0019202003576792492
		 23 -0.0019202003576792492;
createNode animCurveTL -n "jnt_L_Middle1_translateZ";
	rename -uid "B7411047-4A27-FC9C-025A-2A8D67D86B91";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.0021442910693361171 2 0.0021442910693361171
		 3 0.0021442910693361171 4 0.0021442910693361171 5 0.0021442910693361171 6 0.0021442910693361171
		 7 0.0021442910693361171 8 0.0021442910693361171 9 0.0021442910693361171 10 0.0021442910693361171
		 11 0.0021442910693361171 12 0.0021442910693361171 13 0.0021442910693361171 14 0.0021442910693361171
		 15 0.0021442910693361171 16 0.0021442910693361171 17 0.0021442910693361171 18 0.0021442910693361171
		 19 0.0021442910693361171 20 0.0021442910693361171 21 0.0021442910693361171 22 0.0021442910693361171
		 23 0.0021442910693361171;
createNode animCurveTA -n "jnt_L_Middle2_rotateZ";
	rename -uid "8A13BD36-4B88-4BA8-901E-65AC41557DBA";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_L_Middle2_rotateX";
	rename -uid "720A9860-4710-CA2D-C1FB-0FBCAA025442";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_L_Middle2_rotateY";
	rename -uid "817B4EF3-45A5-7DF5-AC8E-6ABE69797888";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_L_Middle2_scaleX";
	rename -uid "F64179B4-48BB-B233-2C9F-D78D4279FFD1";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Middle2_scaleY";
	rename -uid "5D227D68-42A5-5EE8-8D09-CB847979D965";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Middle2_scaleZ";
	rename -uid "6DA98578-4973-D39F-ECD0-D891727E11D1";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Middle2_visibility";
	rename -uid "19D45728-49F1-BC67-66EB-44A2E9CCC7BA";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Middle2_translateX";
	rename -uid "1E1F09A6-463F-8335-24FB-96B28EB8EF2F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.017200639120447697 2 0.017200639120447697
		 3 0.017200639120447697 4 0.017200639120447697 5 0.017200639120447697 6 0.017200639120447697
		 7 0.017200639120447697 8 0.017200639120447697 9 0.017200639120447697 10 0.017200639120447697
		 11 0.017200639120447697 12 0.017200639120447697 13 0.017200639120447697 14 0.017200639120447697
		 15 0.017200639120447697 16 0.017200639120447697 17 0.017200639120447697 18 0.017200639120447697
		 19 0.017200639120447697 20 0.017200639120447697 21 0.017200639120447697 22 0.017200639120447697
		 23 0.017200639120447697;
createNode animCurveTL -n "jnt_L_Middle2_translateY";
	rename -uid "F6C675E9-4756-4B17-DF4A-8DA68EF8E54B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTL -n "jnt_L_Middle2_translateZ";
	rename -uid "8010C7F2-4943-61A0-51DC-D2AE469D6511";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1.9151347174783952e-017 2 1.9151347174783952e-017
		 3 1.9151347174783952e-017 4 1.9151347174783952e-017 5 1.9151347174783952e-017 6 1.9151347174783952e-017
		 7 1.9151347174783952e-017 8 1.9151347174783952e-017 9 1.9151347174783952e-017 10 1.9151347174783952e-017
		 11 1.9151347174783952e-017 12 1.9151347174783952e-017 13 1.9151347174783952e-017
		 14 1.9151347174783952e-017 15 1.9151347174783952e-017 16 1.9151347174783952e-017
		 17 1.9151347174783952e-017 18 1.9151347174783952e-017 19 1.9151347174783952e-017
		 20 1.9151347174783952e-017 21 1.9151347174783952e-017 22 1.9151347174783952e-017
		 23 1.9151347174783952e-017;
createNode animCurveTA -n "jnt_L_Middle3_rotateZ";
	rename -uid "9556AE80-43A2-A5DC-0080-FFBD31C67879";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_L_Middle3_rotateX";
	rename -uid "71A24E7A-4FE6-077C-0A7B-5DAD14A613AA";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_L_Middle3_rotateY";
	rename -uid "EA80095A-42B5-1F4C-3348-138E27E03E83";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_L_Middle3_scaleX";
	rename -uid "6E1260D8-46A7-5E86-0B2A-5DA59F7BCEC4";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Middle3_scaleY";
	rename -uid "DECB3104-4880-BD9B-6AA0-2AA8B040BECE";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Middle3_scaleZ";
	rename -uid "557903DF-4463-7567-7890-CCBD0B87ABD0";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Middle3_visibility";
	rename -uid "DA0082C1-4B05-615D-2BF8-FA903F3574D9";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Middle3_translateX";
	rename -uid "B99DB876-481E-D662-5F51-D8AF91FCBD06";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.016657432256855616 2 0.016657432256855616
		 3 0.016657432256855616 4 0.016657432256855616 5 0.016657432256855616 6 0.016657432256855616
		 7 0.016657432256855616 8 0.016657432256855616 9 0.016657432256855616 10 0.016657432256855616
		 11 0.016657432256855616 12 0.016657432256855616 13 0.016657432256855616 14 0.016657432256855616
		 15 0.016657432256855616 16 0.016657432256855616 17 0.016657432256855616 18 0.016657432256855616
		 19 0.016657432256855616 20 0.016657432256855616 21 0.016657432256855616 22 0.016657432256855616
		 23 0.016657432256855616;
createNode animCurveTL -n "jnt_L_Middle3_translateY";
	rename -uid "F3489F23-41A4-7747-1DE4-4C938BA2EC84";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTL -n "jnt_L_Middle3_translateZ";
	rename -uid "BBDAF2FF-4724-11DE-9053-EE8D8698CBB7";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -3.5804692544161299e-017 2 -3.5804692544161299e-017
		 3 -3.5804692544161299e-017 4 -3.5804692544161299e-017 5 -3.5804692544161299e-017
		 6 -3.5804692544161299e-017 7 -3.5804692544161299e-017 8 -3.5804692544161299e-017
		 9 -3.5804692544161299e-017 10 -3.5804692544161299e-017 11 -3.5804692544161299e-017
		 12 -3.5804692544161299e-017 13 -3.5804692544161299e-017 14 -3.5804692544161299e-017
		 15 -3.5804692544161299e-017 16 -3.5804692544161299e-017 17 -3.5804692544161299e-017
		 18 -3.5804692544161299e-017 19 -3.5804692544161299e-017 20 -3.5804692544161299e-017
		 21 -3.5804692544161299e-017 22 -3.5804692544161299e-017 23 -3.5804692544161299e-017;
createNode animCurveTA -n "jnt_L_Middle4_rotateZ";
	rename -uid "9B47952F-4ACC-20CA-D3DC-FDBCF0B07752";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_L_Middle4_rotateX";
	rename -uid "D1234A5B-4176-28E5-8E85-EABB365C1901";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_L_Middle4_rotateY";
	rename -uid "5C23DAED-4FB2-7B4F-21B4-AE901298B4A1";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_L_Middle4_visibility";
	rename -uid "CDCF0F07-4E6A-8D53-9886-C4BB5F49E523";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Middle4_translateX";
	rename -uid "E8B0F166-4C17-A5DE-2D55-AFBC05DFDF0B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.018165158492277848 2 0.018165158492277848
		 3 0.018165158492277848 4 0.018165158492277848 5 0.018165158492277848 6 0.018165158492277848
		 7 0.018165158492277848 8 0.018165158492277848 9 0.018165158492277848 10 0.018165158492277848
		 11 0.018165158492277848 12 0.018165158492277848 13 0.018165158492277848 14 0.018165158492277848
		 15 0.018165158492277848 16 0.018165158492277848 17 0.018165158492277848 18 0.018165158492277848
		 19 0.018165158492277848 20 0.018165158492277848 21 0.018165158492277848 22 0.018165158492277848
		 23 0.018165158492277848;
createNode animCurveTL -n "jnt_L_Middle4_translateY";
	rename -uid "A30F7AD8-444F-AAAE-0202-268FB8A314DB";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTL -n "jnt_L_Middle4_translateZ";
	rename -uid "95C4C45B-4070-A7C9-4833-88B11E52663D";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -2.3106516700011071e-017 2 -2.3106516700011071e-017
		 3 -2.3106516700011071e-017 4 -2.3106516700011071e-017 5 -2.3106516700011071e-017
		 6 -2.3106516700011071e-017 7 -2.3106516700011071e-017 8 -2.3106516700011071e-017
		 9 -2.3106516700011071e-017 10 -2.3106516700011071e-017 11 -2.3106516700011071e-017
		 12 -2.3106516700011071e-017 13 -2.3106516700011071e-017 14 -2.3106516700011071e-017
		 15 -2.3106516700011071e-017 16 -2.3106516700011071e-017 17 -2.3106516700011071e-017
		 18 -2.3106516700011071e-017 19 -2.3106516700011071e-017 20 -2.3106516700011071e-017
		 21 -2.3106516700011071e-017 22 -2.3106516700011071e-017 23 -2.3106516700011071e-017;
createNode animCurveTU -n "jnt_L_Middle4_scaleX";
	rename -uid "EDD4B4FC-4FF3-E23C-519A-ECB4869FD916";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Middle4_scaleY";
	rename -uid "6E29A597-49D1-7293-7259-38B4757388F2";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Middle4_scaleZ";
	rename -uid "DED56CE9-4556-A524-FEB7-688085667F72";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTA -n "jnt_L_Ring1_rotateZ";
	rename -uid "CA492659-4E97-A8DD-7233-AA9BDE890CB6";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_L_Ring1_rotateX";
	rename -uid "611838B7-4539-234C-DD08-E7BF676033D5";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_L_Ring1_rotateY";
	rename -uid "28CA13F0-4062-44D8-4343-71AE523C814D";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_L_Ring1_scaleX";
	rename -uid "370551CF-4057-C989-2404-34B4A9E16A03";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Ring1_scaleY";
	rename -uid "0656155F-4872-AF1B-D62B-219BEB8F6244";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Ring1_scaleZ";
	rename -uid "D6481399-4F40-DEBE-974B-7996164BDF52";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Ring1_visibility";
	rename -uid "96D97E9B-484E-F5C2-0849-F6883D7514E0";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Ring1_translateX";
	rename -uid "A07F46CD-4ADF-189C-FD8C-448FE75C3449";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.078738860299270005 2 0.078738860299270005
		 3 0.078738860299270005 4 0.078738860299270005 5 0.078738860299270005 6 0.078738860299270005
		 7 0.078738860299270005 8 0.078738860299270005 9 0.078738860299270005 10 0.078738860299270005
		 11 0.078738860299270005 12 0.078738860299270005 13 0.078738860299270005 14 0.078738860299270005
		 15 0.078738860299270005 16 0.078738860299270005 17 0.078738860299270005 18 0.078738860299270005
		 19 0.078738860299270005 20 0.078738860299270005 21 0.078738860299270005 22 0.078738860299270005
		 23 0.078738860299270005;
createNode animCurveTL -n "jnt_L_Ring1_translateY";
	rename -uid "D0EF9F5C-41D6-AB14-BBDD-8899B7771DE5";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.0019202003576792492 2 -0.0019202003576792492
		 3 -0.0019202003576792492 4 -0.0019202003576792492 5 -0.0019202003576792492 6 -0.0019202003576792492
		 7 -0.0019202003576792492 8 -0.0019202003576792492 9 -0.0019202003576792492 10 -0.0019202003576792492
		 11 -0.0019202003576792492 12 -0.0019202003576792492 13 -0.0019202003576792492 14 -0.0019202003576792492
		 15 -0.0019202003576792492 16 -0.0019202003576792492 17 -0.0019202003576792492 18 -0.0019202003576792492
		 19 -0.0019202003576792492 20 -0.0019202003576792492 21 -0.0019202003576792492 22 -0.0019202003576792492
		 23 -0.0019202003576792492;
createNode animCurveTL -n "jnt_L_Ring1_translateZ";
	rename -uid "7D69EA14-41AF-766E-223F-BA8215E5CF3B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.0084510295085604963 2 -0.0084510295085604963
		 3 -0.0084510295085604963 4 -0.0084510295085604963 5 -0.0084510295085604963 6 -0.0084510295085604963
		 7 -0.0084510295085604963 8 -0.0084510295085604963 9 -0.0084510295085604963 10 -0.0084510295085604963
		 11 -0.0084510295085604963 12 -0.0084510295085604963 13 -0.0084510295085604963 14 -0.0084510295085604963
		 15 -0.0084510295085604963 16 -0.0084510295085604963 17 -0.0084510295085604963 18 -0.0084510295085604963
		 19 -0.0084510295085604963 20 -0.0084510295085604963 21 -0.0084510295085604963 22 -0.0084510295085604963
		 23 -0.0084510295085604963;
createNode animCurveTA -n "jnt_L_Ring2_rotateZ";
	rename -uid "AF9E9A18-4E24-3714-F600-C4B662BCD156";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_L_Ring2_rotateX";
	rename -uid "745C7F11-4C4E-5F47-0058-77B1842B5D7E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_L_Ring2_rotateY";
	rename -uid "E565DBC8-418B-1207-471B-22A21F9AFAB8";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_L_Ring2_scaleX";
	rename -uid "9E58E118-4F40-FE9F-14FD-68AFC22CB7C3";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Ring2_scaleY";
	rename -uid "1A9DF597-466B-72B3-4BA3-248B4BC227E5";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Ring2_scaleZ";
	rename -uid "2F66413D-4E5A-3D94-AC76-369E2F0EF27D";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Ring2_visibility";
	rename -uid "2BCE642A-4D57-1DEE-A995-8DA65F91E5AE";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Ring2_translateX";
	rename -uid "D758F194-4BB0-4483-C053-BC85227E8D5C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.014631633179000118 2 0.014631633179000118
		 3 0.014631633179000118 4 0.014631633179000118 5 0.014631633179000118 6 0.014631633179000118
		 7 0.014631633179000118 8 0.014631633179000118 9 0.014631633179000118 10 0.014631633179000118
		 11 0.014631633179000118 12 0.014631633179000118 13 0.014631633179000118 14 0.014631633179000118
		 15 0.014631633179000118 16 0.014631633179000118 17 0.014631633179000118 18 0.014631633179000118
		 19 0.014631633179000118 20 0.014631633179000118 21 0.014631633179000118 22 0.014631633179000118
		 23 0.014631633179000118;
createNode animCurveTL -n "jnt_L_Ring2_translateY";
	rename -uid "0B280931-4D94-889C-78B4-10AC0C628EBB";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTL -n "jnt_L_Ring2_translateZ";
	rename -uid "EBC5D847-4815-1AAB-7058-A7B4BAD7A827";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_L_Ring3_rotateZ";
	rename -uid "F69D8C6C-4A84-685A-DF68-9A91DC3DF50C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_L_Ring3_rotateX";
	rename -uid "48E31CDC-4B4A-3278-80CA-A0985C9CD9A6";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_L_Ring3_rotateY";
	rename -uid "7AE760CA-4B58-CF47-226F-67B74C484B8A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_L_Ring3_scaleX";
	rename -uid "519FCF4A-4DA7-2E41-9A91-31AE44695B1B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Ring3_scaleY";
	rename -uid "A4BE0A85-49BD-A8DE-84B2-718BF36F37F9";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Ring3_scaleZ";
	rename -uid "F47A590B-4252-AFCB-915E-E99BBE933C5D";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Ring3_visibility";
	rename -uid "71E0CC72-43BD-1031-0C87-AFBAAEDFAFC6";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Ring3_translateX";
	rename -uid "E22CC77D-4A4B-E36A-3ED4-DFAA5654D839";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.015640711329275803 2 0.015640711329275803
		 3 0.015640711329275803 4 0.015640711329275803 5 0.015640711329275803 6 0.015640711329275803
		 7 0.015640711329275803 8 0.015640711329275803 9 0.015640711329275803 10 0.015640711329275803
		 11 0.015640711329275803 12 0.015640711329275803 13 0.015640711329275803 14 0.015640711329275803
		 15 0.015640711329275803 16 0.015640711329275803 17 0.015640711329275803 18 0.015640711329275803
		 19 0.015640711329275803 20 0.015640711329275803 21 0.015640711329275803 22 0.015640711329275803
		 23 0.015640711329275803;
createNode animCurveTL -n "jnt_L_Ring3_translateY";
	rename -uid "79D8D0AF-41A9-073F-B4CA-3680C7E0D50D";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTL -n "jnt_L_Ring3_translateZ";
	rename -uid "0E72D42B-48DB-6BE3-749C-C4A7F1AB6016";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_L_Ring4_rotateZ";
	rename -uid "49576DCA-429C-7137-8DD6-05BF331D91FF";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_L_Ring4_rotateX";
	rename -uid "156D233E-4577-A846-5E81-1E83922D8339";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_L_Ring4_rotateY";
	rename -uid "5FF137E4-45CE-B665-B61B-5ABC2798B8D9";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_L_Ring4_visibility";
	rename -uid "61965C8A-461A-9F6E-1198-879D67962F27";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Ring4_translateX";
	rename -uid "159F9375-4B8E-2774-4053-0EBC1FF6F4F5";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.018458822537190282 2 0.018458822537190282
		 3 0.018458822537190282 4 0.018458822537190282 5 0.018458822537190282 6 0.018458822537190282
		 7 0.018458822537190282 8 0.018458822537190282 9 0.018458822537190282 10 0.018458822537190282
		 11 0.018458822537190282 12 0.018458822537190282 13 0.018458822537190282 14 0.018458822537190282
		 15 0.018458822537190282 16 0.018458822537190282 17 0.018458822537190282 18 0.018458822537190282
		 19 0.018458822537190282 20 0.018458822537190282 21 0.018458822537190282 22 0.018458822537190282
		 23 0.018458822537190282;
createNode animCurveTL -n "jnt_L_Ring4_translateY";
	rename -uid "11E58ADC-40CD-50A9-5C16-2689A949F058";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTL -n "jnt_L_Ring4_translateZ";
	rename -uid "46BBB3C8-4516-332A-E79B-66BBDC353FEB";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1.4432899320127036e-017 2 1.4432899320127036e-017
		 3 1.4432899320127036e-017 4 1.4432899320127036e-017 5 1.4432899320127036e-017 6 1.4432899320127036e-017
		 7 1.4432899320127036e-017 8 1.4432899320127036e-017 9 1.4432899320127036e-017 10 1.4432899320127036e-017
		 11 1.4432899320127036e-017 12 1.4432899320127036e-017 13 1.4432899320127036e-017
		 14 1.4432899320127036e-017 15 1.4432899320127036e-017 16 1.4432899320127036e-017
		 17 1.4432899320127036e-017 18 1.4432899320127036e-017 19 1.4432899320127036e-017
		 20 1.4432899320127036e-017 21 1.4432899320127036e-017 22 1.4432899320127036e-017
		 23 1.4432899320127036e-017;
createNode animCurveTU -n "jnt_L_Ring4_scaleX";
	rename -uid "1CD38D3E-47FD-7024-6609-908663DF90D4";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Ring4_scaleY";
	rename -uid "0B13A7E4-4B76-DD8D-2C81-0F9E8041E7CE";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Ring4_scaleZ";
	rename -uid "5AD22C31-4039-F1A0-31E3-F099997D3726";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTA -n "jnt_L_Pinky1_rotateZ";
	rename -uid "110CB458-4FA3-2AF1-141B-178157CA5FE2";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_L_Pinky1_rotateX";
	rename -uid "11B18844-4487-33B4-A66F-BE99A683EE2A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_L_Pinky1_rotateY";
	rename -uid "5EC10615-4B22-1C79-81A3-1FA0EA988477";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_L_Pinky1_scaleX";
	rename -uid "BD9F0193-4B79-2CD7-8FB4-B2AE6B604122";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Pinky1_scaleY";
	rename -uid "742A4F3B-4501-9CC6-5539-90AE201BFBDA";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Pinky1_scaleZ";
	rename -uid "1D422001-4310-9310-A9BF-0E9BC0430F91";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Pinky1_visibility";
	rename -uid "334F7EEF-4AED-BF81-9ACA-CFB53A512782";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Pinky1_translateX";
	rename -uid "8D09B9FE-46BD-99E1-C2E5-DE9FB2B27D18";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.070918504634632104 2 0.070918504634632104
		 3 0.070918504634632104 4 0.070918504634632104 5 0.070918504634632104 6 0.070918504634632104
		 7 0.070918504634632104 8 0.070918504634632104 9 0.070918504634632104 10 0.070918504634632104
		 11 0.070918504634632104 12 0.070918504634632104 13 0.070918504634632104 14 0.070918504634632104
		 15 0.070918504634632104 16 0.070918504634632104 17 0.070918504634632104 18 0.070918504634632104
		 19 0.070918504634632104 20 0.070918504634632104 21 0.070918504634632104 22 0.070918504634632104
		 23 0.070918504634632104;
createNode animCurveTL -n "jnt_L_Pinky1_translateY";
	rename -uid "2A960052-4FE8-E73C-8035-D88C22EDF400";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.0019202003576792492 2 -0.0019202003576792492
		 3 -0.0019202003576792492 4 -0.0019202003576792492 5 -0.0019202003576792492 6 -0.0019202003576792492
		 7 -0.0019202003576792492 8 -0.0019202003576792492 9 -0.0019202003576792492 10 -0.0019202003576792492
		 11 -0.0019202003576792492 12 -0.0019202003576792492 13 -0.0019202003576792492 14 -0.0019202003576792492
		 15 -0.0019202003576792492 16 -0.0019202003576792492 17 -0.0019202003576792492 18 -0.0019202003576792492
		 19 -0.0019202003576792492 20 -0.0019202003576792492 21 -0.0019202003576792492 22 -0.0019202003576792492
		 23 -0.0019202003576792492;
createNode animCurveTL -n "jnt_L_Pinky1_translateZ";
	rename -uid "E2B201C3-43D3-B038-5872-C197F8F068BA";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.018289541473750184 2 -0.018289541473750184
		 3 -0.018289541473750184 4 -0.018289541473750184 5 -0.018289541473750184 6 -0.018289541473750184
		 7 -0.018289541473750184 8 -0.018289541473750184 9 -0.018289541473750184 10 -0.018289541473750184
		 11 -0.018289541473750184 12 -0.018289541473750184 13 -0.018289541473750184 14 -0.018289541473750184
		 15 -0.018289541473750184 16 -0.018289541473750184 17 -0.018289541473750184 18 -0.018289541473750184
		 19 -0.018289541473750184 20 -0.018289541473750184 21 -0.018289541473750184 22 -0.018289541473750184
		 23 -0.018289541473750184;
createNode animCurveTA -n "jnt_L_Pinky2_rotateZ";
	rename -uid "914DD317-4B51-E945-FBD4-5BAAA58B8B1A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_L_Pinky2_rotateX";
	rename -uid "989CE506-4220-C8C4-55F4-75A165A436CD";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_L_Pinky2_rotateY";
	rename -uid "8E254A1B-4DAD-BFD9-080C-6A95436735D4";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_L_Pinky2_scaleX";
	rename -uid "C5AA1D67-40F0-3071-03C2-5F8BB75EBEBF";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Pinky2_scaleY";
	rename -uid "DBECA6F9-4924-71E1-874B-E58B29590C83";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Pinky2_scaleZ";
	rename -uid "9478457B-4AA4-1250-74D1-D7ACDF0848B5";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Pinky2_visibility";
	rename -uid "E45007D4-45A9-8B2A-3238-0DB7EB0D7F29";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Pinky2_translateX";
	rename -uid "EC6ABFB1-436C-7817-D9CF-2ABAEB0DA0BD";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.015155080659079423 2 0.015155080659079423
		 3 0.015155080659079423 4 0.015155080659079423 5 0.015155080659079423 6 0.015155080659079423
		 7 0.015155080659079423 8 0.015155080659079423 9 0.015155080659079423 10 0.015155080659079423
		 11 0.015155080659079423 12 0.015155080659079423 13 0.015155080659079423 14 0.015155080659079423
		 15 0.015155080659079423 16 0.015155080659079423 17 0.015155080659079423 18 0.015155080659079423
		 19 0.015155080659079423 20 0.015155080659079423 21 0.015155080659079423 22 0.015155080659079423
		 23 0.015155080659079423;
createNode animCurveTL -n "jnt_L_Pinky2_translateY";
	rename -uid "7AED5662-497D-682E-6861-E797AE955DC9";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTL -n "jnt_L_Pinky2_translateZ";
	rename -uid "5353262E-430D-D0F8-4A49-A4AED7C6FD9C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1.2490009027033011e-018 2 1.2490009027033011e-018
		 3 1.2490009027033011e-018 4 1.2490009027033011e-018 5 1.2490009027033011e-018 6 1.2490009027033011e-018
		 7 1.2490009027033011e-018 8 1.2490009027033011e-018 9 1.2490009027033011e-018 10 1.2490009027033011e-018
		 11 1.2490009027033011e-018 12 1.2490009027033011e-018 13 1.2490009027033011e-018
		 14 1.2490009027033011e-018 15 1.2490009027033011e-018 16 1.2490009027033011e-018
		 17 1.2490009027033011e-018 18 1.2490009027033011e-018 19 1.2490009027033011e-018
		 20 1.2490009027033011e-018 21 1.2490009027033011e-018 22 1.2490009027033011e-018
		 23 1.2490009027033011e-018;
createNode animCurveTA -n "jnt_L_Pinky3_rotateZ";
	rename -uid "94D5D147-451C-E9DC-CF15-EBA10F03164A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_L_Pinky3_rotateX";
	rename -uid "C94A0FF2-4094-0B1D-3674-E8BC70E9F1C9";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_L_Pinky3_rotateY";
	rename -uid "2A6BFC7C-4938-6D89-8DCF-5FBA925A009B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_L_Pinky3_scaleX";
	rename -uid "D233A201-4AA3-3029-D52C-E48870130D2D";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Pinky3_scaleY";
	rename -uid "02ABD141-409C-A1B3-81E2-61BEFC08A923";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Pinky3_scaleZ";
	rename -uid "BEDE24E3-49F1-A85F-856A-FCA2FF1D90DE";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Pinky3_visibility";
	rename -uid "8B320D0D-4AC6-4BD8-8640-99AA7DBD71E3";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Pinky3_translateX";
	rename -uid "02CB6D26-4C21-3090-1810-8CB507F7B839";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.014631633178999976 2 0.014631633178999976
		 3 0.014631633178999976 4 0.014631633178999976 5 0.014631633178999976 6 0.014631633178999976
		 7 0.014631633178999976 8 0.014631633178999976 9 0.014631633178999976 10 0.014631633178999976
		 11 0.014631633178999976 12 0.014631633178999976 13 0.014631633178999976 14 0.014631633178999976
		 15 0.014631633178999976 16 0.014631633178999976 17 0.014631633178999976 18 0.014631633178999976
		 19 0.014631633178999976 20 0.014631633178999976 21 0.014631633178999976 22 0.014631633178999976
		 23 0.014631633178999976;
createNode animCurveTL -n "jnt_L_Pinky3_translateY";
	rename -uid "0B0E9259-48FA-BB3C-CC6C-04AA7EE7A414";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTL -n "jnt_L_Pinky3_translateZ";
	rename -uid "E41C3AFF-42D2-F243-4CD2-B88E533C62A2";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1.0152735026996967e-019 2 1.0152735026996967e-019
		 3 1.0152735026996967e-019 4 1.0152735026996967e-019 5 1.0152735026996967e-019 6 1.0152735026996967e-019
		 7 1.0152735026996967e-019 8 1.0152735026996967e-019 9 1.0152735026996967e-019 10 1.0152735026996967e-019
		 11 1.0152735026996967e-019 12 1.0152735026996967e-019 13 1.0152735026996967e-019
		 14 1.0152735026996967e-019 15 1.0152735026996967e-019 16 1.0152735026996967e-019
		 17 1.0152735026996967e-019 18 1.0152735026996967e-019 19 1.0152735026996967e-019
		 20 1.0152735026996967e-019 21 1.0152735026996967e-019 22 1.0152735026996967e-019
		 23 1.0152735026996967e-019;
createNode animCurveTA -n "jnt_L_Pinky4_rotateZ";
	rename -uid "DFD9A29E-4CE5-8861-53EA-039EBB5E425C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_L_Pinky4_rotateX";
	rename -uid "F783213A-4DBD-2D7D-4E21-50AA208775E1";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_L_Pinky4_rotateY";
	rename -uid "1357C802-4503-F1A5-2B78-7EA241533851";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_L_Pinky4_visibility";
	rename -uid "C94C0C32-4C28-BE88-F9CE-7FA845C56546";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Pinky4_translateX";
	rename -uid "F7161B12-4FD9-5BFA-8B2A-61A6BD9DEA5A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.015648846940400495 2 0.015648846940400495
		 3 0.015648846940400495 4 0.015648846940400495 5 0.015648846940400495 6 0.015648846940400495
		 7 0.015648846940400495 8 0.015648846940400495 9 0.015648846940400495 10 0.015648846940400495
		 11 0.015648846940400495 12 0.015648846940400495 13 0.015648846940400495 14 0.015648846940400495
		 15 0.015648846940400495 16 0.015648846940400495 17 0.015648846940400495 18 0.015648846940400495
		 19 0.015648846940400495 20 0.015648846940400495 21 0.015648846940400495 22 0.015648846940400495
		 23 0.015648846940400495;
createNode animCurveTL -n "jnt_L_Pinky4_translateY";
	rename -uid "FB36E73B-4822-4326-D2B7-80B7641F5543";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTL -n "jnt_L_Pinky4_translateZ";
	rename -uid "719DC7C3-41CE-6361-06C5-7F9D0D8A6AEF";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 2.6020852139652106e-017 2 2.6020852139652106e-017
		 3 2.6020852139652106e-017 4 2.6020852139652106e-017 5 2.6020852139652106e-017 6 2.6020852139652106e-017
		 7 2.6020852139652106e-017 8 2.6020852139652106e-017 9 2.6020852139652106e-017 10 2.6020852139652106e-017
		 11 2.6020852139652106e-017 12 2.6020852139652106e-017 13 2.6020852139652106e-017
		 14 2.6020852139652106e-017 15 2.6020852139652106e-017 16 2.6020852139652106e-017
		 17 2.6020852139652106e-017 18 2.6020852139652106e-017 19 2.6020852139652106e-017
		 20 2.6020852139652106e-017 21 2.6020852139652106e-017 22 2.6020852139652106e-017
		 23 2.6020852139652106e-017;
createNode animCurveTU -n "jnt_L_Pinky4_scaleX";
	rename -uid "BA638E69-4D30-F37F-2CA8-CA8B8FD529BD";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Pinky4_scaleY";
	rename -uid "C0980DE1-4DB7-F77B-E77E-A6863246B300";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Pinky4_scaleZ";
	rename -uid "B6A9772F-4626-1E80-AD14-F1AAB9686177";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode displayLayer -n "leftControls";
	rename -uid "41686D4C-43CC-8F7A-013C-C29ADDE9B744";
	setAttr ".c" 6;
	setAttr ".do" 2;
createNode animCurveTL -n "ctrl_L_Arm_translateX";
	rename -uid "26D9F2C3-40C0-ABB0-44A3-9F9E87552F81";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 4 ".ktv[0:3]"  1 -0.37542244594788599 12.264 -0.37542244594788599
		 18.12 -0.37542244594788599 24.008 -0.37542244594788599;
createNode animCurveTL -n "ctrl_L_Arm_translateY";
	rename -uid "38E572F5-49E7-83E2-B260-2E85B00CE062";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 5 ".ktv[0:4]"  1 -0.44076751888534449 6.396 -0.44785599718443814
		 12.264 -0.4445462830703768 18.12 -0.44785599718443814 24.008 -0.44076751888534449;
createNode animCurveTL -n "ctrl_L_Arm_translateZ";
	rename -uid "0E11CF07-422B-D5BB-80DC-FCA3B0D375BC";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 5 ".ktv[0:4]"  1 0.11693175542261021 6.396 0.066119268926166333
		 12.264 -0.055914107611830514 18.12 0.066119268926166333 24.008 0.11693175542261021;
createNode animCurveTU -n "ctrl_L_Arm_visibility";
	rename -uid "87AD6706-438C-9359-59E3-F585CA541397";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 4 ".ktv[0:3]"  1 1 12.264 1 18.12 1 24.008 1;
createNode animCurveTU -n "ctrl_L_Wrist_FingerRoll";
	rename -uid "EDB4F001-4992-A582-AEC7-519F479862C2";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 4 ".ktv[0:3]"  1 10 12.264 10 18.12 10 24.008 10;
createNode animCurveTA -n "ctrl_L_Wrist_rotateX";
	rename -uid "84A28894-4EBA-C9CE-AEE9-239EBF1B83AB";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 4 ".ktv[0:3]"  1 0 12.264 0 18.12 0 24.008 0;
createNode animCurveTA -n "ctrl_L_Wrist_rotateY";
	rename -uid "7180189E-4A9C-27A3-05EB-0B9E81192A3B";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 5 ".ktv[0:4]"  1 -33.929373705323805 6.396 -18.358444941072094
		 12.264 23.540158034242108 18.12 -18.358444941072094 24.008 -33.929373705323805;
createNode animCurveTA -n "ctrl_L_Wrist_rotateZ";
	rename -uid "E1D39E8A-408C-B083-5338-3F985B475DBA";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 4 ".ktv[0:3]"  1 -85.761971805876371 12.744 -85.761971805876371
		 18.612 -85.761971805876371 24.008 -85.761971805876371;
createNode animCurveTU -n "ctrl_L_Wrist_visibility";
	rename -uid "012A0004-47F2-C1CE-E658-149F1974F380";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 4 ".ktv[0:3]"  1 1 12.264 1 18.12 1 24.008 1;
createNode animCurveTU -n "jnt_R_Shoulder_scaleX";
	rename -uid "768A7A14-4243-438F-6087-F6A23F0C81FD";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Shoulder_scaleY";
	rename -uid "26E6301C-4CB5-F4F5-0913-059D471A5F9F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Shoulder_scaleZ";
	rename -uid "77CECCAE-4CE1-BE01-E496-66BB14E437F5";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Shoulder_visibility";
	rename -uid "4D0EDD2A-4820-B1F8-3BD1-E0B579575171";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Shoulder_translateX";
	rename -uid "F636BCA3-47F9-035D-0894-70B592D531F4";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.034622311600600496 2 0.034622311600600496
		 3 0.034622311600600496 4 0.034622311600600496 5 0.034622311600600496 6 0.034622311600600496
		 7 0.034622311600600496 8 0.034622311600600496 9 0.034622311600600496 10 0.034622311600600496
		 11 0.034622311600600496 12 0.034622311600600496 13 0.034622311600600496 14 0.034622311600600496
		 15 0.034622311600600496 16 0.034622311600600496 17 0.034622311600600496 18 0.034622311600600496
		 19 0.034622311600600496 20 0.034622311600600496 21 0.034622311600600496 22 0.034622311600600496
		 23 0.034622311600600496;
createNode animCurveTL -n "jnt_R_Shoulder_translateY";
	rename -uid "47C5A515-44A7-1FCD-2800-21B8FE524889";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.011373691850441396 2 -0.011373691850441396
		 3 -0.011373691850441396 4 -0.011373691850441396 5 -0.011373691850441396 6 -0.011373691850441396
		 7 -0.011373691850441396 8 -0.011373691850441396 9 -0.011373691850441396 10 -0.011373691850441396
		 11 -0.011373691850441396 12 -0.011373691850441396 13 -0.011373691850441396 14 -0.011373691850441396
		 15 -0.011373691850441396 16 -0.011373691850441396 17 -0.011373691850441396 18 -0.011373691850441396
		 19 -0.011373691850441396 20 -0.011373691850441396 21 -0.011373691850441396 22 -0.011373691850441396
		 23 -0.011373691850441396;
createNode animCurveTL -n "jnt_R_Shoulder_translateZ";
	rename -uid "AE5587FA-40BE-485F-26A5-7E85FF372C92";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.11594056743042241 2 0.11594056743042241
		 3 0.11594056743042241 4 0.11594056743042241 5 0.11594056743042241 6 0.11594056743042241
		 7 0.11594056743042241 8 0.11594056743042241 9 0.11594056743042241 10 0.11594056743042241
		 11 0.11594056743042241 12 0.11594056743042241 13 0.11594056743042241 14 0.11594056743042241
		 15 0.11594056743042241 16 0.11594056743042241 17 0.11594056743042241 18 0.11594056743042241
		 19 0.11594056743042241 20 0.11594056743042241 21 0.11594056743042241 22 0.11594056743042241
		 23 0.11594056743042241;
createNode animCurveTA -n "jnt_R_Shoulder_rotateX";
	rename -uid "D8C20988-4C2A-2352-1423-3FA018A2E39C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 57.110495646913535 2 57.110495646913535
		 3 57.110495646913535 4 57.110495646913535 5 57.110495646913535 6 57.110495646913535
		 7 57.110495646913535 8 57.110495646913535 9 57.110495646913535 10 57.110495646913535
		 11 57.110495646913535 12 57.110495646913535 13 57.110495646913535 14 57.110495646913535
		 15 57.110495646913535 16 57.110495646913535 17 57.110495646913535 18 57.110495646913535
		 19 57.110495646913535 20 57.110495646913535 21 57.110495646913535 22 57.110495646913535
		 23 57.110495646913535;
createNode animCurveTA -n "jnt_R_Shoulder_rotateY";
	rename -uid "B4ABBD9D-4138-ED90-0AB9-688FAC5487B6";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 27.583520573971416 2 27.583520573971416
		 3 27.583520573971416 4 27.583520573971416 5 27.583520573971416 6 27.583520573971416
		 7 27.583520573971416 8 27.583520573971416 9 27.583520573971416 10 27.583520573971416
		 11 27.583520573971416 12 27.583520573971416 13 27.583520573971416 14 27.583520573971416
		 15 27.583520573971416 16 27.583520573971416 17 27.583520573971416 18 27.583520573971416
		 19 27.583520573971416 20 27.583520573971416 21 27.583520573971416 22 27.583520573971416
		 23 27.583520573971416;
createNode animCurveTA -n "jnt_R_Shoulder_rotateZ";
	rename -uid "92141296-483B-9711-6C8D-5387E2C1D5A7";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -64.416986133785286 2 -64.416986133785286
		 3 -64.416986133785286 4 -64.416986133785286 5 -64.416986133785286 6 -64.416986133785286
		 7 -64.416986133785286 8 -64.416986133785286 9 -64.416986133785286 10 -64.416986133785286
		 11 -64.416986133785286 12 -64.416986133785286 13 -64.416986133785286 14 -64.416986133785286
		 15 -64.416986133785286 16 -64.416986133785286 17 -64.416986133785286 18 -64.416986133785286
		 19 -64.416986133785286 20 -64.416986133785286 21 -64.416986133785286 22 -64.416986133785286
		 23 -64.416986133785286;
createNode animCurveTU -n "jnt_R_Elbow_scaleX";
	rename -uid "832A8725-41FC-1E0D-5D52-738927DA8D46";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Elbow_scaleY";
	rename -uid "C9B33D74-4245-65B9-85CF-91B680926952";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Elbow_scaleZ";
	rename -uid "9818EB7F-4028-715F-1B14-59B81258E9C0";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Elbow_visibility";
	rename -uid "BAA289A6-45F9-08BF-8220-229DDDE1D2C7";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Elbow_translateX";
	rename -uid "0AA1B44E-4FFD-62FF-C967-26B954A31AEE";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.24230539869950871 2 -0.24230539869950871
		 3 -0.24230539869950871 4 -0.24230539869950871 5 -0.24230539869950871 6 -0.24230539869950871
		 7 -0.24230539869950871 8 -0.24230539869950871 9 -0.24230539869950871 10 -0.24230539869950871
		 11 -0.24230539869950871 12 -0.24230539869950871 13 -0.24230539869950871 14 -0.24230539869950871
		 15 -0.24230539869950871 16 -0.24230539869950871 17 -0.24230539869950871 18 -0.24230539869950871
		 19 -0.24230539869950871 20 -0.24230539869950871 21 -0.24230539869950871 22 -0.24230539869950871
		 23 -0.24230539869950871;
createNode animCurveTL -n "jnt_R_Elbow_translateY";
	rename -uid "75B291B4-4F91-7280-2E74-308E2BF9AC9B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.0027920000000001013 2 0.0027920000000001013
		 3 0.0027920000000001013 4 0.0027920000000001013 5 0.0027920000000001013 6 0.0027920000000001013
		 7 0.0027920000000001013 8 0.0027920000000001013 9 0.0027920000000001013 10 0.0027920000000001013
		 11 0.0027920000000001013 12 0.0027920000000001013 13 0.0027920000000001013 14 0.0027920000000001013
		 15 0.0027920000000001013 16 0.0027920000000001013 17 0.0027920000000001013 18 0.0027920000000001013
		 19 0.0027920000000001013 20 0.0027920000000001013 21 0.0027920000000001013 22 0.0027920000000001013
		 23 0.0027920000000001013;
createNode animCurveTL -n "jnt_R_Elbow_translateZ";
	rename -uid "AAEBD746-45A1-0807-9BF9-C588C4390B51";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.0058607723989379055 2 0.0058607723989379055
		 3 0.0058607723989379055 4 0.0058607723989379055 5 0.0058607723989379055 6 0.0058607723989379055
		 7 0.0058607723989379055 8 0.0058607723989379055 9 0.0058607723989379055 10 0.0058607723989379055
		 11 0.0058607723989379055 12 0.0058607723989379055 13 0.0058607723989379055 14 0.0058607723989379055
		 15 0.0058607723989379055 16 0.0058607723989379055 17 0.0058607723989379055 18 0.0058607723989379055
		 19 0.0058607723989379055 20 0.0058607723989379055 21 0.0058607723989379055 22 0.0058607723989379055
		 23 0.0058607723989379055;
createNode animCurveTA -n "jnt_R_Elbow_rotateX";
	rename -uid "C519E668-4853-E1F1-9DD0-F38FD3796333";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.00012945831630533736 2 -0.00012945831630533736
		 3 -0.00012945831630533736 4 -0.00012945831630533736 5 -0.00012945831630533736 6 -0.00012945831630533736
		 7 -0.00012945831630533736 8 -0.00012945831630533736 9 -0.00012945831630533736 10 -0.00012945831630533736
		 11 -0.00012945831630533736 12 -0.00012945831630533736 13 -0.00012945831630533736
		 14 -0.00012945831630533736 15 -0.00012945831630533736 16 -0.00012945831630533736
		 17 -0.00012945831630533736 18 -0.00012945831630533736 19 -0.00012945831630533736
		 20 -0.00012945831630533736 21 -0.00012945831630533736 22 -0.00012945831630533736
		 23 -0.00012945831630533736;
createNode animCurveTA -n "jnt_R_Elbow_rotateY";
	rename -uid "540A31DA-41D8-BAD7-DE26-B19923FD7593";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -37.632003886480412 2 -37.632003886480412
		 3 -37.632003886480412 4 -37.632003886480412 5 -37.632003886480412 6 -37.632003886480412
		 7 -37.632003886480412 8 -37.632003886480412 9 -37.632003886480412 10 -37.632003886480412
		 11 -37.632003886480412 12 -37.632003886480412 13 -37.632003886480412 14 -37.632003886480412
		 15 -37.632003886480412 16 -37.632003886480412 17 -37.632003886480412 18 -37.632003886480412
		 19 -37.632003886480412 20 -37.632003886480412 21 -37.632003886480412 22 -37.632003886480412
		 23 -37.632003886480412;
createNode animCurveTA -n "jnt_R_Elbow_rotateZ";
	rename -uid "4A40A586-4700-899B-177E-46BDF822B1DF";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 17.464987447583269 2 17.464987447583269
		 3 17.464987447583269 4 17.464987447583269 5 17.464987447583269 6 17.464987447583269
		 7 17.464987447583269 8 17.464987447583269 9 17.464987447583269 10 17.464987447583269
		 11 17.464987447583269 12 17.464987447583269 13 17.464987447583269 14 17.464987447583269
		 15 17.464987447583269 16 17.464987447583269 17 17.464987447583269 18 17.464987447583269
		 19 17.464987447583269 20 17.464987447583269 21 17.464987447583269 22 17.464987447583269
		 23 17.464987447583269;
createNode animCurveTU -n "jnt_R_Forearm_scaleX";
	rename -uid "07171BDB-4400-9D43-016C-8AB4EB775092";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Forearm_scaleY";
	rename -uid "EEB7D88E-43C1-AE68-1091-CF8FC0D8EDF7";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Forearm_scaleZ";
	rename -uid "C6A25C6B-42B0-F976-3535-278FE3CE9DBA";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Forearm_translateX";
	rename -uid "C749EBDE-443F-168D-393B-8B9E44B0C089";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.12007516239082115 2 -0.12007516239082115
		 3 -0.12007516239082115 4 -0.12007516239082115 5 -0.12007516239082115 6 -0.12007516239082115
		 7 -0.12007516239082115 8 -0.12007516239082115 9 -0.12007516239082115 10 -0.12007516239082115
		 11 -0.12007516239082115 12 -0.12007516239082115 13 -0.12007516239082115 14 -0.12007516239082115
		 15 -0.12007516239082115 16 -0.12007516239082115 17 -0.12007516239082115 18 -0.12007516239082115
		 19 -0.12007516239082115 20 -0.12007516239082115 21 -0.12007516239082115 22 -0.12007516239082115
		 23 -0.12007516239082115;
createNode animCurveTL -n "jnt_R_Forearm_translateY";
	rename -uid "7EBD7ED4-4226-D8D6-F4E5-E1A73C296ECE";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.0012440000000001562 2 -0.0012440000000001562
		 3 -0.0012440000000001562 4 -0.0012440000000001562 5 -0.0012440000000001562 6 -0.0012440000000001562
		 7 -0.0012440000000001562 8 -0.0012440000000001562 9 -0.0012440000000001562 10 -0.0012440000000001562
		 11 -0.0012440000000001562 12 -0.0012440000000001562 13 -0.0012440000000001562 14 -0.0012440000000001562
		 15 -0.0012440000000001562 16 -0.0012440000000001562 17 -0.0012440000000001562 18 -0.0012440000000001562
		 19 -0.0012440000000001562 20 -0.0012440000000001562 21 -0.0012440000000001562 22 -0.0012440000000001562
		 23 -0.0012440000000001562;
createNode animCurveTL -n "jnt_R_Forearm_translateZ";
	rename -uid "860DF885-44A0-39EE-CF9F-82B7784D4916";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.0026818976617209865 2 -0.0026818976617209865
		 3 -0.0026818976617209865 4 -0.0026818976617209865 5 -0.0026818976617209865 6 -0.0026818976617209865
		 7 -0.0026818976617209865 8 -0.0026818976617209865 9 -0.0026818976617209865 10 -0.0026818976617209865
		 11 -0.0026818976617209865 12 -0.0026818976617209865 13 -0.0026818976617209865 14 -0.0026818976617209865
		 15 -0.0026818976617209865 16 -0.0026818976617209865 17 -0.0026818976617209865 18 -0.0026818976617209865
		 19 -0.0026818976617209865 20 -0.0026818976617209865 21 -0.0026818976617209865 22 -0.0026818976617209865
		 23 -0.0026818976617209865;
createNode animCurveTU -n "jnt_R_Forearm_visibility";
	rename -uid "8ED51F9E-4BDB-83BC-876D-A4B4BEFB4F21";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTA -n "jnt_R_Forearm_rotateX";
	rename -uid "F92F58A1-4211-AB38-5F2E-7F8AFC82CE33";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_R_Forearm_rotateY";
	rename -uid "75A0E1AD-4C44-4AC5-1EDA-9A9E6D6FC4FB";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_R_Forearm_rotateZ";
	rename -uid "E06E5183-47BC-3F1D-745E-97A5DF5D906A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTL -n "jnt_R_Wrist_translateX";
	rename -uid "E8F6DDD6-46B0-7721-94CB-C88266586962";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.11539524590181983 2 -0.11539524590181983
		 3 -0.11539524590181983 4 -0.11539524590181983 5 -0.11539524590181983 6 -0.11539524590181983
		 7 -0.11539524590181983 8 -0.11539524590181983 9 -0.11539524590181983 10 -0.11539524590181983
		 11 -0.11539524590181983 12 -0.11539524590181983 13 -0.11539524590181983 14 -0.11539524590181983
		 15 -0.11539524590181983 16 -0.11539524590181983 17 -0.11539524590181983 18 -0.11539524590181983
		 19 -0.11539524590181983 20 -0.11539524590181983 21 -0.11539524590181983 22 -0.11539524590181983
		 23 -0.11539524590181983;
createNode animCurveTL -n "jnt_R_Wrist_translateY";
	rename -uid "321F9EE8-447B-F12F-FEE2-66954FD79494";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.0011960000000000549 2 -0.0011960000000000549
		 3 -0.0011960000000000549 4 -0.0011960000000000549 5 -0.0011960000000000549 6 -0.0011960000000000549
		 7 -0.0011960000000000549 8 -0.0011960000000000549 9 -0.0011960000000000549 10 -0.0011960000000000549
		 11 -0.0011960000000000549 12 -0.0011960000000000549 13 -0.0011960000000000549 14 -0.0011960000000000549
		 15 -0.0011960000000000549 16 -0.0011960000000000549 17 -0.0011960000000000549 18 -0.0011960000000000549
		 19 -0.0011960000000000549 20 -0.0011960000000000549 21 -0.0011960000000000549 22 -0.0011960000000000549
		 23 -0.0011960000000000549;
createNode animCurveTL -n "jnt_R_Wrist_translateZ";
	rename -uid "D43D765F-4B55-E25F-6C05-41824D41E7D1";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.0025773430540991437 2 -0.0025773430540991437
		 3 -0.0025773430540991437 4 -0.0025773430540991437 5 -0.0025773430540991437 6 -0.0025773430540991437
		 7 -0.0025773430540991437 8 -0.0025773430540991437 9 -0.0025773430540991437 10 -0.0025773430540991437
		 11 -0.0025773430540991437 12 -0.0025773430540991437 13 -0.0025773430540991437 14 -0.0025773430540991437
		 15 -0.0025773430540991437 16 -0.0025773430540991437 17 -0.0025773430540991437 18 -0.0025773430540991437
		 19 -0.0025773430540991437 20 -0.0025773430540991437 21 -0.0025773430540991437 22 -0.0025773430540991437
		 23 -0.0025773430540991437;
createNode animCurveTA -n "jnt_R_Wrist_rotateX";
	rename -uid "A78A0F00-4921-43AC-B568-84BF73AB8FB3";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -71.615803153133115 2 -68.030877796871877
		 3 -64.688117584924697 4 -62.808825847912352 5 -62.174752287280818 6 -61.296842163973707
		 7 -58.164724810569496 8 -54.751869309465654 9 -53.865778543509755 10 -53.08834246621074
		 11 -51.032265772220221 12 -49.752534648866295 13 -51.640307515061309 14 -55.61343050086473
		 15 -58.564256230930056 16 -58.577387822694341 17 -57.817350994893289 18 -58.347530852209005
		 19 -59.89776427191272 20 -61.522664698588137 21 -63.449832211475886 22 -65.941546441703139
		 23 -68.766817431234216;
createNode animCurveTA -n "jnt_R_Wrist_rotateY";
	rename -uid "08ADAE20-4EC3-8B90-1C1B-98968F2C8AC5";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 9.6566684027956544 2 9.7348496357416039
		 3 9.7892848673227064 4 11.090134810953941 5 14.279941300100781 6 16.182534387694933
		 7 12.826234573154602 8 3.3200760633212085 9 -7.000471017733692 10 -13.222584472651739
		 11 -17.375042569696976 12 -19.421035864193957 13 -18.916452777580162 14 -15.808973518763342
		 15 -11.48039456305672 16 -6.2515442113874755 17 0.51408995729003237 18 6.2350223921418815
		 19 8.8141342058508485 20 9.6814377948249639 21 10.024752197443746 22 10.201669982770884
		 23 9.964545302139193;
createNode animCurveTA -n "jnt_R_Wrist_rotateZ";
	rename -uid "6D6A487C-4EAE-845D-D745-DFA726A5D8CE";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -19.224723466602732 2 -17.426973822931682
		 3 -16.103976283344839 4 -17.98136804210996 5 -23.568834433525151 6 -26.211877198637588
		 7 -18.933965200700328 8 -3.4973079479619362 9 10.871819643995298 10 17.940674953563956
		 11 20.570239505916089 12 21.382751331585382 13 22.606264529941932 14 23.18965202600506
		 15 20.788149684950547 16 13.125621440500185 17 1.6665658127892398 18 -8.0072397656118834
		 19 -12.746735401224489 20 -14.783693883332258 21 -16.123449037946457 22 -17.547336040869286
		 23 -18.391292173651788;
createNode animCurveTU -n "jnt_R_Wrist_scaleX";
	rename -uid "95D61B29-4834-930F-7827-5791F08C4238";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Wrist_scaleY";
	rename -uid "A2E70FD8-40E2-5CAE-4FB8-3EBC54099CEF";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Wrist_scaleZ";
	rename -uid "1285AF12-4361-F0A8-5579-34B3F08966E5";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Wrist_visibility";
	rename -uid "88362F16-41DC-0FE0-600B-CAB6C8468329";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTA -n "jnt_R_Thumb1_rotateX";
	rename -uid "2D16D5D5-4A37-E14C-ADB2-0B9FF3B6B914";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -5.2305446655852146 2 -5.2305446655852146
		 3 -5.2305446655852146 4 -5.2305446655852146 5 -5.2305446655852146 6 -5.2305446655852146
		 7 -5.2305446655852146 8 -5.2305446655852146 9 -5.2305446655852146 10 -5.2305446655852146
		 11 -5.2305446655852146 12 -5.2305446655852146 13 -5.2305446655852146 14 -5.2305446655852146
		 15 -5.2305446655852146 16 -5.2305446655852146 17 -5.2305446655852146 18 -5.2305446655852146
		 19 -5.2305446655852146 20 -5.2305446655852146 21 -5.2305446655852146 22 -5.2305446655852146
		 23 -5.2305446655852146;
createNode animCurveTA -n "jnt_R_Thumb1_rotateY";
	rename -uid "782A149E-432F-0969-FF2A-F1BC4367B533";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 15.053497955674512 2 15.053497955674512
		 3 15.053497955674512 4 15.053497955674512 5 15.053497955674512 6 15.053497955674512
		 7 15.053497955674512 8 15.053497955674512 9 15.053497955674512 10 15.053497955674512
		 11 15.053497955674512 12 15.053497955674512 13 15.053497955674512 14 15.053497955674512
		 15 15.053497955674512 16 15.053497955674512 17 15.053497955674512 18 15.053497955674512
		 19 15.053497955674512 20 15.053497955674512 21 15.053497955674512 22 15.053497955674512
		 23 15.053497955674512;
createNode animCurveTA -n "jnt_R_Thumb1_rotateZ";
	rename -uid "B44B8D79-4A49-9DAB-01D1-4C9320D30EB0";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -30.28050929520824 2 -30.28050929520824
		 3 -30.28050929520824 4 -30.28050929520824 5 -30.28050929520824 6 -30.28050929520824
		 7 -30.28050929520824 8 -30.28050929520824 9 -30.28050929520824 10 -30.28050929520824
		 11 -30.28050929520824 12 -30.28050929520824 13 -30.28050929520824 14 -30.28050929520824
		 15 -30.28050929520824 16 -30.28050929520824 17 -30.28050929520824 18 -30.28050929520824
		 19 -30.28050929520824 20 -30.28050929520824 21 -30.28050929520824 22 -30.28050929520824
		 23 -30.28050929520824;
createNode animCurveTU -n "jnt_R_Thumb1_scaleX";
	rename -uid "0C262982-494B-B6B2-B664-7CB27D07D9A4";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Thumb1_scaleY";
	rename -uid "EED26BB1-4EB3-CD82-A72A-FBBECA7F64D1";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Thumb1_scaleZ";
	rename -uid "A45C6762-4D6E-557E-7E95-59B4E0CFBE93";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Thumb1_visibility";
	rename -uid "BBB3F19A-46F2-C6A2-0CE1-E2A7C170C74E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Thumb1_translateX";
	rename -uid "F1595A5B-4FD8-8C5A-FED3-10A538D0A89C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.030807999999999964 2 -0.030807999999999964
		 3 -0.030807999999999964 4 -0.030807999999999964 5 -0.030807999999999964 6 -0.030807999999999964
		 7 -0.030807999999999964 8 -0.030807999999999964 9 -0.030807999999999964 10 -0.030807999999999964
		 11 -0.030807999999999964 12 -0.030807999999999964 13 -0.030807999999999964 14 -0.030807999999999964
		 15 -0.030807999999999964 16 -0.030807999999999964 17 -0.030807999999999964 18 -0.030807999999999964
		 19 -0.030807999999999964 20 -0.030807999999999964 21 -0.030807999999999964 22 -0.030807999999999964
		 23 -0.030807999999999964;
createNode animCurveTL -n "jnt_R_Thumb1_translateY";
	rename -uid "6F1DB4F5-4A1F-89FC-4CE9-E0B732DF1FA8";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.0019199999999997175 2 0.0019199999999997175
		 3 0.0019199999999997175 4 0.0019199999999997175 5 0.0019199999999997175 6 0.0019199999999997175
		 7 0.0019199999999997175 8 0.0019199999999997175 9 0.0019199999999997175 10 0.0019199999999997175
		 11 0.0019199999999997175 12 0.0019199999999997175 13 0.0019199999999997175 14 0.0019199999999997175
		 15 0.0019199999999997175 16 0.0019199999999997175 17 0.0019199999999997175 18 0.0019199999999997175
		 19 0.0019199999999997175 20 0.0019199999999997175 21 0.0019199999999997175 22 0.0019199999999997175
		 23 0.0019199999999997175;
createNode animCurveTL -n "jnt_R_Thumb1_translateZ";
	rename -uid "58AED39C-41FB-E1A8-66D6-5188A4AD5C1C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.019046309999999924 2 -0.019046309999999924
		 3 -0.019046309999999924 4 -0.019046309999999924 5 -0.019046309999999924 6 -0.019046309999999924
		 7 -0.019046309999999924 8 -0.019046309999999924 9 -0.019046309999999924 10 -0.019046309999999924
		 11 -0.019046309999999924 12 -0.019046309999999924 13 -0.019046309999999924 14 -0.019046309999999924
		 15 -0.019046309999999924 16 -0.019046309999999924 17 -0.019046309999999924 18 -0.019046309999999924
		 19 -0.019046309999999924 20 -0.019046309999999924 21 -0.019046309999999924 22 -0.019046309999999924
		 23 -0.019046309999999924;
createNode animCurveTA -n "jnt_R_Thumb2_rotateX";
	rename -uid "80BA63EA-4771-F65A-108D-DA8F91670E78";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 8.0342982527927536 2 8.0342982527927536
		 3 8.0342982527927536 4 8.0342982527927536 5 8.0342982527927536 6 8.0342982527927536
		 7 8.0342982527927536 8 8.0342982527927536 9 8.0342982527927536 10 8.0342982527927536
		 11 8.0342982527927536 12 8.0342982527927536 13 8.0342982527927536 14 8.0342982527927536
		 15 8.0342982527927536 16 8.0342982527927536 17 8.0342982527927536 18 8.0342982527927536
		 19 8.0342982527927536 20 8.0342982527927536 21 8.0342982527927536 22 8.0342982527927536
		 23 8.0342982527927536;
createNode animCurveTA -n "jnt_R_Thumb2_rotateY";
	rename -uid "E82B036C-4E2C-B4A6-5FF1-8CA3A6678B42";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 4.1189746948125361 2 4.1189746948125361
		 3 4.1189746948125361 4 4.1189746948125361 5 4.1189746948125361 6 4.1189746948125361
		 7 4.1189746948125361 8 4.1189746948125361 9 4.1189746948125361 10 4.1189746948125361
		 11 4.1189746948125361 12 4.1189746948125361 13 4.1189746948125361 14 4.1189746948125361
		 15 4.1189746948125361 16 4.1189746948125361 17 4.1189746948125361 18 4.1189746948125361
		 19 4.1189746948125361 20 4.1189746948125361 21 4.1189746948125361 22 4.1189746948125361
		 23 4.1189746948125361;
createNode animCurveTA -n "jnt_R_Thumb2_rotateZ";
	rename -uid "E2AD5F95-4987-D13C-61F4-589CB46A511C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -12.254707014995049 2 -12.254707014995049
		 3 -12.254707014995049 4 -12.254707014995049 5 -12.254707014995049 6 -12.254707014995049
		 7 -12.254707014995049 8 -12.254707014995049 9 -12.254707014995049 10 -12.254707014995049
		 11 -12.254707014995049 12 -12.254707014995049 13 -12.254707014995049 14 -12.254707014995049
		 15 -12.254707014995049 16 -12.254707014995049 17 -12.254707014995049 18 -12.254707014995049
		 19 -12.254707014995049 20 -12.254707014995049 21 -12.254707014995049 22 -12.254707014995049
		 23 -12.254707014995049;
createNode animCurveTU -n "jnt_R_Thumb2_scaleX";
	rename -uid "D32A702C-4DAE-523A-3A60-859F1174DAB1";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Thumb2_scaleY";
	rename -uid "8816CF7D-447B-ECA1-8307-F3B3F44F9120";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Thumb2_scaleZ";
	rename -uid "4AD4970B-4E0A-0037-CDD2-5B97AF8464B1";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Thumb2_visibility";
	rename -uid "6646C877-45E1-6E7C-8BC7-A3971E45C289";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Thumb2_translateX";
	rename -uid "C6E1C838-4DF0-9C29-3E26-A39DBBEC41A5";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.017136232768364509 2 -0.017136232768364509
		 3 -0.017136232768364509 4 -0.017136232768364509 5 -0.017136232768364509 6 -0.017136232768364509
		 7 -0.017136232768364509 8 -0.017136232768364509 9 -0.017136232768364509 10 -0.017136232768364509
		 11 -0.017136232768364509 12 -0.017136232768364509 13 -0.017136232768364509 14 -0.017136232768364509
		 15 -0.017136232768364509 16 -0.017136232768364509 17 -0.017136232768364509 18 -0.017136232768364509
		 19 -0.017136232768364509 20 -0.017136232768364509 21 -0.017136232768364509 22 -0.017136232768364509
		 23 -0.017136232768364509;
createNode animCurveTL -n "jnt_R_Thumb2_translateY";
	rename -uid "0834690B-4F07-2F17-BFCE-708A79F53380";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -2.1316282072803005e-016 2 -2.1316282072803005e-016
		 3 -2.1316282072803005e-016 4 -2.1316282072803005e-016 5 -2.1316282072803005e-016
		 6 -2.1316282072803005e-016 7 -2.1316282072803005e-016 8 -2.1316282072803005e-016
		 9 -2.1316282072803005e-016 10 -2.1316282072803005e-016 11 -2.1316282072803005e-016
		 12 -2.1316282072803005e-016 13 -2.1316282072803005e-016 14 -2.1316282072803005e-016
		 15 -2.1316282072803005e-016 16 -2.1316282072803005e-016 17 -2.1316282072803005e-016
		 18 -2.1316282072803005e-016 19 -2.1316282072803005e-016 20 -2.1316282072803005e-016
		 21 -2.1316282072803005e-016 22 -2.1316282072803005e-016 23 -2.1316282072803005e-016;
createNode animCurveTL -n "jnt_R_Thumb2_translateZ";
	rename -uid "EFBC8F0F-4B2B-B0A3-939A-808329B0B12B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.0038874523555324459 2 -0.0038874523555324459
		 3 -0.0038874523555324459 4 -0.0038874523555324459 5 -0.0038874523555324459 6 -0.0038874523555324459
		 7 -0.0038874523555324459 8 -0.0038874523555324459 9 -0.0038874523555324459 10 -0.0038874523555324459
		 11 -0.0038874523555324459 12 -0.0038874523555324459 13 -0.0038874523555324459 14 -0.0038874523555324459
		 15 -0.0038874523555324459 16 -0.0038874523555324459 17 -0.0038874523555324459 18 -0.0038874523555324459
		 19 -0.0038874523555324459 20 -0.0038874523555324459 21 -0.0038874523555324459 22 -0.0038874523555324459
		 23 -0.0038874523555324459;
createNode animCurveTA -n "jnt_R_Thumb3_rotateX";
	rename -uid "162323B2-4840-1DF0-6AA6-ECAA99C26A99";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 41.803314565111855 2 41.803314565111855
		 3 41.803314565111855 4 41.803314565111855 5 41.803314565111855 6 41.803314565111855
		 7 41.803314565111855 8 41.803314565111855 9 41.803314565111855 10 41.803314565111855
		 11 41.803314565111855 12 41.803314565111855 13 41.803314565111855 14 41.803314565111855
		 15 41.803314565111855 16 41.803314565111855 17 41.803314565111855 18 41.803314565111855
		 19 41.803314565111855 20 41.803314565111855 21 41.803314565111855 22 41.803314565111855
		 23 41.803314565111855;
createNode animCurveTA -n "jnt_R_Thumb3_rotateY";
	rename -uid "2CD35C23-42FB-6C48-F48C-A3A69FBE8A91";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 15.468041811736201 2 15.468041811736201
		 3 15.468041811736201 4 15.468041811736201 5 15.468041811736201 6 15.468041811736201
		 7 15.468041811736201 8 15.468041811736201 9 15.468041811736201 10 15.468041811736201
		 11 15.468041811736201 12 15.468041811736201 13 15.468041811736201 14 15.468041811736201
		 15 15.468041811736201 16 15.468041811736201 17 15.468041811736201 18 15.468041811736201
		 19 15.468041811736201 20 15.468041811736201 21 15.468041811736201 22 15.468041811736201
		 23 15.468041811736201;
createNode animCurveTA -n "jnt_R_Thumb3_rotateZ";
	rename -uid "F457E22A-4B21-BDB3-66BF-309E2CD1CDEA";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -30.176538860634412 2 -30.176538860634412
		 3 -30.176538860634412 4 -30.176538860634412 5 -30.176538860634412 6 -30.176538860634412
		 7 -30.176538860634412 8 -30.176538860634412 9 -30.176538860634412 10 -30.176538860634412
		 11 -30.176538860634412 12 -30.176538860634412 13 -30.176538860634412 14 -30.176538860634412
		 15 -30.176538860634412 16 -30.176538860634412 17 -30.176538860634412 18 -30.176538860634412
		 19 -30.176538860634412 20 -30.176538860634412 21 -30.176538860634412 22 -30.176538860634412
		 23 -30.176538860634412;
createNode animCurveTU -n "jnt_R_Thumb3_scaleX";
	rename -uid "ED725A20-4C3A-71B5-B26F-A8AD59A0954D";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Thumb3_scaleY";
	rename -uid "3EED071A-45D1-138A-87DC-71B4D09B2246";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Thumb3_scaleZ";
	rename -uid "CC933425-4078-605E-6B4F-E784A93314D0";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Thumb3_visibility";
	rename -uid "C4802252-49BB-2696-2697-18805B900923";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Thumb3_translateX";
	rename -uid "F9186D14-41AA-C7BE-3D45-F38203FC8D54";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.020554254758513354 2 -0.020554254758513354
		 3 -0.020554254758513354 4 -0.020554254758513354 5 -0.020554254758513354 6 -0.020554254758513354
		 7 -0.020554254758513354 8 -0.020554254758513354 9 -0.020554254758513354 10 -0.020554254758513354
		 11 -0.020554254758513354 12 -0.020554254758513354 13 -0.020554254758513354 14 -0.020554254758513354
		 15 -0.020554254758513354 16 -0.020554254758513354 17 -0.020554254758513354 18 -0.020554254758513354
		 19 -0.020554254758513354 20 -0.020554254758513354 21 -0.020554254758513354 22 -0.020554254758513354
		 23 -0.020554254758513354;
createNode animCurveTL -n "jnt_R_Thumb3_translateY";
	rename -uid "DA553013-4BFB-118B-DA74-1EAECA583A80";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -2.25609760218741e-016 2 -2.25609760218741e-016
		 3 -2.25609760218741e-016 4 -2.25609760218741e-016 5 -2.25609760218741e-016 6 -2.25609760218741e-016
		 7 -2.25609760218741e-016 8 -2.25609760218741e-016 9 -2.25609760218741e-016 10 -2.25609760218741e-016
		 11 -2.25609760218741e-016 12 -2.25609760218741e-016 13 -2.25609760218741e-016 14 -2.25609760218741e-016
		 15 -2.25609760218741e-016 16 -2.25609760218741e-016 17 -2.25609760218741e-016 18 -2.25609760218741e-016
		 19 -2.25609760218741e-016 20 -2.25609760218741e-016 21 -2.25609760218741e-016 22 -2.25609760218741e-016
		 23 -2.25609760218741e-016;
createNode animCurveTL -n "jnt_R_Thumb3_translateZ";
	rename -uid "830408A4-4B10-2957-131F-47BE1C87508E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.0018093273386389156 2 0.0018093273386389156
		 3 0.0018093273386389156 4 0.0018093273386389156 5 0.0018093273386389156 6 0.0018093273386389156
		 7 0.0018093273386389156 8 0.0018093273386389156 9 0.0018093273386389156 10 0.0018093273386389156
		 11 0.0018093273386389156 12 0.0018093273386389156 13 0.0018093273386389156 14 0.0018093273386389156
		 15 0.0018093273386389156 16 0.0018093273386389156 17 0.0018093273386389156 18 0.0018093273386389156
		 19 0.0018093273386389156 20 0.0018093273386389156 21 0.0018093273386389156 22 0.0018093273386389156
		 23 0.0018093273386389156;
createNode animCurveTA -n "jnt_R_Thumb4_rotateX";
	rename -uid "20F8A160-4C0E-DC80-C2C4-94849BB821F2";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 11.003912418272776 2 11.003912418272776
		 3 11.003912418272776 4 11.003912418272776 5 11.003912418272776 6 11.003912418272776
		 7 11.003912418272776 8 11.003912418272776 9 11.003912418272776 10 11.003912418272776
		 11 11.003912418272776 12 11.003912418272776 13 11.003912418272776 14 11.003912418272776
		 15 11.003912418272776 16 11.003912418272776 17 11.003912418272776 18 11.003912418272776
		 19 11.003912418272776 20 11.003912418272776 21 11.003912418272776 22 11.003912418272776
		 23 11.003912418272776;
createNode animCurveTA -n "jnt_R_Thumb4_rotateY";
	rename -uid "70F165E7-477A-8B1D-74A1-0FA64CD83D3E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 13.763889383284203 2 13.763889383284203
		 3 13.763889383284203 4 13.763889383284203 5 13.763889383284203 6 13.763889383284203
		 7 13.763889383284203 8 13.763889383284203 9 13.763889383284203 10 13.763889383284203
		 11 13.763889383284203 12 13.763889383284203 13 13.763889383284203 14 13.763889383284203
		 15 13.763889383284203 16 13.763889383284203 17 13.763889383284203 18 13.763889383284203
		 19 13.763889383284203 20 13.763889383284203 21 13.763889383284203 22 13.763889383284203
		 23 13.763889383284203;
createNode animCurveTA -n "jnt_R_Thumb4_rotateZ";
	rename -uid "EAB0E2FA-4842-77D5-AF3E-4C8D22E4BB19";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -2.0466164490976785e-016 2 -2.0466164490976785e-016
		 3 -2.0466164490976785e-016 4 -2.0466164490976785e-016 5 -2.0466164490976785e-016
		 6 -2.0466164490976785e-016 7 -2.0466164490976785e-016 8 -2.0466164490976785e-016
		 9 -2.0466164490976785e-016 10 -2.0466164490976785e-016 11 -2.0466164490976785e-016
		 12 -2.0466164490976785e-016 13 -2.0466164490976785e-016 14 -2.0466164490976785e-016
		 15 -2.0466164490976785e-016 16 -2.0466164490976785e-016 17 -2.0466164490976785e-016
		 18 -2.0466164490976785e-016 19 -2.0466164490976785e-016 20 -2.0466164490976785e-016
		 21 -2.0466164490976785e-016 22 -2.0466164490976785e-016 23 -2.0466164490976785e-016;
createNode animCurveTU -n "jnt_R_Thumb4_visibility";
	rename -uid "EA79621B-49BC-B6B1-38DB-A48CF3758B0B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Thumb4_translateX";
	rename -uid "5C10ACCC-4D80-3F49-B6AD-9589CF63279B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.019977797407058243 2 -0.019977797407058243
		 3 -0.019977797407058243 4 -0.019977797407058243 5 -0.019977797407058243 6 -0.019977797407058243
		 7 -0.019977797407058243 8 -0.019977797407058243 9 -0.019977797407058243 10 -0.019977797407058243
		 11 -0.019977797407058243 12 -0.019977797407058243 13 -0.019977797407058243 14 -0.019977797407058243
		 15 -0.019977797407058243 16 -0.019977797407058243 17 -0.019977797407058243 18 -0.019977797407058243
		 19 -0.019977797407058243 20 -0.019977797407058243 21 -0.019977797407058243 22 -0.019977797407058243
		 23 -0.019977797407058243;
createNode animCurveTL -n "jnt_R_Thumb4_translateY";
	rename -uid "8C347121-4DA2-07BA-E9FA-4B8D7174BD4C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 4.6160394594588053e-017 2 4.6160394594588053e-017
		 3 4.6160394594588053e-017 4 4.6160394594588053e-017 5 4.6160394594588053e-017 6 4.6160394594588053e-017
		 7 4.6160394594588053e-017 8 4.6160394594588053e-017 9 4.6160394594588053e-017 10 4.6160394594588053e-017
		 11 4.6160394594588053e-017 12 4.6160394594588053e-017 13 4.6160394594588053e-017
		 14 4.6160394594588053e-017 15 4.6160394594588053e-017 16 4.6160394594588053e-017
		 17 4.6160394594588053e-017 18 4.6160394594588053e-017 19 4.6160394594588053e-017
		 20 4.6160394594588053e-017 21 4.6160394594588053e-017 22 4.6160394594588053e-017
		 23 4.6160394594588053e-017;
createNode animCurveTL -n "jnt_R_Thumb4_translateZ";
	rename -uid "4CBAFB92-4FB2-D8FF-3279-EE841AA47838";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.00015750086255362177 2 -0.00015750086255362177
		 3 -0.00015750086255362177 4 -0.00015750086255362177 5 -0.00015750086255362177 6 -0.00015750086255362177
		 7 -0.00015750086255362177 8 -0.00015750086255362177 9 -0.00015750086255362177 10 -0.00015750086255362177
		 11 -0.00015750086255362177 12 -0.00015750086255362177 13 -0.00015750086255362177
		 14 -0.00015750086255362177 15 -0.00015750086255362177 16 -0.00015750086255362177
		 17 -0.00015750086255362177 18 -0.00015750086255362177 19 -0.00015750086255362177
		 20 -0.00015750086255362177 21 -0.00015750086255362177 22 -0.00015750086255362177
		 23 -0.00015750086255362177;
createNode animCurveTU -n "jnt_R_Thumb4_scaleX";
	rename -uid "BFF9C930-474C-9941-69DF-FBBA6D26F9E7";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Thumb4_scaleY";
	rename -uid "F8D21813-4E91-61D9-BA75-C6B8FFFE0ADF";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Thumb4_scaleZ";
	rename -uid "A12BE70F-4F31-9055-D933-87A0EC0D31E7";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTA -n "jnt_R_Index1_rotateZ";
	rename -uid "B6C46948-4459-2694-0CA1-5FBD1535AD40";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_R_Index1_rotateX";
	rename -uid "B0EEF8BE-405A-D25E-FB0A-D289EBF0843D";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_R_Index1_rotateY";
	rename -uid "D02433D9-4D37-4315-3768-51A1A4F8915D";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_R_Index1_scaleX";
	rename -uid "1C439734-4FC8-7C75-BD31-00B207FAC3BB";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Index1_scaleY";
	rename -uid "EC387BED-4DE9-1ECD-B642-D8A6ABF0E3EC";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Index1_scaleZ";
	rename -uid "1C8F053D-45F9-EC1A-F187-AA8E46630C9E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Index1_visibility";
	rename -uid "48A422CF-43D3-972E-DC04-9D8D1DBB94C0";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Index1_translateX";
	rename -uid "D0F5F6B0-4959-F300-FD22-689FD6CD4ECF";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.072937000000000016 2 -0.072937000000000016
		 3 -0.072937000000000016 4 -0.072937000000000016 5 -0.072937000000000016 6 -0.072937000000000016
		 7 -0.072937000000000016 8 -0.072937000000000016 9 -0.072937000000000016 10 -0.072937000000000016
		 11 -0.072937000000000016 12 -0.072937000000000016 13 -0.072937000000000016 14 -0.072937000000000016
		 15 -0.072937000000000016 16 -0.072937000000000016 17 -0.072937000000000016 18 -0.072937000000000016
		 19 -0.072937000000000016 20 -0.072937000000000016 21 -0.072937000000000016 22 -0.072937000000000016
		 23 -0.072937000000000016;
createNode animCurveTL -n "jnt_R_Index1_translateY";
	rename -uid "A4A9978E-4E56-F704-A1D4-898D68A3934A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.0019199999999998595 2 0.0019199999999998595
		 3 0.0019199999999998595 4 0.0019199999999998595 5 0.0019199999999998595 6 0.0019199999999998595
		 7 0.0019199999999998595 8 0.0019199999999998595 9 0.0019199999999998595 10 0.0019199999999998595
		 11 0.0019199999999998595 12 0.0019199999999998595 13 0.0019199999999998595 14 0.0019199999999998595
		 15 0.0019199999999998595 16 0.0019199999999998595 17 0.0019199999999998595 18 0.0019199999999998595
		 19 0.0019199999999998595 20 0.0019199999999998595 21 0.0019199999999998595 22 0.0019199999999998595
		 23 0.0019199999999998595;
createNode animCurveTL -n "jnt_R_Index1_translateZ";
	rename -uid "5A502CEE-4DE3-5A57-E497-1E86FA4E5247";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.014757724999999782 2 -0.014757724999999782
		 3 -0.014757724999999782 4 -0.014757724999999782 5 -0.014757724999999782 6 -0.014757724999999782
		 7 -0.014757724999999782 8 -0.014757724999999782 9 -0.014757724999999782 10 -0.014757724999999782
		 11 -0.014757724999999782 12 -0.014757724999999782 13 -0.014757724999999782 14 -0.014757724999999782
		 15 -0.014757724999999782 16 -0.014757724999999782 17 -0.014757724999999782 18 -0.014757724999999782
		 19 -0.014757724999999782 20 -0.014757724999999782 21 -0.014757724999999782 22 -0.014757724999999782
		 23 -0.014757724999999782;
createNode animCurveTA -n "jnt_R_Index2_rotateZ";
	rename -uid "3CF780B6-4A1D-5BA6-A629-FBBD8DCDCAAB";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_R_Index2_rotateX";
	rename -uid "3F625C13-4C30-45C4-613E-1CAA3E8B0DDE";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_R_Index2_rotateY";
	rename -uid "5607963B-43DF-E7E6-4708-ADB755477DA6";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_R_Index2_scaleX";
	rename -uid "EFC8FD63-4BFA-B184-166D-00AEFCE7DDED";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Index2_scaleY";
	rename -uid "D6A0D6EB-46A1-A8C2-4450-8C9AAD19539A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Index2_scaleZ";
	rename -uid "4390132F-4204-463A-CA49-AD8F14C47A18";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Index2_visibility";
	rename -uid "E0DF8F1A-47B2-A37F-F9CE-8686EBFBCE88";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Index2_translateX";
	rename -uid "6C7F33E6-4E4B-1337-73A2-12B9929425C4";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.018921681747479227 2 -0.018921681747479227
		 3 -0.018921681747479227 4 -0.018921681747479227 5 -0.018921681747479227 6 -0.018921681747479227
		 7 -0.018921681747479227 8 -0.018921681747479227 9 -0.018921681747479227 10 -0.018921681747479227
		 11 -0.018921681747479227 12 -0.018921681747479227 13 -0.018921681747479227 14 -0.018921681747479227
		 15 -0.018921681747479227 16 -0.018921681747479227 17 -0.018921681747479227 18 -0.018921681747479227
		 19 -0.018921681747479227 20 -0.018921681747479227 21 -0.018921681747479227 22 -0.018921681747479227
		 23 -0.018921681747479227;
createNode animCurveTL -n "jnt_R_Index2_translateY";
	rename -uid "516DD6C6-49E0-9A18-A830-33A9C84C6E98";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -7.105427357601002e-017 2 -7.105427357601002e-017
		 3 -7.105427357601002e-017 4 -7.105427357601002e-017 5 -7.105427357601002e-017 6 -7.105427357601002e-017
		 7 -7.105427357601002e-017 8 -7.105427357601002e-017 9 -7.105427357601002e-017 10 -7.105427357601002e-017
		 11 -7.105427357601002e-017 12 -7.105427357601002e-017 13 -7.105427357601002e-017
		 14 -7.105427357601002e-017 15 -7.105427357601002e-017 16 -7.105427357601002e-017
		 17 -7.105427357601002e-017 18 -7.105427357601002e-017 19 -7.105427357601002e-017
		 20 -7.105427357601002e-017 21 -7.105427357601002e-017 22 -7.105427357601002e-017
		 23 -7.105427357601002e-017;
createNode animCurveTL -n "jnt_R_Index2_translateZ";
	rename -uid "F95BE149-4706-768B-E018-6FB6373F09E8";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -3.3330372051221247e-009 2 -3.3330372051221247e-009
		 3 -3.3330372051221247e-009 4 -3.3330372051221247e-009 5 -3.3330372051221247e-009
		 6 -3.3330372051221247e-009 7 -3.3330372051221247e-009 8 -3.3330372051221247e-009
		 9 -3.3330372051221247e-009 10 -3.3330372051221247e-009 11 -3.3330372051221247e-009
		 12 -3.3330372051221247e-009 13 -3.3330372051221247e-009 14 -3.3330372051221247e-009
		 15 -3.3330372051221247e-009 16 -3.3330372051221247e-009 17 -3.3330372051221247e-009
		 18 -3.3330372051221247e-009 19 -3.3330372051221247e-009 20 -3.3330372051221247e-009
		 21 -3.3330372051221247e-009 22 -3.3330372051221247e-009 23 -3.3330372051221247e-009;
createNode animCurveTA -n "jnt_R_Index3_rotateZ";
	rename -uid "CC29D7D0-4B27-5EB9-1531-70A0F718CC8B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_R_Index3_rotateX";
	rename -uid "CC7A1F00-43B8-1917-2A70-DA8475281793";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_R_Index3_rotateY";
	rename -uid "8E692D3A-44FA-8921-8FE8-1AA5FD52122F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_R_Index3_scaleX";
	rename -uid "782F9090-498B-23C5-2668-CCBAA0112A57";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Index3_scaleY";
	rename -uid "589F89A8-41C3-B2DA-187D-E6ABF5830CF4";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Index3_scaleZ";
	rename -uid "F789713E-46EA-C15A-9249-E3B740D0C3B3";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Index3_visibility";
	rename -uid "DE464BB2-47A9-3060-1B37-6B9DE56041E9";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Index3_translateX";
	rename -uid "6C1F6746-4DDA-DCCE-0D20-77B9924C5D02";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.019426637965180051 2 -0.019426637965180051
		 3 -0.019426637965180051 4 -0.019426637965180051 5 -0.019426637965180051 6 -0.019426637965180051
		 7 -0.019426637965180051 8 -0.019426637965180051 9 -0.019426637965180051 10 -0.019426637965180051
		 11 -0.019426637965180051 12 -0.019426637965180051 13 -0.019426637965180051 14 -0.019426637965180051
		 15 -0.019426637965180051 16 -0.019426637965180051 17 -0.019426637965180051 18 -0.019426637965180051
		 19 -0.019426637965180051 20 -0.019426637965180051 21 -0.019426637965180051 22 -0.019426637965180051
		 23 -0.019426637965180051;
createNode animCurveTL -n "jnt_R_Index3_translateY";
	rename -uid "758E8C12-4A3F-27F2-F6D9-389390A26C1C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 7.105427357601002e-017 2 7.105427357601002e-017
		 3 7.105427357601002e-017 4 7.105427357601002e-017 5 7.105427357601002e-017 6 7.105427357601002e-017
		 7 7.105427357601002e-017 8 7.105427357601002e-017 9 7.105427357601002e-017 10 7.105427357601002e-017
		 11 7.105427357601002e-017 12 7.105427357601002e-017 13 7.105427357601002e-017 14 7.105427357601002e-017
		 15 7.105427357601002e-017 16 7.105427357601002e-017 17 7.105427357601002e-017 18 7.105427357601002e-017
		 19 7.105427357601002e-017 20 7.105427357601002e-017 21 7.105427357601002e-017 22 7.105427357601002e-017
		 23 7.105427357601002e-017;
createNode animCurveTL -n "jnt_R_Index3_translateZ";
	rename -uid "7E8A0A4E-405C-C4E4-AFDF-83A002B6A3AD";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 7.7266212983317921e-009 2 7.7266212983317921e-009
		 3 7.7266212983317921e-009 4 7.7266212983317921e-009 5 7.7266212983317921e-009 6 7.7266212983317921e-009
		 7 7.7266212983317921e-009 8 7.7266212983317921e-009 9 7.7266212983317921e-009 10 7.7266212983317921e-009
		 11 7.7266212983317921e-009 12 7.7266212983317921e-009 13 7.7266212983317921e-009
		 14 7.7266212983317921e-009 15 7.7266212983317921e-009 16 7.7266212983317921e-009
		 17 7.7266212983317921e-009 18 7.7266212983317921e-009 19 7.7266212983317921e-009
		 20 7.7266212983317921e-009 21 7.7266212983317921e-009 22 7.7266212983317921e-009
		 23 7.7266212983317921e-009;
createNode animCurveTA -n "jnt_R_Index4_rotateZ";
	rename -uid "03B57D0C-4CAE-DC02-B218-468EFF30BD1D";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_R_Index4_rotateX";
	rename -uid "2415A9FE-4467-1E46-C853-2686141BD183";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_R_Index4_rotateY";
	rename -uid "EEB8A876-4B86-2D3E-FCB0-B89A028EFCB7";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_R_Index4_visibility";
	rename -uid "5BBA8AF5-407D-4082-F538-228EF73F0F4B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Index4_translateX";
	rename -uid "82936268-4DE9-488D-5A0D-979049D062E7";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.013372379749052357 2 -0.013372379749052357
		 3 -0.013372379749052357 4 -0.013372379749052357 5 -0.013372379749052357 6 -0.013372379749052357
		 7 -0.013372379749052357 8 -0.013372379749052357 9 -0.013372379749052357 10 -0.013372379749052357
		 11 -0.013372379749052357 12 -0.013372379749052357 13 -0.013372379749052357 14 -0.013372379749052357
		 15 -0.013372379749052357 16 -0.013372379749052357 17 -0.013372379749052357 18 -0.013372379749052357
		 19 -0.013372379749052357 20 -0.013372379749052357 21 -0.013372379749052357 22 -0.013372379749052357
		 23 -0.013372379749052357;
createNode animCurveTL -n "jnt_R_Index4_translateY";
	rename -uid "4EE77267-4B9B-60E4-0A37-E1A5C31286C8";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 7.105427357601002e-017 2 7.105427357601002e-017
		 3 7.105427357601002e-017 4 7.105427357601002e-017 5 7.105427357601002e-017 6 7.105427357601002e-017
		 7 7.105427357601002e-017 8 7.105427357601002e-017 9 7.105427357601002e-017 10 7.105427357601002e-017
		 11 7.105427357601002e-017 12 7.105427357601002e-017 13 7.105427357601002e-017 14 7.105427357601002e-017
		 15 7.105427357601002e-017 16 7.105427357601002e-017 17 7.105427357601002e-017 18 7.105427357601002e-017
		 19 7.105427357601002e-017 20 7.105427357601002e-017 21 7.105427357601002e-017 22 7.105427357601002e-017
		 23 7.105427357601002e-017;
createNode animCurveTL -n "jnt_R_Index4_translateZ";
	rename -uid "315A7019-40E7-F47E-7644-1AB9431799E0";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -5.8480158826590416e-009 2 -5.8480158826590416e-009
		 3 -5.8480158826590416e-009 4 -5.8480158826590416e-009 5 -5.8480158826590416e-009
		 6 -5.8480158826590416e-009 7 -5.8480158826590416e-009 8 -5.8480158826590416e-009
		 9 -5.8480158826590416e-009 10 -5.8480158826590416e-009 11 -5.8480158826590416e-009
		 12 -5.8480158826590416e-009 13 -5.8480158826590416e-009 14 -5.8480158826590416e-009
		 15 -5.8480158826590416e-009 16 -5.8480158826590416e-009 17 -5.8480158826590416e-009
		 18 -5.8480158826590416e-009 19 -5.8480158826590416e-009 20 -5.8480158826590416e-009
		 21 -5.8480158826590416e-009 22 -5.8480158826590416e-009 23 -5.8480158826590416e-009;
createNode animCurveTU -n "jnt_R_Index4_scaleX";
	rename -uid "66BACE3B-445A-BE96-C14A-32A4561C5679";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Index4_scaleY";
	rename -uid "0225C884-4986-4DE2-F050-B79DE917C588";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Index4_scaleZ";
	rename -uid "ECC42AB4-49A3-1EE6-4716-86878C363DE3";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTA -n "jnt_R_Middle1_rotateZ";
	rename -uid "1525B518-4B28-6840-9C98-C188A56ED4B0";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_R_Middle1_rotateX";
	rename -uid "C06F46D3-44C8-8B40-FF88-AEA5288D738A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_R_Middle1_rotateY";
	rename -uid "4549DA8D-41F5-FA23-A878-AB92B2CFF287";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_R_Middle1_scaleX";
	rename -uid "6881B0C9-4AEF-7328-C835-9B93B256B818";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Middle1_scaleY";
	rename -uid "955EF467-4583-9D3D-17C1-5390EC3C8CBB";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Middle1_scaleZ";
	rename -uid "8B2BAE8C-42DC-7941-3F9C-38A92E2BE736";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Middle1_visibility";
	rename -uid "13A8A9EF-4619-D913-419A-DBA696575B85";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Middle1_translateX";
	rename -uid "7D9753B9-4D69-128F-4BF0-04B6985691DD";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.078739000000000059 2 -0.078739000000000059
		 3 -0.078739000000000059 4 -0.078739000000000059 5 -0.078739000000000059 6 -0.078739000000000059
		 7 -0.078739000000000059 8 -0.078739000000000059 9 -0.078739000000000059 10 -0.078739000000000059
		 11 -0.078739000000000059 12 -0.078739000000000059 13 -0.078739000000000059 14 -0.078739000000000059
		 15 -0.078739000000000059 16 -0.078739000000000059 17 -0.078739000000000059 18 -0.078739000000000059
		 19 -0.078739000000000059 20 -0.078739000000000059 21 -0.078739000000000059 22 -0.078739000000000059
		 23 -0.078739000000000059;
createNode animCurveTL -n "jnt_R_Middle1_translateY";
	rename -uid "D23C6D18-4BE6-1500-1C09-F38F475E786E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.0019200000000000731 2 0.0019200000000000731
		 3 0.0019200000000000731 4 0.0019200000000000731 5 0.0019200000000000731 6 0.0019200000000000731
		 7 0.0019200000000000731 8 0.0019200000000000731 9 0.0019200000000000731 10 0.0019200000000000731
		 11 0.0019200000000000731 12 0.0019200000000000731 13 0.0019200000000000731 14 0.0019200000000000731
		 15 0.0019200000000000731 16 0.0019200000000000731 17 0.0019200000000000731 18 0.0019200000000000731
		 19 0.0019200000000000731 20 0.0019200000000000731 21 0.0019200000000000731 22 0.0019200000000000731
		 23 0.0019200000000000731;
createNode animCurveTL -n "jnt_R_Middle1_translateZ";
	rename -uid "09A579A3-46CE-8347-52A8-08A7A3F2D43A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.002144199999999763 2 -0.002144199999999763
		 3 -0.002144199999999763 4 -0.002144199999999763 5 -0.002144199999999763 6 -0.002144199999999763
		 7 -0.002144199999999763 8 -0.002144199999999763 9 -0.002144199999999763 10 -0.002144199999999763
		 11 -0.002144199999999763 12 -0.002144199999999763 13 -0.002144199999999763 14 -0.002144199999999763
		 15 -0.002144199999999763 16 -0.002144199999999763 17 -0.002144199999999763 18 -0.002144199999999763
		 19 -0.002144199999999763 20 -0.002144199999999763 21 -0.002144199999999763 22 -0.002144199999999763
		 23 -0.002144199999999763;
createNode animCurveTA -n "jnt_R_Middle2_rotateZ";
	rename -uid "4AE66233-4D75-B04F-B820-2DADA59B7FF8";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_R_Middle2_rotateX";
	rename -uid "0C5B828A-4699-6B71-D09A-33831B7C8EF5";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_R_Middle2_rotateY";
	rename -uid "B2B0B64D-4E4D-D069-AC84-E38092A6F31A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_R_Middle2_scaleX";
	rename -uid "38A2920A-4286-BD6B-00DD-E8B8B1D82AEE";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Middle2_scaleY";
	rename -uid "5F07BE5C-45B5-D154-58BC-799453D56383";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Middle2_scaleZ";
	rename -uid "612C56EF-4D3D-A764-C56C-DEA53BE283C6";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Middle2_visibility";
	rename -uid "22FF89EC-465D-0933-E458-92A2E79D2CA1";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Middle2_translateX";
	rename -uid "30A23527-4C0B-5D60-5602-ADA424D2E296";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.017200315286476239 2 -0.017200315286476239
		 3 -0.017200315286476239 4 -0.017200315286476239 5 -0.017200315286476239 6 -0.017200315286476239
		 7 -0.017200315286476239 8 -0.017200315286476239 9 -0.017200315286476239 10 -0.017200315286476239
		 11 -0.017200315286476239 12 -0.017200315286476239 13 -0.017200315286476239 14 -0.017200315286476239
		 15 -0.017200315286476239 16 -0.017200315286476239 17 -0.017200315286476239 18 -0.017200315286476239
		 19 -0.017200315286476239 20 -0.017200315286476239 21 -0.017200315286476239 22 -0.017200315286476239
		 23 -0.017200315286476239;
createNode animCurveTL -n "jnt_R_Middle2_translateY";
	rename -uid "E5994EDC-4CC1-ACED-23EB-2A93AFB5E747";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -1.4210854715202004e-016 2 -1.4210854715202004e-016
		 3 -1.4210854715202004e-016 4 -1.4210854715202004e-016 5 -1.4210854715202004e-016
		 6 -1.4210854715202004e-016 7 -1.4210854715202004e-016 8 -1.4210854715202004e-016
		 9 -1.4210854715202004e-016 10 -1.4210854715202004e-016 11 -1.4210854715202004e-016
		 12 -1.4210854715202004e-016 13 -1.4210854715202004e-016 14 -1.4210854715202004e-016
		 15 -1.4210854715202004e-016 16 -1.4210854715202004e-016 17 -1.4210854715202004e-016
		 18 -1.4210854715202004e-016 19 -1.4210854715202004e-016 20 -1.4210854715202004e-016
		 21 -1.4210854715202004e-016 22 -1.4210854715202004e-016 23 -1.4210854715202004e-016;
createNode animCurveTL -n "jnt_R_Middle2_translateZ";
	rename -uid "9EC05590-4AEE-DED7-4EB1-C4879D679194";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -7.6264700794581582e-008 2 -7.6264700794581582e-008
		 3 -7.6264700794581582e-008 4 -7.6264700794581582e-008 5 -7.6264700794581582e-008
		 6 -7.6264700794581582e-008 7 -7.6264700794581582e-008 8 -7.6264700794581582e-008
		 9 -7.6264700794581582e-008 10 -7.6264700794581582e-008 11 -7.6264700794581582e-008
		 12 -7.6264700794581582e-008 13 -7.6264700794581582e-008 14 -7.6264700794581582e-008
		 15 -7.6264700794581582e-008 16 -7.6264700794581582e-008 17 -7.6264700794581582e-008
		 18 -7.6264700794581582e-008 19 -7.6264700794581582e-008 20 -7.6264700794581582e-008
		 21 -7.6264700794581582e-008 22 -7.6264700794581582e-008 23 -7.6264700794581582e-008;
createNode animCurveTA -n "jnt_R_Middle3_rotateZ";
	rename -uid "D0DA7EE8-4936-95D2-4B17-399100C34CDD";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_R_Middle3_rotateX";
	rename -uid "964AA565-4205-249F-7C0C-D592342751C0";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_R_Middle3_rotateY";
	rename -uid "6E87F6AF-4D75-7F66-3F87-B48A8536B2FC";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_R_Middle3_scaleX";
	rename -uid "B79E5618-4C76-AF68-82D0-DEBF314FEC1F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Middle3_scaleY";
	rename -uid "868DD853-4251-05C0-C7CF-CB940E44E2BC";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Middle3_scaleZ";
	rename -uid "BE337103-42F2-F83A-E4DB-51B314E2A86A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Middle3_visibility";
	rename -uid "6E9748AF-4FCA-65A5-F934-C4AB9C609307";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Middle3_translateX";
	rename -uid "90E0D535-4747-F061-B5DB-4BB810417291";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.016657641497160681 2 -0.016657641497160681
		 3 -0.016657641497160681 4 -0.016657641497160681 5 -0.016657641497160681 6 -0.016657641497160681
		 7 -0.016657641497160681 8 -0.016657641497160681 9 -0.016657641497160681 10 -0.016657641497160681
		 11 -0.016657641497160681 12 -0.016657641497160681 13 -0.016657641497160681 14 -0.016657641497160681
		 15 -0.016657641497160681 16 -0.016657641497160681 17 -0.016657641497160681 18 -0.016657641497160681
		 19 -0.016657641497160681 20 -0.016657641497160681 21 -0.016657641497160681 22 -0.016657641497160681
		 23 -0.016657641497160681;
createNode animCurveTL -n "jnt_R_Middle3_translateY";
	rename -uid "4654C342-4EA0-AD87-5858-CEB1140E2BDA";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1.4210854715202004e-016 2 1.4210854715202004e-016
		 3 1.4210854715202004e-016 4 1.4210854715202004e-016 5 1.4210854715202004e-016 6 1.4210854715202004e-016
		 7 1.4210854715202004e-016 8 1.4210854715202004e-016 9 1.4210854715202004e-016 10 1.4210854715202004e-016
		 11 1.4210854715202004e-016 12 1.4210854715202004e-016 13 1.4210854715202004e-016
		 14 1.4210854715202004e-016 15 1.4210854715202004e-016 16 1.4210854715202004e-016
		 17 1.4210854715202004e-016 18 1.4210854715202004e-016 19 1.4210854715202004e-016
		 20 1.4210854715202004e-016 21 1.4210854715202004e-016 22 1.4210854715202004e-016
		 23 1.4210854715202004e-016;
createNode animCurveTL -n "jnt_R_Middle3_translateZ";
	rename -uid "614575B3-430A-8844-0420-4785093DF26D";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 4.5433690019081041e-008 2 4.5433690019081041e-008
		 3 4.5433690019081041e-008 4 4.5433690019081041e-008 5 4.5433690019081041e-008 6 4.5433690019081041e-008
		 7 4.5433690019081041e-008 8 4.5433690019081041e-008 9 4.5433690019081041e-008 10 4.5433690019081041e-008
		 11 4.5433690019081041e-008 12 4.5433690019081041e-008 13 4.5433690019081041e-008
		 14 4.5433690019081041e-008 15 4.5433690019081041e-008 16 4.5433690019081041e-008
		 17 4.5433690019081041e-008 18 4.5433690019081041e-008 19 4.5433690019081041e-008
		 20 4.5433690019081041e-008 21 4.5433690019081041e-008 22 4.5433690019081041e-008
		 23 4.5433690019081041e-008;
createNode animCurveTA -n "jnt_R_Middle4_rotateZ";
	rename -uid "35FC84E7-4657-3543-D204-33B2A8916C43";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_R_Middle4_rotateX";
	rename -uid "B93F7407-4129-3B62-B54A-4092EDB21DD1";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_R_Middle4_rotateY";
	rename -uid "E7EF4FAC-49D6-FFEE-BF87-7B984DD8BC67";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_R_Middle4_visibility";
	rename -uid "3E3B1C45-4313-0376-1B22-3EACE83C95B5";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Middle4_translateX";
	rename -uid "AAA07040-43FA-3A78-1451-FAA49DB8F05A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.018164750860827184 2 -0.018164750860827184
		 3 -0.018164750860827184 4 -0.018164750860827184 5 -0.018164750860827184 6 -0.018164750860827184
		 7 -0.018164750860827184 8 -0.018164750860827184 9 -0.018164750860827184 10 -0.018164750860827184
		 11 -0.018164750860827184 12 -0.018164750860827184 13 -0.018164750860827184 14 -0.018164750860827184
		 15 -0.018164750860827184 16 -0.018164750860827184 17 -0.018164750860827184 18 -0.018164750860827184
		 19 -0.018164750860827184 20 -0.018164750860827184 21 -0.018164750860827184 22 -0.018164750860827184
		 23 -0.018164750860827184;
createNode animCurveTL -n "jnt_R_Middle4_translateY";
	rename -uid "3F0D7392-4D08-ED23-FBCC-8AAF8DAEF9AD";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTL -n "jnt_R_Middle4_translateZ";
	rename -uid "12E52AFC-4A42-30CD-1F2F-57A7F65F7417";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -6.3882727602201931e-008 2 -6.3882727602201931e-008
		 3 -6.3882727602201931e-008 4 -6.3882727602201931e-008 5 -6.3882727602201931e-008
		 6 -6.3882727602201931e-008 7 -6.3882727602201931e-008 8 -6.3882727602201931e-008
		 9 -6.3882727602201931e-008 10 -6.3882727602201931e-008 11 -6.3882727602201931e-008
		 12 -6.3882727602201931e-008 13 -6.3882727602201931e-008 14 -6.3882727602201931e-008
		 15 -6.3882727602201931e-008 16 -6.3882727602201931e-008 17 -6.3882727602201931e-008
		 18 -6.3882727602201931e-008 19 -6.3882727602201931e-008 20 -6.3882727602201931e-008
		 21 -6.3882727602201931e-008 22 -6.3882727602201931e-008 23 -6.3882727602201931e-008;
createNode animCurveTU -n "jnt_R_Middle4_scaleX";
	rename -uid "A77A0D8C-4C60-E92F-7F1D-49AAEFBBA7CF";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Middle4_scaleY";
	rename -uid "7936A02F-49D8-63B6-D2D9-43A092D21F8F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Middle4_scaleZ";
	rename -uid "6D7D49E2-476A-7A20-7BAC-0791764D7F47";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTA -n "jnt_R_Ring1_rotateZ";
	rename -uid "64A4DA7F-49B2-14B0-499E-208695FB8571";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_R_Ring1_rotateX";
	rename -uid "8ACF941A-4D7D-7625-6846-DBBA37446B4A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_R_Ring1_rotateY";
	rename -uid "436FEF55-4452-3609-B363-068A8988D4E2";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_R_Ring1_scaleX";
	rename -uid "2DB0B00F-4751-62C8-4756-43A237E59291";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Ring1_scaleY";
	rename -uid "2391CA40-4E80-6ABF-6054-51911C21E33C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Ring1_scaleZ";
	rename -uid "050A571D-411D-1F76-0569-EDB2577C87D7";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Ring1_visibility";
	rename -uid "B1A663E3-4141-03FB-F0E2-86923A8FD702";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Ring1_translateX";
	rename -uid "AAAEDE06-4CF7-39D4-8C59-4C96FC583402";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.07873899999999992 2 -0.07873899999999992
		 3 -0.07873899999999992 4 -0.07873899999999992 5 -0.07873899999999992 6 -0.07873899999999992
		 7 -0.07873899999999992 8 -0.07873899999999992 9 -0.07873899999999992 10 -0.07873899999999992
		 11 -0.07873899999999992 12 -0.07873899999999992 13 -0.07873899999999992 14 -0.07873899999999992
		 15 -0.07873899999999992 16 -0.07873899999999992 17 -0.07873899999999992 18 -0.07873899999999992
		 19 -0.07873899999999992 20 -0.07873899999999992 21 -0.07873899999999992 22 -0.07873899999999992
		 23 -0.07873899999999992;
createNode animCurveTL -n "jnt_R_Ring1_translateY";
	rename -uid "A248818D-47F6-FBBB-5518-EDB3129E9BB9";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.0019200000000002149 2 0.0019200000000002149
		 3 0.0019200000000002149 4 0.0019200000000002149 5 0.0019200000000002149 6 0.0019200000000002149
		 7 0.0019200000000002149 8 0.0019200000000002149 9 0.0019200000000002149 10 0.0019200000000002149
		 11 0.0019200000000002149 12 0.0019200000000002149 13 0.0019200000000002149 14 0.0019200000000002149
		 15 0.0019200000000002149 16 0.0019200000000002149 17 0.0019200000000002149 18 0.0019200000000002149
		 19 0.0019200000000002149 20 0.0019200000000002149 21 0.0019200000000002149 22 0.0019200000000002149
		 23 0.0019200000000002149;
createNode animCurveTL -n "jnt_R_Ring1_translateZ";
	rename -uid "8E80AAE3-4183-0D07-D60E-0C921B8C911F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.0084511000000002338 2 0.0084511000000002338
		 3 0.0084511000000002338 4 0.0084511000000002338 5 0.0084511000000002338 6 0.0084511000000002338
		 7 0.0084511000000002338 8 0.0084511000000002338 9 0.0084511000000002338 10 0.0084511000000002338
		 11 0.0084511000000002338 12 0.0084511000000002338 13 0.0084511000000002338 14 0.0084511000000002338
		 15 0.0084511000000002338 16 0.0084511000000002338 17 0.0084511000000002338 18 0.0084511000000002338
		 19 0.0084511000000002338 20 0.0084511000000002338 21 0.0084511000000002338 22 0.0084511000000002338
		 23 0.0084511000000002338;
createNode animCurveTA -n "jnt_R_Ring2_rotateZ";
	rename -uid "0D3D603A-4102-D8B6-2317-CAACBEF79CC3";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_R_Ring2_rotateX";
	rename -uid "6AC0A1D0-47E3-BFE4-8C92-329E1FA99B77";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_R_Ring2_rotateY";
	rename -uid "743040C2-43F1-BD26-83E3-D6B43483A9B8";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_R_Ring2_scaleX";
	rename -uid "F78AC4B2-437D-3CBB-4317-C589E52DBE37";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Ring2_scaleY";
	rename -uid "F4B4F866-46CF-D63E-A531-818775EF716E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Ring2_scaleZ";
	rename -uid "EE812A71-4625-9A50-4D7F-63BDE0106BA4";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Ring2_visibility";
	rename -uid "C4FBF55F-4406-64BE-CD0B-FFBCD2B3CC64";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Ring2_translateX";
	rename -uid "703629C4-4268-DB81-FF1E-71A784805250";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.014630999999999972 2 -0.014630999999999972
		 3 -0.014630999999999972 4 -0.014630999999999972 5 -0.014630999999999972 6 -0.014630999999999972
		 7 -0.014630999999999972 8 -0.014630999999999972 9 -0.014630999999999972 10 -0.014630999999999972
		 11 -0.014630999999999972 12 -0.014630999999999972 13 -0.014630999999999972 14 -0.014630999999999972
		 15 -0.014630999999999972 16 -0.014630999999999972 17 -0.014630999999999972 18 -0.014630999999999972
		 19 -0.014630999999999972 20 -0.014630999999999972 21 -0.014630999999999972 22 -0.014630999999999972
		 23 -0.014630999999999972;
createNode animCurveTL -n "jnt_R_Ring2_translateY";
	rename -uid "9D498EF4-4BFF-B9EF-C8FC-979F1F0C6D60";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -7.105427357601002e-017 2 -7.105427357601002e-017
		 3 -7.105427357601002e-017 4 -7.105427357601002e-017 5 -7.105427357601002e-017 6 -7.105427357601002e-017
		 7 -7.105427357601002e-017 8 -7.105427357601002e-017 9 -7.105427357601002e-017 10 -7.105427357601002e-017
		 11 -7.105427357601002e-017 12 -7.105427357601002e-017 13 -7.105427357601002e-017
		 14 -7.105427357601002e-017 15 -7.105427357601002e-017 16 -7.105427357601002e-017
		 17 -7.105427357601002e-017 18 -7.105427357601002e-017 19 -7.105427357601002e-017
		 20 -7.105427357601002e-017 21 -7.105427357601002e-017 22 -7.105427357601002e-017
		 23 -7.105427357601002e-017;
createNode animCurveTL -n "jnt_R_Ring2_translateZ";
	rename -uid "DCC24AE5-473E-6E53-9CF9-5A84E7EADA35";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 4.8849813083506888e-017 2 4.8849813083506888e-017
		 3 4.8849813083506888e-017 4 4.8849813083506888e-017 5 4.8849813083506888e-017 6 4.8849813083506888e-017
		 7 4.8849813083506888e-017 8 4.8849813083506888e-017 9 4.8849813083506888e-017 10 4.8849813083506888e-017
		 11 4.8849813083506888e-017 12 4.8849813083506888e-017 13 4.8849813083506888e-017
		 14 4.8849813083506888e-017 15 4.8849813083506888e-017 16 4.8849813083506888e-017
		 17 4.8849813083506888e-017 18 4.8849813083506888e-017 19 4.8849813083506888e-017
		 20 4.8849813083506888e-017 21 4.8849813083506888e-017 22 4.8849813083506888e-017
		 23 4.8849813083506888e-017;
createNode animCurveTA -n "jnt_R_Ring3_rotateZ";
	rename -uid "5A53668F-4254-973C-5E72-C69B55365859";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_R_Ring3_rotateX";
	rename -uid "2950C83D-460B-CF5A-6E33-659856334DEF";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_R_Ring3_rotateY";
	rename -uid "9029D57E-4B25-9948-F0BB-8B91B70DD334";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_R_Ring3_scaleX";
	rename -uid "A5EBF4CB-4B50-95DE-7121-51A56EDA8BB3";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Ring3_scaleY";
	rename -uid "01F915DF-4E28-C09D-4BDF-B3A36372F288";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Ring3_scaleZ";
	rename -uid "42373345-45F9-C698-5FE1-D0A36136347D";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Ring3_visibility";
	rename -uid "81F69783-428B-1ACE-ACFF-BC8E8C60D946";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Ring3_translateX";
	rename -uid "9C2627DE-41DE-4552-2157-3F9DEC152FED";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.015640999999999964 2 -0.015640999999999964
		 3 -0.015640999999999964 4 -0.015640999999999964 5 -0.015640999999999964 6 -0.015640999999999964
		 7 -0.015640999999999964 8 -0.015640999999999964 9 -0.015640999999999964 10 -0.015640999999999964
		 11 -0.015640999999999964 12 -0.015640999999999964 13 -0.015640999999999964 14 -0.015640999999999964
		 15 -0.015640999999999964 16 -0.015640999999999964 17 -0.015640999999999964 18 -0.015640999999999964
		 19 -0.015640999999999964 20 -0.015640999999999964 21 -0.015640999999999964 22 -0.015640999999999964
		 23 -0.015640999999999964;
createNode animCurveTL -n "jnt_R_Ring3_translateY";
	rename -uid "41F092E9-4139-C972-D6C1-CFA21CE07B91";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTL -n "jnt_R_Ring3_translateZ";
	rename -uid "7357125D-4437-4975-23AD-3887BC4E08EC";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 4.8849813083506888e-017 2 4.8849813083506888e-017
		 3 4.8849813083506888e-017 4 4.8849813083506888e-017 5 4.8849813083506888e-017 6 4.8849813083506888e-017
		 7 4.8849813083506888e-017 8 4.8849813083506888e-017 9 4.8849813083506888e-017 10 4.8849813083506888e-017
		 11 4.8849813083506888e-017 12 4.8849813083506888e-017 13 4.8849813083506888e-017
		 14 4.8849813083506888e-017 15 4.8849813083506888e-017 16 4.8849813083506888e-017
		 17 4.8849813083506888e-017 18 4.8849813083506888e-017 19 4.8849813083506888e-017
		 20 4.8849813083506888e-017 21 4.8849813083506888e-017 22 4.8849813083506888e-017
		 23 4.8849813083506888e-017;
createNode animCurveTA -n "jnt_R_Ring4_rotateZ";
	rename -uid "4FF2CB2C-4F91-E8BF-E886-1890136BFFFC";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_R_Ring4_rotateX";
	rename -uid "176BB42C-493F-E7CF-5C16-A5A25613A2FA";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_R_Ring4_rotateY";
	rename -uid "E961121E-4AF2-0FF3-93FA-56BC8E785574";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_R_Ring4_visibility";
	rename -uid "634E1CBE-4380-505A-6D44-CBAE2083E789";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Ring4_translateX";
	rename -uid "9C83EDF9-4C43-E710-2D5B-8A9F91665D7B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.018459149112543118 2 -0.018459149112543118
		 3 -0.018459149112543118 4 -0.018459149112543118 5 -0.018459149112543118 6 -0.018459149112543118
		 7 -0.018459149112543118 8 -0.018459149112543118 9 -0.018459149112543118 10 -0.018459149112543118
		 11 -0.018459149112543118 12 -0.018459149112543118 13 -0.018459149112543118 14 -0.018459149112543118
		 15 -0.018459149112543118 16 -0.018459149112543118 17 -0.018459149112543118 18 -0.018459149112543118
		 19 -0.018459149112543118 20 -0.018459149112543118 21 -0.018459149112543118 22 -0.018459149112543118
		 23 -0.018459149112543118;
createNode animCurveTL -n "jnt_R_Ring4_translateY";
	rename -uid "168799CB-4181-0F06-44CF-EF9964AEAA42";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 7.105427357601002e-017 2 7.105427357601002e-017
		 3 7.105427357601002e-017 4 7.105427357601002e-017 5 7.105427357601002e-017 6 7.105427357601002e-017
		 7 7.105427357601002e-017 8 7.105427357601002e-017 9 7.105427357601002e-017 10 7.105427357601002e-017
		 11 7.105427357601002e-017 12 7.105427357601002e-017 13 7.105427357601002e-017 14 7.105427357601002e-017
		 15 7.105427357601002e-017 16 7.105427357601002e-017 17 7.105427357601002e-017 18 7.105427357601002e-017
		 19 7.105427357601002e-017 20 7.105427357601002e-017 21 7.105427357601002e-017 22 7.105427357601002e-017
		 23 7.105427357601002e-017;
createNode animCurveTL -n "jnt_R_Ring4_translateZ";
	rename -uid "13A92235-470F-A6D1-2D06-E295F6BA839D";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -3.0066543050821795e-008 2 -3.0066543050821795e-008
		 3 -3.0066543050821795e-008 4 -3.0066543050821795e-008 5 -3.0066543050821795e-008
		 6 -3.0066543050821795e-008 7 -3.0066543050821795e-008 8 -3.0066543050821795e-008
		 9 -3.0066543050821795e-008 10 -3.0066543050821795e-008 11 -3.0066543050821795e-008
		 12 -3.0066543050821795e-008 13 -3.0066543050821795e-008 14 -3.0066543050821795e-008
		 15 -3.0066543050821795e-008 16 -3.0066543050821795e-008 17 -3.0066543050821795e-008
		 18 -3.0066543050821795e-008 19 -3.0066543050821795e-008 20 -3.0066543050821795e-008
		 21 -3.0066543050821795e-008 22 -3.0066543050821795e-008 23 -3.0066543050821795e-008;
createNode animCurveTU -n "jnt_R_Ring4_scaleX";
	rename -uid "02156924-4612-D204-082D-5FBB78A468A3";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Ring4_scaleY";
	rename -uid "27108ADC-4F42-BBD3-A46D-DC8D55F38F99";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Ring4_scaleZ";
	rename -uid "4FC4272E-4C31-653A-63F4-BEA630D5B9A4";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTA -n "jnt_R_Pinky1_rotateZ";
	rename -uid "E0D3E47A-43CC-C1AA-A247-578E7FA4F99C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_R_Pinky1_rotateX";
	rename -uid "EDBBEDD6-41AF-EF99-2AD0-B48A4546F346";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_R_Pinky1_rotateY";
	rename -uid "58CD7FE0-404C-849B-693F-99A0B50FCAF2";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_R_Pinky1_scaleX";
	rename -uid "F978CEF9-45A1-5282-9028-BEBE11706F25";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Pinky1_scaleY";
	rename -uid "4380736A-4630-8077-AC2D-3F8A3BA7C1B4";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Pinky1_scaleZ";
	rename -uid "CAFF3779-48FC-1A0C-2C6D-939720CACE88";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Pinky1_visibility";
	rename -uid "EF13705C-465F-2E5F-2446-D891B5350E6F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Pinky1_translateX";
	rename -uid "F56D4889-4B53-BB8C-B9FF-8982872747AA";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.070917999999999926 2 -0.070917999999999926
		 3 -0.070917999999999926 4 -0.070917999999999926 5 -0.070917999999999926 6 -0.070917999999999926
		 7 -0.070917999999999926 8 -0.070917999999999926 9 -0.070917999999999926 10 -0.070917999999999926
		 11 -0.070917999999999926 12 -0.070917999999999926 13 -0.070917999999999926 14 -0.070917999999999926
		 15 -0.070917999999999926 16 -0.070917999999999926 17 -0.070917999999999926 18 -0.070917999999999926
		 19 -0.070917999999999926 20 -0.070917999999999926 21 -0.070917999999999926 22 -0.070917999999999926
		 23 -0.070917999999999926;
createNode animCurveTL -n "jnt_R_Pinky1_translateY";
	rename -uid "A1E2E9FA-4FFB-3AFF-7F80-FF9726D043D2";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.0019200000000002861 2 0.0019200000000002861
		 3 0.0019200000000002861 4 0.0019200000000002861 5 0.0019200000000002861 6 0.0019200000000002861
		 7 0.0019200000000002861 8 0.0019200000000002861 9 0.0019200000000002861 10 0.0019200000000002861
		 11 0.0019200000000002861 12 0.0019200000000002861 13 0.0019200000000002861 14 0.0019200000000002861
		 15 0.0019200000000002861 16 0.0019200000000002861 17 0.0019200000000002861 18 0.0019200000000002861
		 19 0.0019200000000002861 20 0.0019200000000002861 21 0.0019200000000002861 22 0.0019200000000002861
		 23 0.0019200000000002861;
createNode animCurveTL -n "jnt_R_Pinky1_translateZ";
	rename -uid "E634E3D0-4DDB-3B43-0525-00AAF8B4DB4F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.018289600000000208 2 0.018289600000000208
		 3 0.018289600000000208 4 0.018289600000000208 5 0.018289600000000208 6 0.018289600000000208
		 7 0.018289600000000208 8 0.018289600000000208 9 0.018289600000000208 10 0.018289600000000208
		 11 0.018289600000000208 12 0.018289600000000208 13 0.018289600000000208 14 0.018289600000000208
		 15 0.018289600000000208 16 0.018289600000000208 17 0.018289600000000208 18 0.018289600000000208
		 19 0.018289600000000208 20 0.018289600000000208 21 0.018289600000000208 22 0.018289600000000208
		 23 0.018289600000000208;
createNode animCurveTA -n "jnt_R_Pinky2_rotateZ";
	rename -uid "8BB7BA46-474B-4C22-3A16-AD8FB703BA01";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_R_Pinky2_rotateX";
	rename -uid "656C38CE-4497-431D-6328-B5A489ED438F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_R_Pinky2_rotateY";
	rename -uid "6E85C882-44D3-F4B6-48BD-BB9ADD828443";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_R_Pinky2_scaleX";
	rename -uid "B670268A-4AF2-FF5A-92BF-198481CB76B3";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Pinky2_scaleY";
	rename -uid "784A1570-43E2-F4B1-0E4D-9397A2AA8CDD";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Pinky2_scaleZ";
	rename -uid "593E60C0-4596-D3AB-8727-6A9E4642D63B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Pinky2_visibility";
	rename -uid "E82D93AF-4301-8E2D-201F-FC808BA21E60";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Pinky2_translateX";
	rename -uid "C4C8BCFD-4F7B-52F3-129A-07A97ECCD558";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.015155906942097062 2 -0.015155906942097062
		 3 -0.015155906942097062 4 -0.015155906942097062 5 -0.015155906942097062 6 -0.015155906942097062
		 7 -0.015155906942097062 8 -0.015155906942097062 9 -0.015155906942097062 10 -0.015155906942097062
		 11 -0.015155906942097062 12 -0.015155906942097062 13 -0.015155906942097062 14 -0.015155906942097062
		 15 -0.015155906942097062 16 -0.015155906942097062 17 -0.015155906942097062 18 -0.015155906942097062
		 19 -0.015155906942097062 20 -0.015155906942097062 21 -0.015155906942097062 22 -0.015155906942097062
		 23 -0.015155906942097062;
createNode animCurveTL -n "jnt_R_Pinky2_translateY";
	rename -uid "5747FD65-4F28-63EE-936A-8C8C2D091B89";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 7.105427357601002e-017 2 7.105427357601002e-017
		 3 7.105427357601002e-017 4 7.105427357601002e-017 5 7.105427357601002e-017 6 7.105427357601002e-017
		 7 7.105427357601002e-017 8 7.105427357601002e-017 9 7.105427357601002e-017 10 7.105427357601002e-017
		 11 7.105427357601002e-017 12 7.105427357601002e-017 13 7.105427357601002e-017 14 7.105427357601002e-017
		 15 7.105427357601002e-017 16 7.105427357601002e-017 17 7.105427357601002e-017 18 7.105427357601002e-017
		 19 7.105427357601002e-017 20 7.105427357601002e-017 21 7.105427357601002e-017 22 7.105427357601002e-017
		 23 7.105427357601002e-017;
createNode animCurveTL -n "jnt_R_Pinky2_translateZ";
	rename -uid "8044970F-4EA6-B6E5-522A-8990BEF09AAF";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -4.9937616930506579e-008 2 -4.9937616930506579e-008
		 3 -4.9937616930506579e-008 4 -4.9937616930506579e-008 5 -4.9937616930506579e-008
		 6 -4.9937616930506579e-008 7 -4.9937616930506579e-008 8 -4.9937616930506579e-008
		 9 -4.9937616930506579e-008 10 -4.9937616930506579e-008 11 -4.9937616930506579e-008
		 12 -4.9937616930506579e-008 13 -4.9937616930506579e-008 14 -4.9937616930506579e-008
		 15 -4.9937616930506579e-008 16 -4.9937616930506579e-008 17 -4.9937616930506579e-008
		 18 -4.9937616930506579e-008 19 -4.9937616930506579e-008 20 -4.9937616930506579e-008
		 21 -4.9937616930506579e-008 22 -4.9937616930506579e-008 23 -4.9937616930506579e-008;
createNode animCurveTA -n "jnt_R_Pinky3_rotateZ";
	rename -uid "9476386D-461E-B225-D915-97829998C517";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_R_Pinky3_rotateX";
	rename -uid "69AA6FFE-488E-90F3-7342-28B3D32ACCE0";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_R_Pinky3_rotateY";
	rename -uid "45908378-4D78-D0B6-F63B-BA8DB46ED723";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_R_Pinky3_scaleX";
	rename -uid "55CA834C-44B2-DE01-CA73-949D02746A9C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Pinky3_scaleY";
	rename -uid "24CCB091-4555-85F5-6237-F18DF097429E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Pinky3_scaleZ";
	rename -uid "7EBCCDEF-4F8E-84B1-2995-95B6CC29C9C9";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Pinky3_visibility";
	rename -uid "E2A88888-4952-0B80-88D8-05B41AE7E425";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Pinky3_translateX";
	rename -uid "C0BC3ACD-46F8-67A5-B650-7090C1B1A383";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.014630999999999972 2 -0.014630999999999972
		 3 -0.014630999999999972 4 -0.014630999999999972 5 -0.014630999999999972 6 -0.014630999999999972
		 7 -0.014630999999999972 8 -0.014630999999999972 9 -0.014630999999999972 10 -0.014630999999999972
		 11 -0.014630999999999972 12 -0.014630999999999972 13 -0.014630999999999972 14 -0.014630999999999972
		 15 -0.014630999999999972 16 -0.014630999999999972 17 -0.014630999999999972 18 -0.014630999999999972
		 19 -0.014630999999999972 20 -0.014630999999999972 21 -0.014630999999999972 22 -0.014630999999999972
		 23 -0.014630999999999972;
createNode animCurveTL -n "jnt_R_Pinky3_translateY";
	rename -uid "2D7BAD28-429E-8BA9-7F2C-7088E0437CCF";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -7.105427357601002e-017 2 -7.105427357601002e-017
		 3 -7.105427357601002e-017 4 -7.105427357601002e-017 5 -7.105427357601002e-017 6 -7.105427357601002e-017
		 7 -7.105427357601002e-017 8 -7.105427357601002e-017 9 -7.105427357601002e-017 10 -7.105427357601002e-017
		 11 -7.105427357601002e-017 12 -7.105427357601002e-017 13 -7.105427357601002e-017
		 14 -7.105427357601002e-017 15 -7.105427357601002e-017 16 -7.105427357601002e-017
		 17 -7.105427357601002e-017 18 -7.105427357601002e-017 19 -7.105427357601002e-017
		 20 -7.105427357601002e-017 21 -7.105427357601002e-017 22 -7.105427357601002e-017
		 23 -7.105427357601002e-017;
createNode animCurveTL -n "jnt_R_Pinky3_translateZ";
	rename -uid "9258EA76-4D83-3306-48A8-EFAF09460619";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -1.7763568394002505e-017 2 -1.7763568394002505e-017
		 3 -1.7763568394002505e-017 4 -1.7763568394002505e-017 5 -1.7763568394002505e-017
		 6 -1.7763568394002505e-017 7 -1.7763568394002505e-017 8 -1.7763568394002505e-017
		 9 -1.7763568394002505e-017 10 -1.7763568394002505e-017 11 -1.7763568394002505e-017
		 12 -1.7763568394002505e-017 13 -1.7763568394002505e-017 14 -1.7763568394002505e-017
		 15 -1.7763568394002505e-017 16 -1.7763568394002505e-017 17 -1.7763568394002505e-017
		 18 -1.7763568394002505e-017 19 -1.7763568394002505e-017 20 -1.7763568394002505e-017
		 21 -1.7763568394002505e-017 22 -1.7763568394002505e-017 23 -1.7763568394002505e-017;
createNode animCurveTA -n "jnt_R_Pinky4_rotateZ";
	rename -uid "4A943042-42DB-B66B-8AE1-CBBC8BC2F549";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -70 2 -70 3 -70 4 -70 5 -70 6 -70 7 -70
		 8 -70 9 -70 10 -70 11 -70 12 -70 13 -70 14 -70 15 -70 16 -70 17 -70 18 -70 19 -70
		 20 -70 21 -70 22 -70 23 -70;
createNode animCurveTA -n "jnt_R_Pinky4_rotateX";
	rename -uid "FE954D60-419B-2911-9A7C-2086EAED9087";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_R_Pinky4_rotateY";
	rename -uid "215BEEF0-40BE-C9BB-1FA0-1087FB7B2916";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_R_Pinky4_visibility";
	rename -uid "B382B287-4E77-D33E-345D-DE96C51C3057";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Pinky4_translateX";
	rename -uid "2CC11156-4B69-D9FC-1E3D-5094A734A640";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.015649134201215845 2 -0.015649134201215845
		 3 -0.015649134201215845 4 -0.015649134201215845 5 -0.015649134201215845 6 -0.015649134201215845
		 7 -0.015649134201215845 8 -0.015649134201215845 9 -0.015649134201215845 10 -0.015649134201215845
		 11 -0.015649134201215845 12 -0.015649134201215845 13 -0.015649134201215845 14 -0.015649134201215845
		 15 -0.015649134201215845 16 -0.015649134201215845 17 -0.015649134201215845 18 -0.015649134201215845
		 19 -0.015649134201215845 20 -0.015649134201215845 21 -0.015649134201215845 22 -0.015649134201215845
		 23 -0.015649134201215845;
createNode animCurveTL -n "jnt_R_Pinky4_translateY";
	rename -uid "2606D265-4919-FCC9-A0BB-FA994CB1CFB0";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTL -n "jnt_R_Pinky4_translateZ";
	rename -uid "2BFBD56C-460E-DAE9-95C0-CD8A47E82347";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -4.8361941005214961e-008 2 -4.8361941005214961e-008
		 3 -4.8361941005214961e-008 4 -4.8361941005214961e-008 5 -4.8361941005214961e-008
		 6 -4.8361941005214961e-008 7 -4.8361941005214961e-008 8 -4.8361941005214961e-008
		 9 -4.8361941005214961e-008 10 -4.8361941005214961e-008 11 -4.8361941005214961e-008
		 12 -4.8361941005214961e-008 13 -4.8361941005214961e-008 14 -4.8361941005214961e-008
		 15 -4.8361941005214961e-008 16 -4.8361941005214961e-008 17 -4.8361941005214961e-008
		 18 -4.8361941005214961e-008 19 -4.8361941005214961e-008 20 -4.8361941005214961e-008
		 21 -4.8361941005214961e-008 22 -4.8361941005214961e-008 23 -4.8361941005214961e-008;
createNode animCurveTU -n "jnt_R_Pinky4_scaleX";
	rename -uid "AB41C4F1-40AC-E2DD-97B3-69B7D6F1146D";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Pinky4_scaleY";
	rename -uid "46C7BCC1-4398-0EBD-D05A-12873AD9DB8D";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Pinky4_scaleZ";
	rename -uid "6ACC22B9-48D9-ADC0-1E23-21B41FB3E9E8";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode displayLayer -n "rightControls";
	rename -uid "6926AE86-4218-96B9-0F29-AF8D1F54E478";
	setAttr ".c" 13;
	setAttr ".do" 3;
createNode animCurveTL -n "ctrl_R_Arm_translateX";
	rename -uid "A203A796-4404-73ED-C943-46BC69E38E92";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 4 ".ktv[0:3]"  1 -0.81275941099084592 12.264 -0.81275941099084592
		 18.12 -0.81275941099084592 24.008 -0.81275941099084592;
	setAttr -s 4 ".kit[2:3]"  18 9;
	setAttr -s 4 ".kot[2:3]"  18 9;
createNode animCurveTL -n "ctrl_R_Arm_translateY";
	rename -uid "9F649606-4E7B-9866-4C76-B28AA1D3EAE4";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 5 ".ktv[0:4]"  1 -0.45152472317563552 6.396 -0.45098927504650377
		 12.264 -0.46528847243069421 18.12 -0.45098927504650377 24.008 -0.45152472317563552;
createNode animCurveTL -n "ctrl_R_Arm_translateZ";
	rename -uid "02568FBF-46BF-17E3-FBAB-0DA7C8F9A41F";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 5 ".ktv[0:4]"  1 -0.025714629904325124 6.396 -0.033349851201912903
		 12.264 0.084785089942917516 18.12 -0.033349851201912903 24.008 -0.025714629904325124;
createNode animCurveTU -n "ctrl_R_Arm_visibility";
	rename -uid "694F0176-4DF0-E9CE-E65F-75BEA46D9BF2";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 4 ".ktv[0:3]"  1 1 12.264 1 18.12 1 24.008 1;
	setAttr -s 4 ".kot[2:3]"  5 9;
createNode animCurveTU -n "ctrl_R_Wrist_FingerRoll";
	rename -uid "E0A73397-498E-AA9D-4F6B-F0B4F75689C2";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 7 ".ktv[0:6]"  1 10 6.396 10 9.308 10 12.264 10 18.12 10
		 21.084 10 24.008 10;
createNode pairBlend -n "pairBlend1";
	rename -uid "F13723F6-44C8-733C-B701-628C134753DA";
	setAttr ".txm" 2;
	setAttr ".tym" 2;
	setAttr ".tzm" 2;
createNode unitConversion -n "unitConversion15";
	rename -uid "88DC9F77-46D7-E311-FF3C-C6BA9A934308";
	setAttr ".cf" 0.017453292519943295;
createNode expression -n "expression2";
	rename -uid "4E4880F8-4532-875C-AD38-B59EFD7F597D";
	setAttr -k on ".nds";
	setAttr ".ixp" -type "string" ".O[0] = .O[0] * 0.25;";
createNode animCurveTA -n "pairBlend1_inRotateX1";
	rename -uid "E8DBD43B-444D-C574-FC7D-EBB4ED1BD64A";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 4 ".ktv[0:3]"  1 0 12.264 0 21.084 0 24.008 0;
	setAttr -s 4 ".kit[2:3]"  18 9;
	setAttr -s 4 ".kot[2:3]"  18 9;
createNode animCurveTA -n "ctrl_R_Wrist_rotateY";
	rename -uid "1E0030CD-461F-E603-D853-89AB8F07B969";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 9 ".ktv[0:8]"  1 -14.704799972525217 3.444 -12.758154251612241
		 6.396 -23.200400873802529 9.308 22.158950585400422 12.264 33.840934007435109 15.2 28.209917565979413
		 18.12 -4.9871109851741826 21.084 -12.758154251612241 24.008 -14.704799972525217;
createNode animCurveTA -n "ctrl_R_Wrist_rotateZ";
	rename -uid "7F2A8348-4FC6-09B1-B45A-93A5621044B8";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 4 ".ktv[0:3]"  1 86.38775962055557 12.744 86.38775962055557
		 21.084 86.38775962055557 24.008 86.38775962055557;
	setAttr -s 4 ".kit[2:3]"  18 9;
	setAttr -s 4 ".kot[2:3]"  18 9;
createNode animCurveTU -n "ctrl_R_Wrist_visibility";
	rename -uid "6A4B964C-4090-C6B6-B335-7EB8C525BF2B";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 4 ".ktv[0:3]"  1 1 12.264 1 21.084 1 24.008 1;
	setAttr -s 4 ".kot[2:3]"  5 9;
createNode animCurveTU -n "ctrl_R_Wrist_blendUnitConversion15";
	rename -uid "E8E23ABE-4D76-B5CD-45E3-C5BEB8BA3D35";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 3 ".ktv[0:2]"  12.28 0 21.088 0 24.008 0;
	setAttr -s 3 ".kit[1:2]"  18 9;
	setAttr -s 3 ".kot[1:2]"  18 9;
createNode animCurveTL -n "jnt_L_Hip_translateX";
	rename -uid "6BDC5E1E-48C3-DFBF-A45A-4C9125552DD2";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.013804886186734153 2 -0.013804886186734153
		 3 -0.013804886186734153 4 -0.013804886186734153 5 -0.013804886186734153 6 -0.013804886186734153
		 7 -0.013804886186734153 8 -0.013804886186734153 9 -0.013804886186734153 10 -0.013804886186734153
		 11 -0.013804886186734153 12 -0.013804886186734153 13 -0.013804886186734153 14 -0.013804886186734153
		 15 -0.013804886186734153 16 -0.013804886186734153 17 -0.013804886186734153 18 -0.013804886186734153
		 19 -0.013804886186734153 20 -0.013804886186734153 21 -0.013804886186734153 22 -0.013804886186734153
		 23 -0.013804886186734153;
createNode animCurveTL -n "jnt_L_Hip_translateY";
	rename -uid "AA44A6D8-422C-8472-CDE3-84A33DCB5577";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.025662519608617509 2 -0.025662519608617509
		 3 -0.025662519608617509 4 -0.025662519608617509 5 -0.025662519608617509 6 -0.025662519608617509
		 7 -0.025662519608617509 8 -0.025662519608617509 9 -0.025662519608617509 10 -0.025662519608617509
		 11 -0.025662519608617509 12 -0.025662519608617509 13 -0.025662519608617509 14 -0.025662519608617509
		 15 -0.025662519608617509 16 -0.025662519608617509 17 -0.025662519608617509 18 -0.025662519608617509
		 19 -0.025662519608617509 20 -0.025662519608617509 21 -0.025662519608617509 22 -0.025662519608617509
		 23 -0.025662519608617509;
createNode animCurveTL -n "jnt_L_Hip_translateZ";
	rename -uid "7649F184-499E-3643-F0F3-539897CA247D";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.089351204020901701 2 0.089351204020901701
		 3 0.089351204020901701 4 0.089351204020901701 5 0.089351204020901701 6 0.089351204020901701
		 7 0.089351204020901701 8 0.089351204020901701 9 0.089351204020901701 10 0.089351204020901701
		 11 0.089351204020901701 12 0.089351204020901701 13 0.089351204020901701 14 0.089351204020901701
		 15 0.089351204020901701 16 0.089351204020901701 17 0.089351204020901701 18 0.089351204020901701
		 19 0.089351204020901701 20 0.089351204020901701 21 0.089351204020901701 22 0.089351204020901701
		 23 0.089351204020901701;
createNode animCurveTU -n "jnt_L_Hip_scaleX";
	rename -uid "5B335CD8-479A-90C7-2F76-E1B066F137EE";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Hip_scaleY";
	rename -uid "DD253E94-4F7D-FAC2-07FB-68AA3607A610";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Hip_scaleZ";
	rename -uid "58264EE8-4E28-45F9-94AE-98BBFEF7F68C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTA -n "jnt_L_Hip_rotateX";
	rename -uid "95249F24-43F0-427E-40F1-DD8B7A8A7E90";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 11.10031240013255 2 7.733839438771132
		 3 4.5481179093579867 4 2.2636825900529272 5 0.408693910047213 6 -1.2013861696744994
		 7 -2.5709046314939954 8 -3.8587775595336926 9 -5.7739048304231666 10 -8.6625102079225069
		 11 -12.25705772767653 12 -14.303915547750819 13 -12.493876072004035 14 -7.6416409399242751
		 15 -3.3492138986373265 16 -1.7719788759211796 17 -1.6234377847621975 18 -1.3481711977105464
		 19 -0.1820181652405452 20 1.1748602765678553 21 2.8439489742057074 22 5.1505766086530462
		 23 8.047890361449106;
createNode animCurveTA -n "jnt_L_Hip_rotateY";
	rename -uid "FA61FFC6-4E2C-7A26-1C3C-C2A8B4247D88";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -3.6935569666487429 2 -2.4820705272672963
		 3 -1.3116099520688604 4 -0.66252069926463697 5 -0.057084505817550646 6 0.69851598100619117
		 7 1.8643224226972428 8 3.4879203697266603 9 4.9320835250335335 10 6.2467337312836717
		 11 7.9955134063207014 12 8.8302285020599705 13 7.3571658804793429 14 4.304260070979721
		 15 1.5070519963974274 16 0.48640272468416951 17 0.25503383241128996 18 0.17856529306440314
		 19 -0.036865065713423066 20 -0.69762448617089812 21 -1.6561451868012427 22 -2.659823380363644
		 23 -3.4199124992748988;
createNode animCurveTA -n "jnt_L_Hip_rotateZ";
	rename -uid "1F5177CC-400B-B671-EE3C-B9972F69E69A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 8.8758773176551511 2 8.3911237671191117
		 3 7.3857078575594892 4 9.2146213902410672 5 12.512301832252529 6 18.185776828967764
		 7 27.447918056846603 8 36.497355689007925 9 37.173015913921247 10 32.296081283726245
		 11 27.971654666445129 12 25.388888610670421 13 24.394363727706125 14 24.695795285987035
		 15 23.343131321735349 16 18.570847791640276 17 9.3467295022620949 18 5.6805528370086504
		 19 13.437649901135039 20 18.970145190753861 21 20.242906945589812 22 17.623423288768247
		 23 13.421864971140527;
createNode animCurveTU -n "jnt_L_Hip_visibility";
	rename -uid "14018F47-45C0-0D68-7EF3-FF920EDC9BC1";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Knee_scaleX";
	rename -uid "28CB41D7-48E3-0F4A-2992-BC9D8C8AA5ED";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Knee_scaleY";
	rename -uid "5F8B8026-4DA8-C02C-919B-3B90FAF28BF3";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Knee_scaleZ";
	rename -uid "2053100C-47AF-7330-E408-E7A0EE9D15C5";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTA -n "jnt_L_Knee_rotateX";
	rename -uid "3B76BB42-4F9A-74B2-D595-19878766260F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 8.6145014661893391e-015 2 9.3030913272023703e-015
		 3 9.6033740403423291e-015 4 9.9121347058447126e-015 5 1.0039172961708649e-014 6 1.0494317287132679e-014
		 7 1.1468664485759289e-014 8 1.1151751598389056e-014 9 8.2145161089917836e-015 10 5.2500783411861137e-015
		 11 4.0610883893968829e-015 12 3.8877432474266676e-015 13 3.6723682568352388e-015
		 14 3.8053181796440679e-015 15 3.6436644633846847e-015 16 2.8090073902113942e-015
		 17 6.036872197242273e-016 18 6.4454408142818689e-016 19 5.1867207463836374e-015 20 8.7883435818082519e-015
		 21 1.0571501717853491e-014 22 1.0539419922447028e-014 23 9.6614686221463192e-015;
createNode animCurveTA -n "jnt_L_Knee_rotateY";
	rename -uid "FF35F30F-4729-8718-8CCF-E685CDBECB3E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1.1705654625761737e-013 2 1.264133211371106e-013
		 3 1.3049365677104015e-013 4 1.3468919347920209e-013 5 1.3641542912178558e-013 6 1.426000728869526e-013
		 7 1.5583980804454237e-013 8 1.5153349639021303e-013 9 1.1162141984305575e-013 10 7.1339710209953541e-014
		 11 5.5183342039640282e-014 12 5.282787391310856e-014 13 4.9901291028672445e-014 14 5.1707856254797203e-014
		 15 4.9511254885663911e-014 16 3.8169672940542284e-014 17 8.2030911757497953e-015
		 18 8.7582670197335086e-015 19 7.0478787351460117e-014 20 1.1941876741787087e-013
		 21 1.4364887912611796e-013 22 1.4321294163365097e-013 23 1.3128306415914563e-013;
createNode animCurveTA -n "jnt_L_Knee_rotateZ";
	rename -uid "D0C75875-4C1D-ED2C-3CAD-0DA464C9FCBC";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 38.442777321095157 2 41.515654700753608
		 3 42.855685986362083 4 44.233550689967707 5 44.800467231871551 6 46.831578610737672
		 7 51.179666835836635 8 49.765422307911756 9 36.657816452634563 10 23.428818647331624
		 11 18.122873070207913 12 17.349309014457347 13 16.388184004921328 14 16.981481747971973
		 15 16.260091445622191 16 12.535379559575995 17 2.6939937790405182 18 2.8763202018391771
		 19 23.146081228555698 20 39.218559154320864 21 47.176019190903737 22 47.032852076508071
		 23 43.11493686473483;
createNode animCurveTU -n "jnt_L_Knee_visibility";
	rename -uid "7C578B3C-4A64-6E25-44FF-98BAE782F8E0";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Knee_translateX";
	rename -uid "A6397095-480C-C667-AEC3-56A60A32E5B2";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.32618059368026431 2 0.32618059368026431
		 3 0.32618059368026431 4 0.32618059368026431 5 0.32618059368026431 6 0.32618059368026431
		 7 0.32618059368026431 8 0.32618059368026431 9 0.32618059368026431 10 0.32618059368026431
		 11 0.32618059368026431 12 0.32618059368026431 13 0.32618059368026431 14 0.32618059368026431
		 15 0.32618059368026431 16 0.32618059368026431 17 0.32618059368026431 18 0.32618059368026431
		 19 0.32618059368026431 20 0.32618059368026431 21 0.32618059368026431 22 0.32618059368026431
		 23 0.32618059368026431;
createNode animCurveTL -n "jnt_L_Knee_translateY";
	rename -uid "2841FDC4-41DB-E43A-3A9E-2DB77853E404";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.010191400934105947 2 -0.010191400934105947
		 3 -0.010191400934105947 4 -0.010191400934105947 5 -0.010191400934105947 6 -0.010191400934105947
		 7 -0.010191400934105947 8 -0.010191400934105947 9 -0.010191400934105947 10 -0.010191400934105947
		 11 -0.010191400934105947 12 -0.010191400934105947 13 -0.010191400934105947 14 -0.010191400934105947
		 15 -0.010191400934105947 16 -0.010191400934105947 17 -0.010191400934105947 18 -0.010191400934105947
		 19 -0.010191400934105947 20 -0.010191400934105947 21 -0.010191400934105947 22 -0.010191400934105947
		 23 -0.010191400934105947;
createNode animCurveTL -n "jnt_L_Knee_translateZ";
	rename -uid "1B362F55-4D00-E205-A723-60BD9C31C220";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -6.7077257031468735e-017 2 -6.7077257031468735e-017
		 3 -6.7077257031468735e-017 4 -6.7077257031468735e-017 5 -6.7077257031468735e-017
		 6 -6.7077257031468735e-017 7 -6.7077257031468735e-017 8 -6.7077257031468735e-017
		 9 -6.7077257031468735e-017 10 -6.7077257031468735e-017 11 -6.7077257031468735e-017
		 12 -6.7077257031468735e-017 13 -6.7077257031468735e-017 14 -6.7077257031468735e-017
		 15 -6.7077257031468735e-017 16 -6.7077257031468735e-017 17 -6.7077257031468735e-017
		 18 -6.7077257031468735e-017 19 -6.7077257031468735e-017 20 -6.7077257031468735e-017
		 21 -6.7077257031468735e-017 22 -6.7077257031468735e-017 23 -6.7077257031468735e-017;
createNode animCurveTU -n "jnt_L_Ankle_scaleX";
	rename -uid "AA8BEC3F-46A3-6922-84A3-07B544449247";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Ankle_scaleY";
	rename -uid "BDD25BD1-4951-E3C7-644E-0999C8568A72";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Ankle_scaleZ";
	rename -uid "E6520971-4E6A-DCB6-EC7D-F48C7D67856F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Ankle_translateX";
	rename -uid "C60F1FC3-49F9-C272-7297-DFA629EA318E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.37876158699700874 2 0.37876158699700874
		 3 0.37876158699700874 4 0.37876158699700874 5 0.37876158699700874 6 0.37876158699700874
		 7 0.37876158699700874 8 0.37876158699700874 9 0.37876158699700874 10 0.37876158699700874
		 11 0.37876158699700874 12 0.37876158699700874 13 0.37876158699700874 14 0.37876158699700874
		 15 0.37876158699700874 16 0.37876158699700874 17 0.37876158699700874 18 0.37876158699700874
		 19 0.37876158699700874 20 0.37876158699700874 21 0.37876158699700874 22 0.37876158699700874
		 23 0.37876158699700874;
createNode animCurveTL -n "jnt_L_Ankle_translateY";
	rename -uid "CB163025-4B8B-57FB-AFD8-58BA7B2F1C28";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.007455743627897961 2 -0.007455743627897961
		 3 -0.007455743627897961 4 -0.007455743627897961 5 -0.007455743627897961 6 -0.007455743627897961
		 7 -0.007455743627897961 8 -0.007455743627897961 9 -0.007455743627897961 10 -0.007455743627897961
		 11 -0.007455743627897961 12 -0.007455743627897961 13 -0.007455743627897961 14 -0.007455743627897961
		 15 -0.007455743627897961 16 -0.007455743627897961 17 -0.007455743627897961 18 -0.007455743627897961
		 19 -0.007455743627897961 20 -0.007455743627897961 21 -0.007455743627897961 22 -0.007455743627897961
		 23 -0.007455743627897961;
createNode animCurveTL -n "jnt_L_Ankle_translateZ";
	rename -uid "91A3FC74-414A-971A-EA34-568D1567836B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -6.2172892132494644e-017 2 -6.2172892132494644e-017
		 3 -6.2172892132494644e-017 4 -6.2172892132494644e-017 5 -6.2172892132494644e-017
		 6 -6.2172892132494644e-017 7 -6.2172892132494644e-017 8 -6.2172892132494644e-017
		 9 -6.2172892132494644e-017 10 -6.2172892132494644e-017 11 -6.2172892132494644e-017
		 12 -6.2172892132494644e-017 13 -6.2172892132494644e-017 14 -6.2172892132494644e-017
		 15 -6.2172892132494644e-017 16 -6.2172892132494644e-017 17 -6.2172892132494644e-017
		 18 -6.2172892132494644e-017 19 -6.2172892132494644e-017 20 -6.2172892132494644e-017
		 21 -6.2172892132494644e-017 22 -6.2172892132494644e-017 23 -6.2172892132494644e-017;
createNode animCurveTA -n "jnt_L_Ankle_rotateX";
	rename -uid "35323826-487C-B998-71B1-1EA704897DE8";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.30748062557021333 2 0.36384744556505177
		 3 0.50525619430903146 4 0.6757074873224499 5 0.85377623948645764 6 1.0589359986033211
		 7 1.3194298507139524 8 1.6451643338354753 9 1.956578221207967 10 2.1126325443579934
		 11 2.1119440373459888 12 2.0742033431876417 13 2.0826821579801424 14 1.9419388114189986
		 15 1.6119458860415039 16 1.3809889333707333 17 1.2247191841665361 18 1.1012032755356651
		 19 1.0204561291676926 20 0.93143008429460783 21 0.78797451565688303 22 0.61265703900599022
		 23 0.44597179481524118;
createNode animCurveTA -n "jnt_L_Ankle_rotateY";
	rename -uid "2D651DA7-4B38-7E57-65B4-6BA1D61A62CC";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.66836678171990294 2 0.50824056373064119
		 3 0.35579670365839777 4 0.2668547152370655 5 0.21793057317768988 6 0.14045097327192355
		 7 -0.098772633669058252 8 -0.64769746204745982 9 -1.4594071813458067 10 -2.2339335890987133
		 11 -2.929181368800021 12 -3.2100247081821771 13 -2.6574728745180698 14 -1.5168048136113506
		 15 -0.69755032278500195 16 -0.51389144520622454 17 -0.59358679079671517 18 -0.60914265919246413
		 19 -0.41280881604250091 20 -0.14689370453973966 21 0.099960111314017802 22 0.30294202727615727
		 23 0.49386970260472379;
createNode animCurveTA -n "jnt_L_Ankle_rotateZ";
	rename -uid "74D24CF1-43AD-CCAD-01FF-ED8A49CA4EE3";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 7.7514515260489336 2 0.3413144423187946
		 3 -7.267126124463835 4 -12.240330899941338 5 -16.712579899803316 6 -16.826257885179121
		 7 -8.327904100984032 8 5.5009255597212494 9 14.193016912333711 10 16.319129587072872
		 11 18.270641140054444 12 18.746817421125364 13 14.011335493259416 14 4.737862934577147
		 15 -3.1793882722313338 16 -4.2419508769105603 17 -3.1598584847337605 18 0.53986967311622358
		 19 6.8128385904556206 20 7.9443421473818265 21 7.157687798622848 22 7.1778311783135065
		 23 7.6346509070551623;
createNode animCurveTU -n "jnt_L_Ankle_visibility";
	rename -uid "7EF85F92-4F1E-F2B6-A18C-A284D2B463E7";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Ball_scaleX";
	rename -uid "9D2F6735-4A5E-1A4D-ACB0-30AF08BCB6A6";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Ball_scaleY";
	rename -uid "441A8E47-4C7C-DA94-E084-6FA98DFE3F69";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Ball_scaleZ";
	rename -uid "4A60A5B1-4777-CE3A-00D1-23BA669FB7DD";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Ball_translateX";
	rename -uid "8D57FB36-47E4-B582-6DA4-7A81EB42B075";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.081306691346609603 2 0.081306691346609603
		 3 0.081306691346609603 4 0.081306691346609603 5 0.081306691346609603 6 0.081306691346609603
		 7 0.081306691346609603 8 0.081306691346609603 9 0.081306691346609603 10 0.081306691346609603
		 11 0.081306691346609603 12 0.081306691346609603 13 0.081306691346609603 14 0.081306691346609603
		 15 0.081306691346609603 16 0.081306691346609603 17 0.081306691346609603 18 0.081306691346609603
		 19 0.081306691346609603 20 0.081306691346609603 21 0.081306691346609603 22 0.081306691346609603
		 23 0.081306691346609603;
createNode animCurveTL -n "jnt_L_Ball_translateY";
	rename -uid "52D692B6-454E-6036-7E28-9C819B605FE1";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.008736557123889219 2 -0.008736557123889219
		 3 -0.008736557123889219 4 -0.008736557123889219 5 -0.008736557123889219 6 -0.008736557123889219
		 7 -0.008736557123889219 8 -0.008736557123889219 9 -0.008736557123889219 10 -0.008736557123889219
		 11 -0.008736557123889219 12 -0.008736557123889219 13 -0.008736557123889219 14 -0.008736557123889219
		 15 -0.008736557123889219 16 -0.008736557123889219 17 -0.008736557123889219 18 -0.008736557123889219
		 19 -0.008736557123889219 20 -0.008736557123889219 21 -0.008736557123889219 22 -0.008736557123889219
		 23 -0.008736557123889219;
createNode animCurveTL -n "jnt_L_Ball_translateZ";
	rename -uid "8E9B288F-47C2-6B58-7802-5EAD835ACD81";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 9.9436971221746478e-019 2 9.9436971221746478e-019
		 3 9.9436971221746478e-019 4 9.9436971221746478e-019 5 9.9436971221746478e-019 6 9.9436971221746478e-019
		 7 9.9436971221746478e-019 8 9.9436971221746478e-019 9 9.9436971221746478e-019 10 9.9436971221746478e-019
		 11 9.9436971221746478e-019 12 9.9436971221746478e-019 13 9.9436971221746478e-019
		 14 9.9436971221746478e-019 15 9.9436971221746478e-019 16 9.9436971221746478e-019
		 17 9.9436971221746478e-019 18 9.9436971221746478e-019 19 9.9436971221746478e-019
		 20 9.9436971221746478e-019 21 9.9436971221746478e-019 22 9.9436971221746478e-019
		 23 9.9436971221746478e-019;
createNode animCurveTA -n "jnt_L_Ball_rotateX";
	rename -uid "20C1B23B-4388-22F0-9B24-FE983BBEB084";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 3.8323611211060018e-007 2 1.1781408914425617e-007
		 3 5.3430050986593145e-008 4 2.3958700053676802e-008 5 1.2656513349287015e-008 6 5.9116455069376173e-009
		 7 6.0075594470466055e-009 8 4.373147288147532e-009 9 -3.5481189893031253e-007 10 -7.1787997049400731e-006
		 11 -1.5334628299006487e-005 12 -1.854059341951398e-005 13 -1.5293842042000726e-005
		 14 -8.270701620279325e-006 15 -2.3348157511388903e-006 16 -3.0153570374362575e-007
		 17 -5.3560373281043656e-007 18 -2.3733515860557934e-007 19 8.110490273079074e-007
		 20 7.5576373114932555e-008 21 1.3793572757384191e-008 22 1.8092106290751902e-008
		 23 7.5063595925928696e-008;
createNode animCurveTA -n "jnt_L_Ball_rotateY";
	rename -uid "A93FEEFC-44E1-E05B-500E-D8A00A8CF456";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1.8533536808506235e-007 2 4.6423784681792771e-008
		 3 1.2669022217154837e-008 4 -2.71716937633565e-009 5 -8.6449355931372348e-009 6 -1.2192362222611196e-008
		 7 -1.2190479714885761e-008 8 -1.3010293052663555e-008 9 -2.0089993485629658e-007
		 10 -3.7732990098632075e-006 11 -8.0244513161021115e-006 12 -9.7037987614719162e-006
		 13 -8.021571936277379e-006 14 -4.3450339894710302e-006 15 -1.2375731474505247e-006
		 16 -1.7313241435959686e-007 17 -2.9566649290530821e-007 18 -1.3952083474018514e-007
		 19 4.09316857650904e-007 20 2.4262157625963492e-008 21 -8.0347315733627156e-009 22 -5.8224852700874624e-009
		 23 2.3992493551652728e-008;
createNode animCurveTA -n "jnt_L_Ball_rotateZ";
	rename -uid "0C5A4EBE-4D02-C9D6-0953-9AAFC24EC4D9";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -2.099926244220715e-005 2 -1.4688806635267662e-005
		 3 -1.3115913888646996e-005 4 -1.126204750469015e-005 5 -1.0833169586939077e-005 6 -8.9544451845213248e-006
		 7 -7.5884962924791512e-006 8 -7.6363725032176139e-006 9 -2.1949557295536944e-005
		 10 -7.8398661488568203e-005 11 -1.0251959555462251e-005 12 8.686337264658634e-006
		 13 -8.7081745934050126e-005 14 -0.00030058026995062614 15 -0.0004567624839599834
		 16 -0.00031593312069609674 17 -0.00052720289912442265 18 -0.00050201888510361802
		 19 -0.00023060705448498005 20 -1.8231600665620188e-005 21 -8.0996038966398632e-006
		 22 -8.1891069653003298e-006 23 -1.0663603689430369e-005;
createNode animCurveTU -n "jnt_L_Ball_visibility";
	rename -uid "CA9AB6B8-4A64-4D02-7F9D-E19EE12CDD71";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_L_Toe_translateX";
	rename -uid "EDE05F0C-4063-B8EA-DA29-A89294243F37";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.11035542189910116 2 0.11035542189910116
		 3 0.11035542189910116 4 0.11035542189910116 5 0.11035542189910116 6 0.11035542189910116
		 7 0.11035542189910116 8 0.11035542189910116 9 0.11035542189910116 10 0.11035542189910116
		 11 0.11035542189910116 12 0.11035542189910116 13 0.11035542189910116 14 0.11035542189910116
		 15 0.11035542189910116 16 0.11035542189910116 17 0.11035542189910116 18 0.11035542189910116
		 19 0.11035542189910116 20 0.11035542189910116 21 0.11035542189910116 22 0.11035542189910116
		 23 0.11035542189910116;
createNode animCurveTL -n "jnt_L_Toe_translateY";
	rename -uid "D3FB8D6F-47C1-94A7-9343-DCBD8178F2C3";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.00082977385805263395 2 0.00082977385805263395
		 3 0.00082977385805263395 4 0.00082977385805263395 5 0.00082977385805263395 6 0.00082977385805263395
		 7 0.00082977385805263395 8 0.00082977385805263395 9 0.00082977385805263395 10 0.00082977385805263395
		 11 0.00082977385805263395 12 0.00082977385805263395 13 0.00082977385805263395 14 0.00082977385805263395
		 15 0.00082977385805263395 16 0.00082977385805263395 17 0.00082977385805263395 18 0.00082977385805263395
		 19 0.00082977385805263395 20 0.00082977385805263395 21 0.00082977385805263395 22 0.00082977385805263395
		 23 0.00082977385805263395;
createNode animCurveTL -n "jnt_L_Toe_translateZ";
	rename -uid "74713CBC-4A0A-0404-0CE0-2CAB23C22780";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 2.2619127663470719e-017 2 2.2619127663470719e-017
		 3 2.2619127663470719e-017 4 2.2619127663470719e-017 5 2.2619127663470719e-017 6 2.2619127663470719e-017
		 7 2.2619127663470719e-017 8 2.2619127663470719e-017 9 2.2619127663470719e-017 10 2.2619127663470719e-017
		 11 2.2619127663470719e-017 12 2.2619127663470719e-017 13 2.2619127663470719e-017
		 14 2.2619127663470719e-017 15 2.2619127663470719e-017 16 2.2619127663470719e-017
		 17 2.2619127663470719e-017 18 2.2619127663470719e-017 19 2.2619127663470719e-017
		 20 2.2619127663470719e-017 21 2.2619127663470719e-017 22 2.2619127663470719e-017
		 23 2.2619127663470719e-017;
createNode animCurveTU -n "jnt_L_Toe_visibility";
	rename -uid "55A26379-4033-749A-8732-5BBEC36C5CE1";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTA -n "jnt_L_Toe_rotateX";
	rename -uid "C48BF339-4505-F4E6-8FEC-6FB52D480857";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_L_Toe_rotateY";
	rename -uid "62640A65-4065-24B4-FBC6-CAAD1BA7D435";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_L_Toe_rotateZ";
	rename -uid "0E21A6C9-469B-5049-F2E0-FE8290CE4AA2";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_L_Toe_scaleX";
	rename -uid "742E75A0-4235-F138-2B16-AAA196F8EEDD";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Toe_scaleY";
	rename -uid "2A7E8FCF-4DB3-5758-E4FF-619AD26A800A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_L_Toe_scaleZ";
	rename -uid "E1C7D2E6-49F0-4BF7-0595-AEA66CE8BC4E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Hip_translateX";
	rename -uid "F28C82C7-422C-32B0-DD45-E195730CA91A";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.013804933139814662 2 -0.013804933139814662
		 3 -0.013804933139814662 4 -0.013804933139814662 5 -0.013804933139814662 6 -0.013804933139814662
		 7 -0.013804933139814662 8 -0.013804933139814662 9 -0.013804933139814662 10 -0.013804933139814662
		 11 -0.013804933139814662 12 -0.013804933139814662 13 -0.013804933139814662 14 -0.013804933139814662
		 15 -0.013804933139814662 16 -0.013804933139814662 17 -0.013804933139814662 18 -0.013804933139814662
		 19 -0.013804933139814662 20 -0.013804933139814662 21 -0.013804933139814662 22 -0.013804933139814662
		 23 -0.013804933139814662;
createNode animCurveTL -n "jnt_R_Hip_translateY";
	rename -uid "B3CD97AA-4985-08DA-34B5-27BFF854D6C8";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.025662515862142434 2 -0.025662515862142434
		 3 -0.025662515862142434 4 -0.025662515862142434 5 -0.025662515862142434 6 -0.025662515862142434
		 7 -0.025662515862142434 8 -0.025662515862142434 9 -0.025662515862142434 10 -0.025662515862142434
		 11 -0.025662515862142434 12 -0.025662515862142434 13 -0.025662515862142434 14 -0.025662515862142434
		 15 -0.025662515862142434 16 -0.025662515862142434 17 -0.025662515862142434 18 -0.025662515862142434
		 19 -0.025662515862142434 20 -0.025662515862142434 21 -0.025662515862142434 22 -0.025662515862142434
		 23 -0.025662515862142434;
createNode animCurveTL -n "jnt_R_Hip_translateZ";
	rename -uid "E4E8FC1C-48CF-F6CD-A521-43A6D97F1D97";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.089351200000000019 2 -0.089351200000000019
		 3 -0.089351200000000019 4 -0.089351200000000019 5 -0.089351200000000019 6 -0.089351200000000019
		 7 -0.089351200000000019 8 -0.089351200000000019 9 -0.089351200000000019 10 -0.089351200000000019
		 11 -0.089351200000000019 12 -0.089351200000000019 13 -0.089351200000000019 14 -0.089351200000000019
		 15 -0.089351200000000019 16 -0.089351200000000019 17 -0.089351200000000019 18 -0.089351200000000019
		 19 -0.089351200000000019 20 -0.089351200000000019 21 -0.089351200000000019 22 -0.089351200000000019
		 23 -0.089351200000000019;
createNode animCurveTU -n "jnt_R_Hip_scaleX";
	rename -uid "4827E323-4804-C4B1-6880-0B9C7B11C2DC";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Hip_scaleY";
	rename -uid "08FD2A4D-433F-B413-3A7F-E59F1F791996";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Hip_scaleZ";
	rename -uid "9A91FD46-402A-BF1B-3086-D29998F8A22B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTA -n "jnt_R_Hip_rotateX";
	rename -uid "2FEC408F-4444-A2FF-B142-869B2870944B";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -8.3552270888799232 2 -5.0068685009192508
		 3 -2.0274215561898887 4 -0.20582908445380466 5 1.1634211510260157 6 2.5289486918231461
		 7 3.9058616202466729 8 5.2522097544382689 9 6.7545377221671528 10 9.0762478244456339
		 11 12.401982740574956 12 14.356051875446353 13 12.505839789144501 14 7.6642790261591376
		 15 3.2748956747262308 16 1.7390409406281804 17 1.6930283302066171 18 1.5867614505142571
		 19 0.89425613971175899 20 0.53406754063465078 21 0.10816690462240153 22 -1.6473766295863876
		 23 -4.7106375798053746;
createNode animCurveTA -n "jnt_R_Hip_rotateY";
	rename -uid "5486927A-4155-AFA6-02B2-2BB9E2D0BA90";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 6.9627839861732914 2 4.6288521093934731
		 3 2.482836620342463 4 1.0838878829034024 5 0.13468856488186551 6 -0.38012164682662453
		 7 -0.9952037097905565 8 -1.8786663256043288 9 -2.7691368493519204 10 -3.6718993698862898
		 11 -4.6869968744982229 12 -5.0572939149410416 13 -4.4120934804062459 14 -3.0198903985612708
		 15 -1.5389114589276685 16 -0.94777326663812256 17 -0.93356545983753281 18 -0.93586946518608505
		 19 -0.46674805380148848 20 0.45910461155019722 21 1.8793896837767465 22 3.7919808904221517
		 23 5.7067109581064193;
createNode animCurveTA -n "jnt_R_Hip_rotateZ";
	rename -uid "D6AB3032-422A-62D8-3E4C-568C09B88AB7";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 26.210481532378189 2 25.823837465354085
		 3 23.851433316211814 4 20.494327866356567 5 14.242286711215311 6 7.508991610850841
		 7 8.2160787461308047 8 11.477659971117445 9 12.890580119773286 10 11.909072962933417
		 11 10.229205727078856 12 8.6582299839027499 13 8.2297142894556465 14 9.3838672135934118
		 15 11.016942784007542 16 12.38511130202011 17 13.949391653356772 18 18.597178134949914
		 19 29.053481548527287 20 39.367472860553271 21 42.173946144795948 22 38.721138577651949
		 23 33.098601199558978;
createNode animCurveTU -n "jnt_R_Hip_visibility";
	rename -uid "E9057BE0-4F49-BFF9-2B1A-9C82E8A74B9E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Knee_scaleX";
	rename -uid "13D4B939-4D42-B083-FE88-ABAB234DDEA0";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Knee_scaleY";
	rename -uid "BC3DD6C4-4889-2252-2A71-659674219277";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Knee_scaleZ";
	rename -uid "2E377947-4A73-8E87-CEAC-DBBEC9CB541C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTA -n "jnt_R_Knee_rotateX";
	rename -uid "5199772A-4A3B-44E8-AB1E-F888BCA67B37";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1.6425027398477617e-015 2 1.5111644048889991e-015
		 3 1.1884019132470601e-015 4 1.0310521313739617e-015 5 7.1377562457699102e-016 6 3.2453753175552839e-016
		 7 9.7591115387634308e-016 8 1.9911675327917231e-015 9 2.6953374037841928e-015 10 3.0200731095616347e-015
		 11 3.2176204170186035e-015 12 3.3773385003240258e-015 13 3.5880750380270011e-015
		 14 3.8621908387205106e-015 15 4.0727067934385765e-015 16 4.1338912739648208e-015
		 17 4.0878884835018543e-015 18 4.2445759731286728e-015 19 4.6943690621817376e-015
		 20 4.6318146517682922e-015 21 3.8233412847833031e-015 22 3.0246116249552619e-015
		 23 2.4302141023257763e-015;
createNode animCurveTA -n "jnt_R_Knee_rotateY";
	rename -uid "BA26C352-4E51-0891-70FD-6BAB280357EB";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -2.6964545748452245e-007 2 -2.4808398026075027e-007
		 3 -1.950968907380249e-007 4 -1.6926518106173295e-007 5 -1.171787115851037e-007 6 -5.327849330055195e-008
		 7 -1.6021282836680393e-007 8 -3.2688486130483808e-007 9 -4.4248662098785732e-007
		 10 -4.9579764800875199e-007 11 -5.282284822483389e-007 12 -5.5444898988988686e-007
		 13 -5.8904506619408203e-007 14 -6.3404595336982499e-007 15 -6.6860581713176007e-007
		 16 -6.7865031620150357e-007 17 -6.7109815620869833e-007 18 -6.9682113906743067e-007
		 19 -7.7066251560134856e-007 20 -7.6039311865947707e-007 21 -6.2766812185068919e-007
		 22 -4.9654272442775906e-007 23 -3.9896200932225496e-007;
createNode animCurveTA -n "jnt_R_Knee_rotateZ";
	rename -uid "4681BCA7-4E89-FE86-40A5-9A8CEB7AF1F5";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 18.095601974227034 2 16.648635600465152
		 3 13.09273189372086 4 11.359195045087692 5 7.8637309320090969 6 3.5754594850115322
		 7 10.751701884157439 8 21.936873688711358 9 29.694777160399678 10 33.272419946622946
		 11 35.448816588221788 12 37.208445228993028 13 39.530148818999315 14 42.550107510000373
		 15 44.869380917212844 16 45.543455900311734 17 45.036638976524578 18 46.762879291283831
		 19 51.718290635691524 20 51.029123010510538 21 42.122098443184981 22 33.32242118322641
		 23 26.773889650812219;
createNode animCurveTU -n "jnt_R_Knee_visibility";
	rename -uid "A324A2F1-40A0-37AA-E9EF-34B196428516";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Knee_translateX";
	rename -uid "586C6170-4BD5-D8C6-9A00-04B7C6C74E90";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.32618102547125943 2 -0.32618102547125943
		 3 -0.32618102547125943 4 -0.32618102547125943 5 -0.32618102547125943 6 -0.32618102547125943
		 7 -0.32618102547125943 8 -0.32618102547125943 9 -0.32618102547125943 10 -0.32618102547125943
		 11 -0.32618102547125943 12 -0.32618102547125943 13 -0.32618102547125943 14 -0.32618102547125943
		 15 -0.32618102547125943 16 -0.32618102547125943 17 -0.32618102547125943 18 -0.32618102547125943
		 19 -0.32618102547125943 20 -0.32618102547125943 21 -0.32618102547125943 22 -0.32618102547125943
		 23 -0.32618102547125943;
createNode animCurveTL -n "jnt_R_Knee_translateY";
	rename -uid "007E9190-42B6-479C-F8AD-C9966819C5B6";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.010191465582904891 2 0.010191465582904891
		 3 0.010191465582904891 4 0.010191465582904891 5 0.010191465582904891 6 0.010191465582904891
		 7 0.010191465582904891 8 0.010191465582904891 9 0.010191465582904891 10 0.010191465582904891
		 11 0.010191465582904891 12 0.010191465582904891 13 0.010191465582904891 14 0.010191465582904891
		 15 0.010191465582904891 16 0.010191465582904891 17 0.010191465582904891 18 0.010191465582904891
		 19 0.010191465582904891 20 0.010191465582904891 21 0.010191465582904891 22 0.010191465582904891
		 23 0.010191465582904891;
createNode animCurveTL -n "jnt_R_Knee_translateZ";
	rename -uid "6E6C56C9-4D0A-2E59-ACAF-26AFB4B5A674";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 3.552713678800501e-017 2 3.552713678800501e-017
		 3 3.552713678800501e-017 4 3.552713678800501e-017 5 3.552713678800501e-017 6 3.552713678800501e-017
		 7 3.552713678800501e-017 8 3.552713678800501e-017 9 3.552713678800501e-017 10 3.552713678800501e-017
		 11 3.552713678800501e-017 12 3.552713678800501e-017 13 3.552713678800501e-017 14 3.552713678800501e-017
		 15 3.552713678800501e-017 16 3.552713678800501e-017 17 3.552713678800501e-017 18 3.552713678800501e-017
		 19 3.552713678800501e-017 20 3.552713678800501e-017 21 3.552713678800501e-017 22 3.552713678800501e-017
		 23 3.552713678800501e-017;
createNode animCurveTU -n "jnt_R_Ankle_scaleX";
	rename -uid "5AEF5018-4427-6861-32D9-87BA1474EBDA";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Ankle_scaleY";
	rename -uid "30805CCF-4371-368D-8FFC-E092F8ED3E19";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Ankle_scaleZ";
	rename -uid "D3116EA6-4020-7D68-FF2D-01AF7883B962";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTA -n "jnt_R_Ankle_rotateX";
	rename -uid "4F815386-44F8-08E7-0975-48899FEF2ACE";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -1.7900120330707687 2 -2.1921156471361551
		 3 -2.5482143751223716 4 -2.5216163242593659 5 -2.2501479729853666 6 -1.9746112319991171
		 7 -1.8639164487026232 8 -1.8503373155357425 9 -1.8655198965986823 10 -1.8872662205504491
		 11 -1.9355360542828799 12 -1.9856338764788282 13 -2.0377584472959782 14 -1.9639632625726664
		 15 -1.7218750187298653 16 -1.6174346436370033 17 -1.6423837343979295 18 -1.703844761794836
		 19 -1.8788668955895824 20 -2.3268204772545609 21 -2.8205005134751566 22 -2.7447281975830937
		 23 -2.2633637116197445;
createNode animCurveTA -n "jnt_R_Ankle_rotateY";
	rename -uid "067D1209-4F1D-E589-A04E-BBB1D998B9D2";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.11186852481440449 2 0.35594679322632933
		 3 0.39839998324174719 4 0.51162019211813392 5 0.80347836706385112 6 1.046580690915454
		 7 1.1179640225051886 8 1.1007604190642211 9 1.1012184170191937 10 1.2317107847281641
		 11 1.456701581877879 12 1.5444299142301996 13 1.2781875677163534 14 0.67705909643300222
		 15 0.16453253783015556 16 0.059303097228878665 17 0.18931972833465455 18 0.35769618291639499
		 19 0.49037814620094294 20 0.75225750324093732 21 1.1008467929482333 22 1.0811709079653788
		 23 0.64672607302042606;
createNode animCurveTA -n "jnt_R_Ankle_rotateZ";
	rename -uid "B180EC79-484B-141E-FC3B-B389961FAF26";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 16.847028076367366 2 5.6369561903789309
		 3 -5.3135340984362065 4 -7.5459682520585147 5 -3.8949915774546899 6 -0.4266207244199165
		 7 3.1100061745376086 8 5.1539295269415648 9 5.4744681128669157 10 6.1681832609691778
		 11 7.4761427418166804 12 7.5832148018420673 13 3.9938167004104725 14 -3.0535602313631078
		 15 -8.1908746925454601 16 -7.4009401843504525 17 -2.9033258567341038 18 3.6645425312909912
		 19 11.207432539276777 20 16.395808806144831 21 17.57958253368778 22 17.651255204086315
		 23 17.792043473934097;
createNode animCurveTU -n "jnt_R_Ankle_visibility";
	rename -uid "81260374-4B14-374F-9F71-ACB04CB9748F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Ankle_translateX";
	rename -uid "F5716B0A-4399-6442-14C9-FB913A875157";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.37876095564505391 2 -0.37876095564505391
		 3 -0.37876095564505391 4 -0.37876095564505391 5 -0.37876095564505391 6 -0.37876095564505391
		 7 -0.37876095564505391 8 -0.37876095564505391 9 -0.37876095564505391 10 -0.37876095564505391
		 11 -0.37876095564505391 12 -0.37876095564505391 13 -0.37876095564505391 14 -0.37876095564505391
		 15 -0.37876095564505391 16 -0.37876095564505391 17 -0.37876095564505391 18 -0.37876095564505391
		 19 -0.37876095564505391 20 -0.37876095564505391 21 -0.37876095564505391 22 -0.37876095564505391
		 23 -0.37876095564505391;
createNode animCurveTL -n "jnt_R_Ankle_translateY";
	rename -uid "9E493781-4921-6077-1993-BCAD7E118DC4";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.0074556870833941396 2 0.0074556870833941396
		 3 0.0074556870833941396 4 0.0074556870833941396 5 0.0074556870833941396 6 0.0074556870833941396
		 7 0.0074556870833941396 8 0.0074556870833941396 9 0.0074556870833941396 10 0.0074556870833941396
		 11 0.0074556870833941396 12 0.0074556870833941396 13 0.0074556870833941396 14 0.0074556870833941396
		 15 0.0074556870833941396 16 0.0074556870833941396 17 0.0074556870833941396 18 0.0074556870833941396
		 19 0.0074556870833941396 20 0.0074556870833941396 21 0.0074556870833941396 22 0.0074556870833941396
		 23 0.0074556870833941396;
createNode animCurveTL -n "jnt_R_Ankle_translateZ";
	rename -uid "B29C091B-42A5-8B34-9322-96A4B1F4DED1";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1.1109841935308395e-010 2 1.1109841935308395e-010
		 3 1.1109841935308395e-010 4 1.1109841935308395e-010 5 1.1109841935308395e-010 6 1.1109841935308395e-010
		 7 1.1109841935308395e-010 8 1.1109841935308395e-010 9 1.1109841935308395e-010 10 1.1109841935308395e-010
		 11 1.1109841935308395e-010 12 1.1109841935308395e-010 13 1.1109841935308395e-010
		 14 1.1109841935308395e-010 15 1.1109841935308395e-010 16 1.1109841935308395e-010
		 17 1.1109841935308395e-010 18 1.1109841935308395e-010 19 1.1109841935308395e-010
		 20 1.1109841935308395e-010 21 1.1109841935308395e-010 22 1.1109841935308395e-010
		 23 1.1109841935308395e-010;
createNode animCurveTU -n "jnt_R_Ball_scaleX";
	rename -uid "F66BCCD1-422D-AA1B-90AF-85A74705B09D";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Ball_scaleY";
	rename -uid "28C9E5C5-447F-05F8-80C0-8DB65F25EE26";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Ball_scaleZ";
	rename -uid "F625F20A-4D0B-345E-8961-E4A9A8C3E25E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTA -n "jnt_R_Ball_rotateX";
	rename -uid "72A6C43B-4E2E-F0DE-B954-8EA56C8ECA14";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -2.7270731429280324e-005 2 -2.2384123508821803e-005
		 3 -1.6574427021874405e-005 4 -1.3732093209752176e-005 5 -1.1851931854216704e-005
		 6 -1.1392641637304034e-005 7 -1.0869903240282675e-005 8 -9.5412442428550387e-006
		 9 -1.1445739104258908e-005 10 -1.2112583105251577e-005 11 -1.2420518809755681e-005
		 12 -1.2730108450129563e-005 13 -1.3138141348703138e-005 14 -1.3482888598874842e-005
		 15 -1.3657806578759179e-005 16 -1.3701719011840706e-005 17 -1.3673866357013171e-005
		 18 -1.3769649940498789e-005 19 -1.4042405196110733e-005 20 -1.4004070885738321e-005
		 21 -1.3560231043242142e-005 22 -1.3970068085018578e-005 23 -1.7697900116214315e-005;
createNode animCurveTA -n "jnt_R_Ball_rotateY";
	rename -uid "3E8105AD-480B-713C-4E83-8EA62CACA5C2";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -1.6558257027473015e-005 2 -1.3589819436533532e-005
		 3 -1.0060297793745694e-005 4 -8.3334776248479224e-006 5 -7.19111954626416e-006 6 -6.912069000574404e-006
		 7 -6.5945975008256515e-006 8 -5.7873578017536683e-006 9 -6.9443789485418066e-006
		 10 -7.3495670591911905e-006 11 -7.5366193152797553e-006 12 -7.7245940486789521e-006
		 13 -7.9725728785986318e-006 14 -8.1820337931817104e-006 15 -8.2882525853321167e-006
		 16 -8.3148674332370749e-006 17 -8.2980756510382606e-006 18 -8.3563462249208145e-006
		 19 -8.5219565379968596e-006 20 -8.4987711679867773e-006 21 -8.2290023868154059e-006
		 22 -8.4779536437517321e-006 23 -1.0742883468827649e-005;
createNode animCurveTA -n "jnt_R_Ball_rotateZ";
	rename -uid "E2379AFA-409D-23A2-8E75-F992D88472D6";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.00013380063912241894 2 -0.00034408125338984393
		 3 -0.00044147493451917225 4 -0.00038368086015770115 5 -0.00021688507321457228 6 -0.00017249201728069286
		 7 -0.00025249886377005286 8 -0.00035860341488994579 9 -0.00024940783685636241 10 -0.0002101475437719956
		 11 -0.00019386866619466937 12 -0.00018624629657242804 13 -0.00018125948928602868
		 14 -0.00017681655419545114 15 -0.00017451702376647252 16 -0.00017394052147532259
		 17 -0.00017407116559121829 18 -0.00017294463535438346 19 -0.00017222294414708387
		 20 -0.00017225791778138134 21 -0.00017380406272994768 22 -0.00018247168077438803
		 23 -0.00018216732619007227;
createNode animCurveTU -n "jnt_R_Ball_visibility";
	rename -uid "287033C6-48ED-AC06-6093-669B9BCCC70E";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Ball_translateX";
	rename -uid "A9F8DE80-464C-DEC6-8D6E-2084C51C27EC";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.081292730702309635 2 -0.081292730702309635
		 3 -0.081292730702309635 4 -0.081292730702309635 5 -0.081292730702309635 6 -0.081292730702309635
		 7 -0.081292730702309635 8 -0.081292730702309635 9 -0.081292730702309635 10 -0.081292730702309635
		 11 -0.081292730702309635 12 -0.081292730702309635 13 -0.081292730702309635 14 -0.081292730702309635
		 15 -0.081292730702309635 16 -0.081292730702309635 17 -0.081292730702309635 18 -0.081292730702309635
		 19 -0.081292730702309635 20 -0.081292730702309635 21 -0.081292730702309635 22 -0.081292730702309635
		 23 -0.081292730702309635;
createNode animCurveTL -n "jnt_R_Ball_translateY";
	rename -uid "68D897C1-456B-C783-F882-309EFD5DB71C";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0.0087614962964497559 2 0.0087614962964497559
		 3 0.0087614962964497559 4 0.0087614962964497559 5 0.0087614962964497559 6 0.0087614962964497559
		 7 0.0087614962964497559 8 0.0087614962964497559 9 0.0087614962964497559 10 0.0087614962964497559
		 11 0.0087614962964497559 12 0.0087614962964497559 13 0.0087614962964497559 14 0.0087614962964497559
		 15 0.0087614962964497559 16 0.0087614962964497559 17 0.0087614962964497559 18 0.0087614962964497559
		 19 0.0087614962964497559 20 0.0087614962964497559 21 0.0087614962964497559 22 0.0087614962964497559
		 23 0.0087614962964497559;
createNode animCurveTL -n "jnt_R_Ball_translateZ";
	rename -uid "CEAC0DA6-4318-E166-C801-5A8588369160";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -5.3986856315603164e-010 2 -5.3986856315603164e-010
		 3 -5.3986856315603164e-010 4 -5.3986856315603164e-010 5 -5.3986856315603164e-010
		 6 -5.3986856315603164e-010 7 -5.3986856315603164e-010 8 -5.3986856315603164e-010
		 9 -5.3986856315603164e-010 10 -5.3986856315603164e-010 11 -5.3986856315603164e-010
		 12 -5.3986856315603164e-010 13 -5.3986856315603164e-010 14 -5.3986856315603164e-010
		 15 -5.3986856315603164e-010 16 -5.3986856315603164e-010 17 -5.3986856315603164e-010
		 18 -5.3986856315603164e-010 19 -5.3986856315603164e-010 20 -5.3986856315603164e-010
		 21 -5.3986856315603164e-010 22 -5.3986856315603164e-010 23 -5.3986856315603164e-010;
createNode animCurveTU -n "jnt_R_Toe_visibility";
	rename -uid "B1E0E580-4057-D3A6-56FC-82AA6CF6A3E9";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTL -n "jnt_R_Toe_translateX";
	rename -uid "61B4121E-46EA-E670-AC51-15B3D86CDF09";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.1103555303162201 2 -0.1103555303162201
		 3 -0.1103555303162201 4 -0.1103555303162201 5 -0.1103555303162201 6 -0.1103555303162201
		 7 -0.1103555303162201 8 -0.1103555303162201 9 -0.1103555303162201 10 -0.1103555303162201
		 11 -0.1103555303162201 12 -0.1103555303162201 13 -0.1103555303162201 14 -0.1103555303162201
		 15 -0.1103555303162201 16 -0.1103555303162201 17 -0.1103555303162201 18 -0.1103555303162201
		 19 -0.1103555303162201 20 -0.1103555303162201 21 -0.1103555303162201 22 -0.1103555303162201
		 23 -0.1103555303162201;
createNode animCurveTL -n "jnt_R_Toe_translateY";
	rename -uid "3F2BA2A4-42C9-EC64-1C6B-7EB3CBCF72ED";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -0.00082965154536410071 2 -0.00082965154536410071
		 3 -0.00082965154536410071 4 -0.00082965154536410071 5 -0.00082965154536410071 6 -0.00082965154536410071
		 7 -0.00082965154536410071 8 -0.00082965154536410071 9 -0.00082965154536410071 10 -0.00082965154536410071
		 11 -0.00082965154536410071 12 -0.00082965154536410071 13 -0.00082965154536410071
		 14 -0.00082965154536410071 15 -0.00082965154536410071 16 -0.00082965154536410071
		 17 -0.00082965154536410071 18 -0.00082965154536410071 19 -0.00082965154536410071
		 20 -0.00082965154536410071 21 -0.00082965154536410071 22 -0.00082965154536410071
		 23 -0.00082965154536410071;
createNode animCurveTL -n "jnt_R_Toe_translateZ";
	rename -uid "63207866-4774-9B27-85A7-31A37061B4D5";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 -1.8740587393040187e-009 2 -1.8740587393040187e-009
		 3 -1.8740587393040187e-009 4 -1.8740587393040187e-009 5 -1.8740587393040187e-009
		 6 -1.8740587393040187e-009 7 -1.8740587393040187e-009 8 -1.8740587393040187e-009
		 9 -1.8740587393040187e-009 10 -1.8740587393040187e-009 11 -1.8740587393040187e-009
		 12 -1.8740587393040187e-009 13 -1.8740587393040187e-009 14 -1.8740587393040187e-009
		 15 -1.8740587393040187e-009 16 -1.8740587393040187e-009 17 -1.8740587393040187e-009
		 18 -1.8740587393040187e-009 19 -1.8740587393040187e-009 20 -1.8740587393040187e-009
		 21 -1.8740587393040187e-009 22 -1.8740587393040187e-009 23 -1.8740587393040187e-009;
createNode animCurveTA -n "jnt_R_Toe_rotateX";
	rename -uid "A3849E5A-4AEE-E269-AEF4-01BEA72997A5";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_R_Toe_rotateY";
	rename -uid "BCBE4BA5-4E98-4998-4416-7FA0839CA592";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTA -n "jnt_R_Toe_rotateZ";
	rename -uid "565BD154-475F-3A0F-1005-8DB075676DB4";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 0 2 0 3 0 4 0 5 0 6 0 7 0 8 0 9 0 10 0
		 11 0 12 0 13 0 14 0 15 0 16 0 17 0 18 0 19 0 20 0 21 0 22 0 23 0;
createNode animCurveTU -n "jnt_R_Toe_scaleX";
	rename -uid "19A498F4-446B-CC25-5F18-2FB735AD23B1";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Toe_scaleY";
	rename -uid "45BF84A6-4A88-CE51-0ABB-D5B138CA9951";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode animCurveTU -n "jnt_R_Toe_scaleZ";
	rename -uid "6B3F7D1E-4D8C-8827-E729-A8A43A17E53F";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 23 ".ktv[0:22]"  1 1 2 1 3 1 4 1 5 1 6 1 7 1 8 1 9 1 10 1
		 11 1 12 1 13 1 14 1 15 1 16 1 17 1 18 1 19 1 20 1 21 1 22 1 23 1;
createNode cluster -n "clusterHipsCluster";
	rename -uid "32777C2C-46BA-FDE3-585E-0886884A1253";
	setAttr ".rel" yes;
	setAttr ".gm[0]" -type "matrix" 1.0000000000000002 1.1897263655005476e-016 -1.2028428014216932e-016 0
		 -1.2222138810700908e-016 1 5.5511151231257864e-017 0 1.2886007860243378e-016 5.5511151231257815e-017 1.0000000000000002 0
		 0 0 -1.7763568394002505e-015 1;
createNode objectSet -n "cluster4Set";
	rename -uid "1E112E87-405B-E302-6534-D1BA4E3A81A4";
	setAttr ".ihi" 0;
	setAttr ".vo" yes;
createNode groupId -n "cluster4GroupId";
	rename -uid "99B460F6-4E0D-C611-DB83-EBB4B5D3F864";
	setAttr ".ihi" 0;
createNode groupParts -n "cluster4GroupParts";
	rename -uid "E9793244-44DF-D639-0A9C-C8917A686F53";
	setAttr ".ihi" 0;
	setAttr ".ic" -type "componentList" 1 "cv[0]";
createNode cluster -n "clusterAbsCluster";
	rename -uid "4AFA0EE6-40D2-B3D1-81B6-1FAFE5EA4ADC";
	setAttr ".rel" yes;
	setAttr ".gm[0]" -type "matrix" 1.0000000000000002 1.1897263655005476e-016 -1.2028428014216932e-016 0
		 -1.2222138810700908e-016 1 5.5511151231257864e-017 0 1.2886007860243378e-016 5.5511151231257815e-017 1.0000000000000002 0
		 0 0 -1.7763568394002505e-015 1;
createNode objectSet -n "cluster3Set";
	rename -uid "176FFFA1-45F9-93AE-252B-2BAC296B4A1E";
	setAttr ".ihi" 0;
	setAttr ".vo" yes;
createNode groupId -n "cluster3GroupId";
	rename -uid "F244C0CA-446A-5A5D-BF5A-919A808F472F";
	setAttr ".ihi" 0;
createNode groupParts -n "cluster3GroupParts";
	rename -uid "6710E6D2-4694-5EC9-4613-F1B6AB55C4AC";
	setAttr ".ihi" 0;
	setAttr ".ic" -type "componentList" 1 "cv[1]";
createNode cluster -n "clusterChestCluster";
	rename -uid "D5C71989-4E3E-3339-0181-EC8D32C3BE93";
	setAttr ".rel" yes;
	setAttr ".gm[0]" -type "matrix" 1.0000000000000002 1.1897263655005476e-016 -1.2028428014216932e-016 0
		 -1.2222138810700908e-016 1 5.5511151231257864e-017 0 1.2886007860243378e-016 5.5511151231257815e-017 1.0000000000000002 0
		 0 0 -1.7763568394002505e-015 1;
createNode objectSet -n "cluster2Set";
	rename -uid "BBEEBBC9-4DAB-F9C0-F7AC-A5ACBBDEC5F6";
	setAttr ".ihi" 0;
	setAttr ".vo" yes;
createNode groupId -n "cluster2GroupId";
	rename -uid "3BEF46E9-4982-3432-1D66-CC9FA0DDE7C4";
	setAttr ".ihi" 0;
createNode groupParts -n "cluster2GroupParts";
	rename -uid "D329B044-4DE1-C06D-602D-89BEE10D0ADC";
	setAttr ".ihi" 0;
	setAttr ".ic" -type "componentList" 1 "cv[2]";
createNode cluster -n "clusterNeckbaseCluster";
	rename -uid "9388A853-444F-8420-F745-BC9D37755A59";
	setAttr ".rel" yes;
	setAttr ".gm[0]" -type "matrix" 1.0000000000000002 1.1897263655005476e-016 -1.2028428014216932e-016 0
		 -1.2222138810700908e-016 1 5.5511151231257864e-017 0 1.2886007860243378e-016 5.5511151231257815e-017 1.0000000000000002 0
		 0 0 -1.7763568394002505e-015 1;
createNode objectSet -n "cluster1Set";
	rename -uid "68046328-4CFC-C246-4496-6B8637D4C668";
	setAttr ".ihi" 0;
	setAttr ".vo" yes;
createNode groupId -n "cluster1GroupId";
	rename -uid "C2D70116-4DC8-3BEF-7B5D-D0B780BB0D98";
	setAttr ".ihi" 0;
createNode groupParts -n "cluster1GroupParts";
	rename -uid "FCF51DB2-4E7B-2EB5-148D-A79B24B5D1D1";
	setAttr ".ihi" 0;
	setAttr ".ic" -type "componentList" 1 "cv[3]";
createNode tweak -n "tweak1";
	rename -uid "9E00A410-4D73-BA8B-0D21-4388032F6C99";
createNode objectSet -n "tweakSet1";
	rename -uid "5716F83B-490C-8ACB-86F3-F7A41E473249";
	setAttr ".ihi" 0;
	setAttr ".vo" yes;
createNode groupId -n "groupId2";
	rename -uid "99B17721-4F79-D1A9-243A-A39B5BDC9D0D";
	setAttr ".ihi" 0;
createNode groupParts -n "groupParts2";
	rename -uid "73F48EC3-437C-45B0-8102-228D633458C5";
	setAttr ".ihi" 0;
	setAttr ".ic" -type "componentList" 1 "cv[*]";
createNode displayLayer -n "hiddenCtrls";
	rename -uid "C3BFAD40-4178-B8C4-080C-C99C631606AE";
	setAttr ".v" no;
	setAttr ".c" 30;
	setAttr ".do" 6;
createNode animCurveTL -n "ctrl_HipSway_translateX";
	rename -uid "F0B715B5-4CAC-912D-AA4C-24AFD9536A38";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 3 ".ktv[0:2]"  1 0 12.264 0 24.008 0;
createNode animCurveTL -n "ctrl_HipSway_translateY";
	rename -uid "968F6FF2-41E5-E5DE-F48F-72B4BEAE9281";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 3 ".ktv[0:2]"  1 0 12.264 0 24.008 0;
createNode animCurveTL -n "ctrl_HipSway_translateZ";
	rename -uid "C02E06D1-4E06-462F-7781-528FEEF479ED";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 3 ".ktv[0:2]"  1 0 12.264 0 24.008 0;
createNode animCurveTU -n "ctrl_HipSway_visibility";
	rename -uid "1D874ADE-404B-AD15-9277-F1B7C8A330D9";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 3 ".ktv[0:2]"  1 1 12.264 1 24.008 1;
createNode animCurveTA -n "ctrl_Chest_rotateY";
	rename -uid "F0C6A05F-4B7E-D898-E422-12B557D2A44D";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 3 ".ktv[0:2]"  1 0 12.264 0 24.008 0;
createNode animCurveTL -n "ctrl_Chest_translateX";
	rename -uid "9C210B26-481C-1EE1-BDA9-CF9712D179A4";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 3 ".ktv[0:2]"  1 0 12.264 0 24.008 0;
createNode animCurveTL -n "ctrl_Chest_translateY";
	rename -uid "8D66ED4D-488E-E77A-235D-02B690456B4A";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 3 ".ktv[0:2]"  1 0 12.264 0 24.008 0;
createNode animCurveTL -n "ctrl_Chest_translateZ";
	rename -uid "D2BA3A5A-4BBD-1E37-89A3-009D56E87BB1";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 3 ".ktv[0:2]"  1 0 12.264 0 24.008 0;
createNode animCurveTU -n "ctrl_Chest_visibility";
	rename -uid "508EB0FB-4AE6-F107-B737-638094EEF724";
	setAttr ".tan" 9;
	setAttr ".wgt" no;
	setAttr -s 3 ".ktv[0:2]"  1 1 12.264 1 24.008 1;
select -ne :time1;
	setAttr ".o" 11;
	setAttr ".unw" 11;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
select -ne :renderPartition;
	setAttr -s 3 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 5 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderUtilityList1;
select -ne :defaultRenderingList1;
select -ne :defaultTextureList1;
select -ne :initialShadingGroup;
	setAttr ".ro" yes;
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultResolution;
	setAttr ".w" 1280;
	setAttr ".h" 720;
	setAttr ".pa" 1;
	setAttr ".dar" 1.7777777910232544;
select -ne :defaultColorMgtGlobals;
	setAttr ".cme" no;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
select -ne :ikSystem;
	setAttr -s 2 ".sol";
connectAttr "ctrl_Global_translateX.o" "ctrl_Global.tx";
connectAttr "ctrl_Global_translateY.o" "ctrl_Global.ty";
connectAttr "ctrl_Global_translateZ.o" "ctrl_Global.tz";
connectAttr "ctrl_Global_rotateX.o" "ctrl_Global.rx";
connectAttr "ctrl_Global_rotateY.o" "ctrl_Global.ry";
connectAttr "ctrl_Global_rotateZ.o" "ctrl_Global.rz";
connectAttr "ctrl_Global_scaleX.o" "ctrl_Global.sx";
connectAttr "ctrl_Global_scaleY.o" "ctrl_Global.sy";
connectAttr "ctrl_Global_scaleZ.o" "ctrl_Global.sz";
connectAttr "ctrl_Global_visibility.o" "ctrl_Global.v";
connectAttr "grp_CtrlCurves_parentConstraint1.ctx" "grp_CtrlCurves.tx";
connectAttr "grp_CtrlCurves_parentConstraint1.cty" "grp_CtrlCurves.ty";
connectAttr "grp_CtrlCurves_parentConstraint1.ctz" "grp_CtrlCurves.tz";
connectAttr "grp_CtrlCurves_parentConstraint1.crx" "grp_CtrlCurves.rx";
connectAttr "grp_CtrlCurves_parentConstraint1.cry" "grp_CtrlCurves.ry";
connectAttr "grp_CtrlCurves_parentConstraint1.crz" "grp_CtrlCurves.rz";
connectAttr "grp_CtrlCurves_scaleConstraint1.csx" "grp_CtrlCurves.sx";
connectAttr "grp_CtrlCurves_scaleConstraint1.csy" "grp_CtrlCurves.sy";
connectAttr "grp_CtrlCurves_scaleConstraint1.csz" "grp_CtrlCurves.sz";
connectAttr "bodyControls.di" "ctrl_Hips.do";
connectAttr "ctrl_Hips_translateX.o" "ctrl_Hips.tx";
connectAttr "ctrl_Hips_translateY.o" "ctrl_Hips.ty";
connectAttr "ctrl_Hips_translateZ.o" "ctrl_Hips.tz";
connectAttr "ctrl_Hips_rotateX.o" "ctrl_Hips.rx";
connectAttr "ctrl_Hips_rotateY.o" "ctrl_Hips.ry";
connectAttr "ctrl_Hips_rotateZ.o" "ctrl_Hips.rz";
connectAttr "ctrl_Hips_visibility.o" "ctrl_Hips.v";
connectAttr "ctrl_Chest_rotateY.o" "ctrl_Chest.ry";
connectAttr "bodyControls.di" "ctrl_Chest.do";
connectAttr "ctrl_Chest_translateX.o" "ctrl_Chest.tx";
connectAttr "ctrl_Chest_translateY.o" "ctrl_Chest.ty";
connectAttr "ctrl_Chest_translateZ.o" "ctrl_Chest.tz";
connectAttr "ctrl_Chest_visibility.o" "ctrl_Chest.v";
connectAttr "bodyControls.di" "ctrl_HipSway.do";
connectAttr "ctrl_HipSway_translateX.o" "ctrl_HipSway.tx";
connectAttr "ctrl_HipSway_translateY.o" "ctrl_HipSway.ty";
connectAttr "ctrl_HipSway_translateZ.o" "ctrl_HipSway.tz";
connectAttr "ctrl_HipSway_visibility.o" "ctrl_HipSway.v";
connectAttr "bodyControls.di" "ctrl_Back.do";
connectAttr "ctrl_Back_translateX.o" "ctrl_Back.tx";
connectAttr "ctrl_Back_translateY.o" "ctrl_Back.ty";
connectAttr "ctrl_Back_translateZ.o" "ctrl_Back.tz";
connectAttr "ctrl_Back_visibility.o" "ctrl_Back.v";
connectAttr "ctrl_Back_rotateX.o" "ctrl_Back.rx";
connectAttr "ctrl_Back_rotateY.o" "ctrl_Back.ry";
connectAttr "ctrl_Back_rotateZ.o" "ctrl_Back.rz";
connectAttr "bodyControls.di" "ctrl_Neck.do";
connectAttr "leftControls.di" "ctrl_L_Arm.do";
connectAttr "ctrl_L_Arm_translateX.o" "ctrl_L_Arm.tx";
connectAttr "ctrl_L_Arm_translateY.o" "ctrl_L_Arm.ty";
connectAttr "ctrl_L_Arm_translateZ.o" "ctrl_L_Arm.tz";
connectAttr "ctrl_L_Arm_visibility.o" "ctrl_L_Arm.v";
connectAttr "rightControls.di" "ctrl_R_Arm.do";
connectAttr "ctrl_R_Arm_translateX.o" "ctrl_R_Arm.tx";
connectAttr "ctrl_R_Arm_translateY.o" "ctrl_R_Arm.ty";
connectAttr "ctrl_R_Arm_translateZ.o" "ctrl_R_Arm.tz";
connectAttr "ctrl_R_Arm_visibility.o" "ctrl_R_Arm.v";
connectAttr "ctrl_L_Wrist_pointConstraint1.ctx" "ctrl_L_Wrist.tx" -l on;
connectAttr "ctrl_L_Wrist_pointConstraint1.cty" "ctrl_L_Wrist.ty" -l on;
connectAttr "ctrl_L_Wrist_pointConstraint1.ctz" "ctrl_L_Wrist.tz" -l on;
connectAttr "ctrl_L_Wrist_FingerRoll.o" "ctrl_L_Wrist.FingerRoll";
connectAttr "leftControls.di" "ctrl_L_Wrist.do";
connectAttr "ctrl_L_Wrist_rotateX.o" "ctrl_L_Wrist.rx";
connectAttr "ctrl_L_Wrist_rotateY.o" "ctrl_L_Wrist.ry";
connectAttr "ctrl_L_Wrist_rotateZ.o" "ctrl_L_Wrist.rz";
connectAttr "ctrl_L_Wrist_visibility.o" "ctrl_L_Wrist.v";
connectAttr "ctrl_L_Wrist.pim" "ctrl_L_Wrist_pointConstraint1.cpim";
connectAttr "ctrl_L_Wrist.rp" "ctrl_L_Wrist_pointConstraint1.crp";
connectAttr "ctrl_L_Wrist.rpt" "ctrl_L_Wrist_pointConstraint1.crt";
connectAttr "ctrl_L_Arm.t" "ctrl_L_Wrist_pointConstraint1.tg[0].tt";
connectAttr "ctrl_L_Arm.rp" "ctrl_L_Wrist_pointConstraint1.tg[0].trp";
connectAttr "ctrl_L_Arm.rpt" "ctrl_L_Wrist_pointConstraint1.tg[0].trt";
connectAttr "ctrl_L_Arm.pm" "ctrl_L_Wrist_pointConstraint1.tg[0].tpm";
connectAttr "ctrl_L_Wrist_pointConstraint1.w0" "ctrl_L_Wrist_pointConstraint1.tg[0].tw"
		;
connectAttr "ctrl_R_Wrist_pointConstraint1.ctx" "ctrl_R_Wrist.tx" -l on;
connectAttr "ctrl_R_Wrist_pointConstraint1.cty" "ctrl_R_Wrist.ty" -l on;
connectAttr "ctrl_R_Wrist_pointConstraint1.ctz" "ctrl_R_Wrist.tz" -l on;
connectAttr "ctrl_R_Wrist_FingerRoll.o" "ctrl_R_Wrist.FingerRoll";
connectAttr "pairBlend1.orx" "ctrl_R_Wrist.rx";
connectAttr "ctrl_R_Wrist_rotateY.o" "ctrl_R_Wrist.ry";
connectAttr "ctrl_R_Wrist_rotateZ.o" "ctrl_R_Wrist.rz";
connectAttr "rightControls.di" "ctrl_R_Wrist.do";
connectAttr "ctrl_R_Wrist_visibility.o" "ctrl_R_Wrist.v";
connectAttr "ctrl_R_Wrist_blendUnitConversion15.o" "ctrl_R_Wrist.blendUnitConversion15"
		;
connectAttr "ctrl_R_Wrist.pim" "ctrl_R_Wrist_pointConstraint1.cpim";
connectAttr "ctrl_R_Wrist.rp" "ctrl_R_Wrist_pointConstraint1.crp";
connectAttr "ctrl_R_Wrist.rpt" "ctrl_R_Wrist_pointConstraint1.crt";
connectAttr "ctrl_R_Arm.t" "ctrl_R_Wrist_pointConstraint1.tg[0].tt";
connectAttr "ctrl_R_Arm.rp" "ctrl_R_Wrist_pointConstraint1.tg[0].trp";
connectAttr "ctrl_R_Arm.rpt" "ctrl_R_Wrist_pointConstraint1.tg[0].trt";
connectAttr "ctrl_R_Arm.pm" "ctrl_R_Wrist_pointConstraint1.tg[0].tpm";
connectAttr "ctrl_R_Wrist_pointConstraint1.w0" "ctrl_R_Wrist_pointConstraint1.tg[0].tw"
		;
connectAttr "grp_CtrlCurves.ro" "grp_CtrlCurves_parentConstraint1.cro";
connectAttr "grp_CtrlCurves.pim" "grp_CtrlCurves_parentConstraint1.cpim";
connectAttr "grp_CtrlCurves.rp" "grp_CtrlCurves_parentConstraint1.crp";
connectAttr "grp_CtrlCurves.rpt" "grp_CtrlCurves_parentConstraint1.crt";
connectAttr "ctrl_Global.t" "grp_CtrlCurves_parentConstraint1.tg[0].tt";
connectAttr "ctrl_Global.rp" "grp_CtrlCurves_parentConstraint1.tg[0].trp";
connectAttr "ctrl_Global.rpt" "grp_CtrlCurves_parentConstraint1.tg[0].trt";
connectAttr "ctrl_Global.r" "grp_CtrlCurves_parentConstraint1.tg[0].tr";
connectAttr "ctrl_Global.ro" "grp_CtrlCurves_parentConstraint1.tg[0].tro";
connectAttr "ctrl_Global.s" "grp_CtrlCurves_parentConstraint1.tg[0].ts";
connectAttr "ctrl_Global.pm" "grp_CtrlCurves_parentConstraint1.tg[0].tpm";
connectAttr "grp_CtrlCurves_parentConstraint1.w0" "grp_CtrlCurves_parentConstraint1.tg[0].tw"
		;
connectAttr "grp_CtrlCurves.pim" "grp_CtrlCurves_scaleConstraint1.cpim";
connectAttr "ctrl_Global.s" "grp_CtrlCurves_scaleConstraint1.tg[0].ts";
connectAttr "ctrl_Global.pm" "grp_CtrlCurves_scaleConstraint1.tg[0].tpm";
connectAttr "grp_CtrlCurves_scaleConstraint1.w0" "grp_CtrlCurves_scaleConstraint1.tg[0].tw"
		;
connectAttr "grp_Root_scaleConstraint1.csx" "grp_Root.sx";
connectAttr "grp_Root_scaleConstraint1.csy" "grp_Root.sy";
connectAttr "grp_Root_scaleConstraint1.csz" "grp_Root.sz";
connectAttr "SkeletonLayer.di" "jnt_Root.do";
connectAttr "jnt_Root_translateX.o" "jnt_Root.tx";
connectAttr "jnt_Root_translateY.o" "jnt_Root.ty";
connectAttr "jnt_Root_translateZ.o" "jnt_Root.tz";
connectAttr "jnt_Root_rotateX.o" "jnt_Root.rx";
connectAttr "jnt_Root_rotateY.o" "jnt_Root.ry";
connectAttr "jnt_Root_rotateZ.o" "jnt_Root.rz";
connectAttr "jnt_Root_scaleX.o" "jnt_Root.sx";
connectAttr "jnt_Root_scaleY.o" "jnt_Root.sy";
connectAttr "jnt_Root_scaleZ.o" "jnt_Root.sz";
connectAttr "jnt_Root_visibility.o" "jnt_Root.v";
connectAttr "jnt_Root.s" "jnt_Hip.is";
connectAttr "jnt_Hip_scaleX.o" "jnt_Hip.sx";
connectAttr "jnt_Hip_scaleY.o" "jnt_Hip.sy";
connectAttr "jnt_Hip_scaleZ.o" "jnt_Hip.sz";
connectAttr "jnt_Hip_visibility.o" "jnt_Hip.v";
connectAttr "jnt_Hip_translateX.o" "jnt_Hip.tx";
connectAttr "jnt_Hip_translateY.o" "jnt_Hip.ty";
connectAttr "jnt_Hip_translateZ.o" "jnt_Hip.tz";
connectAttr "jnt_Hip_rotateX.o" "jnt_Hip.rx";
connectAttr "jnt_Hip_rotateY.o" "jnt_Hip.ry";
connectAttr "jnt_Hip_rotateZ.o" "jnt_Hip.rz";
connectAttr "jnt_Hip.s" "jnt_Spine1.is";
connectAttr "jnt_Spine1_scaleX.o" "jnt_Spine1.sx";
connectAttr "jnt_Spine1_scaleY.o" "jnt_Spine1.sy";
connectAttr "jnt_Spine1_scaleZ.o" "jnt_Spine1.sz";
connectAttr "jnt_Spine1_visibility.o" "jnt_Spine1.v";
connectAttr "jnt_Spine1_translateX.o" "jnt_Spine1.tx";
connectAttr "jnt_Spine1_translateY.o" "jnt_Spine1.ty";
connectAttr "jnt_Spine1_translateZ.o" "jnt_Spine1.tz";
connectAttr "jnt_Spine1_rotateX.o" "jnt_Spine1.rx";
connectAttr "jnt_Spine1_rotateY.o" "jnt_Spine1.ry";
connectAttr "jnt_Spine1_rotateZ.o" "jnt_Spine1.rz";
connectAttr "jnt_Spine1.s" "jnt_Spine2.is";
connectAttr "jnt_Spine2_scaleX.o" "jnt_Spine2.sx";
connectAttr "jnt_Spine2_scaleY.o" "jnt_Spine2.sy";
connectAttr "jnt_Spine2_scaleZ.o" "jnt_Spine2.sz";
connectAttr "jnt_Spine2_visibility.o" "jnt_Spine2.v";
connectAttr "jnt_Spine2_translateX.o" "jnt_Spine2.tx";
connectAttr "jnt_Spine2_translateY.o" "jnt_Spine2.ty";
connectAttr "jnt_Spine2_translateZ.o" "jnt_Spine2.tz";
connectAttr "jnt_Spine2_rotateX.o" "jnt_Spine2.rx";
connectAttr "jnt_Spine2_rotateY.o" "jnt_Spine2.ry";
connectAttr "jnt_Spine2_rotateZ.o" "jnt_Spine2.rz";
connectAttr "jnt_Spine2.s" "jnt_Spine3.is";
connectAttr "jnt_Spine3_scaleX.o" "jnt_Spine3.sx";
connectAttr "jnt_Spine3_scaleY.o" "jnt_Spine3.sy";
connectAttr "jnt_Spine3_scaleZ.o" "jnt_Spine3.sz";
connectAttr "jnt_Spine3_visibility.o" "jnt_Spine3.v";
connectAttr "jnt_Spine3_translateX.o" "jnt_Spine3.tx";
connectAttr "jnt_Spine3_translateY.o" "jnt_Spine3.ty";
connectAttr "jnt_Spine3_translateZ.o" "jnt_Spine3.tz";
connectAttr "jnt_Spine3_rotateX.o" "jnt_Spine3.rx";
connectAttr "jnt_Spine3_rotateY.o" "jnt_Spine3.ry";
connectAttr "jnt_Spine3_rotateZ.o" "jnt_Spine3.rz";
connectAttr "jnt_Spine3.s" "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase.is"
		;
connectAttr "jnt_NeckBase_scaleX.o" "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase.sx"
		;
connectAttr "jnt_NeckBase_scaleY.o" "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase.sy"
		;
connectAttr "jnt_NeckBase_scaleZ.o" "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase.sz"
		;
connectAttr "jnt_NeckBase_translateX.o" "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase.tx"
		;
connectAttr "jnt_NeckBase_translateY.o" "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase.ty"
		;
connectAttr "jnt_NeckBase_translateZ.o" "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase.tz"
		;
connectAttr "jnt_NeckBase_visibility.o" "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase.v"
		;
connectAttr "jnt_NeckBase_rotateX.o" "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase.rx"
		;
connectAttr "jnt_NeckBase_rotateY.o" "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase.ry"
		;
connectAttr "jnt_NeckBase_rotateZ.o" "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase.rz"
		;
connectAttr "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase.s" "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase|jnt_NeckBase.is"
		;
connectAttr "jnt_NeckBase_scaleX1.o" "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase|jnt_NeckBase.sx"
		;
connectAttr "jnt_NeckBase_scaleY1.o" "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase|jnt_NeckBase.sy"
		;
connectAttr "jnt_NeckBase_scaleZ1.o" "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase|jnt_NeckBase.sz"
		;
connectAttr "jnt_NeckBase_visibility1.o" "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase|jnt_NeckBase.v"
		;
connectAttr "jnt_NeckBase_translateX1.o" "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase|jnt_NeckBase.tx"
		;
connectAttr "jnt_NeckBase_translateY1.o" "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase|jnt_NeckBase.ty"
		;
connectAttr "jnt_NeckBase_translateZ1.o" "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase|jnt_NeckBase.tz"
		;
connectAttr "jnt_NeckBase_rotateX1.o" "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase|jnt_NeckBase.rx"
		;
connectAttr "jnt_NeckBase_rotateY1.o" "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase|jnt_NeckBase.ry"
		;
connectAttr "jnt_NeckBase_rotateZ1.o" "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase|jnt_NeckBase.rz"
		;
connectAttr "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase|jnt_NeckBase.s" "jnt_Head.is"
		;
connectAttr "jnt_Head_rotateX.o" "jnt_Head.rx";
connectAttr "jnt_Head_rotateY.o" "jnt_Head.ry";
connectAttr "jnt_Head_rotateZ.o" "jnt_Head.rz";
connectAttr "jnt_Head_scaleX.o" "jnt_Head.sx";
connectAttr "jnt_Head_scaleY.o" "jnt_Head.sy";
connectAttr "jnt_Head_scaleZ.o" "jnt_Head.sz";
connectAttr "jnt_Head_translateX.o" "jnt_Head.tx";
connectAttr "jnt_Head_translateY.o" "jnt_Head.ty";
connectAttr "jnt_Head_translateZ.o" "jnt_Head.tz";
connectAttr "jnt_Head_visibility.o" "jnt_Head.v";
connectAttr "jnt_Head.s" "jnt_HeadTop.is";
connectAttr "jnt_HeadTop_scaleX.o" "jnt_HeadTop.sx";
connectAttr "jnt_HeadTop_scaleY.o" "jnt_HeadTop.sy";
connectAttr "jnt_HeadTop_scaleZ.o" "jnt_HeadTop.sz";
connectAttr "jnt_HeadTop_visibility.o" "jnt_HeadTop.v";
connectAttr "jnt_HeadTop_translateX.o" "jnt_HeadTop.tx";
connectAttr "jnt_HeadTop_translateY.o" "jnt_HeadTop.ty";
connectAttr "jnt_HeadTop_translateZ.o" "jnt_HeadTop.tz";
connectAttr "jnt_HeadTop_rotateX.o" "jnt_HeadTop.rx";
connectAttr "jnt_HeadTop_rotateY.o" "jnt_HeadTop.ry";
connectAttr "jnt_HeadTop_rotateZ.o" "jnt_HeadTop.rz";
connectAttr "jnt_HeadTop.s" "jnt_ChinBase.is";
connectAttr "jnt_ChinBase_scaleX.o" "jnt_ChinBase.sx";
connectAttr "jnt_ChinBase_scaleY.o" "jnt_ChinBase.sy";
connectAttr "jnt_ChinBase_scaleZ.o" "jnt_ChinBase.sz";
connectAttr "jnt_ChinBase_visibility.o" "jnt_ChinBase.v";
connectAttr "jnt_ChinBase_translateX.o" "jnt_ChinBase.tx";
connectAttr "jnt_ChinBase_translateY.o" "jnt_ChinBase.ty";
connectAttr "jnt_ChinBase_translateZ.o" "jnt_ChinBase.tz";
connectAttr "jnt_ChinBase_rotateX.o" "jnt_ChinBase.rx";
connectAttr "jnt_ChinBase_rotateY.o" "jnt_ChinBase.ry";
connectAttr "jnt_ChinBase_rotateZ.o" "jnt_ChinBase.rz";
connectAttr "jnt_ChinBase.s" "jnt_ChinTip.is";
connectAttr "jnt_ChinTip_visibility.o" "jnt_ChinTip.v";
connectAttr "jnt_ChinTip_translateX.o" "jnt_ChinTip.tx";
connectAttr "jnt_ChinTip_translateY.o" "jnt_ChinTip.ty";
connectAttr "jnt_ChinTip_translateZ.o" "jnt_ChinTip.tz";
connectAttr "jnt_ChinTip_rotateX.o" "jnt_ChinTip.rx";
connectAttr "jnt_ChinTip_rotateY.o" "jnt_ChinTip.ry";
connectAttr "jnt_ChinTip_rotateZ.o" "jnt_ChinTip.rz";
connectAttr "jnt_ChinTip_scaleX.o" "jnt_ChinTip.sx";
connectAttr "jnt_ChinTip_scaleY.o" "jnt_ChinTip.sy";
connectAttr "jnt_ChinTip_scaleZ.o" "jnt_ChinTip.sz";
connectAttr "jnt_Head.ro" "jnt_Head_orientConstraint1.cro";
connectAttr "jnt_Head.pim" "jnt_Head_orientConstraint1.cpim";
connectAttr "jnt_Head.jo" "jnt_Head_orientConstraint1.cjo";
connectAttr "jnt_Head.is" "jnt_Head_orientConstraint1.is";
connectAttr "ctrl_Neck.r" "jnt_Head_orientConstraint1.tg[0].tr";
connectAttr "ctrl_Neck.ro" "jnt_Head_orientConstraint1.tg[0].tro";
connectAttr "ctrl_Neck.pm" "jnt_Head_orientConstraint1.tg[0].tpm";
connectAttr "jnt_Head_orientConstraint1.w0" "jnt_Head_orientConstraint1.tg[0].tw"
		;
connectAttr "jnt_Head.tx" "effector10.tx";
connectAttr "jnt_Head.ty" "effector10.ty";
connectAttr "jnt_Head.tz" "effector10.tz";
connectAttr "jnt_Spine3.s" "jnt_L_Shoulder.is";
connectAttr "jnt_L_Shoulder_scaleX.o" "jnt_L_Shoulder.sx";
connectAttr "jnt_L_Shoulder_scaleY.o" "jnt_L_Shoulder.sy";
connectAttr "jnt_L_Shoulder_scaleZ.o" "jnt_L_Shoulder.sz";
connectAttr "jnt_L_Shoulder_visibility.o" "jnt_L_Shoulder.v";
connectAttr "jnt_L_Shoulder_translateX.o" "jnt_L_Shoulder.tx";
connectAttr "jnt_L_Shoulder_translateY.o" "jnt_L_Shoulder.ty";
connectAttr "jnt_L_Shoulder_translateZ.o" "jnt_L_Shoulder.tz";
connectAttr "jnt_L_Shoulder_rotateX.o" "jnt_L_Shoulder.rx";
connectAttr "jnt_L_Shoulder_rotateY.o" "jnt_L_Shoulder.ry";
connectAttr "jnt_L_Shoulder_rotateZ.o" "jnt_L_Shoulder.rz";
connectAttr "jnt_L_Shoulder.s" "jnt_L_Elbow.is";
connectAttr "jnt_L_Elbow_scaleX.o" "jnt_L_Elbow.sx";
connectAttr "jnt_L_Elbow_scaleY.o" "jnt_L_Elbow.sy";
connectAttr "jnt_L_Elbow_scaleZ.o" "jnt_L_Elbow.sz";
connectAttr "jnt_L_Elbow_visibility.o" "jnt_L_Elbow.v";
connectAttr "jnt_L_Elbow_translateX.o" "jnt_L_Elbow.tx";
connectAttr "jnt_L_Elbow_translateY.o" "jnt_L_Elbow.ty";
connectAttr "jnt_L_Elbow_translateZ.o" "jnt_L_Elbow.tz";
connectAttr "jnt_L_Elbow_rotateX.o" "jnt_L_Elbow.rx";
connectAttr "jnt_L_Elbow_rotateY.o" "jnt_L_Elbow.ry";
connectAttr "jnt_L_Elbow_rotateZ.o" "jnt_L_Elbow.rz";
connectAttr "jnt_L_Elbow.s" "jnt_L_Forearm.is";
connectAttr "jnt_L_Forearm_rotateX.o" "jnt_L_Forearm.rx";
connectAttr "jnt_L_Forearm_rotateY.o" "jnt_L_Forearm.ry";
connectAttr "jnt_L_Forearm_rotateZ.o" "jnt_L_Forearm.rz";
connectAttr "jnt_L_Forearm_scaleX.o" "jnt_L_Forearm.sx";
connectAttr "jnt_L_Forearm_scaleY.o" "jnt_L_Forearm.sy";
connectAttr "jnt_L_Forearm_scaleZ.o" "jnt_L_Forearm.sz";
connectAttr "jnt_L_Forearm_translateX.o" "jnt_L_Forearm.tx";
connectAttr "jnt_L_Forearm_translateY.o" "jnt_L_Forearm.ty";
connectAttr "jnt_L_Forearm_translateZ.o" "jnt_L_Forearm.tz";
connectAttr "jnt_L_Forearm_visibility.o" "jnt_L_Forearm.v";
connectAttr "jnt_L_Wrist_translateX.o" "jnt_L_Wrist.tx";
connectAttr "jnt_L_Wrist_translateY.o" "jnt_L_Wrist.ty";
connectAttr "jnt_L_Wrist_translateZ.o" "jnt_L_Wrist.tz";
connectAttr "jnt_L_Forearm.s" "jnt_L_Wrist.is";
connectAttr "jnt_L_Wrist_rotateX.o" "jnt_L_Wrist.rx";
connectAttr "jnt_L_Wrist_rotateY.o" "jnt_L_Wrist.ry";
connectAttr "jnt_L_Wrist_rotateZ.o" "jnt_L_Wrist.rz";
connectAttr "jnt_L_Wrist_scaleX.o" "jnt_L_Wrist.sx";
connectAttr "jnt_L_Wrist_scaleY.o" "jnt_L_Wrist.sy";
connectAttr "jnt_L_Wrist_scaleZ.o" "jnt_L_Wrist.sz";
connectAttr "jnt_L_Wrist_visibility.o" "jnt_L_Wrist.v";
connectAttr "jnt_L_Wrist.s" "jnt_L_Thumb1.is";
connectAttr "jnt_L_Thumb1_rotateX.o" "jnt_L_Thumb1.rx";
connectAttr "jnt_L_Thumb1_rotateY.o" "jnt_L_Thumb1.ry";
connectAttr "jnt_L_Thumb1_rotateZ.o" "jnt_L_Thumb1.rz";
connectAttr "jnt_L_Thumb1_scaleX.o" "jnt_L_Thumb1.sx";
connectAttr "jnt_L_Thumb1_scaleY.o" "jnt_L_Thumb1.sy";
connectAttr "jnt_L_Thumb1_scaleZ.o" "jnt_L_Thumb1.sz";
connectAttr "jnt_L_Thumb1_visibility.o" "jnt_L_Thumb1.v";
connectAttr "jnt_L_Thumb1_translateX.o" "jnt_L_Thumb1.tx";
connectAttr "jnt_L_Thumb1_translateY.o" "jnt_L_Thumb1.ty";
connectAttr "jnt_L_Thumb1_translateZ.o" "jnt_L_Thumb1.tz";
connectAttr "jnt_L_Thumb1.s" "jnt_L_Thumb2.is";
connectAttr "jnt_L_Thumb2_rotateX.o" "jnt_L_Thumb2.rx";
connectAttr "jnt_L_Thumb2_rotateY.o" "jnt_L_Thumb2.ry";
connectAttr "jnt_L_Thumb2_rotateZ.o" "jnt_L_Thumb2.rz";
connectAttr "jnt_L_Thumb2_scaleX.o" "jnt_L_Thumb2.sx";
connectAttr "jnt_L_Thumb2_scaleY.o" "jnt_L_Thumb2.sy";
connectAttr "jnt_L_Thumb2_scaleZ.o" "jnt_L_Thumb2.sz";
connectAttr "jnt_L_Thumb2_visibility.o" "jnt_L_Thumb2.v";
connectAttr "jnt_L_Thumb2_translateX.o" "jnt_L_Thumb2.tx";
connectAttr "jnt_L_Thumb2_translateY.o" "jnt_L_Thumb2.ty";
connectAttr "jnt_L_Thumb2_translateZ.o" "jnt_L_Thumb2.tz";
connectAttr "jnt_L_Thumb2.s" "jnt_L_Thumb3.is";
connectAttr "jnt_L_Thumb3_rotateX.o" "jnt_L_Thumb3.rx";
connectAttr "jnt_L_Thumb3_rotateY.o" "jnt_L_Thumb3.ry";
connectAttr "jnt_L_Thumb3_rotateZ.o" "jnt_L_Thumb3.rz";
connectAttr "jnt_L_Thumb3_scaleX.o" "jnt_L_Thumb3.sx";
connectAttr "jnt_L_Thumb3_scaleY.o" "jnt_L_Thumb3.sy";
connectAttr "jnt_L_Thumb3_scaleZ.o" "jnt_L_Thumb3.sz";
connectAttr "jnt_L_Thumb3_visibility.o" "jnt_L_Thumb3.v";
connectAttr "jnt_L_Thumb3_translateX.o" "jnt_L_Thumb3.tx";
connectAttr "jnt_L_Thumb3_translateY.o" "jnt_L_Thumb3.ty";
connectAttr "jnt_L_Thumb3_translateZ.o" "jnt_L_Thumb3.tz";
connectAttr "jnt_L_Thumb3.s" "jnt_L_Thumb4.is";
connectAttr "jnt_L_Thumb4_rotateX.o" "jnt_L_Thumb4.rx";
connectAttr "jnt_L_Thumb4_rotateY.o" "jnt_L_Thumb4.ry";
connectAttr "jnt_L_Thumb4_rotateZ.o" "jnt_L_Thumb4.rz";
connectAttr "jnt_L_Thumb4_visibility.o" "jnt_L_Thumb4.v";
connectAttr "jnt_L_Thumb4_translateX.o" "jnt_L_Thumb4.tx";
connectAttr "jnt_L_Thumb4_translateY.o" "jnt_L_Thumb4.ty";
connectAttr "jnt_L_Thumb4_translateZ.o" "jnt_L_Thumb4.tz";
connectAttr "jnt_L_Thumb4_scaleX.o" "jnt_L_Thumb4.sx";
connectAttr "jnt_L_Thumb4_scaleY.o" "jnt_L_Thumb4.sy";
connectAttr "jnt_L_Thumb4_scaleZ.o" "jnt_L_Thumb4.sz";
connectAttr "jnt_L_Wrist.s" "jnt_L_Index1.is";
connectAttr "jnt_L_Index1_rotateZ.o" "jnt_L_Index1.rz";
connectAttr "jnt_L_Index1_rotateX.o" "jnt_L_Index1.rx";
connectAttr "jnt_L_Index1_rotateY.o" "jnt_L_Index1.ry";
connectAttr "jnt_L_Index1_scaleX.o" "jnt_L_Index1.sx";
connectAttr "jnt_L_Index1_scaleY.o" "jnt_L_Index1.sy";
connectAttr "jnt_L_Index1_scaleZ.o" "jnt_L_Index1.sz";
connectAttr "jnt_L_Index1_visibility.o" "jnt_L_Index1.v";
connectAttr "jnt_L_Index1_translateX.o" "jnt_L_Index1.tx";
connectAttr "jnt_L_Index1_translateY.o" "jnt_L_Index1.ty";
connectAttr "jnt_L_Index1_translateZ.o" "jnt_L_Index1.tz";
connectAttr "jnt_L_Index1.s" "jnt_L_Index2.is";
connectAttr "jnt_L_Index2_rotateZ.o" "jnt_L_Index2.rz";
connectAttr "jnt_L_Index2_rotateX.o" "jnt_L_Index2.rx";
connectAttr "jnt_L_Index2_rotateY.o" "jnt_L_Index2.ry";
connectAttr "jnt_L_Index2_scaleX.o" "jnt_L_Index2.sx";
connectAttr "jnt_L_Index2_scaleY.o" "jnt_L_Index2.sy";
connectAttr "jnt_L_Index2_scaleZ.o" "jnt_L_Index2.sz";
connectAttr "jnt_L_Index2_visibility.o" "jnt_L_Index2.v";
connectAttr "jnt_L_Index2_translateX.o" "jnt_L_Index2.tx";
connectAttr "jnt_L_Index2_translateY.o" "jnt_L_Index2.ty";
connectAttr "jnt_L_Index2_translateZ.o" "jnt_L_Index2.tz";
connectAttr "jnt_L_Index2.s" "jnt_L_Index3.is";
connectAttr "jnt_L_Index3_rotateZ.o" "jnt_L_Index3.rz";
connectAttr "jnt_L_Index3_rotateX.o" "jnt_L_Index3.rx";
connectAttr "jnt_L_Index3_rotateY.o" "jnt_L_Index3.ry";
connectAttr "jnt_L_Index3_scaleX.o" "jnt_L_Index3.sx";
connectAttr "jnt_L_Index3_scaleY.o" "jnt_L_Index3.sy";
connectAttr "jnt_L_Index3_scaleZ.o" "jnt_L_Index3.sz";
connectAttr "jnt_L_Index3_visibility.o" "jnt_L_Index3.v";
connectAttr "jnt_L_Index3_translateX.o" "jnt_L_Index3.tx";
connectAttr "jnt_L_Index3_translateY.o" "jnt_L_Index3.ty";
connectAttr "jnt_L_Index3_translateZ.o" "jnt_L_Index3.tz";
connectAttr "jnt_L_Index3.s" "jnt_L_Index4.is";
connectAttr "jnt_L_Index4_rotateZ.o" "jnt_L_Index4.rz";
connectAttr "jnt_L_Index4_rotateX.o" "jnt_L_Index4.rx";
connectAttr "jnt_L_Index4_rotateY.o" "jnt_L_Index4.ry";
connectAttr "jnt_L_Index4_visibility.o" "jnt_L_Index4.v";
connectAttr "jnt_L_Index4_translateX.o" "jnt_L_Index4.tx";
connectAttr "jnt_L_Index4_translateY.o" "jnt_L_Index4.ty";
connectAttr "jnt_L_Index4_translateZ.o" "jnt_L_Index4.tz";
connectAttr "jnt_L_Index4_scaleX.o" "jnt_L_Index4.sx";
connectAttr "jnt_L_Index4_scaleY.o" "jnt_L_Index4.sy";
connectAttr "jnt_L_Index4_scaleZ.o" "jnt_L_Index4.sz";
connectAttr "jnt_L_Wrist.s" "jnt_L_Middle1.is";
connectAttr "jnt_L_Middle1_rotateZ.o" "jnt_L_Middle1.rz";
connectAttr "jnt_L_Middle1_rotateX.o" "jnt_L_Middle1.rx";
connectAttr "jnt_L_Middle1_rotateY.o" "jnt_L_Middle1.ry";
connectAttr "jnt_L_Middle1_scaleX.o" "jnt_L_Middle1.sx";
connectAttr "jnt_L_Middle1_scaleY.o" "jnt_L_Middle1.sy";
connectAttr "jnt_L_Middle1_scaleZ.o" "jnt_L_Middle1.sz";
connectAttr "jnt_L_Middle1_visibility.o" "jnt_L_Middle1.v";
connectAttr "jnt_L_Middle1_translateX.o" "jnt_L_Middle1.tx";
connectAttr "jnt_L_Middle1_translateY.o" "jnt_L_Middle1.ty";
connectAttr "jnt_L_Middle1_translateZ.o" "jnt_L_Middle1.tz";
connectAttr "jnt_L_Middle1.s" "jnt_L_Middle2.is";
connectAttr "jnt_L_Middle2_rotateZ.o" "jnt_L_Middle2.rz";
connectAttr "jnt_L_Middle2_rotateX.o" "jnt_L_Middle2.rx";
connectAttr "jnt_L_Middle2_rotateY.o" "jnt_L_Middle2.ry";
connectAttr "jnt_L_Middle2_scaleX.o" "jnt_L_Middle2.sx";
connectAttr "jnt_L_Middle2_scaleY.o" "jnt_L_Middle2.sy";
connectAttr "jnt_L_Middle2_scaleZ.o" "jnt_L_Middle2.sz";
connectAttr "jnt_L_Middle2_visibility.o" "jnt_L_Middle2.v";
connectAttr "jnt_L_Middle2_translateX.o" "jnt_L_Middle2.tx";
connectAttr "jnt_L_Middle2_translateY.o" "jnt_L_Middle2.ty";
connectAttr "jnt_L_Middle2_translateZ.o" "jnt_L_Middle2.tz";
connectAttr "jnt_L_Middle2.s" "jnt_L_Middle3.is";
connectAttr "jnt_L_Middle3_rotateZ.o" "jnt_L_Middle3.rz";
connectAttr "jnt_L_Middle3_rotateX.o" "jnt_L_Middle3.rx";
connectAttr "jnt_L_Middle3_rotateY.o" "jnt_L_Middle3.ry";
connectAttr "jnt_L_Middle3_scaleX.o" "jnt_L_Middle3.sx";
connectAttr "jnt_L_Middle3_scaleY.o" "jnt_L_Middle3.sy";
connectAttr "jnt_L_Middle3_scaleZ.o" "jnt_L_Middle3.sz";
connectAttr "jnt_L_Middle3_visibility.o" "jnt_L_Middle3.v";
connectAttr "jnt_L_Middle3_translateX.o" "jnt_L_Middle3.tx";
connectAttr "jnt_L_Middle3_translateY.o" "jnt_L_Middle3.ty";
connectAttr "jnt_L_Middle3_translateZ.o" "jnt_L_Middle3.tz";
connectAttr "jnt_L_Middle3.s" "jnt_L_Middle4.is";
connectAttr "jnt_L_Middle4_rotateZ.o" "jnt_L_Middle4.rz";
connectAttr "jnt_L_Middle4_rotateX.o" "jnt_L_Middle4.rx";
connectAttr "jnt_L_Middle4_rotateY.o" "jnt_L_Middle4.ry";
connectAttr "jnt_L_Middle4_visibility.o" "jnt_L_Middle4.v";
connectAttr "jnt_L_Middle4_translateX.o" "jnt_L_Middle4.tx";
connectAttr "jnt_L_Middle4_translateY.o" "jnt_L_Middle4.ty";
connectAttr "jnt_L_Middle4_translateZ.o" "jnt_L_Middle4.tz";
connectAttr "jnt_L_Middle4_scaleX.o" "jnt_L_Middle4.sx";
connectAttr "jnt_L_Middle4_scaleY.o" "jnt_L_Middle4.sy";
connectAttr "jnt_L_Middle4_scaleZ.o" "jnt_L_Middle4.sz";
connectAttr "jnt_L_Wrist.s" "jnt_L_Ring1.is";
connectAttr "jnt_L_Ring1_rotateZ.o" "jnt_L_Ring1.rz";
connectAttr "jnt_L_Ring1_rotateX.o" "jnt_L_Ring1.rx";
connectAttr "jnt_L_Ring1_rotateY.o" "jnt_L_Ring1.ry";
connectAttr "jnt_L_Ring1_scaleX.o" "jnt_L_Ring1.sx";
connectAttr "jnt_L_Ring1_scaleY.o" "jnt_L_Ring1.sy";
connectAttr "jnt_L_Ring1_scaleZ.o" "jnt_L_Ring1.sz";
connectAttr "jnt_L_Ring1_visibility.o" "jnt_L_Ring1.v";
connectAttr "jnt_L_Ring1_translateX.o" "jnt_L_Ring1.tx";
connectAttr "jnt_L_Ring1_translateY.o" "jnt_L_Ring1.ty";
connectAttr "jnt_L_Ring1_translateZ.o" "jnt_L_Ring1.tz";
connectAttr "jnt_L_Ring1.s" "jnt_L_Ring2.is";
connectAttr "jnt_L_Ring2_rotateZ.o" "jnt_L_Ring2.rz";
connectAttr "jnt_L_Ring2_rotateX.o" "jnt_L_Ring2.rx";
connectAttr "jnt_L_Ring2_rotateY.o" "jnt_L_Ring2.ry";
connectAttr "jnt_L_Ring2_scaleX.o" "jnt_L_Ring2.sx";
connectAttr "jnt_L_Ring2_scaleY.o" "jnt_L_Ring2.sy";
connectAttr "jnt_L_Ring2_scaleZ.o" "jnt_L_Ring2.sz";
connectAttr "jnt_L_Ring2_visibility.o" "jnt_L_Ring2.v";
connectAttr "jnt_L_Ring2_translateX.o" "jnt_L_Ring2.tx";
connectAttr "jnt_L_Ring2_translateY.o" "jnt_L_Ring2.ty";
connectAttr "jnt_L_Ring2_translateZ.o" "jnt_L_Ring2.tz";
connectAttr "jnt_L_Ring2.s" "jnt_L_Ring3.is";
connectAttr "jnt_L_Ring3_rotateZ.o" "jnt_L_Ring3.rz";
connectAttr "jnt_L_Ring3_rotateX.o" "jnt_L_Ring3.rx";
connectAttr "jnt_L_Ring3_rotateY.o" "jnt_L_Ring3.ry";
connectAttr "jnt_L_Ring3_scaleX.o" "jnt_L_Ring3.sx";
connectAttr "jnt_L_Ring3_scaleY.o" "jnt_L_Ring3.sy";
connectAttr "jnt_L_Ring3_scaleZ.o" "jnt_L_Ring3.sz";
connectAttr "jnt_L_Ring3_visibility.o" "jnt_L_Ring3.v";
connectAttr "jnt_L_Ring3_translateX.o" "jnt_L_Ring3.tx";
connectAttr "jnt_L_Ring3_translateY.o" "jnt_L_Ring3.ty";
connectAttr "jnt_L_Ring3_translateZ.o" "jnt_L_Ring3.tz";
connectAttr "jnt_L_Ring3.s" "jnt_L_Ring4.is";
connectAttr "jnt_L_Ring4_rotateZ.o" "jnt_L_Ring4.rz";
connectAttr "jnt_L_Ring4_rotateX.o" "jnt_L_Ring4.rx";
connectAttr "jnt_L_Ring4_rotateY.o" "jnt_L_Ring4.ry";
connectAttr "jnt_L_Ring4_visibility.o" "jnt_L_Ring4.v";
connectAttr "jnt_L_Ring4_translateX.o" "jnt_L_Ring4.tx";
connectAttr "jnt_L_Ring4_translateY.o" "jnt_L_Ring4.ty";
connectAttr "jnt_L_Ring4_translateZ.o" "jnt_L_Ring4.tz";
connectAttr "jnt_L_Ring4_scaleX.o" "jnt_L_Ring4.sx";
connectAttr "jnt_L_Ring4_scaleY.o" "jnt_L_Ring4.sy";
connectAttr "jnt_L_Ring4_scaleZ.o" "jnt_L_Ring4.sz";
connectAttr "jnt_L_Wrist.s" "jnt_L_Pinky1.is";
connectAttr "jnt_L_Pinky1_rotateZ.o" "jnt_L_Pinky1.rz";
connectAttr "jnt_L_Pinky1_rotateX.o" "jnt_L_Pinky1.rx";
connectAttr "jnt_L_Pinky1_rotateY.o" "jnt_L_Pinky1.ry";
connectAttr "jnt_L_Pinky1_scaleX.o" "jnt_L_Pinky1.sx";
connectAttr "jnt_L_Pinky1_scaleY.o" "jnt_L_Pinky1.sy";
connectAttr "jnt_L_Pinky1_scaleZ.o" "jnt_L_Pinky1.sz";
connectAttr "jnt_L_Pinky1_visibility.o" "jnt_L_Pinky1.v";
connectAttr "jnt_L_Pinky1_translateX.o" "jnt_L_Pinky1.tx";
connectAttr "jnt_L_Pinky1_translateY.o" "jnt_L_Pinky1.ty";
connectAttr "jnt_L_Pinky1_translateZ.o" "jnt_L_Pinky1.tz";
connectAttr "jnt_L_Pinky1.s" "jnt_L_Pinky2.is";
connectAttr "jnt_L_Pinky2_rotateZ.o" "jnt_L_Pinky2.rz";
connectAttr "jnt_L_Pinky2_rotateX.o" "jnt_L_Pinky2.rx";
connectAttr "jnt_L_Pinky2_rotateY.o" "jnt_L_Pinky2.ry";
connectAttr "jnt_L_Pinky2_scaleX.o" "jnt_L_Pinky2.sx";
connectAttr "jnt_L_Pinky2_scaleY.o" "jnt_L_Pinky2.sy";
connectAttr "jnt_L_Pinky2_scaleZ.o" "jnt_L_Pinky2.sz";
connectAttr "jnt_L_Pinky2_visibility.o" "jnt_L_Pinky2.v";
connectAttr "jnt_L_Pinky2_translateX.o" "jnt_L_Pinky2.tx";
connectAttr "jnt_L_Pinky2_translateY.o" "jnt_L_Pinky2.ty";
connectAttr "jnt_L_Pinky2_translateZ.o" "jnt_L_Pinky2.tz";
connectAttr "jnt_L_Pinky2.s" "jnt_L_Pinky3.is";
connectAttr "jnt_L_Pinky3_rotateZ.o" "jnt_L_Pinky3.rz";
connectAttr "jnt_L_Pinky3_rotateX.o" "jnt_L_Pinky3.rx";
connectAttr "jnt_L_Pinky3_rotateY.o" "jnt_L_Pinky3.ry";
connectAttr "jnt_L_Pinky3_scaleX.o" "jnt_L_Pinky3.sx";
connectAttr "jnt_L_Pinky3_scaleY.o" "jnt_L_Pinky3.sy";
connectAttr "jnt_L_Pinky3_scaleZ.o" "jnt_L_Pinky3.sz";
connectAttr "jnt_L_Pinky3_visibility.o" "jnt_L_Pinky3.v";
connectAttr "jnt_L_Pinky3_translateX.o" "jnt_L_Pinky3.tx";
connectAttr "jnt_L_Pinky3_translateY.o" "jnt_L_Pinky3.ty";
connectAttr "jnt_L_Pinky3_translateZ.o" "jnt_L_Pinky3.tz";
connectAttr "jnt_L_Pinky3.s" "jnt_L_Pinky4.is";
connectAttr "jnt_L_Pinky4_rotateZ.o" "jnt_L_Pinky4.rz";
connectAttr "jnt_L_Pinky4_rotateX.o" "jnt_L_Pinky4.rx";
connectAttr "jnt_L_Pinky4_rotateY.o" "jnt_L_Pinky4.ry";
connectAttr "jnt_L_Pinky4_visibility.o" "jnt_L_Pinky4.v";
connectAttr "jnt_L_Pinky4_translateX.o" "jnt_L_Pinky4.tx";
connectAttr "jnt_L_Pinky4_translateY.o" "jnt_L_Pinky4.ty";
connectAttr "jnt_L_Pinky4_translateZ.o" "jnt_L_Pinky4.tz";
connectAttr "jnt_L_Pinky4_scaleX.o" "jnt_L_Pinky4.sx";
connectAttr "jnt_L_Pinky4_scaleY.o" "jnt_L_Pinky4.sy";
connectAttr "jnt_L_Pinky4_scaleZ.o" "jnt_L_Pinky4.sz";
connectAttr "jnt_L_Wrist.ro" "jnt_L_Wrist_orientConstraint1.cro";
connectAttr "jnt_L_Wrist.pim" "jnt_L_Wrist_orientConstraint1.cpim";
connectAttr "jnt_L_Wrist.jo" "jnt_L_Wrist_orientConstraint1.cjo";
connectAttr "jnt_L_Wrist.is" "jnt_L_Wrist_orientConstraint1.is";
connectAttr "ctrl_L_Wrist.r" "jnt_L_Wrist_orientConstraint1.tg[0].tr";
connectAttr "ctrl_L_Wrist.ro" "jnt_L_Wrist_orientConstraint1.tg[0].tro";
connectAttr "ctrl_L_Wrist.pm" "jnt_L_Wrist_orientConstraint1.tg[0].tpm";
connectAttr "jnt_L_Wrist_orientConstraint1.w0" "jnt_L_Wrist_orientConstraint1.tg[0].tw"
		;
connectAttr "jnt_L_Forearm.tx" "effector7.tx";
connectAttr "jnt_L_Forearm.ty" "effector7.ty";
connectAttr "jnt_L_Forearm.tz" "effector7.tz";
connectAttr "jnt_Spine3.s" "jnt_R_Shoulder.is";
connectAttr "jnt_R_Shoulder_scaleX.o" "jnt_R_Shoulder.sx";
connectAttr "jnt_R_Shoulder_scaleY.o" "jnt_R_Shoulder.sy";
connectAttr "jnt_R_Shoulder_scaleZ.o" "jnt_R_Shoulder.sz";
connectAttr "jnt_R_Shoulder_visibility.o" "jnt_R_Shoulder.v";
connectAttr "jnt_R_Shoulder_translateX.o" "jnt_R_Shoulder.tx";
connectAttr "jnt_R_Shoulder_translateY.o" "jnt_R_Shoulder.ty";
connectAttr "jnt_R_Shoulder_translateZ.o" "jnt_R_Shoulder.tz";
connectAttr "jnt_R_Shoulder_rotateX.o" "jnt_R_Shoulder.rx";
connectAttr "jnt_R_Shoulder_rotateY.o" "jnt_R_Shoulder.ry";
connectAttr "jnt_R_Shoulder_rotateZ.o" "jnt_R_Shoulder.rz";
connectAttr "jnt_R_Shoulder.s" "jnt_R_Elbow.is";
connectAttr "jnt_R_Elbow_scaleX.o" "jnt_R_Elbow.sx";
connectAttr "jnt_R_Elbow_scaleY.o" "jnt_R_Elbow.sy";
connectAttr "jnt_R_Elbow_scaleZ.o" "jnt_R_Elbow.sz";
connectAttr "jnt_R_Elbow_visibility.o" "jnt_R_Elbow.v";
connectAttr "jnt_R_Elbow_translateX.o" "jnt_R_Elbow.tx";
connectAttr "jnt_R_Elbow_translateY.o" "jnt_R_Elbow.ty";
connectAttr "jnt_R_Elbow_translateZ.o" "jnt_R_Elbow.tz";
connectAttr "jnt_R_Elbow_rotateX.o" "jnt_R_Elbow.rx";
connectAttr "jnt_R_Elbow_rotateY.o" "jnt_R_Elbow.ry";
connectAttr "jnt_R_Elbow_rotateZ.o" "jnt_R_Elbow.rz";
connectAttr "jnt_R_Elbow.s" "jnt_R_Forearm.is";
connectAttr "jnt_R_Forearm_scaleX.o" "jnt_R_Forearm.sx";
connectAttr "jnt_R_Forearm_scaleY.o" "jnt_R_Forearm.sy";
connectAttr "jnt_R_Forearm_scaleZ.o" "jnt_R_Forearm.sz";
connectAttr "jnt_R_Forearm_translateX.o" "jnt_R_Forearm.tx";
connectAttr "jnt_R_Forearm_translateY.o" "jnt_R_Forearm.ty";
connectAttr "jnt_R_Forearm_translateZ.o" "jnt_R_Forearm.tz";
connectAttr "jnt_R_Forearm_visibility.o" "jnt_R_Forearm.v";
connectAttr "jnt_R_Forearm_rotateX.o" "jnt_R_Forearm.rx";
connectAttr "jnt_R_Forearm_rotateY.o" "jnt_R_Forearm.ry";
connectAttr "jnt_R_Forearm_rotateZ.o" "jnt_R_Forearm.rz";
connectAttr "jnt_R_Wrist_translateX.o" "jnt_R_Wrist.tx";
connectAttr "jnt_R_Wrist_translateY.o" "jnt_R_Wrist.ty";
connectAttr "jnt_R_Wrist_translateZ.o" "jnt_R_Wrist.tz";
connectAttr "jnt_R_Forearm.s" "jnt_R_Wrist.is";
connectAttr "jnt_R_Wrist_rotateX.o" "jnt_R_Wrist.rx";
connectAttr "jnt_R_Wrist_rotateY.o" "jnt_R_Wrist.ry";
connectAttr "jnt_R_Wrist_rotateZ.o" "jnt_R_Wrist.rz";
connectAttr "jnt_R_Wrist_scaleX.o" "jnt_R_Wrist.sx";
connectAttr "jnt_R_Wrist_scaleY.o" "jnt_R_Wrist.sy";
connectAttr "jnt_R_Wrist_scaleZ.o" "jnt_R_Wrist.sz";
connectAttr "jnt_R_Wrist_visibility.o" "jnt_R_Wrist.v";
connectAttr "jnt_R_Wrist.s" "jnt_R_Thumb1.is";
connectAttr "jnt_R_Thumb1_rotateX.o" "jnt_R_Thumb1.rx";
connectAttr "jnt_R_Thumb1_rotateY.o" "jnt_R_Thumb1.ry";
connectAttr "jnt_R_Thumb1_rotateZ.o" "jnt_R_Thumb1.rz";
connectAttr "jnt_R_Thumb1_scaleX.o" "jnt_R_Thumb1.sx";
connectAttr "jnt_R_Thumb1_scaleY.o" "jnt_R_Thumb1.sy";
connectAttr "jnt_R_Thumb1_scaleZ.o" "jnt_R_Thumb1.sz";
connectAttr "jnt_R_Thumb1_visibility.o" "jnt_R_Thumb1.v";
connectAttr "jnt_R_Thumb1_translateX.o" "jnt_R_Thumb1.tx";
connectAttr "jnt_R_Thumb1_translateY.o" "jnt_R_Thumb1.ty";
connectAttr "jnt_R_Thumb1_translateZ.o" "jnt_R_Thumb1.tz";
connectAttr "jnt_R_Thumb1.s" "jnt_R_Thumb2.is";
connectAttr "jnt_R_Thumb2_rotateX.o" "jnt_R_Thumb2.rx";
connectAttr "jnt_R_Thumb2_rotateY.o" "jnt_R_Thumb2.ry";
connectAttr "jnt_R_Thumb2_rotateZ.o" "jnt_R_Thumb2.rz";
connectAttr "jnt_R_Thumb2_scaleX.o" "jnt_R_Thumb2.sx";
connectAttr "jnt_R_Thumb2_scaleY.o" "jnt_R_Thumb2.sy";
connectAttr "jnt_R_Thumb2_scaleZ.o" "jnt_R_Thumb2.sz";
connectAttr "jnt_R_Thumb2_visibility.o" "jnt_R_Thumb2.v";
connectAttr "jnt_R_Thumb2_translateX.o" "jnt_R_Thumb2.tx";
connectAttr "jnt_R_Thumb2_translateY.o" "jnt_R_Thumb2.ty";
connectAttr "jnt_R_Thumb2_translateZ.o" "jnt_R_Thumb2.tz";
connectAttr "jnt_R_Thumb2.s" "jnt_R_Thumb3.is";
connectAttr "jnt_R_Thumb3_rotateX.o" "jnt_R_Thumb3.rx";
connectAttr "jnt_R_Thumb3_rotateY.o" "jnt_R_Thumb3.ry";
connectAttr "jnt_R_Thumb3_rotateZ.o" "jnt_R_Thumb3.rz";
connectAttr "jnt_R_Thumb3_scaleX.o" "jnt_R_Thumb3.sx";
connectAttr "jnt_R_Thumb3_scaleY.o" "jnt_R_Thumb3.sy";
connectAttr "jnt_R_Thumb3_scaleZ.o" "jnt_R_Thumb3.sz";
connectAttr "jnt_R_Thumb3_visibility.o" "jnt_R_Thumb3.v";
connectAttr "jnt_R_Thumb3_translateX.o" "jnt_R_Thumb3.tx";
connectAttr "jnt_R_Thumb3_translateY.o" "jnt_R_Thumb3.ty";
connectAttr "jnt_R_Thumb3_translateZ.o" "jnt_R_Thumb3.tz";
connectAttr "jnt_R_Thumb3.s" "jnt_R_Thumb4.is";
connectAttr "jnt_R_Thumb4_rotateX.o" "jnt_R_Thumb4.rx";
connectAttr "jnt_R_Thumb4_rotateY.o" "jnt_R_Thumb4.ry";
connectAttr "jnt_R_Thumb4_rotateZ.o" "jnt_R_Thumb4.rz";
connectAttr "jnt_R_Thumb4_visibility.o" "jnt_R_Thumb4.v";
connectAttr "jnt_R_Thumb4_translateX.o" "jnt_R_Thumb4.tx";
connectAttr "jnt_R_Thumb4_translateY.o" "jnt_R_Thumb4.ty";
connectAttr "jnt_R_Thumb4_translateZ.o" "jnt_R_Thumb4.tz";
connectAttr "jnt_R_Thumb4_scaleX.o" "jnt_R_Thumb4.sx";
connectAttr "jnt_R_Thumb4_scaleY.o" "jnt_R_Thumb4.sy";
connectAttr "jnt_R_Thumb4_scaleZ.o" "jnt_R_Thumb4.sz";
connectAttr "jnt_R_Wrist.s" "jnt_R_Index1.is";
connectAttr "jnt_R_Index1_rotateZ.o" "jnt_R_Index1.rz";
connectAttr "jnt_R_Index1_rotateX.o" "jnt_R_Index1.rx";
connectAttr "jnt_R_Index1_rotateY.o" "jnt_R_Index1.ry";
connectAttr "jnt_R_Index1_scaleX.o" "jnt_R_Index1.sx";
connectAttr "jnt_R_Index1_scaleY.o" "jnt_R_Index1.sy";
connectAttr "jnt_R_Index1_scaleZ.o" "jnt_R_Index1.sz";
connectAttr "jnt_R_Index1_visibility.o" "jnt_R_Index1.v";
connectAttr "jnt_R_Index1_translateX.o" "jnt_R_Index1.tx";
connectAttr "jnt_R_Index1_translateY.o" "jnt_R_Index1.ty";
connectAttr "jnt_R_Index1_translateZ.o" "jnt_R_Index1.tz";
connectAttr "jnt_R_Index1.s" "jnt_R_Index2.is";
connectAttr "jnt_R_Index2_rotateZ.o" "jnt_R_Index2.rz";
connectAttr "jnt_R_Index2_rotateX.o" "jnt_R_Index2.rx";
connectAttr "jnt_R_Index2_rotateY.o" "jnt_R_Index2.ry";
connectAttr "jnt_R_Index2_scaleX.o" "jnt_R_Index2.sx";
connectAttr "jnt_R_Index2_scaleY.o" "jnt_R_Index2.sy";
connectAttr "jnt_R_Index2_scaleZ.o" "jnt_R_Index2.sz";
connectAttr "jnt_R_Index2_visibility.o" "jnt_R_Index2.v";
connectAttr "jnt_R_Index2_translateX.o" "jnt_R_Index2.tx";
connectAttr "jnt_R_Index2_translateY.o" "jnt_R_Index2.ty";
connectAttr "jnt_R_Index2_translateZ.o" "jnt_R_Index2.tz";
connectAttr "jnt_R_Index2.s" "jnt_R_Index3.is";
connectAttr "jnt_R_Index3_rotateZ.o" "jnt_R_Index3.rz";
connectAttr "jnt_R_Index3_rotateX.o" "jnt_R_Index3.rx";
connectAttr "jnt_R_Index3_rotateY.o" "jnt_R_Index3.ry";
connectAttr "jnt_R_Index3_scaleX.o" "jnt_R_Index3.sx";
connectAttr "jnt_R_Index3_scaleY.o" "jnt_R_Index3.sy";
connectAttr "jnt_R_Index3_scaleZ.o" "jnt_R_Index3.sz";
connectAttr "jnt_R_Index3_visibility.o" "jnt_R_Index3.v";
connectAttr "jnt_R_Index3_translateX.o" "jnt_R_Index3.tx";
connectAttr "jnt_R_Index3_translateY.o" "jnt_R_Index3.ty";
connectAttr "jnt_R_Index3_translateZ.o" "jnt_R_Index3.tz";
connectAttr "jnt_R_Index3.s" "jnt_R_Index4.is";
connectAttr "jnt_R_Index4_rotateZ.o" "jnt_R_Index4.rz";
connectAttr "jnt_R_Index4_rotateX.o" "jnt_R_Index4.rx";
connectAttr "jnt_R_Index4_rotateY.o" "jnt_R_Index4.ry";
connectAttr "jnt_R_Index4_visibility.o" "jnt_R_Index4.v";
connectAttr "jnt_R_Index4_translateX.o" "jnt_R_Index4.tx";
connectAttr "jnt_R_Index4_translateY.o" "jnt_R_Index4.ty";
connectAttr "jnt_R_Index4_translateZ.o" "jnt_R_Index4.tz";
connectAttr "jnt_R_Index4_scaleX.o" "jnt_R_Index4.sx";
connectAttr "jnt_R_Index4_scaleY.o" "jnt_R_Index4.sy";
connectAttr "jnt_R_Index4_scaleZ.o" "jnt_R_Index4.sz";
connectAttr "jnt_R_Wrist.s" "jnt_R_Middle1.is";
connectAttr "jnt_R_Middle1_rotateZ.o" "jnt_R_Middle1.rz";
connectAttr "jnt_R_Middle1_rotateX.o" "jnt_R_Middle1.rx";
connectAttr "jnt_R_Middle1_rotateY.o" "jnt_R_Middle1.ry";
connectAttr "jnt_R_Middle1_scaleX.o" "jnt_R_Middle1.sx";
connectAttr "jnt_R_Middle1_scaleY.o" "jnt_R_Middle1.sy";
connectAttr "jnt_R_Middle1_scaleZ.o" "jnt_R_Middle1.sz";
connectAttr "jnt_R_Middle1_visibility.o" "jnt_R_Middle1.v";
connectAttr "jnt_R_Middle1_translateX.o" "jnt_R_Middle1.tx";
connectAttr "jnt_R_Middle1_translateY.o" "jnt_R_Middle1.ty";
connectAttr "jnt_R_Middle1_translateZ.o" "jnt_R_Middle1.tz";
connectAttr "jnt_R_Middle1.s" "jnt_R_Middle2.is";
connectAttr "jnt_R_Middle2_rotateZ.o" "jnt_R_Middle2.rz";
connectAttr "jnt_R_Middle2_rotateX.o" "jnt_R_Middle2.rx";
connectAttr "jnt_R_Middle2_rotateY.o" "jnt_R_Middle2.ry";
connectAttr "jnt_R_Middle2_scaleX.o" "jnt_R_Middle2.sx";
connectAttr "jnt_R_Middle2_scaleY.o" "jnt_R_Middle2.sy";
connectAttr "jnt_R_Middle2_scaleZ.o" "jnt_R_Middle2.sz";
connectAttr "jnt_R_Middle2_visibility.o" "jnt_R_Middle2.v";
connectAttr "jnt_R_Middle2_translateX.o" "jnt_R_Middle2.tx";
connectAttr "jnt_R_Middle2_translateY.o" "jnt_R_Middle2.ty";
connectAttr "jnt_R_Middle2_translateZ.o" "jnt_R_Middle2.tz";
connectAttr "jnt_R_Middle2.s" "jnt_R_Middle3.is";
connectAttr "jnt_R_Middle3_rotateZ.o" "jnt_R_Middle3.rz";
connectAttr "jnt_R_Middle3_rotateX.o" "jnt_R_Middle3.rx";
connectAttr "jnt_R_Middle3_rotateY.o" "jnt_R_Middle3.ry";
connectAttr "jnt_R_Middle3_scaleX.o" "jnt_R_Middle3.sx";
connectAttr "jnt_R_Middle3_scaleY.o" "jnt_R_Middle3.sy";
connectAttr "jnt_R_Middle3_scaleZ.o" "jnt_R_Middle3.sz";
connectAttr "jnt_R_Middle3_visibility.o" "jnt_R_Middle3.v";
connectAttr "jnt_R_Middle3_translateX.o" "jnt_R_Middle3.tx";
connectAttr "jnt_R_Middle3_translateY.o" "jnt_R_Middle3.ty";
connectAttr "jnt_R_Middle3_translateZ.o" "jnt_R_Middle3.tz";
connectAttr "jnt_R_Middle3.s" "jnt_R_Middle4.is";
connectAttr "jnt_R_Middle4_rotateZ.o" "jnt_R_Middle4.rz";
connectAttr "jnt_R_Middle4_rotateX.o" "jnt_R_Middle4.rx";
connectAttr "jnt_R_Middle4_rotateY.o" "jnt_R_Middle4.ry";
connectAttr "jnt_R_Middle4_visibility.o" "jnt_R_Middle4.v";
connectAttr "jnt_R_Middle4_translateX.o" "jnt_R_Middle4.tx";
connectAttr "jnt_R_Middle4_translateY.o" "jnt_R_Middle4.ty";
connectAttr "jnt_R_Middle4_translateZ.o" "jnt_R_Middle4.tz";
connectAttr "jnt_R_Middle4_scaleX.o" "jnt_R_Middle4.sx";
connectAttr "jnt_R_Middle4_scaleY.o" "jnt_R_Middle4.sy";
connectAttr "jnt_R_Middle4_scaleZ.o" "jnt_R_Middle4.sz";
connectAttr "jnt_R_Wrist.s" "jnt_R_Ring1.is";
connectAttr "jnt_R_Ring1_rotateZ.o" "jnt_R_Ring1.rz";
connectAttr "jnt_R_Ring1_rotateX.o" "jnt_R_Ring1.rx";
connectAttr "jnt_R_Ring1_rotateY.o" "jnt_R_Ring1.ry";
connectAttr "jnt_R_Ring1_scaleX.o" "jnt_R_Ring1.sx";
connectAttr "jnt_R_Ring1_scaleY.o" "jnt_R_Ring1.sy";
connectAttr "jnt_R_Ring1_scaleZ.o" "jnt_R_Ring1.sz";
connectAttr "jnt_R_Ring1_visibility.o" "jnt_R_Ring1.v";
connectAttr "jnt_R_Ring1_translateX.o" "jnt_R_Ring1.tx";
connectAttr "jnt_R_Ring1_translateY.o" "jnt_R_Ring1.ty";
connectAttr "jnt_R_Ring1_translateZ.o" "jnt_R_Ring1.tz";
connectAttr "jnt_R_Ring1.s" "jnt_R_Ring2.is";
connectAttr "jnt_R_Ring2_rotateZ.o" "jnt_R_Ring2.rz";
connectAttr "jnt_R_Ring2_rotateX.o" "jnt_R_Ring2.rx";
connectAttr "jnt_R_Ring2_rotateY.o" "jnt_R_Ring2.ry";
connectAttr "jnt_R_Ring2_scaleX.o" "jnt_R_Ring2.sx";
connectAttr "jnt_R_Ring2_scaleY.o" "jnt_R_Ring2.sy";
connectAttr "jnt_R_Ring2_scaleZ.o" "jnt_R_Ring2.sz";
connectAttr "jnt_R_Ring2_visibility.o" "jnt_R_Ring2.v";
connectAttr "jnt_R_Ring2_translateX.o" "jnt_R_Ring2.tx";
connectAttr "jnt_R_Ring2_translateY.o" "jnt_R_Ring2.ty";
connectAttr "jnt_R_Ring2_translateZ.o" "jnt_R_Ring2.tz";
connectAttr "jnt_R_Ring2.s" "jnt_R_Ring3.is";
connectAttr "jnt_R_Ring3_rotateZ.o" "jnt_R_Ring3.rz";
connectAttr "jnt_R_Ring3_rotateX.o" "jnt_R_Ring3.rx";
connectAttr "jnt_R_Ring3_rotateY.o" "jnt_R_Ring3.ry";
connectAttr "jnt_R_Ring3_scaleX.o" "jnt_R_Ring3.sx";
connectAttr "jnt_R_Ring3_scaleY.o" "jnt_R_Ring3.sy";
connectAttr "jnt_R_Ring3_scaleZ.o" "jnt_R_Ring3.sz";
connectAttr "jnt_R_Ring3_visibility.o" "jnt_R_Ring3.v";
connectAttr "jnt_R_Ring3_translateX.o" "jnt_R_Ring3.tx";
connectAttr "jnt_R_Ring3_translateY.o" "jnt_R_Ring3.ty";
connectAttr "jnt_R_Ring3_translateZ.o" "jnt_R_Ring3.tz";
connectAttr "jnt_R_Ring3.s" "jnt_R_Ring4.is";
connectAttr "jnt_R_Ring4_rotateZ.o" "jnt_R_Ring4.rz";
connectAttr "jnt_R_Ring4_rotateX.o" "jnt_R_Ring4.rx";
connectAttr "jnt_R_Ring4_rotateY.o" "jnt_R_Ring4.ry";
connectAttr "jnt_R_Ring4_visibility.o" "jnt_R_Ring4.v";
connectAttr "jnt_R_Ring4_translateX.o" "jnt_R_Ring4.tx";
connectAttr "jnt_R_Ring4_translateY.o" "jnt_R_Ring4.ty";
connectAttr "jnt_R_Ring4_translateZ.o" "jnt_R_Ring4.tz";
connectAttr "jnt_R_Ring4_scaleX.o" "jnt_R_Ring4.sx";
connectAttr "jnt_R_Ring4_scaleY.o" "jnt_R_Ring4.sy";
connectAttr "jnt_R_Ring4_scaleZ.o" "jnt_R_Ring4.sz";
connectAttr "jnt_R_Wrist.s" "jnt_R_Pinky1.is";
connectAttr "jnt_R_Pinky1_rotateZ.o" "jnt_R_Pinky1.rz";
connectAttr "jnt_R_Pinky1_rotateX.o" "jnt_R_Pinky1.rx";
connectAttr "jnt_R_Pinky1_rotateY.o" "jnt_R_Pinky1.ry";
connectAttr "jnt_R_Pinky1_scaleX.o" "jnt_R_Pinky1.sx";
connectAttr "jnt_R_Pinky1_scaleY.o" "jnt_R_Pinky1.sy";
connectAttr "jnt_R_Pinky1_scaleZ.o" "jnt_R_Pinky1.sz";
connectAttr "jnt_R_Pinky1_visibility.o" "jnt_R_Pinky1.v";
connectAttr "jnt_R_Pinky1_translateX.o" "jnt_R_Pinky1.tx";
connectAttr "jnt_R_Pinky1_translateY.o" "jnt_R_Pinky1.ty";
connectAttr "jnt_R_Pinky1_translateZ.o" "jnt_R_Pinky1.tz";
connectAttr "jnt_R_Pinky1.s" "jnt_R_Pinky2.is";
connectAttr "jnt_R_Pinky2_rotateZ.o" "jnt_R_Pinky2.rz";
connectAttr "jnt_R_Pinky2_rotateX.o" "jnt_R_Pinky2.rx";
connectAttr "jnt_R_Pinky2_rotateY.o" "jnt_R_Pinky2.ry";
connectAttr "jnt_R_Pinky2_scaleX.o" "jnt_R_Pinky2.sx";
connectAttr "jnt_R_Pinky2_scaleY.o" "jnt_R_Pinky2.sy";
connectAttr "jnt_R_Pinky2_scaleZ.o" "jnt_R_Pinky2.sz";
connectAttr "jnt_R_Pinky2_visibility.o" "jnt_R_Pinky2.v";
connectAttr "jnt_R_Pinky2_translateX.o" "jnt_R_Pinky2.tx";
connectAttr "jnt_R_Pinky2_translateY.o" "jnt_R_Pinky2.ty";
connectAttr "jnt_R_Pinky2_translateZ.o" "jnt_R_Pinky2.tz";
connectAttr "jnt_R_Pinky2.s" "jnt_R_Pinky3.is";
connectAttr "jnt_R_Pinky3_rotateZ.o" "jnt_R_Pinky3.rz";
connectAttr "jnt_R_Pinky3_rotateX.o" "jnt_R_Pinky3.rx";
connectAttr "jnt_R_Pinky3_rotateY.o" "jnt_R_Pinky3.ry";
connectAttr "jnt_R_Pinky3_scaleX.o" "jnt_R_Pinky3.sx";
connectAttr "jnt_R_Pinky3_scaleY.o" "jnt_R_Pinky3.sy";
connectAttr "jnt_R_Pinky3_scaleZ.o" "jnt_R_Pinky3.sz";
connectAttr "jnt_R_Pinky3_visibility.o" "jnt_R_Pinky3.v";
connectAttr "jnt_R_Pinky3_translateX.o" "jnt_R_Pinky3.tx";
connectAttr "jnt_R_Pinky3_translateY.o" "jnt_R_Pinky3.ty";
connectAttr "jnt_R_Pinky3_translateZ.o" "jnt_R_Pinky3.tz";
connectAttr "jnt_R_Pinky3.s" "jnt_R_Pinky4.is";
connectAttr "jnt_R_Pinky4_rotateZ.o" "jnt_R_Pinky4.rz";
connectAttr "jnt_R_Pinky4_rotateX.o" "jnt_R_Pinky4.rx";
connectAttr "jnt_R_Pinky4_rotateY.o" "jnt_R_Pinky4.ry";
connectAttr "jnt_R_Pinky4_visibility.o" "jnt_R_Pinky4.v";
connectAttr "jnt_R_Pinky4_translateX.o" "jnt_R_Pinky4.tx";
connectAttr "jnt_R_Pinky4_translateY.o" "jnt_R_Pinky4.ty";
connectAttr "jnt_R_Pinky4_translateZ.o" "jnt_R_Pinky4.tz";
connectAttr "jnt_R_Pinky4_scaleX.o" "jnt_R_Pinky4.sx";
connectAttr "jnt_R_Pinky4_scaleY.o" "jnt_R_Pinky4.sy";
connectAttr "jnt_R_Pinky4_scaleZ.o" "jnt_R_Pinky4.sz";
connectAttr "jnt_R_Wrist.ro" "jnt_R_Wrist_orientConstraint1.cro";
connectAttr "jnt_R_Wrist.pim" "jnt_R_Wrist_orientConstraint1.cpim";
connectAttr "jnt_R_Wrist.jo" "jnt_R_Wrist_orientConstraint1.cjo";
connectAttr "jnt_R_Wrist.is" "jnt_R_Wrist_orientConstraint1.is";
connectAttr "ctrl_R_Wrist.r" "jnt_R_Wrist_orientConstraint1.tg[0].tr";
connectAttr "ctrl_R_Wrist.ro" "jnt_R_Wrist_orientConstraint1.tg[0].tro";
connectAttr "ctrl_R_Wrist.pm" "jnt_R_Wrist_orientConstraint1.tg[0].tpm";
connectAttr "jnt_R_Wrist_orientConstraint1.w0" "jnt_R_Wrist_orientConstraint1.tg[0].tw"
		;
connectAttr "jnt_R_Forearm.tx" "effector8.tx";
connectAttr "jnt_R_Forearm.ty" "effector8.ty";
connectAttr "jnt_R_Forearm.tz" "effector8.tz";
connectAttr "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase.tx" "effector9.tx"
		;
connectAttr "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase.ty" "effector9.ty"
		;
connectAttr "|grp_Root|jnt_Root|jnt_Hip|jnt_Spine1|jnt_Spine2|jnt_Spine3|jnt_NeckBase.tz" "effector9.tz"
		;
connectAttr "jnt_L_Hip_translateX.o" "jnt_L_Hip.tx";
connectAttr "jnt_L_Hip_translateY.o" "jnt_L_Hip.ty";
connectAttr "jnt_L_Hip_translateZ.o" "jnt_L_Hip.tz";
connectAttr "jnt_Hip.s" "jnt_L_Hip.is";
connectAttr "jnt_L_Hip_scaleX.o" "jnt_L_Hip.sx";
connectAttr "jnt_L_Hip_scaleY.o" "jnt_L_Hip.sy";
connectAttr "jnt_L_Hip_scaleZ.o" "jnt_L_Hip.sz";
connectAttr "jnt_L_Hip_rotateX.o" "jnt_L_Hip.rx";
connectAttr "jnt_L_Hip_rotateY.o" "jnt_L_Hip.ry";
connectAttr "jnt_L_Hip_rotateZ.o" "jnt_L_Hip.rz";
connectAttr "jnt_L_Hip_visibility.o" "jnt_L_Hip.v";
connectAttr "jnt_L_Hip.s" "jnt_L_Knee.is";
connectAttr "jnt_L_Knee_scaleX.o" "jnt_L_Knee.sx";
connectAttr "jnt_L_Knee_scaleY.o" "jnt_L_Knee.sy";
connectAttr "jnt_L_Knee_scaleZ.o" "jnt_L_Knee.sz";
connectAttr "jnt_L_Knee_rotateX.o" "jnt_L_Knee.rx";
connectAttr "jnt_L_Knee_rotateY.o" "jnt_L_Knee.ry";
connectAttr "jnt_L_Knee_rotateZ.o" "jnt_L_Knee.rz";
connectAttr "jnt_L_Knee_visibility.o" "jnt_L_Knee.v";
connectAttr "jnt_L_Knee_translateX.o" "jnt_L_Knee.tx";
connectAttr "jnt_L_Knee_translateY.o" "jnt_L_Knee.ty";
connectAttr "jnt_L_Knee_translateZ.o" "jnt_L_Knee.tz";
connectAttr "jnt_L_Knee.s" "jnt_L_Ankle.is";
connectAttr "jnt_L_Ankle_scaleX.o" "jnt_L_Ankle.sx";
connectAttr "jnt_L_Ankle_scaleY.o" "jnt_L_Ankle.sy";
connectAttr "jnt_L_Ankle_scaleZ.o" "jnt_L_Ankle.sz";
connectAttr "jnt_L_Ankle_translateX.o" "jnt_L_Ankle.tx";
connectAttr "jnt_L_Ankle_translateY.o" "jnt_L_Ankle.ty";
connectAttr "jnt_L_Ankle_translateZ.o" "jnt_L_Ankle.tz";
connectAttr "jnt_L_Ankle_rotateX.o" "jnt_L_Ankle.rx";
connectAttr "jnt_L_Ankle_rotateY.o" "jnt_L_Ankle.ry";
connectAttr "jnt_L_Ankle_rotateZ.o" "jnt_L_Ankle.rz";
connectAttr "jnt_L_Ankle_visibility.o" "jnt_L_Ankle.v";
connectAttr "jnt_L_Ankle.s" "jnt_L_Ball.is";
connectAttr "jnt_L_Ball_scaleX.o" "jnt_L_Ball.sx";
connectAttr "jnt_L_Ball_scaleY.o" "jnt_L_Ball.sy";
connectAttr "jnt_L_Ball_scaleZ.o" "jnt_L_Ball.sz";
connectAttr "jnt_L_Ball_translateX.o" "jnt_L_Ball.tx";
connectAttr "jnt_L_Ball_translateY.o" "jnt_L_Ball.ty";
connectAttr "jnt_L_Ball_translateZ.o" "jnt_L_Ball.tz";
connectAttr "jnt_L_Ball_rotateX.o" "jnt_L_Ball.rx";
connectAttr "jnt_L_Ball_rotateY.o" "jnt_L_Ball.ry";
connectAttr "jnt_L_Ball_rotateZ.o" "jnt_L_Ball.rz";
connectAttr "jnt_L_Ball_visibility.o" "jnt_L_Ball.v";
connectAttr "jnt_L_Ball.s" "jnt_L_Toe.is";
connectAttr "jnt_L_Toe_translateX.o" "jnt_L_Toe.tx";
connectAttr "jnt_L_Toe_translateY.o" "jnt_L_Toe.ty";
connectAttr "jnt_L_Toe_translateZ.o" "jnt_L_Toe.tz";
connectAttr "jnt_L_Toe_visibility.o" "jnt_L_Toe.v";
connectAttr "jnt_L_Toe_rotateX.o" "jnt_L_Toe.rx";
connectAttr "jnt_L_Toe_rotateY.o" "jnt_L_Toe.ry";
connectAttr "jnt_L_Toe_rotateZ.o" "jnt_L_Toe.rz";
connectAttr "jnt_L_Toe_scaleX.o" "jnt_L_Toe.sx";
connectAttr "jnt_L_Toe_scaleY.o" "jnt_L_Toe.sy";
connectAttr "jnt_L_Toe_scaleZ.o" "jnt_L_Toe.sz";
connectAttr "jnt_L_Toe.tx" "effector3.tx";
connectAttr "jnt_L_Toe.ty" "effector3.ty";
connectAttr "jnt_L_Toe.tz" "effector3.tz";
connectAttr "jnt_L_Ball.tx" "effector2.tx";
connectAttr "jnt_L_Ball.ty" "effector2.ty";
connectAttr "jnt_L_Ball.tz" "effector2.tz";
connectAttr "jnt_L_Ankle.tx" "effector1.tx";
connectAttr "jnt_L_Ankle.ty" "effector1.ty";
connectAttr "jnt_L_Ankle.tz" "effector1.tz";
connectAttr "jnt_R_Hip_translateX.o" "jnt_R_Hip.tx";
connectAttr "jnt_R_Hip_translateY.o" "jnt_R_Hip.ty";
connectAttr "jnt_R_Hip_translateZ.o" "jnt_R_Hip.tz";
connectAttr "jnt_Hip.s" "jnt_R_Hip.is";
connectAttr "jnt_R_Hip_scaleX.o" "jnt_R_Hip.sx";
connectAttr "jnt_R_Hip_scaleY.o" "jnt_R_Hip.sy";
connectAttr "jnt_R_Hip_scaleZ.o" "jnt_R_Hip.sz";
connectAttr "jnt_R_Hip_rotateX.o" "jnt_R_Hip.rx";
connectAttr "jnt_R_Hip_rotateY.o" "jnt_R_Hip.ry";
connectAttr "jnt_R_Hip_rotateZ.o" "jnt_R_Hip.rz";
connectAttr "jnt_R_Hip_visibility.o" "jnt_R_Hip.v";
connectAttr "jnt_R_Hip.s" "jnt_R_Knee.is";
connectAttr "jnt_R_Knee_scaleX.o" "jnt_R_Knee.sx";
connectAttr "jnt_R_Knee_scaleY.o" "jnt_R_Knee.sy";
connectAttr "jnt_R_Knee_scaleZ.o" "jnt_R_Knee.sz";
connectAttr "jnt_R_Knee_rotateX.o" "jnt_R_Knee.rx";
connectAttr "jnt_R_Knee_rotateY.o" "jnt_R_Knee.ry";
connectAttr "jnt_R_Knee_rotateZ.o" "jnt_R_Knee.rz";
connectAttr "jnt_R_Knee_visibility.o" "jnt_R_Knee.v";
connectAttr "jnt_R_Knee_translateX.o" "jnt_R_Knee.tx";
connectAttr "jnt_R_Knee_translateY.o" "jnt_R_Knee.ty";
connectAttr "jnt_R_Knee_translateZ.o" "jnt_R_Knee.tz";
connectAttr "jnt_R_Knee.s" "jnt_R_Ankle.is";
connectAttr "jnt_R_Ankle_scaleX.o" "jnt_R_Ankle.sx";
connectAttr "jnt_R_Ankle_scaleY.o" "jnt_R_Ankle.sy";
connectAttr "jnt_R_Ankle_scaleZ.o" "jnt_R_Ankle.sz";
connectAttr "jnt_R_Ankle_rotateX.o" "jnt_R_Ankle.rx";
connectAttr "jnt_R_Ankle_rotateY.o" "jnt_R_Ankle.ry";
connectAttr "jnt_R_Ankle_rotateZ.o" "jnt_R_Ankle.rz";
connectAttr "jnt_R_Ankle_visibility.o" "jnt_R_Ankle.v";
connectAttr "jnt_R_Ankle_translateX.o" "jnt_R_Ankle.tx";
connectAttr "jnt_R_Ankle_translateY.o" "jnt_R_Ankle.ty";
connectAttr "jnt_R_Ankle_translateZ.o" "jnt_R_Ankle.tz";
connectAttr "jnt_R_Ankle.s" "jnt_R_Ball.is";
connectAttr "jnt_R_Ball_scaleX.o" "jnt_R_Ball.sx";
connectAttr "jnt_R_Ball_scaleY.o" "jnt_R_Ball.sy";
connectAttr "jnt_R_Ball_scaleZ.o" "jnt_R_Ball.sz";
connectAttr "jnt_R_Ball_rotateX.o" "jnt_R_Ball.rx";
connectAttr "jnt_R_Ball_rotateY.o" "jnt_R_Ball.ry";
connectAttr "jnt_R_Ball_rotateZ.o" "jnt_R_Ball.rz";
connectAttr "jnt_R_Ball_visibility.o" "jnt_R_Ball.v";
connectAttr "jnt_R_Ball_translateX.o" "jnt_R_Ball.tx";
connectAttr "jnt_R_Ball_translateY.o" "jnt_R_Ball.ty";
connectAttr "jnt_R_Ball_translateZ.o" "jnt_R_Ball.tz";
connectAttr "jnt_R_Ball.s" "jnt_R_Toe.is";
connectAttr "jnt_R_Toe_visibility.o" "jnt_R_Toe.v";
connectAttr "jnt_R_Toe_translateX.o" "jnt_R_Toe.tx";
connectAttr "jnt_R_Toe_translateY.o" "jnt_R_Toe.ty";
connectAttr "jnt_R_Toe_translateZ.o" "jnt_R_Toe.tz";
connectAttr "jnt_R_Toe_rotateX.o" "jnt_R_Toe.rx";
connectAttr "jnt_R_Toe_rotateY.o" "jnt_R_Toe.ry";
connectAttr "jnt_R_Toe_rotateZ.o" "jnt_R_Toe.rz";
connectAttr "jnt_R_Toe_scaleX.o" "jnt_R_Toe.sx";
connectAttr "jnt_R_Toe_scaleY.o" "jnt_R_Toe.sy";
connectAttr "jnt_R_Toe_scaleZ.o" "jnt_R_Toe.sz";
connectAttr "clusterHipsCluster.og[0]" "curve_SpineShape.cr";
connectAttr "tweak1.pl[0].cp[0]" "curve_SpineShape.twl";
connectAttr "cluster1GroupId.id" "curve_SpineShape.iog.og[0].gid";
connectAttr "cluster1Set.mwc" "curve_SpineShape.iog.og[0].gco";
connectAttr "groupId2.id" "curve_SpineShape.iog.og[1].gid";
connectAttr "tweakSet1.mwc" "curve_SpineShape.iog.og[1].gco";
connectAttr "cluster2GroupId.id" "curve_SpineShape.iog.og[2].gid";
connectAttr "cluster2Set.mwc" "curve_SpineShape.iog.og[2].gco";
connectAttr "cluster3GroupId.id" "curve_SpineShape.iog.og[3].gid";
connectAttr "cluster3Set.mwc" "curve_SpineShape.iog.og[3].gco";
connectAttr "cluster4GroupId.id" "curve_SpineShape.iog.og[4].gid";
connectAttr "cluster4Set.mwc" "curve_SpineShape.iog.og[4].gco";
connectAttr "hiddenCtrls.di" "grp_SpineClutser.do";
connectAttr "clusterHips_pointConstraint1.ctx" "clusterHips.tx";
connectAttr "clusterHips_pointConstraint1.cty" "clusterHips.ty";
connectAttr "clusterHips_pointConstraint1.ctz" "clusterHips.tz";
connectAttr "clusterHips.pim" "clusterHips_pointConstraint1.cpim";
connectAttr "clusterHips.rp" "clusterHips_pointConstraint1.crp";
connectAttr "clusterHips.rpt" "clusterHips_pointConstraint1.crt";
connectAttr "ctrl_HipSway.t" "clusterHips_pointConstraint1.tg[0].tt";
connectAttr "ctrl_HipSway.rp" "clusterHips_pointConstraint1.tg[0].trp";
connectAttr "ctrl_HipSway.rpt" "clusterHips_pointConstraint1.tg[0].trt";
connectAttr "ctrl_HipSway.pm" "clusterHips_pointConstraint1.tg[0].tpm";
connectAttr "clusterHips_pointConstraint1.w0" "clusterHips_pointConstraint1.tg[0].tw"
		;
connectAttr "clusterChest_pointConstraint1.ctx" "clusterChest.tx";
connectAttr "clusterChest_pointConstraint1.cty" "clusterChest.ty";
connectAttr "clusterChest_pointConstraint1.ctz" "clusterChest.tz";
connectAttr "clusterChest.pim" "clusterChest_pointConstraint1.cpim";
connectAttr "clusterChest.rp" "clusterChest_pointConstraint1.crp";
connectAttr "clusterChest.rpt" "clusterChest_pointConstraint1.crt";
connectAttr "ctrl_Chest.t" "clusterChest_pointConstraint1.tg[0].tt";
connectAttr "ctrl_Chest.rp" "clusterChest_pointConstraint1.tg[0].trp";
connectAttr "ctrl_Chest.rpt" "clusterChest_pointConstraint1.tg[0].trt";
connectAttr "ctrl_Chest.pm" "clusterChest_pointConstraint1.tg[0].tpm";
connectAttr "clusterChest_pointConstraint1.w0" "clusterChest_pointConstraint1.tg[0].tw"
		;
connectAttr "clusterNeckbase_pointConstraint1.ctx" "clusterNeckbase.tx";
connectAttr "clusterNeckbase_pointConstraint1.cty" "clusterNeckbase.ty";
connectAttr "clusterNeckbase_pointConstraint1.ctz" "clusterNeckbase.tz";
connectAttr "clusterNeckbase.pim" "clusterNeckbase_pointConstraint1.cpim";
connectAttr "clusterNeckbase.rp" "clusterNeckbase_pointConstraint1.crp";
connectAttr "clusterNeckbase.rpt" "clusterNeckbase_pointConstraint1.crt";
connectAttr "ctrl_Back.t" "clusterNeckbase_pointConstraint1.tg[0].tt";
connectAttr "ctrl_Back.rp" "clusterNeckbase_pointConstraint1.tg[0].trp";
connectAttr "ctrl_Back.rpt" "clusterNeckbase_pointConstraint1.tg[0].trt";
connectAttr "ctrl_Back.pm" "clusterNeckbase_pointConstraint1.tg[0].tpm";
connectAttr "clusterNeckbase_pointConstraint1.w0" "clusterNeckbase_pointConstraint1.tg[0].tw"
		;
connectAttr "jnt_Root.ro" "jnt_Root_parentConstraint1.cro";
connectAttr "jnt_Root.pim" "jnt_Root_parentConstraint1.cpim";
connectAttr "jnt_Root.rp" "jnt_Root_parentConstraint1.crp";
connectAttr "jnt_Root.rpt" "jnt_Root_parentConstraint1.crt";
connectAttr "jnt_Root.jo" "jnt_Root_parentConstraint1.cjo";
connectAttr "ctrl_Hips.t" "jnt_Root_parentConstraint1.tg[0].tt";
connectAttr "ctrl_Hips.rp" "jnt_Root_parentConstraint1.tg[0].trp";
connectAttr "ctrl_Hips.rpt" "jnt_Root_parentConstraint1.tg[0].trt";
connectAttr "ctrl_Hips.r" "jnt_Root_parentConstraint1.tg[0].tr";
connectAttr "ctrl_Hips.ro" "jnt_Root_parentConstraint1.tg[0].tro";
connectAttr "ctrl_Hips.s" "jnt_Root_parentConstraint1.tg[0].ts";
connectAttr "ctrl_Hips.pm" "jnt_Root_parentConstraint1.tg[0].tpm";
connectAttr "jnt_Root_parentConstraint1.w0" "jnt_Root_parentConstraint1.tg[0].tw"
		;
connectAttr "grp_Root.pim" "grp_Root_scaleConstraint1.cpim";
connectAttr "ctrl_Global.s" "grp_Root_scaleConstraint1.tg[0].ts";
connectAttr "ctrl_Global.pm" "grp_Root_scaleConstraint1.tg[0].tpm";
connectAttr "grp_Root_scaleConstraint1.w0" "grp_Root_scaleConstraint1.tg[0].tw";
connectAttr "layerManager.dli[3]" "SkeletonLayer.id";
connectAttr "layerManager.dli[10]" "bodyControls.id";
connectAttr "layerManager.dli[1]" "leftControls.id";
connectAttr "layerManager.dli[2]" "rightControls.id";
connectAttr "unitConversion15.o" "pairBlend1.irx2";
connectAttr "ctrl_R_Wrist.blendUnitConversion15" "pairBlend1.w";
connectAttr "pairBlend1_inRotateX1.o" "pairBlend1.irx1";
connectAttr "expression2.out[0]" "unitConversion15.i";
connectAttr ":time1.o" "expression2.tim";
connectAttr "ctrl_R_Wrist.msg" "expression2.obm";
connectAttr "cluster4GroupParts.og" "clusterHipsCluster.ip[0].ig";
connectAttr "cluster4GroupId.id" "clusterHipsCluster.ip[0].gi";
connectAttr "clusterHips.wm" "clusterHipsCluster.ma";
connectAttr "clusterHipsShape.x" "clusterHipsCluster.x";
connectAttr "cluster4GroupId.msg" "cluster4Set.gn" -na;
connectAttr "curve_SpineShape.iog.og[4]" "cluster4Set.dsm" -na;
connectAttr "clusterHipsCluster.msg" "cluster4Set.ub[0]";
connectAttr "clusterAbsCluster.og[0]" "cluster4GroupParts.ig";
connectAttr "cluster4GroupId.id" "cluster4GroupParts.gi";
connectAttr "cluster3GroupParts.og" "clusterAbsCluster.ip[0].ig";
connectAttr "cluster3GroupId.id" "clusterAbsCluster.ip[0].gi";
connectAttr "clusterAbs.wm" "clusterAbsCluster.ma";
connectAttr "clusterAbsShape.x" "clusterAbsCluster.x";
connectAttr "cluster3GroupId.msg" "cluster3Set.gn" -na;
connectAttr "curve_SpineShape.iog.og[3]" "cluster3Set.dsm" -na;
connectAttr "clusterAbsCluster.msg" "cluster3Set.ub[0]";
connectAttr "clusterChestCluster.og[0]" "cluster3GroupParts.ig";
connectAttr "cluster3GroupId.id" "cluster3GroupParts.gi";
connectAttr "cluster2GroupParts.og" "clusterChestCluster.ip[0].ig";
connectAttr "cluster2GroupId.id" "clusterChestCluster.ip[0].gi";
connectAttr "clusterChest.wm" "clusterChestCluster.ma";
connectAttr "clusterChestShape.x" "clusterChestCluster.x";
connectAttr "cluster2GroupId.msg" "cluster2Set.gn" -na;
connectAttr "curve_SpineShape.iog.og[2]" "cluster2Set.dsm" -na;
connectAttr "clusterChestCluster.msg" "cluster2Set.ub[0]";
connectAttr "clusterNeckbaseCluster.og[0]" "cluster2GroupParts.ig";
connectAttr "cluster2GroupId.id" "cluster2GroupParts.gi";
connectAttr "cluster1GroupParts.og" "clusterNeckbaseCluster.ip[0].ig";
connectAttr "cluster1GroupId.id" "clusterNeckbaseCluster.ip[0].gi";
connectAttr "clusterNeckbase.wm" "clusterNeckbaseCluster.ma";
connectAttr "clusterNeckbaseShape.x" "clusterNeckbaseCluster.x";
connectAttr "cluster1GroupId.msg" "cluster1Set.gn" -na;
connectAttr "curve_SpineShape.iog.og[0]" "cluster1Set.dsm" -na;
connectAttr "clusterNeckbaseCluster.msg" "cluster1Set.ub[0]";
connectAttr "tweak1.og[0]" "cluster1GroupParts.ig";
connectAttr "cluster1GroupId.id" "cluster1GroupParts.gi";
connectAttr "groupParts2.og" "tweak1.ip[0].ig";
connectAttr "groupId2.id" "tweak1.ip[0].gi";
connectAttr "groupId2.msg" "tweakSet1.gn" -na;
connectAttr "curve_SpineShape.iog.og[1]" "tweakSet1.dsm" -na;
connectAttr "tweak1.msg" "tweakSet1.ub[0]";
connectAttr "curve_SpineShapeOrig.ws" "groupParts2.ig";
connectAttr "groupId2.id" "groupParts2.gi";
connectAttr "layerManager.dli[11]" "hiddenCtrls.id";
// End of FolkTest@WalkAnimation.ma
