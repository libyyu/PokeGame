
MsgBoxType = 
{
	MBT_INFO            = bit.lshift(1,0),
	MBT_OK              = bit.lshift(1,1),
	MBT_WARN            = bit.lshift(1,2),
	MBT_AUTOCLOSE       = bit.lshift(1,3),

	MBBT_OK             = bit.lshift(1,4),
	MBBT_CANCEL         = bit.lshift(1,5),
	MBBT_CHECKBOX       = bit.lshift(1,6),
	MBBT_OKCANCEL       = bit.bor(bit.lshift(1,4),bit.lshift(1,5)),

	MBT_OVERTIME        = bit.lshift(1,7),
}
MsgBoxRetT = 
{
	MBRT_CANCEL    = 0,
	MBRT_OK        = 1,
	MBRT_OKCHECKED = 2,
	MBRT_OVERTIME  = 3,
}
