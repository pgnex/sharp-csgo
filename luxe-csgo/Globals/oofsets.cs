using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace luxe_csgo.Globals {

    public static class oofsets {
        public static string data = string.Empty; 

        public static void setoofsets() {
            WebClient web = new WebClient();
            data = web.DownloadString("https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.cs");
            // incase we ever post on uc and web requests arent allowed
            // data = File.ReadAllText("csgo.cs");
            setoofset("m_ArmorValue", ref netvars.m_ArmorValue);
            setoofset("m_Collision", ref netvars.m_Collision);
            setoofset("m_CollisionGroup", ref netvars.m_CollisionGroup);
            setoofset("m_Local", ref netvars.m_Local);
            setoofset("m_MoveType", ref netvars.m_MoveType);
            setoofset("m_OriginalOwnerXuidHigh", ref netvars.m_OriginalOwnerXuidHigh);
            setoofset("m_OriginalOwnerXuidLow", ref netvars.m_OriginalOwnerXuidLow);
            setoofset("m_aimPunchAngle", ref netvars.m_aimPunchAngle);
            setoofset("m_aimPunchAngleVel", ref netvars.m_aimPunchAngleVel);
            setoofset("m_bGunGameImmunity", ref netvars.m_bGunGameImmunity);
            setoofset("m_bHasDefuser", ref netvars.m_bHasDefuser);
            setoofset("m_bHasHelmet", ref netvars.m_bHasHelmet);
            setoofset("m_bInReload", ref netvars.m_bInReload);
            setoofset("m_bIsDefusing", ref netvars.m_bIsDefusing);
            setoofset("m_bIsScoped", ref netvars.m_bIsScoped);
            setoofset("m_bSpotted", ref netvars.m_bSpotted);
            setoofset("m_bSpottedByMask", ref netvars.m_bSpottedByMask);
            setoofset("m_dwBoneMatrix", ref netvars.m_dwBoneMatrix);
            setoofset("m_fAccuracyPenalty", ref netvars.m_fAccuracyPenalty);
            setoofset("m_fFlags", ref netvars.m_fFlags);
            setoofset("m_flFallbackWear", ref netvars.m_flFallbackWear);
            setoofset("m_flFlashDuration", ref netvars.m_flFlashDuration);
            setoofset("m_flFlashMaxAlpha", ref netvars.m_flFlashMaxAlpha);
            setoofset("m_flNextPrimaryAttack", ref netvars.m_flNextPrimaryAttack);
            setoofset("m_hActiveWeapon", ref netvars.m_hActiveWeapon);
            setoofset("m_hMyWeapons", ref netvars.m_hMyWeapons);
            setoofset("m_hObserverTarget", ref netvars.m_hObserverTarget);
            setoofset("m_hOwner", ref netvars.m_hOwner);
            setoofset("m_hOwnerEntity", ref netvars.m_hOwnerEntity);
            setoofset("m_iAccountID", ref netvars.m_iAccountID);
            setoofset("m_iClip1", ref netvars.m_iClip1);
            setoofset("m_iCompetitiveRanking", ref netvars.m_iCompetitiveRanking);
            setoofset("m_iCompetitiveWins", ref netvars.m_iCompetitiveWins);
            setoofset("m_iCrosshairId", ref netvars.m_iCrosshairId);
            setoofset("m_iEntityQuality", ref netvars.m_iEntityQuality);
            setoofset("m_iFOVStart", ref netvars.m_iFOVStart);
            setoofset("m_iGlowIndex", ref netvars.m_iGlowIndex);
            setoofset("m_iHealth", ref netvars.m_iHealth);
            setoofset("m_iItemDefinitionIndex", ref netvars.m_iItemDefinitionIndex);
            setoofset("m_iItemIDHigh", ref netvars.m_iItemIDHigh);
            setoofset("m_iObserverMode", ref netvars.m_iObserverMode);
            setoofset("m_iShotsFired", ref netvars.m_iShotsFired);
            setoofset("m_iState", ref netvars.m_iState);
            setoofset("m_iTeamNum", ref netvars.m_iTeamNum);
            setoofset("m_lifeState", ref netvars.m_lifeState);
            setoofset("m_nFallbackPaintKit", ref netvars.m_nFallbackPaintKit);
            setoofset("m_nFallbackSeed", ref netvars.m_nFallbackSeed);
            setoofset("m_nFallbackStatTrak", ref netvars.m_nFallbackStatTrak);
            setoofset("m_nForceBone", ref netvars.m_nForceBone);
            setoofset("m_nTickBase", ref netvars.m_nTickBase);
            setoofset("m_rgflCoordinateFrame", ref netvars.m_rgflCoordinateFrame);
            setoofset("m_szCustomName", ref netvars.m_szCustomName);
            setoofset("m_szLastPlaceName", ref netvars.m_szLastPlaceName);
            setoofset("m_vecOrigin", ref netvars.m_vecOrigin);
            setoofset("m_vecVelocity", ref netvars.m_vecVelocity);
            setoofset("m_vecViewOffset", ref netvars.m_vecViewOffset);
            setoofset("m_viewPunchAngle", ref netvars.m_viewPunchAngle);
            setoofset("dwClientState", ref signatures.dwClientState);
            setoofset("dwClientState_GetLocalPlayer", ref signatures.dwClientState_GetLocalPlayer);
            setoofset("dwClientState_Map", ref signatures.dwClientState_Map);
            setoofset("dwClientState_MapDirectory", ref signatures.dwClientState_MapDirectory);
            setoofset("dwClientState_MaxPlayer", ref signatures.dwClientState_MaxPlayer);
            setoofset("dwClientState_PlayerInfo", ref signatures.dwClientState_PlayerInfo);
            setoofset("dwClientState_State", ref signatures.dwClientState_State);
            setoofset("dwClientState_ViewAngles", ref signatures.dwClientState_ViewAngles);
            setoofset("dwClientState_IsHLTV", ref signatures.dwClientState_IsHLTV);
            setoofset("dwEntityList", ref signatures.dwEntityList);
            setoofset("dwForceAttack", ref signatures.dwForceAttack);
            setoofset("dwForceAttack2", ref signatures.dwForceAttack2);
            setoofset("dwForceBackward", ref signatures.dwForceBackward);
            setoofset("dwForceForward", ref signatures.dwForceForward);
            setoofset("dwForceJump", ref signatures.dwForceJump);
            setoofset("dwForceLeft", ref signatures.dwForceLeft);
            setoofset("dwForceRight", ref signatures.dwForceRight);
            setoofset("dwGameDir", ref signatures.dwGameDir);
            setoofset("dwGameRulesProxy", ref signatures.dwGameRulesProxy);
            setoofset("dwGetAllClasses", ref signatures.dwGetAllClasses);
            setoofset("dwGlobalVars", ref signatures.dwGlobalVars);
            setoofset("dwGlowObjectManager", ref signatures.dwGlowObjectManager);
            setoofset("dwInput", ref signatures.dwInput);
            setoofset("dwInterfaceLinkList", ref signatures.dwInterfaceLinkList);
            setoofset("dwLocalPlayer", ref signatures.dwLocalPlayer);
            setoofset("dwMouseEnable", ref signatures.dwMouseEnable);
            setoofset("dwMouseEnablePtr", ref signatures.dwMouseEnablePtr);
            setoofset("dwPlayerResource", ref signatures.dwPlayerResource);
            setoofset("dwRadarBase", ref signatures.dwRadarBase);
            setoofset("dwSensitivity", ref signatures.dwSensitivity);
            setoofset("dwSensitivityPtr", ref signatures.dwSensitivityPtr);
            setoofset("dwViewMatrix", ref signatures.dwViewMatrix);
            setoofset("dwWeaponTable", ref signatures.dwWeaponTable);
            setoofset("dwWeaponTableIndex", ref signatures.dwWeaponTableIndex);
            setoofset("dwYawPtr", ref signatures.dwYawPtr);
            setoofset("dwZoomSensitivityRatioPtr", ref signatures.dwZoomSensitivityRatioPtr);
            setoofset("dwbSendPackets", ref signatures.dwbSendPackets);
            setoofset("dwppDirect3DDevice9", ref signatures.dwppDirect3DDevice9);
            setoofset("dwSetClanTag", ref signatures.dwSetClanTag);
            setoofset("m_pStudioHdr", ref signatures.m_pStudioHdr);
            // Done setting offsets.
        }

        private static void setoofset(string patternInfo, ref int varName) {
            Regex wegex = new Regex($"public const Int32 {patternInfo} = 0x.*;"); // csgo.cs format from HazeDumper
            Match match = wegex.Match(data);
            if (match.Success) {
                string hexValue = match.Value.Split('=').GetValue(1).ToString().Replace(" ", "").Replace(";", ""); // Gets the offsets hexadecimal value as a string.
                varName = Convert.ToInt32(hexValue, 16);
            } else {
                MessageBox.Show($"Error finding the following offset: {patternInfo}" +
                    $"{System.Environment.NewLine}This will likely prevent the cheat from functioning properly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }



    class basevaluwus {
        public static IntPtr csgoWindow = IntPtr.Zero;
        public static int m_ClientPointer = 0;
        public static int m_EnginePointer = 0;
        public static int m_vecMins = 0x0320;
        public static int m_vecMaxs = 0x032C;
    }

    public static class netvars {
        public static int cs_gamerules_data;
        public static int m_ArmorValue;
        public static int m_Collision;
        public static int m_CollisionGroup;
        public static int m_Local;
        public static int m_MoveType;
        public static int m_OriginalOwnerXuidHigh;
        public static int m_OriginalOwnerXuidLow;
        public static int m_SurvivalGameRuleDecisionTypes;
        public static int m_SurvivalRules;
        public static int m_aimPunchAngle;
        public static int m_aimPunchAngleVel;
        public static int m_bBombPlanted;
        public static int m_bFreezePeriod;
        public static int m_bGunGameImmunity;
        public static int m_bHasDefuser;
        public static int m_bHasHelmet;
        public static int m_bInReload;
        public static int m_bIsDefusing;
        public static int m_bIsQueuedMatchmaking;
        public static int m_bIsScoped;
        public static int m_bIsValveDS;
        public static int m_bSpotted;
        public static int m_bSpottedByMask;
        public static int m_clrRender;
        public static int m_dwBoneMatrix;
        public static int m_fAccuracyPenalty;
        public static int m_fFlags;
        public static int m_flC4Blow;
        public static int m_flDefuseCountDown;
        public static int m_flDefuseLength;
        public static int m_flFallbackWear;
        public static int m_flFlashDuration;
        public static int m_flFlashMaxAlpha;
        public static int m_flNextPrimaryAttack;
        public static int m_flTimerLength;
        public static int m_hActiveWeapon;
        public static int m_hMyWeapons;
        public static int m_hObserverTarget;
        public static int m_hOwner;
        public static int m_hOwnerEntity;
        public static int m_iAccountID;
        public static int m_iClip1;
        public static int m_iCompetitiveRanking;
        public static int m_iCompetitiveWins;
        public static int m_iCrosshairId;
        public static int m_iEntityQuality;
        public static int m_iFOV;
        public static int m_iFOVStart;
        public static int m_iGlowIndex;
        public static int m_iHealth;
        public static int m_iItemDefinitionIndex;
        public static int m_iItemIDHigh;
        public static int m_iObserverMode;
        public static int m_iShotsFired;
        public static int m_iState;
        public static int m_iTeamNum;
        public static int m_lifeState;
        public static int m_nFallbackPaintKit;
        public static int m_nFallbackSeed;
        public static int m_nFallbackStatTrak;
        public static int m_nForceBone;
        public static int m_nTickBase;
        public static int m_rgflCoordinateFrame;
        public static int m_szCustomName;
        public static int m_szLastPlaceName;
        public static int m_thirdPersonViewAngles;
        public static int m_vecOrigin;
        public static int m_vecVelocity;
        public static int m_vecViewOffset;
        public static int m_viewPunchAngle;
    }
    public static class signatures {
        public static int clientstate_choked_commands;
        public static int clientstate_delta_ticks;
        public static int clientstate_last_outgoing_command;
        public static int clientstate_net_channel;
        public static int convar_name_hash_table;
        public static int dwClientState;
        public static int dwClientState_GetLocalPlayer;
        public static int dwClientState_IsHLTV;
        public static int dwClientState_Map;
        public static int dwClientState_MapDirectory;
        public static int dwClientState_MaxPlayer;
        public static int dwClientState_PlayerInfo;
        public static int dwClientState_State;
        public static int dwClientState_ViewAngles;
        public static int dwEntityList;
        public static int dwForceAttack;
        public static int dwForceAttack2;
        public static int dwForceBackward;
        public static int dwForceForward;
        public static int dwForceJump;
        public static int dwForceLeft;
        public static int dwForceRight;
        public static int dwGameDir;
        public static int dwGameRulesProxy;
        public static int dwGetAllClasses;
        public static int dwGlobalVars;
        public static int dwGlowObjectManager;
        public static int dwInput;
        public static int dwInterfaceLinkList;
        public static int dwLocalPlayer;
        public static int dwMouseEnable;
        public static int dwMouseEnablePtr;
        public static int dwPlayerResource;
        public static int dwRadarBase;
        public static int dwSensitivity;
        public static int dwSensitivityPtr;
        public static int dwSetClanTag;
        public static int dwViewMatrix;
        public static int dwWeaponTable;
        public static int dwWeaponTableIndex;
        public static int dwYawPtr;
        public static int dwZoomSensitivityRatioPtr;
        public static int dwbSendPackets;
        public static int dwppDirect3DDevice9;
        public static int interface_engine_cvar;
        public static int m_bDormant;
        public static int m_pStudioHdr;
        public static int m_pitchClassPtr;
        public static int m_yawClassPtr;
        public static int model_ambient_min;
    }
}
