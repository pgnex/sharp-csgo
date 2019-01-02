using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luxe_csgo.Globals {


    class basevaluwus {
        public static IntPtr csgoWindow = IntPtr.Zero;
        public static int m_ClientPointer = 0;
        public static int m_EnginePointer = 0;
        public static int m_vecMins = 0x0320;
        public static int m_vecMaxs = 0x032C;
    }

    class Netvars {
        public static int m_ArmorValue;
        public static int m_Collision;
        public static int m_CollisionGroup;
        public static int m_Local;
        public static int m_MoveType;
        public static int m_OriginalOwnerXuidHigh;
        public static int m_OriginalOwnerXuidLow;
        public static int m_aimPunchAngle;
        public static int m_aimPunchAngleVel;
        public static int m_bGunGameImmunity;
        public static int m_bHasDefuser;
        public static int m_bHasHelmet;
        public static int m_bInReload;
        public static int m_bIsDefusing;
        public static int m_bIsScoped;
        public static int m_bSpotted;
        public static int m_bSpottedByMask;
        public static int m_dwBoneMatrix;
        public static int m_fAccuracyPenalty;
        public static int m_fFlags;
        public static int m_flFallbackWear;
        public static int m_flFlashDuration;
        public static int m_flFlashMaxAlpha;
        public static int m_flNextPrimaryAttack;
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
        public static int m_vecOrigin;
        public static int m_vecVelocity;
        public static int m_vecViewOffset;
        public static int m_viewPunchAngle;
    }

    class Signatures {
        public static int dwClientState;
        public static int dwClientState_GetLocalPlayer;
        public static int dwClientState_Map;
        public static int dwClientState_MapDirectory;
        public static int dwClientState_MaxPlayer;
        public static int dwClientState_PlayerInfo;
        public static int dwClientState_State;
        public static int dwClientState_ViewAngles;
        public static int dwClientState_IsHLTV;
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
        public static int dwViewMatrix;
        public static int dwWeaponTable;
        public static int dwWeaponTableIndex;
        public static int dwYawPtr;
        public static int dwZoomSensitivityRatioPtr;
        public static int dwbSendPackets;
        public static int dwppDirect3DDevice9;
        public static int dwSetClanTag;
        public static int m_pStudioHdr;
    }

}
