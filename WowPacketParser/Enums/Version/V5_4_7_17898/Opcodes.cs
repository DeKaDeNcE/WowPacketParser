using WowPacketParser.Misc;

namespace WowPacketParser.Enums.Version.V5_4_7_17898
{
    public static class Opcodes_5_4_7
    {
        public static BiDictionary<Opcode, int> Opcodes()
        {
            return Opcs;
        }

        private static readonly BiDictionary<Opcode, int> Opcs = new BiDictionary<Opcode, int>
        {
            {Opcode.CMSG_ATTACKSTOP,  0x1777},
            {Opcode.CMSG_ATTACKSWING, 0x1513},
            {Opcode.CMSG_AUTH_SESSION, 0x1A51},
            {Opcode.CMSG_CREATURE_QUERY, 0x1E72},
            {Opcode.CMSG_CHAR_CREATE, 0x09B9},
            {Opcode.CMSG_CHAR_DELETE, 0x113B},
            {Opcode.CMSG_CHAR_ENUM, 0x12C2},
            {Opcode.CMSG_CONNECT_TO_FAILED, 0x16C8},
            {Opcode.CMSG_DB_QUERY_BULK, 0x16C2},
            {Opcode.CMSG_GAMEOBJECT_QUERY, 0x14EA},
            {Opcode.CMSG_GOSSIP_HELLO, 0x05F6},
            {Opcode.CMSG_GOSSIP_SELECT_OPTION, 0x02D7},
            {Opcode.CMSG_GUILD_QUERY, 0x1280},
            {Opcode.CMSG_LEARN_TALENT, 0x1F5A},
            {Opcode.CMSG_LOAD_SCREEN, 0x1691},
            {Opcode.CMSG_LOGOUT_CANCEL, 0x11D4},
            {Opcode.CMSG_LOGOUT_REQUEST, 0x0476},
            {Opcode.CMSG_LOG_DISCONNECT, 0x1A13},
            {Opcode.CMSG_MESSAGECHAT_GUILD, 0x070B},
            {Opcode.CMSG_MESSAGECHAT_SAY, 0x0C41},
            {Opcode.CMSG_MESSAGECHAT_WHISPER, 0x0D60},
            {Opcode.CMSG_MESSAGECHAT_YELL, 0x0C43},
            {Opcode.CMSG_NAME_QUERY, 0x0DB3},
            {Opcode.CMSG_NPC_TEXT_QUERY, 0x12FA},
            {Opcode.CMSG_OBJECT_UPDATE_FAILED, 0x0882},
            {Opcode.CMSG_RANDOMIZE_CHAR_NAME, 0x1DB9},
            {Opcode.CMSG_REDIRECT_AUTH_PROOF, 0x1A5B},
            {Opcode.CMSG_RESET_FACTION_CHEAT, 0x1B5A | 0x10000},
            {Opcode.CMSG_SET_PRIMARY_TALENT_TREE, 0x04AA},
            {Opcode.CMSG_SET_SELECTION, 0x10D5},
            {Opcode.CMSG_PING, 0x1070},
            {Opcode.CMSG_TUTORIAL_FLAG, 0x07A4},
            {Opcode.CMSG_VIOLENCE_LEVEL, 0x05A0},
            {Opcode.CMSG_WARDEN_DATA, 0x1681},

            {Opcode.SMSG_ACCOUNT_DATA_TIMES, 0x0F40},
            {Opcode.SMSG_ACTION_BUTTONS, 0x1768},
            {Opcode.SMSG_ADDON_INFO, 0x10E2},
            {Opcode.SMSG_ALL_ACHIEVEMENT_DATA_ACCOUNT, 0x13F0},
            {Opcode.SMSG_ARENA_SEASON_WORLD_STATE, 0x00E1},
            {Opcode.SMSG_ATTACKERSTATEUPDATE, 0x0540},
            {Opcode.SMSG_ATTACKSTART,  0x0403},
            {Opcode.SMSG_ATTACKSTOP,  0x1448},
            {Opcode.SMSG_AUTH_CHALLENGE, 0x14B8},
            {Opcode.SMSG_AUTH_RESPONSE, 0x15A0},
            {Opcode.SMSG_AURA_UPDATE, 0x1B8D},
            {Opcode.SMSG_BATTLEPET_CAGE_DATA_ERROR, 0x14A1},
            {Opcode.SMSG_BATTLE_PET_DELETED, 0x13F1},
            {Opcode.SMSG_BATTLE_PET_ERROR, 0x1C12},
            {Opcode.SMSG_BATTLE_PET_HEALED, 0x1C3B},
            {Opcode.SMSG_BATTLE_PET_JOURNAL, 0x14A0},
            {Opcode.SMSG_BATTLE_PET_JOURNAL_LOCK_ACQUIRED, 0x1C7A},
            {Opcode.SMSG_BATTLE_PET_JOURNAL_LOCK_DENIED, 0x13E3},
            {Opcode.SMSG_BATTLE_PET_LICENSE_CHANGED, 0x11E0},
            {Opcode.SMSG_BATTLE_PET_TRAP_LEVEL, 0x13AA},
            {Opcode.SMSG_BATTLE_PET_UPDATES, 0x04E3},
            {Opcode.SMSG_BINDPOINTUPDATE, 0x11E2},
            {Opcode.SMSG_CHAR_CREATE, 0x1469},
            {Opcode.SMSG_CHAR_DELETE, 0x1529},
            {Opcode.SMSG_CHAR_ENUM, 0x040A},
            {Opcode.SMSG_CLIENTCACHE_VERSION, 0x1E41},
            {Opcode.SMSG_CORPSE_RECLAIM_DELAY, 0x1E73},
            {Opcode.SMSG_CREATURE_QUERY_RESPONSE, 0x00E0},
            {Opcode.SMSG_CRITERIA_UPDATE_ACCOUNT, 0x12F9 | 0x20000},
            {Opcode.SMSG_CRITERIA_UPDATE_PLAYER, 0x13B2},
            {Opcode.SMSG_DB_REPLY, 0x1F01},
            {Opcode.SMSG_DESTROY_OBJECT, 0x1D69},
            {Opcode.SMSG_EQUIPMENT_SET_LIST, 0x1520},
            {Opcode.SMSG_FEATURE_SYSTEM_STATUS, 0x1560},
            {Opcode.SMSG_FORCE_SEND_QUEUED_PACKETS, 0x01B9},
            {Opcode.SMSG_INITIALIZE_FACTIONS, 0x11E1},
            {Opcode.SMSG_INITIAL_SPELLS, 0x1B05},
            {Opcode.SMSG_INIT_CURRENCY, 0x1E3A},
            {Opcode.SMSG_INIT_WORLD_STATES, 0x0F03},
            {Opcode.SMSG_GAMEOBJECT_QUERY_RESPONSE, 0x066A},
            {Opcode.SMSG_GOSSIP_MESSAGE, 0x0E52},
            {Opcode.SMSG_GOSSIP_POI, 0x058F},
            {Opcode.SMSG_GUILD_NEWS_TEXT, 0x1850},
            {Opcode.SMSG_GUILD_QUERY_RESPONSE, 0x1953},
            {Opcode.SMSG_GUILD_RANK, 0x1271},
            {Opcode.SMSG_HOTFIX_INFO, 0x0C81},
            {Opcode.SMSG_LEARNED_SPELL, 0x0C99},
            {Opcode.SMSG_LIST_INVENTORY, 0x0D2A},
            {Opcode.SMSG_LOGIN_VERIFY_WORLD, 0x0603},
            {Opcode.SMSG_LOGOUT_CANCEL_ACK, 0x0E0A},
            {Opcode.SMSG_LOGOUT_COMPLETE, 0x0429},
            {Opcode.SMSG_LOGOUT_RESPONSE, 0x0D2B},
            {Opcode.SMSG_LOGIN_SETTIMESPEED, 0x0F4A},
            {Opcode.SMSG_MESSAGECHAT, 0x0E60},
            {Opcode.SMSG_MONSTER_MOVE, 0x12D8},
            {Opcode.SMSG_MOTD, 0x0E20},
            {Opcode.SMSG_MOVE_SET_CAN_FLY, 0x01F4},
            {Opcode.SMSG_MOVE_UNSET_CAN_FLY, 0x1D81},
            {Opcode.SMSG_NAME_QUERY_RESPONSE, 0x1E5B},
            {Opcode.SMSG_NEW_WORLD, 0x05AB},
            {Opcode.SMSG_NPC_TEXT_UPDATE, 0x10E0},
            {Opcode.SMSG_PET_BATTLE_CHAT_RESTRICTED, 0x1F53},  // 5.4.7 17930 PET_BATTLE NYI
            {Opcode.SMSG_PET_BATTLE_DEBUG_QUEUE_DUMP_RESPONSE, 0x13E9},  // 5.4.7 17930 PET_BATTLE NYI
            {Opcode.SMSG_PET_BATTLE_FULL_UPDATE, 0x01E3},  // 5.4.7 17930 PET_BATTLE NYI 
            {Opcode.SMSG_PET_BATTLE_FINAL_ROUND, 0x12F0},  // 5.4.7 17930 PET_BATTLE NYI // done
            {Opcode.SMSG_PET_BATTLE_FINISHED, 0x1E33},  // 5.4.7 17930 PET_BATTLE NYI
            {Opcode.SMSG_PET_BATTLE_FIRST_ROUND, 0x1612},  // 5.4.7 17930 PET_BATTLE NYI //done
            {Opcode.SMSG_PET_BATTLE_MAX_GAME_LENGTH_WARNING, 0x12BB},  // 5.4.7 17930 PET_BATTLE NYI
            {Opcode.SMSG_PET_BATTLE_PVP_CHALLENGE, 0x1C08},  // 5.4.7 17930 PET_BATTLE NYI
            {Opcode.SMSG_PET_BATTLE_QUEUE_PROPOSE_MATCH, 0x0E62},  // 5.4.7 17930 PET_BATTLE NYI
            {Opcode.SMSG_PET_BATTLE_QUEUE_STATUS, 0x1540},  // 5.4.7 17930 PET_BATTLE NYI
            {Opcode.SMSG_PET_BATTLE_ROUND_RESULT, 0x0709},  // 5.4.7 17930 PET_BATTLE NYI
            {Opcode.SMSG_PET_BATTLE_REPLACEMENTS_MADE, 0x0891},  // 5.4.0 17399 PET_BATTLE NYI
            //SMSG_PET_BATTLE_REQUEST_FAILED, 0x0000},  // 5.4.7 17930 PET_BATTLE NYI (not sure)
            {Opcode.SMSG_PET_BATTLE_SLOT_UPDATE, 0x0421},  // 5.4.7 17930 PET_BATTLE NYI
            {Opcode.SMSG_REALM_QUERY_RESPONSE, 0x1652},
            {Opcode.SMSG_REDIRECT_CLIENT, 0x05B9},
            {Opcode.SMSG_REMOVED_SPELL, 0x05E3},
            {Opcode.SMSG_PLAYER_MOVE, 0x1CB2},
            {Opcode.SMSG_PONG, 0x15B1},
            {Opcode.SMSG_SEND_SERVER_LOCATION, 0x0C2B},
            {Opcode.SMSG_SEND_UNLEARN_SPELLS, 0x1B3E},
            {Opcode.SMSG_SET_FLAT_SPELL_MODIFIER, 0x0179},
            {Opcode.SMSG_SET_PCT_SPELL_MODIFIER, 0x193C},
            {Opcode.SMSG_SET_PHASE_SHIFT, 0x1D52},
            {Opcode.SMSG_SET_PROFICIENCY, 0x1E3B},
            {Opcode.SMSG_SPELL_CATEGORY_COOLDOWN, 0x053B},
            {Opcode.SMSG_SPELL_START, 0x0130},
            {Opcode.SMSG_SPELL_GO, 0x0851},
            {Opcode.SMSG_SUSPEND_COMMS, 0x10B0},
            {Opcode.SMSG_TALENTS_INFO, 0x0C68},
            {Opcode.SMSG_TIME_SYNC_REQ, 0x12F1},
            {Opcode.SMSG_TRAINER_LIST, 0x1509},
            {Opcode.SMSG_TRANSFER_PENDING, 0x0440},
            {Opcode.SMSG_TRIGGER_CINEMATIC, 0x04CC},
            {Opcode.SMSG_TUTORIAL_FLAGS, 0x10A7},
            {Opcode.SMSG_UI_TIME, 0x0C22},
            {Opcode.SMSG_UPDATE_OBJECT, 0x1725},
            {Opcode.SMSG_UPDATE_WORLD_STATE, 0x1D13},
            {Opcode.SMSG_WARDEN_DATA, 0x14EB},
            {Opcode.SMSG_WEATHER, 0x0F41},
            {Opcode.SMSG_WEEKLY_SPELL_USAGE, 0x1D04},
            {Opcode.SMSG_WORLD_SERVER_INFO, 0x1D01},
        };
    }
}
         