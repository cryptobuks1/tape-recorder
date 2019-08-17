\ bitcoin opcodes implemented in forth
\ TODO: allow pushdata to handle multibyte data, for now assume 1 byte
: PUSHDATA 0x01 write dup write ;

\ OP_0, OP_FALSE 0x00
\ 01 - 4b literals
\ OP_PUSHDATA1 0x4C
\ OP_PUSHDATA2 0x4D
\ OP_PUSHDATA4 0x4E
\ OP_1NEGATE 0x4F
\ OP_1, OP_TRUE 0x51
\ OP_2 0x52
\ OP_16 0x60
\ OP_NOP 0x61
\ OP_IF 0x63
\ OP_NOTIF 0x64
\ OP_ELSE 0x67
\ OP_ENDIF 0x68
\ OP_VERIFY 0x69
\ OP_RETURN 0x6A
\ OP_TOALTSTACK 0x6B
\ OP_FROMALTSTACK 0x6C
\ OP_IFDUP 0x73
\ OP_DEPTH 0x74
: OP_DROP drop 0x75 write ;
: OP_DUP dup 0x76 write ;
\ OP_NIP 0x77
\ OP_OVER 0x78
\ OP_PICK 0x79
\ OP_ROLL 0x7A
\ OP_ROT 0x7B
: OP_SWAP swap 0x7C write ;
\ OP_TUCK 0x7D
\ OP_2DROP 0x6D
\ OP_2DUP 0x6E
\ OP_3DUP 0x6F
\ OP_2OVER 0x70
\ OP_2ROT 0x71
\ OP_2SWAP 0x72
\ OP_CAT 0x7E
\ OP_SUBSTR 0x7F
\ OP_LEFT 0x80
\ OP_RIGHT 0x81
\ OP_SIZE 0x82
\ OP_INVERT 0x83
\ OP_AND 0x84
\ OP_OR 0x85
\ OP_XOR 0x86
: OP_EQUAL = 0x87 write ;
\ OP_EQUALVERIFY 0x88
\ OP_1SUB 0x8C
: OP_2MUL 2 * 0x8D write ;
\ OP_2DIV 0x8E
\ OP_NEGATE 0x8F
\ OP_ABS 0x90
\ OP_NOT 0x91
\ OP_0NOTEQUAL 0x92
: OP_ADD + 0x93 write ;
: OP_1ADD 1 PUSHDATA OP_ADD 0x8B write ;
\ OP_SUB 0x94
: OP_MUL * 0x95 write ;
\ OP_DIV 0x96
\ OP_MOD 0x97
\ OP_LSHIFT 0x98
\ OP_RSHIFT 0x99
\ OP_BOOLAND 0x9A
\ OP_BOOLOR 0x9B
\ OP_NUMEQUAL 0x9C
\ OP_NUMEQUALVERIFY 0x9D
\ OP_NUMNOTEQUAL 0x9E
\ OP_LESSTHAN 0x9F
: OP_GREATERTHAN > 0xA0 write ;
\ OP_LESSTHANOREQUAL 0xA1
\ OP_GREATERTHANOREQUAL 0xA2
\ OP_MIN 0xA3
\ OP_MAX 0xA4
\ OP_WITHIN 0xA5
\ OP_RIPEMD160 0xA6
\ OP_SHA1 0xA7
\ OP_SHA256 0xA8
\ OP_HASH160 0xA9
\ OP_HASH256 0xAA
\ OP_CODESEPARATOR 0xAB
\ OP_CHECKSIG 0xAC
\ OP_CHECKSIGVERIFY 0xAD
\ OP_CHECKMULTISIG 0xAE
\ OP_CHECKMULTISIGVERIFY 0xAF
\ OP_CHECKLOCKTIMEVERIFY 0xB1
\ OP_CHECKSEQUENCEVERIFY 0xB2
\ OP_PUBKEYHASH 0xFD
\ OP_PUBKEY 0xFE
\ OP_INVALIDOPCODE 0xFF
\ OP_RESERVED 0x50
\ OP_VER 0x62
\ OP_VERIF 0x65
\ OP_VERIFNOT 0x66
\ OP_RESERVED1 0x89
\ OP_RESERVED2 0x8A
\ OP_NOP1 0xB0
