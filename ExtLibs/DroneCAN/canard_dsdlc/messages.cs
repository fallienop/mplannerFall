using System;using System.Reflection;
namespace DroneCAN {
public partial class DroneCAN {
    public static (Type type,UInt16 msgid, ulong crcseed, Func<Byte[],int, object> convert)[] MSG_INFO = {	(typeof(dronecan_sensors_hygrometer_Hygrometer), 1032, 0xCEB308892BF163E8, (b,s) => dronecan_sensors_hygrometer_Hygrometer.ByteArrayToDroneCANMsg(b,s)),
	(typeof(org_ardupilot_sensor_output_IMUDeltas), 20900, 0x63C61262BD84919D, (b,s) => org_ardupilot_sensor_output_IMUDeltas.ByteArrayToDroneCANMsg(b,s)),
	(typeof(org_cubepilot_uwb_Observation), 20759, 0x817EABC2996B0D62, (b,s) => org_cubepilot_uwb_Observation.ByteArrayToDroneCANMsg(b,s)),
	(typeof(com_hex_equipment_flow_Measurement), 20200, 0x6A908866BCB49C18, (b,s) => com_hex_equipment_flow_Measurement.ByteArrayToDroneCANMsg(b,s)),
	(typeof(com_hex_equipment_gnss_BodyPosition), 20210, 0x68DD4C23FEC97050, (b,s) => com_hex_equipment_gnss_BodyPosition.ByteArrayToDroneCANMsg(b,s)),
	(typeof(com_hex_equipment_gnss_MovingBaseFix), 20211, 0x3B4274BABDEBC236, (b,s) => com_hex_equipment_gnss_MovingBaseFix.ByteArrayToDroneCANMsg(b,s)),
	(typeof(com_hex_equipment_gnss_Signals), 20212, 0xE448A43008E96FA0, (b,s) => com_hex_equipment_gnss_Signals.ByteArrayToDroneCANMsg(b,s)),
	(typeof(com_hex_equipment_gpio_GetInputStates_req), 225, 0x6147C4FB7586515E, (b,s) => com_hex_equipment_gpio_GetInputStates_req.ByteArrayToDroneCANMsg(b,s)),
	(typeof(com_hex_equipment_gpio_GetInputStates_res), 225, 0x6147C4FB7586515E, (b,s) => com_hex_equipment_gpio_GetInputStates_res.ByteArrayToDroneCANMsg(b,s)),
	(typeof(com_hex_equipment_gpio_InputStateArray), 42455, 0xE4C758178F4D1A45, (b,s) => com_hex_equipment_gpio_InputStateArray.ByteArrayToDroneCANMsg(b,s)),
	(typeof(ardupilot_equipment_power_BatteryInfoAux), 20004, 0x7D7F49FC75484882, (b,s) => ardupilot_equipment_power_BatteryInfoAux.ByteArrayToDroneCANMsg(b,s)),
	(typeof(ardupilot_equipment_trafficmonitor_TrafficReport), 20790, 0x68E45DB60B6981F8, (b,s) => ardupilot_equipment_trafficmonitor_TrafficReport.ByteArrayToDroneCANMsg(b,s)),
	(typeof(ardupilot_gnss_Heading), 20002, 0x315CAE39ECED3412, (b,s) => ardupilot_gnss_Heading.ByteArrayToDroneCANMsg(b,s)),
	(typeof(ardupilot_gnss_Status), 20003, 0xBA3CB4ABBB007F69, (b,s) => ardupilot_gnss_Status.ByteArrayToDroneCANMsg(b,s)),
	(typeof(ardupilot_gnss_MovingBaselineData), 20005, 0x9F323748C32133A, (b,s) => ardupilot_gnss_MovingBaselineData.ByteArrayToDroneCANMsg(b,s)),
	(typeof(ardupilot_gnss_RelPosHeading), 20006, 0xA1727AF295F94478, (b,s) => ardupilot_gnss_RelPosHeading.ByteArrayToDroneCANMsg(b,s)),
	(typeof(ardupilot_indication_SafetyState), 20000, 0xE965701A95A1A6A1, (b,s) => ardupilot_indication_SafetyState.ByteArrayToDroneCANMsg(b,s)),
	(typeof(ardupilot_indication_Button), 20001, 0x645A46EFBA7466E, (b,s) => ardupilot_indication_Button.ByteArrayToDroneCANMsg(b,s)),
	(typeof(ardupilot_indication_NotifyState), 20007, 0x631F2A9C1651FDEC, (b,s) => ardupilot_indication_NotifyState.ByteArrayToDroneCANMsg(b,s)),
	(typeof(cuav_equipment_power_CBAT), 20300, 0xB4DACE3A38E09A74, (b,s) => cuav_equipment_power_CBAT.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_actuator_ArrayCommand), 1010, 0xD8A7486238EC3AF3, (b,s) => uavcan_equipment_actuator_ArrayCommand.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_actuator_Status), 1011, 0x5E9BBA44FAF1EA04, (b,s) => uavcan_equipment_actuator_Status.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_ahrs_Solution), 1000, 0x72A63A3C6F41FA9B, (b,s) => uavcan_equipment_ahrs_Solution.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_ahrs_MagneticFieldStrength), 1001, 0xE2A7D4A9460BC2F2, (b,s) => uavcan_equipment_ahrs_MagneticFieldStrength.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_ahrs_MagneticFieldStrength2), 1002, 0xB6AC0C442430297E, (b,s) => uavcan_equipment_ahrs_MagneticFieldStrength2.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_ahrs_RawIMU), 1003, 0x8280632C40E574B5, (b,s) => uavcan_equipment_ahrs_RawIMU.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_air_data_TrueAirspeed), 1020, 0x306F69E0A591AFAA, (b,s) => uavcan_equipment_air_data_TrueAirspeed.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_air_data_IndicatedAirspeed), 1021, 0xA1892D72AB8945F, (b,s) => uavcan_equipment_air_data_IndicatedAirspeed.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_air_data_AngleOfAttack), 1025, 0xD5513C3F7AFAC74E, (b,s) => uavcan_equipment_air_data_AngleOfAttack.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_air_data_Sideslip), 1026, 0x7B48E55FCFF42A57, (b,s) => uavcan_equipment_air_data_Sideslip.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_air_data_RawAirData), 1027, 0xC77DF38BA122F5DA, (b,s) => uavcan_equipment_air_data_RawAirData.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_air_data_StaticPressure), 1028, 0xCDC7C43412BDC89A, (b,s) => uavcan_equipment_air_data_StaticPressure.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_air_data_StaticTemperature), 1029, 0x49272A6477D96271, (b,s) => uavcan_equipment_air_data_StaticTemperature.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_camera_gimbal_AngularCommand), 1040, 0x4AF6E57B2B2BE29C, (b,s) => uavcan_equipment_camera_gimbal_AngularCommand.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_camera_gimbal_GEOPOICommand), 1041, 0x9371428A92F01FD6, (b,s) => uavcan_equipment_camera_gimbal_GEOPOICommand.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_camera_gimbal_Status), 1044, 0xB9F127865BE0D61E, (b,s) => uavcan_equipment_camera_gimbal_Status.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_device_Temperature), 1110, 0x70261C28A94144C6, (b,s) => uavcan_equipment_device_Temperature.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_esc_RawCommand), 1030, 0x217F5C87D7EC951D, (b,s) => uavcan_equipment_esc_RawCommand.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_esc_RPMCommand), 1031, 0xCE0F9F621CF7E70B, (b,s) => uavcan_equipment_esc_RPMCommand.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_esc_Status), 1034, 0xA9AF28AEA2FBB254, (b,s) => uavcan_equipment_esc_Status.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_gnss_Fix), 1060, 0x54C1572B9E07F297, (b,s) => uavcan_equipment_gnss_Fix.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_gnss_Auxiliary), 1061, 0x9BE8BDC4C3DBBFD2, (b,s) => uavcan_equipment_gnss_Auxiliary.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_gnss_RTCMStream), 1062, 0x1F56030ECB171501, (b,s) => uavcan_equipment_gnss_RTCMStream.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_gnss_Fix2), 1063, 0xCA41E7000F37435F, (b,s) => uavcan_equipment_gnss_Fix2.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_hardpoint_Command), 1070, 0xA1A036268B0C3455, (b,s) => uavcan_equipment_hardpoint_Command.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_hardpoint_Status), 1071, 0x624A519D42553D82, (b,s) => uavcan_equipment_hardpoint_Status.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_ice_FuelTankStatus), 1129, 0x286B4A387BA84BC4, (b,s) => uavcan_equipment_ice_FuelTankStatus.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_ice_reciprocating_Status), 1120, 0xD38AA3EE75537EC6, (b,s) => uavcan_equipment_ice_reciprocating_Status.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_indication_BeepCommand), 1080, 0xBE9EA9FEC2B15D52, (b,s) => uavcan_equipment_indication_BeepCommand.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_indication_LightsCommand), 1081, 0x2031D93C8BDD1EC4, (b,s) => uavcan_equipment_indication_LightsCommand.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_power_PrimaryPowerSupplyStatus), 1090, 0xBBA05074AD757480, (b,s) => uavcan_equipment_power_PrimaryPowerSupplyStatus.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_power_CircuitStatus), 1091, 0x8313D33D0DDDA115, (b,s) => uavcan_equipment_power_CircuitStatus.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_power_BatteryInfo), 1092, 0x249C26548A711966, (b,s) => uavcan_equipment_power_BatteryInfo.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_range_sensor_Measurement), 1050, 0x68FFFE70FC771952, (b,s) => uavcan_equipment_range_sensor_Measurement.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_equipment_safety_ArmingStatus), 1100, 0x8700F375556A8003, (b,s) => uavcan_equipment_safety_ArmingStatus.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_navigation_GlobalNavigationSolution), 2000, 0x463B10CCCBE51C3D, (b,s) => uavcan_navigation_GlobalNavigationSolution.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_olliw_storm32_Control), 28300, 0xBF15FB6305CE5599, (b,s) => uavcan_olliw_storm32_Control.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_olliw_storm32_Status), 28301, 0xFD38D6AA0F5099A5, (b,s) => uavcan_olliw_storm32_Status.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_olliw_storm32_Command), 28302, 0x49874D32ADB9DA75, (b,s) => uavcan_olliw_storm32_Command.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_olliw_storm32_CommandAck), 28303, 0x883EA85F57ACBBBD, (b,s) => uavcan_olliw_storm32_CommandAck.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_olliw_uc4h_GenericBatteryInfo), 28310, 0x4711AD8CBD503D5, (b,s) => uavcan_olliw_uc4h_GenericBatteryInfo.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_olliw_uc4h_Notify), 28340, 0x69BC2CB0D471C96F, (b,s) => uavcan_olliw_uc4h_Notify.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_olliw_uc4h_Distance), 28350, 0xE12C901C6174B583, (b,s) => uavcan_olliw_uc4h_Distance.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_GetNodeInfo_req), 1, 0xEE468A8121C46A9E, (b,s) => uavcan_protocol_GetNodeInfo_req.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_GetNodeInfo_res), 1, 0xEE468A8121C46A9E, (b,s) => uavcan_protocol_GetNodeInfo_res.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_GetDataTypeInfo_req), 2, 0x1B283338A7BED2D8, (b,s) => uavcan_protocol_GetDataTypeInfo_req.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_GetDataTypeInfo_res), 2, 0x1B283338A7BED2D8, (b,s) => uavcan_protocol_GetDataTypeInfo_res.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_NodeStatus), 341, 0xF0868D0C1A7C6F1, (b,s) => uavcan_protocol_NodeStatus.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_GetTransportStats_req), 4, 0xBE6F76A7EC312B04, (b,s) => uavcan_protocol_GetTransportStats_req.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_GetTransportStats_res), 4, 0xBE6F76A7EC312B04, (b,s) => uavcan_protocol_GetTransportStats_res.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_GlobalTimeSync), 4, 0x20271116A793C2DB, (b,s) => uavcan_protocol_GlobalTimeSync.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_Panic), 5, 0x8B79B4101811C1D7, (b,s) => uavcan_protocol_Panic.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_RestartNode_req), 5, 0x569E05394A3017F0, (b,s) => uavcan_protocol_RestartNode_req.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_RestartNode_res), 5, 0x569E05394A3017F0, (b,s) => uavcan_protocol_RestartNode_res.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_AccessCommandShell_req), 6, 0x59276B5921C9246E, (b,s) => uavcan_protocol_AccessCommandShell_req.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_AccessCommandShell_res), 6, 0x59276B5921C9246E, (b,s) => uavcan_protocol_AccessCommandShell_res.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_debug_KeyValue), 16370, 0xE02F25D6E0C98AE0, (b,s) => uavcan_protocol_debug_KeyValue.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_debug_LogMessage), 16383, 0xD654A48E0C049D75, (b,s) => uavcan_protocol_debug_LogMessage.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_dynamic_node_id_Allocation), 1, 0xB2A812620A11D40, (b,s) => uavcan_protocol_dynamic_node_id_Allocation.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_dynamic_node_id_server_AppendEntries_req), 30, 0x8032C7097B48A3CC, (b,s) => uavcan_protocol_dynamic_node_id_server_AppendEntries_req.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_dynamic_node_id_server_AppendEntries_res), 30, 0x8032C7097B48A3CC, (b,s) => uavcan_protocol_dynamic_node_id_server_AppendEntries_res.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_dynamic_node_id_server_RequestVote_req), 31, 0xCDDE07BB89A56356, (b,s) => uavcan_protocol_dynamic_node_id_server_RequestVote_req.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_dynamic_node_id_server_RequestVote_res), 31, 0xCDDE07BB89A56356, (b,s) => uavcan_protocol_dynamic_node_id_server_RequestVote_res.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_dynamic_node_id_server_Discovery), 390, 0x821AE2F525F69F21, (b,s) => uavcan_protocol_dynamic_node_id_server_Discovery.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_enumeration_Begin_req), 15, 0x196AE06426A3B5D8, (b,s) => uavcan_protocol_enumeration_Begin_req.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_enumeration_Begin_res), 15, 0x196AE06426A3B5D8, (b,s) => uavcan_protocol_enumeration_Begin_res.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_enumeration_Indication), 380, 0x884CB63050A84F35, (b,s) => uavcan_protocol_enumeration_Indication.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_file_BeginFirmwareUpdate_req), 40, 0xB7D725DF72724126, (b,s) => uavcan_protocol_file_BeginFirmwareUpdate_req.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_file_BeginFirmwareUpdate_res), 40, 0xB7D725DF72724126, (b,s) => uavcan_protocol_file_BeginFirmwareUpdate_res.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_file_GetInfo_req), 45, 0x5004891EE8A27531, (b,s) => uavcan_protocol_file_GetInfo_req.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_file_GetInfo_res), 45, 0x5004891EE8A27531, (b,s) => uavcan_protocol_file_GetInfo_res.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_file_GetDirectoryEntryInfo_req), 46, 0x8C46E8AB568BDA79, (b,s) => uavcan_protocol_file_GetDirectoryEntryInfo_req.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_file_GetDirectoryEntryInfo_res), 46, 0x8C46E8AB568BDA79, (b,s) => uavcan_protocol_file_GetDirectoryEntryInfo_res.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_file_Delete_req), 47, 0x78648C99170B47AA, (b,s) => uavcan_protocol_file_Delete_req.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_file_Delete_res), 47, 0x78648C99170B47AA, (b,s) => uavcan_protocol_file_Delete_res.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_file_Read_req), 48, 0x8DCDCA939F33F678, (b,s) => uavcan_protocol_file_Read_req.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_file_Read_res), 48, 0x8DCDCA939F33F678, (b,s) => uavcan_protocol_file_Read_res.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_file_Write_req), 49, 0x515AA1DC77E58429, (b,s) => uavcan_protocol_file_Write_req.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_file_Write_res), 49, 0x515AA1DC77E58429, (b,s) => uavcan_protocol_file_Write_res.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_param_ExecuteOpcode_req), 10, 0x3B131AC5EB69D2CD, (b,s) => uavcan_protocol_param_ExecuteOpcode_req.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_param_ExecuteOpcode_res), 10, 0x3B131AC5EB69D2CD, (b,s) => uavcan_protocol_param_ExecuteOpcode_res.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_param_GetSet_req), 11, 0xA7B622F939D1A4D5, (b,s) => uavcan_protocol_param_GetSet_req.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_protocol_param_GetSet_res), 11, 0xA7B622F939D1A4D5, (b,s) => uavcan_protocol_param_GetSet_res.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_tunnel_Broadcast), 2010, 0x5AA2D4D9CF4B1E85, (b,s) => uavcan_tunnel_Broadcast.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_tunnel_Call_req), 63, 0xDB11EDC510502658, (b,s) => uavcan_tunnel_Call_req.ByteArrayToDroneCANMsg(b,s)),
	(typeof(uavcan_tunnel_Call_res), 63, 0xDB11EDC510502658, (b,s) => uavcan_tunnel_Call_res.ByteArrayToDroneCANMsg(b,s)),
	(typeof(mppt_Stream), 20020, 0xDD7096B255FB6358, (b,s) => mppt_Stream.ByteArrayToDroneCANMsg(b,s)),
	(typeof(mppt_OutputEnable_req), 240, 0xEA251F2A6DD1D8A5, (b,s) => mppt_OutputEnable_req.ByteArrayToDroneCANMsg(b,s)),
	(typeof(mppt_OutputEnable_res), 240, 0xEA251F2A6DD1D8A5, (b,s) => mppt_OutputEnable_res.ByteArrayToDroneCANMsg(b,s)),
};}}