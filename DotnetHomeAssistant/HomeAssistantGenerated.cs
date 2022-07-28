using System;
using System.Collections.Generic;
using NetDaemon.HassModel;
using NetDaemon.HassModel.Entities;
using NetDaemon.HassModel.Entities.Core;
using System.Text.Json.Serialization;

namespace HomeAssistantGenerated
{
	public interface IEntities
	{
		AlarmControlPanelEntities AlarmControlPanel { get; }

		AutomationEntities Automation { get; }

		BinarySensorEntities BinarySensor { get; }

		ButtonEntities Button { get; }

		CalendarEntities Calendar { get; }

		CameraEntities Camera { get; }

		ClimateEntities Climate { get; }

		CoverEntities Cover { get; }

		DeviceTrackerEntities DeviceTracker { get; }

		FanEntities Fan { get; }

		InputBooleanEntities InputBoolean { get; }

		InputDatetimeEntities InputDatetime { get; }

		InputNumberEntities InputNumber { get; }

		InputSelectEntities InputSelect { get; }

		LightEntities Light { get; }

		LockEntities Lock { get; }

		MediaPlayerEntities MediaPlayer { get; }

		NumberEntities Number { get; }

		PersistentNotificationEntities PersistentNotification { get; }

		PersonEntities Person { get; }

		ScriptEntities Script { get; }

		SelectEntities Select { get; }

		SensorEntities Sensor { get; }

		SunEntities Sun { get; }

		SwitchEntities Switch { get; }

		UpdateEntities Update { get; }

		VacuumEntities Vacuum { get; }

		ZoneEntities Zone { get; }
	}

	public partial class Entities : IEntities
	{
		private readonly IHaContext _haContext;
		public Entities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AlarmControlPanelEntities AlarmControlPanel => new(_haContext);
		public AutomationEntities Automation => new(_haContext);
		public BinarySensorEntities BinarySensor => new(_haContext);
		public ButtonEntities Button => new(_haContext);
		public CalendarEntities Calendar => new(_haContext);
		public CameraEntities Camera => new(_haContext);
		public ClimateEntities Climate => new(_haContext);
		public CoverEntities Cover => new(_haContext);
		public DeviceTrackerEntities DeviceTracker => new(_haContext);
		public FanEntities Fan => new(_haContext);
		public InputBooleanEntities InputBoolean => new(_haContext);
		public InputDatetimeEntities InputDatetime => new(_haContext);
		public InputNumberEntities InputNumber => new(_haContext);
		public InputSelectEntities InputSelect => new(_haContext);
		public LightEntities Light => new(_haContext);
		public LockEntities Lock => new(_haContext);
		public MediaPlayerEntities MediaPlayer => new(_haContext);
		public NumberEntities Number => new(_haContext);
		public PersistentNotificationEntities PersistentNotification => new(_haContext);
		public PersonEntities Person => new(_haContext);
		public ScriptEntities Script => new(_haContext);
		public SelectEntities Select => new(_haContext);
		public SensorEntities Sensor => new(_haContext);
		public SunEntities Sun => new(_haContext);
		public SwitchEntities Switch => new(_haContext);
		public UpdateEntities Update => new(_haContext);
		public VacuumEntities Vacuum => new(_haContext);
		public ZoneEntities Zone => new(_haContext);
	}

	public partial class AlarmControlPanelEntities
	{
		private readonly IHaContext _haContext;
		public AlarmControlPanelEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Alarm</summary>
		public AlarmControlPanelEntity Alarm => new(_haContext, "alarm_control_panel.alarm");
	}

	public partial class AutomationEntities
	{
		private readonly IHaContext _haContext;
		public AutomationEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Low battery level detection & notification for all battery sensors</summary>
		public AutomationEntity LowBatteryLevelDetectionNotificationForAllBatterySensors => new(_haContext, "automation.low_battery_level_detection_notification_for_all_battery_sensors");
		///<summary>Motion control: Kitchen lights</summary>
		public AutomationEntity MotionControlKitchenLights => new(_haContext, "automation.motion_control_kitchen_lights");
		///<summary>Motion control: Upstairs Hallway</summary>
		public AutomationEntity MotionControlUpstairsHallway => new(_haContext, "automation.motion_control_upstairs_hallway");
		///<summary>Turn on bathroom lights</summary>
		public AutomationEntity NewAutomation2 => new(_haContext, "automation.new_automation_2");
		///<summary>Die btch notify</summary>
		public AutomationEntity NewAutomation3 => new(_haContext, "automation.new_automation_3");
		///<summary>Reply die bitch</summary>
		public AutomationEntity ReplyDieBitch => new(_haContext, "automation.reply_die_bitch");
		///<summary>Set the alarm according to occupancy</summary>
		public AutomationEntity SetTheAlarmAccordingToOccupancy => new(_haContext, "automation.set_the_alarm_according_to_occupancy");
		///<summary>Sync Ambilight with TV Backlight</summary>
		public AutomationEntity SyncAmbilightWithTvBacklight => new(_haContext, "automation.sync_ambilight_with_tv_backlight");
		///<summary>Sync Presence Sensors with Device Trackers</summary>
		public AutomationEntity SyncPresenceSensorsWithDeviceTrackers => new(_haContext, "automation.sync_presence_sensors_with_device_trackers");
		///<summary>Warn about opened sensors when Bedroom AC is turned on</summary>
		public AutomationEntity WarnAboutOpenedSensorsWhenBedroomAcIsTurnedOn => new(_haContext, "automation.warn_about_opened_sensors_when_bedroom_ac_is_turned_on");
	}

	public partial class BinarySensorEntities
	{
		private readonly IHaContext _haContext;
		public BinarySensorEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Alarm Contact Sensors</summary>
		public BinarySensorEntity AlarmContactSensors => new(_haContext, "binary_sensor.alarm_contact_sensors");
		///<summary>aqara lumi.motion.ac01 e9284d00 occupancy</summary>
		public BinarySensorEntity AqaraLumiMotionAc01E9284d00Occupancy => new(_haContext, "binary_sensor.aqara_lumi_motion_ac01_e9284d00_occupancy");
		///<summary>Areks Presence</summary>
		public BinarySensorEntity AreksPresence => new(_haContext, "binary_sensor.areks_presence");
		///<summary>Bedroom Is Dark</summary>
		public BinarySensorEntity BedroomIsDark => new(_haContext, "binary_sensor.bedroom_is_dark");
		///<summary>Bedroom Motion</summary>
		public BinarySensorEntity BedroomMotion => new(_haContext, "binary_sensor.bedroom_motion");
		///<summary>Downstairs Room Is Dark</summary>
		public BinarySensorEntity DownstairsRoomIsDark => new(_haContext, "binary_sensor.downstairs_room_is_dark");
		///<summary>Downstairs Room Motion</summary>
		public BinarySensorEntity DownstairsRoomMotion => new(_haContext, "binary_sensor.downstairs_room_motion");
		///<summary>Dream Machine Pro Hdd 1</summary>
		public BinarySensorEntity DreamMachineProDisk0Health => new(_haContext, "binary_sensor.dream_machine_pro_disk_0_health");
		///<summary>EDCMXENLT0251 Active</summary>
		public BinarySensorEntity Edcmxenlt0251Active => new(_haContext, "binary_sensor.edcmxenlt0251_active");
		///<summary>EDCMXENLT0251 Audio Input In Use</summary>
		public BinarySensorEntity Edcmxenlt0251AudioInputInUse => new(_haContext, "binary_sensor.edcmxenlt0251_audio_input_in_use");
		///<summary>EDCMXENLT0251 Audio Output In Use</summary>
		public BinarySensorEntity Edcmxenlt0251AudioOutputInUse => new(_haContext, "binary_sensor.edcmxenlt0251_audio_output_in_use");
		///<summary>EDCMXENLT0251 Camera In Use</summary>
		public BinarySensorEntity Edcmxenlt0251CameraInUse => new(_haContext, "binary_sensor.edcmxenlt0251_camera_in_use");
		///<summary>EDCMXENLT0251 Focus</summary>
		public BinarySensorEntity Edcmxenlt0251Focus => new(_haContext, "binary_sensor.edcmxenlt0251_focus");
		///<summary>Entrance Person Motion</summary>
		public BinarySensorEntity EntrancePersonMotion => new(_haContext, "binary_sensor.entrance_person_motion");
		///<summary>Freyja Doze Mode</summary>
		public BinarySensorEntity FreyjaDozeMode => new(_haContext, "binary_sensor.freyja_doze_mode");
		///<summary>Freyja Interactive</summary>
		public BinarySensorEntity FreyjaInteractive => new(_haContext, "binary_sensor.freyja_interactive");
		///<summary>Front Door Person Motion</summary>
		public BinarySensorEntity FrontDoorPersonMotion => new(_haContext, "binary_sensor.front_door_person_motion");
		///<summary>Garage Is Dark</summary>
		public BinarySensorEntity G3FlexIsDark2 => new(_haContext, "binary_sensor.g3_flex_is_dark_2");
		///<summary>Patio Is Dark</summary>
		public BinarySensorEntity G3FlexIsDark3 => new(_haContext, "binary_sensor.g3_flex_is_dark_3");
		///<summary>Garage Motion</summary>
		public BinarySensorEntity G3FlexMotion2 => new(_haContext, "binary_sensor.g3_flex_motion_2");
		///<summary>Patio Motion</summary>
		public BinarySensorEntity G3FlexMotion3 => new(_haContext, "binary_sensor.g3_flex_motion_3");
		///<summary>Gustavito Bin Full</summary>
		public BinarySensorEntity GustavitoBinFull => new(_haContext, "binary_sensor.gustavito_bin_full");
		///<summary>Hildr Presence</summary>
		public BinarySensorEntity HildrPresence => new(_haContext, "binary_sensor.hildr_presence");
		///<summary>Home</summary>
		public BinarySensorEntity Home => new(_haContext, "binary_sensor.home");
		///<summary>Kitchen Presence Sensor</summary>
		public BinarySensorEntity KitchenPresenceSensor => new(_haContext, "binary_sensor.kitchen_presence_sensor");
		///<summary>Living Room Is Dark</summary>
		public BinarySensorEntity LivingRoomIsDark => new(_haContext, "binary_sensor.living_room_is_dark");
		///<summary>Living Room Motion</summary>
		public BinarySensorEntity LivingRoomMotion => new(_haContext, "binary_sensor.living_room_motion");
		///<summary>LUMI lumi.sensor_magnet.aq2 25aae207 on_off</summary>
		public BinarySensorEntity LumiLumiSensorMagnetAq225aae207OnOff => new(_haContext, "binary_sensor.lumi_lumi_sensor_magnet_aq2_25aae207_on_off");
		///<summary>Downstairs Bathroom Door</summary>
		public BinarySensorEntity LumiLumiSensorMagnetAq2500af807OnOff => new(_haContext, "binary_sensor.lumi_lumi_sensor_magnet_aq2_500af807_on_off");
		///<summary>Dressing Room Door</summary>
		public BinarySensorEntity LumiLumiSensorMagnetAq29862e007OnOff => new(_haContext, "binary_sensor.lumi_lumi_sensor_magnet_aq2_9862e007_on_off");
		///<summary>Main Bathroom Door</summary>
		public BinarySensorEntity LumiLumiSensorMagnetAq2B194e307OnOff => new(_haContext, "binary_sensor.lumi_lumi_sensor_magnet_aq2_b194e307_on_off");
		///<summary>Bedroom Secondary Window</summary>
		public BinarySensorEntity LumiLumiSensorMagnetAq2C770e007OnOff => new(_haContext, "binary_sensor.lumi_lumi_sensor_magnet_aq2_c770e007_on_off");
		///<summary>Bedroom Main Window</summary>
		public BinarySensorEntity LumiLumiSensorMagnetAq2D221e307OnOff => new(_haContext, "binary_sensor.lumi_lumi_sensor_magnet_aq2_d221e307_on_off");
		///<summary>Sliding Door</summary>
		public BinarySensorEntity LumiLumiSensorMagnetAq2E370e007OnOff => new(_haContext, "binary_sensor.lumi_lumi_sensor_magnet_aq2_e370e007_on_off");
		///<summary>Main Door</summary>
		public BinarySensorEntity LumiLumiSensorMagnetAq2OnOff => new(_haContext, "binary_sensor.lumi_lumi_sensor_magnet_aq2_on_off");
		///<summary>Upstairs Hallway Motion Sensor Motion Sensor</summary>
		public BinarySensorEntity LumiLumiSensorMotionAq225c1ec07IasZone => new(_haContext, "binary_sensor.lumi_lumi_sensor_motion_aq2_25c1ec07_ias_zone");
		///<summary>LUMI lumi.sensor_motion.aq2 25c1ec07 occupancy</summary>
		public BinarySensorEntity LumiLumiSensorMotionAq225c1ec07Occupancy => new(_haContext, "binary_sensor.lumi_lumi_sensor_motion_aq2_25c1ec07_occupancy");
		///<summary>Stairs Motion Sensor</summary>
		public BinarySensorEntity LumiLumiSensorMotionAq2Dc4ded07IasZone => new(_haContext, "binary_sensor.lumi_lumi_sensor_motion_aq2_dc4ded07_ias_zone");
		///<summary>LUMI lumi.sensor_motion.aq2 dc4ded07 occupancy</summary>
		public BinarySensorEntity LumiLumiSensorMotionAq2Dc4ded07Occupancy => new(_haContext, "binary_sensor.lumi_lumi_sensor_motion_aq2_dc4ded07_occupancy");
		///<summary>Kitchen Motion Sensor</summary>
		public BinarySensorEntity LumiLumiSensorMotionAq2IasZone => new(_haContext, "binary_sensor.lumi_lumi_sensor_motion_aq2_ias_zone");
		///<summary>Kitchen Motion Sensor occupancy</summary>
		public BinarySensorEntity LumiLumiSensorMotionAq2Occupancy => new(_haContext, "binary_sensor.lumi_lumi_sensor_motion_aq2_occupancy");
		///<summary>Main Bedroom Contact Sensors</summary>
		public BinarySensorEntity MainBedroomContactSensors => new(_haContext, "binary_sensor.main_bedroom_contact_sensors");
		///<summary>Main Bedroom Windows</summary>
		public BinarySensorEntity MainBedroomWindows => new(_haContext, "binary_sensor.main_bedroom_windows");
		///<summary>Motion Sensors</summary>
		public BinarySensorEntity MotionSensors => new(_haContext, "binary_sensor.motion_sensors");
		///<summary>NostalgiaDrive Bluetooth State</summary>
		public BinarySensorEntity NostalgiadriveBluetoothState => new(_haContext, "binary_sensor.nostalgiadrive_bluetooth_state");
		///<summary>NostalgiaDrive Doze Mode</summary>
		public BinarySensorEntity NostalgiadriveDozeMode => new(_haContext, "binary_sensor.nostalgiadrive_doze_mode");
		///<summary>NostalgiaDrive Interactive</summary>
		public BinarySensorEntity NostalgiadriveInteractive => new(_haContext, "binary_sensor.nostalgiadrive_interactive");
		///<summary>Office Is Dark</summary>
		public BinarySensorEntity OfficeIsDark => new(_haContext, "binary_sensor.office_is_dark");
		///<summary>Office Motion</summary>
		public BinarySensorEntity OfficeMotion => new(_haContext, "binary_sensor.office_motion");
		///<summary>Remote UI</summary>
		public BinarySensorEntity RemoteUi => new(_haContext, "binary_sensor.remote_ui");
		///<summary>Rho Aias Active</summary>
		public BinarySensorEntity RhoAiasActive => new(_haContext, "binary_sensor.rho_aias_active");
		///<summary>shelly1-98CDAC245A11 Input</summary>
		public BinarySensorEntity Shelly198cdac245a11Input => new(_haContext, "binary_sensor.shelly1_98cdac245a11_input");
		///<summary>Updater</summary>
		public BinarySensorEntity Updater => new(_haContext, "binary_sensor.updater");
		///<summary>Video Doorbell Motion</summary>
		public BinarySensorEntity VideoDoorbellMotion => new(_haContext, "binary_sensor.video_doorbell_motion");
	}

	public partial class ButtonEntities
	{
		private readonly IHaContext _haContext;
		public ButtonEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>aqara lumi.motion.ac01 e9284d00 opple_cluster reset_no_presence_status</summary>
		public ButtonEntity AqaraLumiMotionAc01E9284d00OppleClusterResetNoPresenceStatus => new(_haContext, "button.aqara_lumi_motion_ac01_e9284d00_opple_cluster_reset_no_presence_status");
		///<summary>Downstairs FP1 identify</summary>
		public ButtonEntity AqaraLumiMotionAc01Identify => new(_haContext, "button.aqara_lumi_motion_ac01_identify");
		///<summary>Bedroom Outlet 2 identify</summary>
		public ButtonEntity BedroomOutlet2Identify => new(_haContext, "button.bedroom_outlet_2_identify");
		///<summary>Bedroom Outlet identify</summary>
		public ButtonEntity BedroomOutletIdentify => new(_haContext, "button.bedroom_outlet_identify");
		///<summary>Kitchen Fan Light 1 identify</summary>
		public ButtonEntity KitchenFanLight1Identify => new(_haContext, "button.kitchen_fan_light_1_identify");
		///<summary>Kitchen Fan Light 2 identify</summary>
		public ButtonEntity KitchenFanLight2Identify => new(_haContext, "button.kitchen_fan_light_2_identify");
		///<summary>Living Room Fan 2 Bulb 1 identify</summary>
		public ButtonEntity LivingRoomFan2Bulb1Identify => new(_haContext, "button.living_room_fan_2_bulb_1_identify");
		///<summary>Living Room Fan 2 Bulb 2 identify</summary>
		public ButtonEntity LivingRoomFan2Bulb2Identify => new(_haContext, "button.living_room_fan_2_bulb_2_identify");
		///<summary>Living Room Fan Bulb 1 identify</summary>
		public ButtonEntity LivingRoomFanBulb1Identify => new(_haContext, "button.living_room_fan_bulb_1_identify");
		///<summary>Living Room Fan Bulb 2 identify</summary>
		public ButtonEntity LivingRoomFanBulb2Identify => new(_haContext, "button.living_room_fan_bulb_2_identify");
		///<summary>LUMI lumi.sensor_magnet.aq2 25aae207 identify</summary>
		public ButtonEntity LumiLumiSensorMagnetAq225aae207Identify => new(_haContext, "button.lumi_lumi_sensor_magnet_aq2_25aae207_identify");
		///<summary>LUMI lumi.sensor_magnet.aq2 500af807 identify</summary>
		public ButtonEntity LumiLumiSensorMagnetAq2500af807Identify => new(_haContext, "button.lumi_lumi_sensor_magnet_aq2_500af807_identify");
		///<summary>LUMI lumi.sensor_magnet.aq2 9862e007 identify</summary>
		public ButtonEntity LumiLumiSensorMagnetAq29862e007Identify => new(_haContext, "button.lumi_lumi_sensor_magnet_aq2_9862e007_identify");
		///<summary>LUMI lumi.sensor_magnet.aq2 b194e307 identify</summary>
		public ButtonEntity LumiLumiSensorMagnetAq2B194e307Identify => new(_haContext, "button.lumi_lumi_sensor_magnet_aq2_b194e307_identify");
		///<summary>LUMI lumi.sensor_magnet.aq2 c770e007 identify</summary>
		public ButtonEntity LumiLumiSensorMagnetAq2C770e007Identify => new(_haContext, "button.lumi_lumi_sensor_magnet_aq2_c770e007_identify");
		///<summary>LUMI lumi.sensor_magnet.aq2 e370e007 identify</summary>
		public ButtonEntity LumiLumiSensorMagnetAq2E370e007Identify => new(_haContext, "button.lumi_lumi_sensor_magnet_aq2_e370e007_identify");
		///<summary>LUMI lumi.sensor_magnet.aq2 fa09e307 identify</summary>
		public ButtonEntity LumiLumiSensorMagnetAq2Fa09e307Identify => new(_haContext, "button.lumi_lumi_sensor_magnet_aq2_fa09e307_identify");
		///<summary>Bedroom Main Window identify</summary>
		public ButtonEntity LumiLumiSensorMagnetAq2Identify => new(_haContext, "button.lumi_lumi_sensor_magnet_aq2_identify");
		///<summary>LUMI lumi.sensor_motion.aq2 25c1ec07 identify</summary>
		public ButtonEntity LumiLumiSensorMotionAq225c1ec07Identify => new(_haContext, "button.lumi_lumi_sensor_motion_aq2_25c1ec07_identify");
		///<summary>LUMI lumi.sensor_motion.aq2 dc4ded07 identify</summary>
		public ButtonEntity LumiLumiSensorMotionAq2Dc4ded07Identify => new(_haContext, "button.lumi_lumi_sensor_motion_aq2_dc4ded07_identify");
		///<summary>Kitchen Motion Sensor identify</summary>
		public ButtonEntity LumiLumiSensorMotionAq2Identify => new(_haContext, "button.lumi_lumi_sensor_motion_aq2_identify");
		///<summary>LUMI lumi.weather 1a7aed07 identify</summary>
		public ButtonEntity LumiLumiWeather1a7aed07Identify => new(_haContext, "button.lumi_lumi_weather_1a7aed07_identify");
		///<summary>LUMI lumi.weather 2c86e407 identify</summary>
		public ButtonEntity LumiLumiWeather2c86e407Identify => new(_haContext, "button.lumi_lumi_weather_2c86e407_identify");
		///<summary>LUMI lumi.weather 3872ed07 identify</summary>
		public ButtonEntity LumiLumiWeather3872ed07Identify => new(_haContext, "button.lumi_lumi_weather_3872ed07_identify");
		///<summary>Main Bathroom Sensor identify</summary>
		public ButtonEntity LumiLumiWeatherIdentify => new(_haContext, "button.lumi_lumi_weather_identify");
		///<summary>Office outlet identify</summary>
		public ButtonEntity OfficeOutletIdentify => new(_haContext, "button.office_outlet_identify");
		///<summary>RHOAIAS_startstrive</summary>
		public ButtonEntity RhoaiasStartstrive => new(_haContext, "button.rhoaias_startstrive");
		///<summary>shelly1-98CDAC245A11 OTA Update</summary>
		public ButtonEntity Shelly198cdac245a11OtaUpdate => new(_haContext, "button.shelly1_98cdac245a11_ota_update");
		///<summary>shelly1-98CDAC245A11 Reboot</summary>
		public ButtonEntity Shelly198cdac245a11Reboot => new(_haContext, "button.shelly1_98cdac245a11_reboot");
		///<summary>Stairs outlet identify</summary>
		public ButtonEntity StairsOutletIdentify => new(_haContext, "button.stairs_outlet_identify");
		///<summary>WLED Restart</summary>
		public ButtonEntity WledRestart => new(_haContext, "button.wled_restart");
	}

	public partial class CalendarEntities
	{
		private readonly IHaContext _haContext;
		public CalendarEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Cleaning Schedule</summary>
		public CalendarEntity CleaningDay => new(_haContext, "calendar.cleaning_day");
		///<summary>Garbage Collection Day</summary>
		public CalendarEntity GarbageCollection => new(_haContext, "calendar.garbage_collection");
	}

	public partial class CameraEntities
	{
		private readonly IHaContext _haContext;
		public CameraEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bedroom High</summary>
		public CameraEntity BedroomHigh => new(_haContext, "camera.bedroom_high");
		///<summary>Downstairs Room High</summary>
		public CameraEntity DownstairsRoomHigh => new(_haContext, "camera.downstairs_room_high");
		///<summary>Entrance</summary>
		public CameraEntity Entrance => new(_haContext, "camera.entrance");
		///<summary>Entrance Person</summary>
		public CameraEntity EntrancePerson => new(_haContext, "camera.entrance_person");
		///<summary>Front Door</summary>
		public CameraEntity FrontDoor => new(_haContext, "camera.front_door");
		///<summary>Front Door Camera</summary>
		public CameraEntity FrontDoorCamera => new(_haContext, "camera.front_door_camera");
		///<summary>Front Door Person</summary>
		public CameraEntity FrontDoorPerson => new(_haContext, "camera.front_door_person");
		///<summary>Garage High</summary>
		public CameraEntity G3FlexHigh2 => new(_haContext, "camera.g3_flex_high_2");
		///<summary>Patio High</summary>
		public CameraEntity G3FlexHigh3 => new(_haContext, "camera.g3_flex_high_3");
		///<summary>Living Room High</summary>
		public CameraEntity LivingRoomHigh => new(_haContext, "camera.living_room_high");
		///<summary>Office High</summary>
		public CameraEntity OfficeHigh => new(_haContext, "camera.office_high");
	}

	public partial class ClimateEntities
	{
		private readonly IHaContext _haContext;
		public ClimateEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bedroom</summary>
		public ClimateEntity Bedroom => new(_haContext, "climate.bedroom");
		///<summary>Office</summary>
		public ClimateEntity Office => new(_haContext, "climate.office");
	}

	public partial class CoverEntities
	{
		private readonly IHaContext _haContext;
		public CoverEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Garage Door</summary>
		public CoverEntity GarageDoor => new(_haContext, "cover.garage_door");
	}

	public partial class DeviceTrackerEntities
	{
		private readonly IHaContext _haContext;
		public DeviceTrackerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>areks_bayesian_tracker</summary>
		public DeviceTrackerEntity AreksBayesianTracker => new(_haContext, "device_tracker.areks_bayesian_tracker");
		///<summary>Bedroom Chromecast</summary>
		public DeviceTrackerEntity BedroomChromecast => new(_haContext, "device_tracker.bedroom_chromecast");
		///<summary>bedroom_fan</summary>
		public DeviceTrackerEntity BedroomFan => new(_haContext, "device_tracker.bedroom_fan");
		///<summary>downstairs_room</summary>
		public DeviceTrackerEntity DownstairsRoom => new(_haContext, "device_tracker.downstairs_room");
		///<summary>EDCMXENLT0251</summary>
		public DeviceTrackerEntity Edcmxenlt0251 => new(_haContext, "device_tracker.edcmxenlt0251");
		///<summary>esphome-web-0c2910</summary>
		public DeviceTrackerEntity EsphomeWeb0c2910 => new(_haContext, "device_tracker.esphome_web_0c2910");
		///<summary>Freyja</summary>
		public DeviceTrackerEntity Freyja => new(_haContext, "device_tracker.freyja");
		///<summary>hallway_light</summary>
		public DeviceTrackerEntity HallwayLight => new(_haContext, "device_tracker.hallway_light");
		///<summary>hildr_bayesian_tracker</summary>
		public DeviceTrackerEntity HildrBayesianTracker => new(_haContext, "device_tracker.hildr_bayesian_tracker");
		///<summary>kitchen_fan</summary>
		public DeviceTrackerEntity KitchenFan => new(_haContext, "device_tracker.kitchen_fan");
		///<summary>kitchen-switch</summary>
		public DeviceTrackerEntity KitchenSwitch => new(_haContext, "device_tracker.kitchen_switch");
		///<summary>living-room-fan</summary>
		public DeviceTrackerEntity LivingRoomFan => new(_haContext, "device_tracker.living_room_fan");
		///<summary>living-room-fan2</summary>
		public DeviceTrackerEntity LivingRoomFan2 => new(_haContext, "device_tracker.living_room_fan2");
		///<summary>Hildr Phone</summary>
		public DeviceTrackerEntity Mi9tHildrwg => new(_haContext, "device_tracker.mi9t_hildrwg");
		///<summary>NostalgiaDrive</summary>
		public DeviceTrackerEntity Nostalgiadrive => new(_haContext, "device_tracker.nostalgiadrive");
		///<summary>Areks Phone</summary>
		public DeviceTrackerEntity Oneplus7Pro => new(_haContext, "device_tracker.oneplus_7_pro");
		///<summary>Rho Aias Device</summary>
		public DeviceTrackerEntity RhoAias => new(_haContext, "device_tracker.rho_aias");
		///<summary>Roomba-3192C22070242710</summary>
		public DeviceTrackerEntity Roomba3192c22070242710 => new(_haContext, "device_tracker.roomba_3192c22070242710");
		///<summary>shelly1-98CDAC245A11</summary>
		public DeviceTrackerEntity Shelly198cdac245a11 => new(_haContext, "device_tracker.shelly1_98cdac245a11");
		///<summary>upstairs_bathroom_switch</summary>
		public DeviceTrackerEntity UpstairsBathroomSwitch => new(_haContext, "device_tracker.upstairs_bathroom_switch");
		///<summary>upstairs_bedroom_switch</summary>
		public DeviceTrackerEntity UpstairsBedroomSwitch => new(_haContext, "device_tracker.upstairs_bedroom_switch");
		///<summary>upstairs_dressing_room_switch</summary>
		public DeviceTrackerEntity UpstairsDressingRoomSwitch => new(_haContext, "device_tracker.upstairs_dressing_room_switch");
		///<summary>upstairs_hallway_switch</summary>
		public DeviceTrackerEntity UpstairsHallwaySwitch => new(_haContext, "device_tracker.upstairs_hallway_switch");
		///<summary>upstairs_room_switch</summary>
		public DeviceTrackerEntity UpstairsRoomSwitch => new(_haContext, "device_tracker.upstairs_room_switch");
		///<summary>wled-WLED</summary>
		public DeviceTrackerEntity WledWled => new(_haContext, "device_tracker.wled_wled");
	}

	public partial class FanEntities
	{
		private readonly IHaContext _haContext;
		public FanEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Downstairs Room Fan</summary>
		public FanEntity DownstairsRoomFan => new(_haContext, "fan.downstairs_room_fan");
		///<summary>Kitchen Fan</summary>
		public FanEntity KitchenFan => new(_haContext, "fan.kitchen_fan");
		///<summary>Living Room Fan 1</summary>
		public FanEntity LivingRoomFan1 => new(_haContext, "fan.living_room_fan_1");
		///<summary>Living Room Fan 2</summary>
		public FanEntity LivingRoomFan2 => new(_haContext, "fan.living_room_fan_2");
	}

	public partial class InputBooleanEntities
	{
		private readonly IHaContext _haContext;
		public InputBooleanEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Areks Alarm State</summary>
		public InputBooleanEntity AreksAlarmState => new(_haContext, "input_boolean.areks_alarm_state");
		///<summary>Motion Living Room Enabled</summary>
		public InputBooleanEntity MotionLivingRoomEnabled => new(_haContext, "input_boolean.motion_living_room_enabled");
		///<summary>netdaemon_dotnet_home_assistant_apps_light_on_movement_kitchen_motion_activated_lights_app</summary>
		public InputBooleanEntity NetdaemonDotnetHomeAssistantAppsLightOnMovementKitchenMotionActivatedLightsApp => new(_haContext, "input_boolean.netdaemon_dotnet_home_assistant_apps_light_on_movement_kitchen_motion_activated_lights_app");
		///<summary>netdaemon_dotnet_home_assistant_apps_light_on_movement_office_motion_activated_lights_app</summary>
		public InputBooleanEntity NetdaemonDotnetHomeAssistantAppsLightOnMovementOfficeMotionActivatedLightsApp => new(_haContext, "input_boolean.netdaemon_dotnet_home_assistant_apps_light_on_movement_office_motion_activated_lights_app");
		///<summary>netdaemon_dotnet_home_assistant_apps_light_on_movement_upstairs_hallway_motion_activated_lights_app</summary>
		public InputBooleanEntity NetdaemonDotnetHomeAssistantAppsLightOnMovementUpstairsHallwayMotionActivatedLightsApp => new(_haContext, "input_boolean.netdaemon_dotnet_home_assistant_apps_light_on_movement_upstairs_hallway_motion_activated_lights_app");
	}

	public partial class InputDatetimeEntities
	{
		private readonly IHaContext _haContext;
		public InputDatetimeEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Areks Alarm Time</summary>
		public InputDatetimeEntity AreksAlarmTime => new(_haContext, "input_datetime.areks_alarm_time");
	}

	public partial class InputNumberEntities
	{
		private readonly IHaContext _haContext;
		public InputNumberEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Areks Water Intake</summary>
		public InputNumberEntity AreksWaterIntake => new(_haContext, "input_number.areks_water_intake");
		///<summary>Living Room People Count</summary>
		public InputNumberEntity LivingRoomPeopleCount => new(_haContext, "input_number.living_room_people_count");
	}

	public partial class InputSelectEntities
	{
		private readonly IHaContext _haContext;
		public InputSelectEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>areks_alarm_songs</summary>
		public InputSelectEntity AreksAlarmSongs => new(_haContext, "input_select.areks_alarm_songs");
	}

	public partial class LightEntities
	{
		private readonly IHaContext _haContext;
		public LightEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>All Bedroom Lights</summary>
		public LightEntity AllBedroomLights => new(_haContext, "light.all_bedroom_lights");
		///<summary>All Downstairs Lights</summary>
		public LightEntity AllDownstairsLights => new(_haContext, "light.all_downstairs_lights");
		///<summary>All Guest Room Lights</summary>
		public LightEntity AllGuestRoomLights => new(_haContext, "light.all_guest_room_lights");
		///<summary>All Kitchen Lights</summary>
		public LightEntity AllKitchenLights => new(_haContext, "light.all_kitchen_lights");
		///<summary>All Lights</summary>
		public LightEntity AllLights => new(_haContext, "light.all_lights");
		///<summary>All Living Room Lights</summary>
		public LightEntity AllLivingRoomLights => new(_haContext, "light.all_living_room_lights");
		///<summary>All Upstairs Lights</summary>
		public LightEntity AllUpstairsLights => new(_haContext, "light.all_upstairs_lights");
		///<summary>Ambilight</summary>
		public LightEntity BedroomTv => new(_haContext, "light.bedroom_tv");
		public LightEntity BrowserMod063d0b07E5cea70a => new(_haContext, "light.browser_mod_063d0b07_e5cea70a");
		public LightEntity BrowserMod0e201c89E23fa539 => new(_haContext, "light.browser_mod_0e201c89_e23fa539");
		public LightEntity BrowserMod6efffaa141a969ff => new(_haContext, "light.browser_mod_6efffaa1_41a969ff");
		public LightEntity BrowserMod9460d8465b19fe48 => new(_haContext, "light.browser_mod_9460d846_5b19fe48");
		public LightEntity BrowserMod9b6ad72d195bec2a => new(_haContext, "light.browser_mod_9b6ad72d_195bec2a");
		public LightEntity BrowserMod9be5b824F163af78 => new(_haContext, "light.browser_mod_9be5b824_f163af78");
		public LightEntity BrowserModA818a8e4E6349656 => new(_haContext, "light.browser_mod_a818a8e4_e6349656");
		public LightEntity BrowserModAae046754a5ec423 => new(_haContext, "light.browser_mod_aae04675_4a5ec423");
		public LightEntity BrowserModB5dfeec6Cf4ff3c6 => new(_haContext, "light.browser_mod_b5dfeec6_cf4ff3c6");
		public LightEntity BrowserModB8bdae81E55c6373 => new(_haContext, "light.browser_mod_b8bdae81_e55c6373");
		public LightEntity BrowserModC8c1e527F1f1f5ee => new(_haContext, "light.browser_mod_c8c1e527_f1f1f5ee");
		public LightEntity BrowserModE90b9e1a23d4c400 => new(_haContext, "light.browser_mod_e90b9e1a_23d4c400");
		public LightEntity BrowserModF6551325D5308c60 => new(_haContext, "light.browser_mod_f6551325_d5308c60");
		///<summary>D_KT_SW1_LEDS</summary>
		public LightEntity DKtSw1Leds => new(_haContext, "light.d_kt_sw1_leds");
		///<summary>D_KT_SW1_STATE</summary>
		public LightEntity DKtSw1State => new(_haContext, "light.d_kt_sw1_state");
		///<summary>D_LR_SW1_LEDS</summary>
		public LightEntity DLrSw1Leds => new(_haContext, "light.d_lr_sw1_leds");
		///<summary>D_LR_SW1_STATE</summary>
		public LightEntity DLrSw1State => new(_haContext, "light.d_lr_sw1_state");
		///<summary>D_LR_SW2_LEDS</summary>
		public LightEntity DLrSw2Leds => new(_haContext, "light.d_lr_sw2_leds");
		///<summary>D_LR_SW2_STATE</summary>
		public LightEntity DLrSw2State => new(_haContext, "light.d_lr_sw2_state");
		///<summary>Downstairs Room Light</summary>
		public LightEntity DownstairsRoomLight => new(_haContext, "light.downstairs_room_light");
		///<summary>Downstairs Room Switch Btn3</summary>
		public LightEntity DownstairsRoomSwitchBtn3 => new(_haContext, "light.downstairs_room_switch_btn3");
		///<summary>Hallway Light</summary>
		public LightEntity HallwayLight => new(_haContext, "light.hallway_light");
		///<summary>Kitchen Fan Light 1</summary>
		public LightEntity KitchenFanLight1LevelOnOff => new(_haContext, "light.kitchen_fan_light_1_level_on_off");
		///<summary>Kitchen Fan Light 2</summary>
		public LightEntity KitchenFanLight2LevelOnOff => new(_haContext, "light.kitchen_fan_light_2_level_on_off");
		///<summary>Kitchen Fan Lights</summary>
		public LightEntity KitchenFanLights => new(_haContext, "light.kitchen_fan_lights");
		///<summary>Kitchen Light</summary>
		public LightEntity KitchenLight => new(_haContext, "light.kitchen_light");
		///<summary>Kitchen Lights 1</summary>
		public LightEntity KitchenLights1 => new(_haContext, "light.kitchen_lights_1");
		///<summary>Kitchen Lights 2</summary>
		public LightEntity KitchenLights2 => new(_haContext, "light.kitchen_lights_2");
		///<summary>LEDs</summary>
		public LightEntity Leds => new(_haContext, "light.leds");
		///<summary>LEDs</summary>
		public LightEntity Leds2 => new(_haContext, "light.leds_2");
		///<summary>Living Room Fan 1 Light</summary>
		public LightEntity LivingRoomFan1Light => new(_haContext, "light.living_room_fan_1_light");
		///<summary>Living Room Fan 2 Bulb 1 level, on_off</summary>
		public LightEntity LivingRoomFan2Bulb1LevelOnOff => new(_haContext, "light.living_room_fan_2_bulb_1_level_on_off");
		///<summary>Living Room Fan 2 Bulb 2 level, on_off</summary>
		public LightEntity LivingRoomFan2Bulb2LevelOnOff => new(_haContext, "light.living_room_fan_2_bulb_2_level_on_off");
		///<summary>Living Room Fan 2 Light</summary>
		public LightEntity LivingRoomFan2Light => new(_haContext, "light.living_room_fan_2_light");
		///<summary>Living Room Fan Bulb 1 level, on_off</summary>
		public LightEntity LivingRoomFanBulb1LevelOnOff => new(_haContext, "light.living_room_fan_bulb_1_level_on_off");
		///<summary>Living Room Fan Bulb 2 level, on_off</summary>
		public LightEntity LivingRoomFanBulb2LevelOnOff => new(_haContext, "light.living_room_fan_bulb_2_level_on_off");
		///<summary>Living Room Fan Lights</summary>
		public LightEntity LivingRoomFanLights => new(_haContext, "light.living_room_fan_lights");
		///<summary>Living Room Lights 1</summary>
		public LightEntity LivingRoomLights1 => new(_haContext, "light.living_room_lights_1");
		///<summary>Living Room Lights 2</summary>
		public LightEntity LivingRoomLights2 => new(_haContext, "light.living_room_lights_2");
		///<summary>Living Room Lights 3</summary>
		public LightEntity LivingRoomLights3 => new(_haContext, "light.living_room_lights_3");
		///<summary>Stairs Light</summary>
		public LightEntity StairsLight => new(_haContext, "light.stairs_light");
		///<summary>Upstairs Bathroom Lights</summary>
		public LightEntity UpstairsBathroomLights => new(_haContext, "light.upstairs_bathroom_lights");
		///<summary>Upstairs Bedroom Light 2</summary>
		public LightEntity UpstairsBedroomLight22 => new(_haContext, "light.upstairs_bedroom_light_2_2");
		///<summary>Upstairs Bedroom Lights 1</summary>
		public LightEntity UpstairsBedroomLights12 => new(_haContext, "light.upstairs_bedroom_lights_1_2");
		///<summary>Upstairs Dressing Room Lights</summary>
		public LightEntity UpstairsDressingRoomLights => new(_haContext, "light.upstairs_dressing_room_lights");
		///<summary>Upstairs Hallway Lights</summary>
		public LightEntity UpstairsHallwayLights => new(_haContext, "light.upstairs_hallway_lights");
		///<summary>Office Lights</summary>
		public LightEntity UpstairsRoomLights => new(_haContext, "light.upstairs_room_lights");
		///<summary>TV Backlight</summary>
		public LightEntity Wled => new(_haContext, "light.wled");
		///<summary>Stairs Light</summary>
		public LightEntity YeelightColor0x0000000007eca741 => new(_haContext, "light.yeelight_color_0x0000000007eca741");
		///<summary>yeelight_color2_04cf8ca01843</summary>
		public LightEntity YeelightColor204cf8ca01843 => new(_haContext, "light.yeelight_color2_04cf8ca01843");
	}

	public partial class LockEntities
	{
		private readonly IHaContext _haContext;
		public LockEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Front Door Lock</summary>
		public LockEntity FrontDoorLock => new(_haContext, "lock.front_door_lock");
	}

	public partial class MediaPlayerEntities
	{
		private readonly IHaContext _haContext;
		public MediaPlayerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Alejandro's Hamburg</summary>
		public MediaPlayerEntity AlejandroSHamburg => new(_haContext, "media_player.alejandro_s_hamburg");
		public MediaPlayerEntity BrowserMod063d0b07E5cea70a => new(_haContext, "media_player.browser_mod_063d0b07_e5cea70a");
		public MediaPlayerEntity BrowserMod0e201c89E23fa539 => new(_haContext, "media_player.browser_mod_0e201c89_e23fa539");
		public MediaPlayerEntity BrowserMod6efffaa141a969ff => new(_haContext, "media_player.browser_mod_6efffaa1_41a969ff");
		public MediaPlayerEntity BrowserMod9460d8465b19fe48 => new(_haContext, "media_player.browser_mod_9460d846_5b19fe48");
		public MediaPlayerEntity BrowserMod9b6ad72d195bec2a => new(_haContext, "media_player.browser_mod_9b6ad72d_195bec2a");
		public MediaPlayerEntity BrowserMod9be5b824F163af78 => new(_haContext, "media_player.browser_mod_9be5b824_f163af78");
		public MediaPlayerEntity BrowserModA818a8e4E6349656 => new(_haContext, "media_player.browser_mod_a818a8e4_e6349656");
		public MediaPlayerEntity BrowserModAae046754a5ec423 => new(_haContext, "media_player.browser_mod_aae04675_4a5ec423");
		public MediaPlayerEntity BrowserModAd49b519Ea6fcb40 => new(_haContext, "media_player.browser_mod_ad49b519_ea6fcb40");
		public MediaPlayerEntity BrowserModB5dfeec6Cf4ff3c6 => new(_haContext, "media_player.browser_mod_b5dfeec6_cf4ff3c6");
		public MediaPlayerEntity BrowserModB8bdae81E55c6373 => new(_haContext, "media_player.browser_mod_b8bdae81_e55c6373");
		public MediaPlayerEntity BrowserModB9707aedC387cf0c => new(_haContext, "media_player.browser_mod_b9707aed_c387cf0c");
		public MediaPlayerEntity BrowserModC8c1e527F1f1f5ee => new(_haContext, "media_player.browser_mod_c8c1e527_f1f1f5ee");
		public MediaPlayerEntity BrowserModDd5fbbad2663f443 => new(_haContext, "media_player.browser_mod_dd5fbbad_2663f443");
		public MediaPlayerEntity BrowserModE90b9e1a23d4c400 => new(_haContext, "media_player.browser_mod_e90b9e1a_23d4c400");
		public MediaPlayerEntity BrowserModF6551325D5308c60 => new(_haContext, "media_player.browser_mod_f6551325_d5308c60");
		///<summary>Cuarto</summary>
		public MediaPlayerEntity Cuarto => new(_haContext, "media_player.cuarto");
		///<summary>Cocina</summary>
		public MediaPlayerEntity EchoDeAlejandro => new(_haContext, "media_player.echo_de_alejandro");
		///<summary>Oficina</summary>
		public MediaPlayerEntity Oficina => new(_haContext, "media_player.oficina");
		///<summary>Roku Streaming Stick+</summary>
		public MediaPlayerEntity RokuYh003j121028 => new(_haContext, "media_player.roku_yh003j121028");
	}

	public partial class NumberEntities
	{
		private readonly IHaContext _haContext;
		public NumberEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bedroom Microphone Level</summary>
		public NumberEntity BedroomMicrophoneLevel => new(_haContext, "number.bedroom_microphone_level");
		///<summary>con ZBT-DIMLight-D0113 1ecf9cfe level on_level</summary>
		public NumberEntity ConZbtDimlightD01131ecf9cfeLevelOnLevel => new(_haContext, "number.con_zbt_dimlight_d0113_1ecf9cfe_level_on_level");
		///<summary>con ZBT-DIMLight-D0113 1ecf9cfe level on_off_transition_time</summary>
		public NumberEntity ConZbtDimlightD01131ecf9cfeLevelOnOffTransitionTime => new(_haContext, "number.con_zbt_dimlight_d0113_1ecf9cfe_level_on_off_transition_time");
		///<summary>con ZBT-DIMLight-D0113 1ecf9cfe level start_up_current_level</summary>
		public NumberEntity ConZbtDimlightD01131ecf9cfeLevelStartUpCurrentLevel => new(_haContext, "number.con_zbt_dimlight_d0113_1ecf9cfe_level_start_up_current_level");
		///<summary>con ZBT-DIMLight-D0113 37e49dfe level on_level</summary>
		public NumberEntity ConZbtDimlightD011337e49dfeLevelOnLevel => new(_haContext, "number.con_zbt_dimlight_d0113_37e49dfe_level_on_level");
		///<summary>con ZBT-DIMLight-D0113 37e49dfe level on_off_transition_time</summary>
		public NumberEntity ConZbtDimlightD011337e49dfeLevelOnOffTransitionTime => new(_haContext, "number.con_zbt_dimlight_d0113_37e49dfe_level_on_off_transition_time");
		///<summary>con ZBT-DIMLight-D0113 37e49dfe level start_up_current_level</summary>
		public NumberEntity ConZbtDimlightD011337e49dfeLevelStartUpCurrentLevel => new(_haContext, "number.con_zbt_dimlight_d0113_37e49dfe_level_start_up_current_level");
		///<summary>con ZBT-DIMLight-D0113 76e19dfe level on_level</summary>
		public NumberEntity ConZbtDimlightD011376e19dfeLevelOnLevel => new(_haContext, "number.con_zbt_dimlight_d0113_76e19dfe_level_on_level");
		///<summary>con ZBT-DIMLight-D0113 76e19dfe level on_off_transition_time</summary>
		public NumberEntity ConZbtDimlightD011376e19dfeLevelOnOffTransitionTime => new(_haContext, "number.con_zbt_dimlight_d0113_76e19dfe_level_on_off_transition_time");
		///<summary>con ZBT-DIMLight-D0113 76e19dfe level start_up_current_level</summary>
		public NumberEntity ConZbtDimlightD011376e19dfeLevelStartUpCurrentLevel => new(_haContext, "number.con_zbt_dimlight_d0113_76e19dfe_level_start_up_current_level");
		///<summary>con ZBT-DIMLight-D0113 91b9b2fe level on_level</summary>
		public NumberEntity ConZbtDimlightD011391b9b2feLevelOnLevel => new(_haContext, "number.con_zbt_dimlight_d0113_91b9b2fe_level_on_level");
		///<summary>con ZBT-DIMLight-D0113 91b9b2fe level on_off_transition_time</summary>
		public NumberEntity ConZbtDimlightD011391b9b2feLevelOnOffTransitionTime => new(_haContext, "number.con_zbt_dimlight_d0113_91b9b2fe_level_on_off_transition_time");
		///<summary>con ZBT-DIMLight-D0113 91b9b2fe level start_up_current_level</summary>
		public NumberEntity ConZbtDimlightD011391b9b2feLevelStartUpCurrentLevel => new(_haContext, "number.con_zbt_dimlight_d0113_91b9b2fe_level_start_up_current_level");
		///<summary>con ZBT-DIMLight-D0113 bdde9dfe level on_level</summary>
		public NumberEntity ConZbtDimlightD0113Bdde9dfeLevelOnLevel => new(_haContext, "number.con_zbt_dimlight_d0113_bdde9dfe_level_on_level");
		///<summary>con ZBT-DIMLight-D0113 bdde9dfe level on_off_transition_time</summary>
		public NumberEntity ConZbtDimlightD0113Bdde9dfeLevelOnOffTransitionTime => new(_haContext, "number.con_zbt_dimlight_d0113_bdde9dfe_level_on_off_transition_time");
		///<summary>con ZBT-DIMLight-D0113 bdde9dfe level start_up_current_level</summary>
		public NumberEntity ConZbtDimlightD0113Bdde9dfeLevelStartUpCurrentLevel => new(_haContext, "number.con_zbt_dimlight_d0113_bdde9dfe_level_start_up_current_level");
		///<summary>con ZBT-DIMLight-D0113 e4f7bcfe level on_level</summary>
		public NumberEntity ConZbtDimlightD0113E4f7bcfeLevelOnLevel => new(_haContext, "number.con_zbt_dimlight_d0113_e4f7bcfe_level_on_level");
		///<summary>con ZBT-DIMLight-D0113 e4f7bcfe level on_off_transition_time</summary>
		public NumberEntity ConZbtDimlightD0113E4f7bcfeLevelOnOffTransitionTime => new(_haContext, "number.con_zbt_dimlight_d0113_e4f7bcfe_level_on_off_transition_time");
		///<summary>con ZBT-DIMLight-D0113 e4f7bcfe level start_up_current_level</summary>
		public NumberEntity ConZbtDimlightD0113E4f7bcfeLevelStartUpCurrentLevel => new(_haContext, "number.con_zbt_dimlight_d0113_e4f7bcfe_level_start_up_current_level");
		///<summary>Downstairs Room Microphone Level</summary>
		public NumberEntity DownstairsRoomMicrophoneLevel => new(_haContext, "number.downstairs_room_microphone_level");
		///<summary>G3 Flex Wide Dynamic Range</summary>
		public NumberEntity G3FlexWideDynamicRange2 => new(_haContext, "number.g3_flex_wide_dynamic_range_2");
		///<summary>G3 Flex Wide Dynamic Range</summary>
		public NumberEntity G3FlexWideDynamicRange3 => new(_haContext, "number.g3_flex_wide_dynamic_range_3");
		///<summary>Garage Microphone Level</summary>
		public NumberEntity GarageMicrophoneLevel => new(_haContext, "number.garage_microphone_level");
		///<summary>Living Room Microphone Level</summary>
		public NumberEntity LivingRoomMicrophoneLevel => new(_haContext, "number.living_room_microphone_level");
		///<summary>Office Microphone Level</summary>
		public NumberEntity OfficeMicrophoneLevel => new(_haContext, "number.office_microphone_level");
		///<summary>Patio Microphone Level</summary>
		public NumberEntity PatioMicrophoneLevel => new(_haContext, "number.patio_microphone_level");
		///<summary>WLED Intensity</summary>
		public NumberEntity WledIntensity => new(_haContext, "number.wled_intensity");
		///<summary>WLED Speed</summary>
		public NumberEntity WledSpeed => new(_haContext, "number.wled_speed");
	}

	public partial class PersistentNotificationEntities
	{
		private readonly IHaContext _haContext;
		public PersistentNotificationEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Login attempt failed</summary>
		public PersistentNotificationEntity HttpLogin => new(_haContext, "persistent_notification.http_login");
	}

	public partial class PersonEntities
	{
		private readonly IHaContext _haContext;
		public PersonEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Areks</summary>
		public PersonEntity Areks => new(_haContext, "person.areks");
		///<summary>Hildr</summary>
		public PersonEntity Hildr => new(_haContext, "person.hildr");
	}

	public partial class ScriptEntities
	{
		private readonly IHaContext _haContext;
		public ScriptEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Media Player Gradual Volume Increase</summary>
		public ScriptEntity MediaPlayerGradualVolumeIncrease => new(_haContext, "script.media_player_gradual_volume_increase");
		///<summary>Noop</summary>
		public ScriptEntity Noop => new(_haContext, "script.noop");
	}

	public partial class SelectEntities
	{
		private readonly IHaContext _haContext;
		public SelectEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>aqara lumi.motion.ac01 e9284d00 opple_cluster approach_distance</summary>
		public SelectEntity AqaraLumiMotionAc01E9284d00OppleClusterApproachDistance => new(_haContext, "select.aqara_lumi_motion_ac01_e9284d00_opple_cluster_approach_distance");
		///<summary>aqara lumi.motion.ac01 e9284d00 opple_cluster monitoring_mode</summary>
		public SelectEntity AqaraLumiMotionAc01E9284d00OppleClusterMonitoringMode => new(_haContext, "select.aqara_lumi_motion_ac01_e9284d00_opple_cluster_monitoring_mode");
		///<summary>aqara lumi.motion.ac01 e9284d00 opple_cluster motion_sensitivity</summary>
		public SelectEntity AqaraLumiMotionAc01E9284d00OppleClusterMotionSensitivity => new(_haContext, "select.aqara_lumi_motion_ac01_e9284d00_opple_cluster_motion_sensitivity");
		///<summary>Bedroom Infrared Mode</summary>
		public SelectEntity BedroomInfraredMode => new(_haContext, "select.bedroom_infrared_mode");
		///<summary>Bedroom Recording Mode</summary>
		public SelectEntity BedroomRecordingMode => new(_haContext, "select.bedroom_recording_mode");
		///<summary>Downstairs Room Infrared Mode</summary>
		public SelectEntity DownstairsRoomInfraredMode => new(_haContext, "select.downstairs_room_infrared_mode");
		///<summary>Downstairs Room Recording Mode</summary>
		public SelectEntity DownstairsRoomRecordingMode => new(_haContext, "select.downstairs_room_recording_mode");
		///<summary>Garage Recording Mode</summary>
		public SelectEntity G3FlexRecordingMode2 => new(_haContext, "select.g3_flex_recording_mode_2");
		///<summary>Patio Recording Mode</summary>
		public SelectEntity G3FlexRecordingMode3 => new(_haContext, "select.g3_flex_recording_mode_3");
		///<summary>Garage Infrared Mode</summary>
		public SelectEntity GarageInfraredMode => new(_haContext, "select.garage_infrared_mode");
		///<summary>Kitchen Fan Light 1 on_off StartUpOnOff</summary>
		public SelectEntity KitchenFanLight1OnOffStartuponoff => new(_haContext, "select.kitchen_fan_light_1_on_off_startuponoff");
		///<summary>Kitchen Fan Light 2 on_off StartUpOnOff</summary>
		public SelectEntity KitchenFanLight2OnOffStartuponoff => new(_haContext, "select.kitchen_fan_light_2_on_off_startuponoff");
		///<summary>Living Room Fan 2 Bulb 1 on_off StartUpOnOff</summary>
		public SelectEntity LivingRoomFan2Bulb1OnOffStartuponoff => new(_haContext, "select.living_room_fan_2_bulb_1_on_off_startuponoff");
		///<summary>Living Room Fan 2 Bulb 2 on_off StartUpOnOff</summary>
		public SelectEntity LivingRoomFan2Bulb2OnOffStartuponoff => new(_haContext, "select.living_room_fan_2_bulb_2_on_off_startuponoff");
		///<summary>Living Room Fan Bulb 1 on_off StartUpOnOff</summary>
		public SelectEntity LivingRoomFanBulb1OnOffStartuponoff => new(_haContext, "select.living_room_fan_bulb_1_on_off_startuponoff");
		///<summary>Living Room Fan Bulb 2 on_off StartUpOnOff</summary>
		public SelectEntity LivingRoomFanBulb2OnOffStartuponoff => new(_haContext, "select.living_room_fan_bulb_2_on_off_startuponoff");
		///<summary>Living Room Infrared Mode</summary>
		public SelectEntity LivingRoomInfraredMode => new(_haContext, "select.living_room_infrared_mode");
		///<summary>Living Room Recording Mode</summary>
		public SelectEntity LivingRoomRecordingMode => new(_haContext, "select.living_room_recording_mode");
		///<summary>Office Infrared Mode</summary>
		public SelectEntity OfficeInfraredMode => new(_haContext, "select.office_infrared_mode");
		///<summary>Office Recording Mode</summary>
		public SelectEntity OfficeRecordingMode => new(_haContext, "select.office_recording_mode");
		///<summary>Patio Infrared Mode</summary>
		public SelectEntity PatioInfraredMode => new(_haContext, "select.patio_infrared_mode");
		///<summary>WLED Color Palette</summary>
		public SelectEntity WledColorPalette => new(_haContext, "select.wled_color_palette");
		///<summary>WLED Live Override</summary>
		public SelectEntity WledLiveOverride => new(_haContext, "select.wled_live_override");
		///<summary>WLED Playlist</summary>
		public SelectEntity WledPlaylist => new(_haContext, "select.wled_playlist");
		///<summary>WLED Preset</summary>
		public SelectEntity WledPreset => new(_haContext, "select.wled_preset");
	}

	public partial class SensorEntities
	{
		private readonly IHaContext _haContext;
		public SensorEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Alejandro's Hamburg next Alarm</summary>
		public SensorEntity AlejandroSHamburgNextAlarm => new(_haContext, "sensor.alejandro_s_hamburg_next_alarm");
		///<summary>Alejandro's Hamburg next Reminder</summary>
		public SensorEntity AlejandroSHamburgNextReminder => new(_haContext, "sensor.alejandro_s_hamburg_next_reminder");
		///<summary>Alejandro's Hamburg next Timer</summary>
		public SensorEntity AlejandroSHamburgNextTimer => new(_haContext, "sensor.alejandro_s_hamburg_next_timer");
		public SensorEntity BrowserMod063d0b07E5cea70a => new(_haContext, "sensor.browser_mod_063d0b07_e5cea70a");
		public SensorEntity BrowserMod0e201c89E23fa539 => new(_haContext, "sensor.browser_mod_0e201c89_e23fa539");
		public SensorEntity BrowserMod6efffaa141a969ff => new(_haContext, "sensor.browser_mod_6efffaa1_41a969ff");
		public SensorEntity BrowserMod9460d8465b19fe48 => new(_haContext, "sensor.browser_mod_9460d846_5b19fe48");
		public SensorEntity BrowserMod9b6ad72d195bec2a => new(_haContext, "sensor.browser_mod_9b6ad72d_195bec2a");
		public SensorEntity BrowserMod9be5b824F163af78 => new(_haContext, "sensor.browser_mod_9be5b824_f163af78");
		public SensorEntity BrowserModA818a8e4E6349656 => new(_haContext, "sensor.browser_mod_a818a8e4_e6349656");
		public SensorEntity BrowserModAae046754a5ec423 => new(_haContext, "sensor.browser_mod_aae04675_4a5ec423");
		public SensorEntity BrowserModAd49b519Ea6fcb40 => new(_haContext, "sensor.browser_mod_ad49b519_ea6fcb40");
		public SensorEntity BrowserModB5dfeec6Cf4ff3c6 => new(_haContext, "sensor.browser_mod_b5dfeec6_cf4ff3c6");
		public SensorEntity BrowserModB8bdae81E55c6373 => new(_haContext, "sensor.browser_mod_b8bdae81_e55c6373");
		public SensorEntity BrowserModB9707aedC387cf0c => new(_haContext, "sensor.browser_mod_b9707aed_c387cf0c");
		public SensorEntity BrowserModC8c1e527F1f1f5ee => new(_haContext, "sensor.browser_mod_c8c1e527_f1f1f5ee");
		public SensorEntity BrowserModDd5fbbad2663f443 => new(_haContext, "sensor.browser_mod_dd5fbbad_2663f443");
		public SensorEntity BrowserModE90b9e1a23d4c400 => new(_haContext, "sensor.browser_mod_e90b9e1a_23d4c400");
		public SensorEntity BrowserModF6551325D5308c60 => new(_haContext, "sensor.browser_mod_f6551325_d5308c60");
		///<summary>Cuarto next Alarm</summary>
		public SensorEntity CuartoNextAlarm => new(_haContext, "sensor.cuarto_next_alarm");
		///<summary>Cuarto next Reminder</summary>
		public SensorEntity CuartoNextReminder => new(_haContext, "sensor.cuarto_next_reminder");
		///<summary>Cuarto next Timer</summary>
		public SensorEntity CuartoNextTimer => new(_haContext, "sensor.cuarto_next_timer");
		///<summary>Dream Machine Pro Uptime</summary>
		public SensorEntity DreamMachineProUptime => new(_haContext, "sensor.dream_machine_pro_uptime");
		///<summary>Cocina next Alarm</summary>
		public SensorEntity EchoDeAlejandroNextAlarm => new(_haContext, "sensor.echo_de_alejandro_next_alarm");
		///<summary>Cocina next Reminder</summary>
		public SensorEntity EchoDeAlejandroNextReminder => new(_haContext, "sensor.echo_de_alejandro_next_reminder");
		///<summary>Cocina next Timer</summary>
		public SensorEntity EchoDeAlejandroNextTimer => new(_haContext, "sensor.echo_de_alejandro_next_timer");
		///<summary>EDCMXENLT0251 Active Audio Input</summary>
		public SensorEntity Edcmxenlt0251ActiveAudioInput => new(_haContext, "sensor.edcmxenlt0251_active_audio_input");
		///<summary>EDCMXENLT0251 Active Audio Output</summary>
		public SensorEntity Edcmxenlt0251ActiveAudioOutput => new(_haContext, "sensor.edcmxenlt0251_active_audio_output");
		///<summary>EDCMXENLT0251 Active Camera</summary>
		public SensorEntity Edcmxenlt0251ActiveCamera => new(_haContext, "sensor.edcmxenlt0251_active_camera");
		///<summary>EDCMXENLT0251 BSSID</summary>
		public SensorEntity Edcmxenlt0251Bssid => new(_haContext, "sensor.edcmxenlt0251_bssid");
		///<summary>EDCMXENLT0251 Connection Type</summary>
		public SensorEntity Edcmxenlt0251ConnectionType => new(_haContext, "sensor.edcmxenlt0251_connection_type");
		///<summary>EDCMXENLT0251 Displays</summary>
		public SensorEntity Edcmxenlt0251Displays => new(_haContext, "sensor.edcmxenlt0251_displays");
		///<summary>EDCMXENLT0251 Frontmost App</summary>
		public SensorEntity Edcmxenlt0251FrontmostApp => new(_haContext, "sensor.edcmxenlt0251_frontmost_app");
		///<summary>EDCMXENLT0251 Geocoded Location</summary>
		public SensorEntity Edcmxenlt0251GeocodedLocation => new(_haContext, "sensor.edcmxenlt0251_geocoded_location");
		///<summary>EDCMXENLT0251 Internal Battery State</summary>
		public SensorEntity Edcmxenlt0251InternalBatteryState => new(_haContext, "sensor.edcmxenlt0251_internal_battery_state");
		///<summary>EDCMXENLT0251 Last Update Trigger</summary>
		public SensorEntity Edcmxenlt0251LastUpdateTrigger => new(_haContext, "sensor.edcmxenlt0251_last_update_trigger");
		///<summary>EDCMXENLT0251 Primary Display ID</summary>
		public SensorEntity Edcmxenlt0251PrimaryDisplayId => new(_haContext, "sensor.edcmxenlt0251_primary_display_id");
		///<summary>EDCMXENLT0251 Primary Display Name</summary>
		public SensorEntity Edcmxenlt0251PrimaryDisplayName => new(_haContext, "sensor.edcmxenlt0251_primary_display_name");
		///<summary>EDCMXENLT0251 SSID</summary>
		public SensorEntity Edcmxenlt0251Ssid => new(_haContext, "sensor.edcmxenlt0251_ssid");
		///<summary>Freyja Battery State</summary>
		public SensorEntity FreyjaBatteryState => new(_haContext, "sensor.freyja_battery_state");
		///<summary>Freyja Detected Activity</summary>
		public SensorEntity FreyjaDetectedActivity => new(_haContext, "sensor.freyja_detected_activity");
		///<summary>Freyja Geocoded Location</summary>
		public SensorEntity FreyjaGeocodedLocation => new(_haContext, "sensor.freyja_geocoded_location");
		///<summary>Freyja WiFi Connection</summary>
		public SensorEntity FreyjaWifiConnection => new(_haContext, "sensor.freyja_wifi_connection");
		public SensorEntity FrontDoorCallstatus => new(_haContext, "sensor.front_door_callstatus");
		///<summary>front_door_door</summary>
		public SensorEntity FrontDoorDoor => new(_haContext, "sensor.front_door_door");
		public SensorEntity FrontDoorMotion => new(_haContext, "sensor.front_door_motion");
		///<summary>Last boot</summary>
		public SensorEntity LastBoot => new(_haContext, "sensor.last_boot");
		///<summary>NostalgiaDrive Battery State</summary>
		public SensorEntity NostalgiadriveBatteryState2 => new(_haContext, "sensor.nostalgiadrive_battery_state_2");
		///<summary>NostalgiaDrive Charger Type</summary>
		public SensorEntity NostalgiadriveChargerType2 => new(_haContext, "sensor.nostalgiadrive_charger_type_2");
		///<summary>NostalgiaDrive Detected Activity</summary>
		public SensorEntity NostalgiadriveDetectedActivity => new(_haContext, "sensor.nostalgiadrive_detected_activity");
		///<summary>NostalgiaDrive Geocoded Location</summary>
		public SensorEntity NostalgiadriveGeocodedLocation => new(_haContext, "sensor.nostalgiadrive_geocoded_location");
		///<summary>NostalgiaDrive WiFi Connection</summary>
		public SensorEntity NostalgiadriveWifiConnection => new(_haContext, "sensor.nostalgiadrive_wifi_connection");
		///<summary>Oficina next Alarm</summary>
		public SensorEntity OficinaNextAlarm => new(_haContext, "sensor.oficina_next_alarm");
		///<summary>Oficina next Reminder</summary>
		public SensorEntity OficinaNextReminder => new(_haContext, "sensor.oficina_next_reminder");
		///<summary>Oficina next Timer</summary>
		public SensorEntity OficinaNextTimer => new(_haContext, "sensor.oficina_next_timer");
		///<summary>RHOAIAS_lastactive</summary>
		public SensorEntity RhoaiasLastactive => new(_haContext, "sensor.rhoaias_lastactive");
		///<summary>WLED LED Count</summary>
		public SensorEntity WledLedCount => new(_haContext, "sensor.wled_led_count");
		///<summary>aqara lumi.motion.ac01 e9284d00 device_temperature</summary>
		public NumericSensorEntity AqaraLumiMotionAc01E9284d00DeviceTemperature => new(_haContext, "sensor.aqara_lumi_motion_ac01_e9284d00_device_temperature");
		///<summary>Bedroom Disk Write Rate</summary>
		public NumericSensorEntity BedroomDiskWriteRate => new(_haContext, "sensor.bedroom_disk_write_rate");
		///<summary>Bedroom Storage Used</summary>
		public NumericSensorEntity BedroomStorageUsed => new(_haContext, "sensor.bedroom_storage_used");
		///<summary>Cpu1 Inference Speed</summary>
		public NumericSensorEntity Cpu1InferenceSpeed => new(_haContext, "sensor.cpu1_inference_speed");
		///<summary>Cpu2 Inference Speed</summary>
		public NumericSensorEntity Cpu2InferenceSpeed => new(_haContext, "sensor.cpu2_inference_speed");
		///<summary>Detection Fps</summary>
		public NumericSensorEntity DetectionFps => new(_haContext, "sensor.detection_fps");
		///<summary>Disk use (percent) /</summary>
		public NumericSensorEntity DiskUsePercent => new(_haContext, "sensor.disk_use_percent");
		///<summary>Downstairs Room Disk Write Rate</summary>
		public NumericSensorEntity DownstairsRoomDiskWriteRate => new(_haContext, "sensor.downstairs_room_disk_write_rate");
		///<summary>Downstairs Room Storage Used</summary>
		public NumericSensorEntity DownstairsRoomStorageUsed => new(_haContext, "sensor.downstairs_room_storage_used");
		///<summary>Dream Machine Pro Recording Capacity</summary>
		public NumericSensorEntity DreamMachineProRecordingCapacity => new(_haContext, "sensor.dream_machine_pro_recording_capacity");
		///<summary>Dream Machine Pro Resolution: 4K Video</summary>
		public NumericSensorEntity DreamMachineProResolution4kVideo => new(_haContext, "sensor.dream_machine_pro_resolution_4k_video");
		///<summary>Dream Machine Pro Resolution: Free Space</summary>
		public NumericSensorEntity DreamMachineProResolutionFreeSpace => new(_haContext, "sensor.dream_machine_pro_resolution_free_space");
		///<summary>Dream Machine Pro Resolution: Hd Video</summary>
		public NumericSensorEntity DreamMachineProResolutionHdVideo => new(_haContext, "sensor.dream_machine_pro_resolution_hd_video");
		///<summary>Dream Machine Pro Storage Utilization</summary>
		public NumericSensorEntity DreamMachineProStorageUtilization => new(_haContext, "sensor.dream_machine_pro_storage_utilization");
		///<summary>Dream Machine Pro Type: Continuous Video</summary>
		public NumericSensorEntity DreamMachineProTypeContinuousVideo => new(_haContext, "sensor.dream_machine_pro_type_continuous_video");
		///<summary>Dream Machine Pro Type: Detections Video</summary>
		public NumericSensorEntity DreamMachineProTypeDetectionsVideo => new(_haContext, "sensor.dream_machine_pro_type_detections_video");
		///<summary>Dream Machine Pro Type: Timelapse Video</summary>
		public NumericSensorEntity DreamMachineProTypeTimelapseVideo => new(_haContext, "sensor.dream_machine_pro_type_timelapse_video");
		///<summary>EDCMXENLT0251 Internal Battery Level</summary>
		public NumericSensorEntity Edcmxenlt0251InternalBatteryLevel => new(_haContext, "sensor.edcmxenlt0251_internal_battery_level");
		///<summary>EDCMXENLT0251 Storage</summary>
		public NumericSensorEntity Edcmxenlt0251Storage => new(_haContext, "sensor.edcmxenlt0251_storage");
		///<summary>Entrance Camera Fps</summary>
		public NumericSensorEntity EntranceCameraFps => new(_haContext, "sensor.entrance_camera_fps");
		///<summary>Entrance Detection Fps</summary>
		public NumericSensorEntity EntranceDetectionFps => new(_haContext, "sensor.entrance_detection_fps");
		///<summary>Entrance Person</summary>
		public NumericSensorEntity EntrancePerson => new(_haContext, "sensor.entrance_person");
		///<summary>Entrance Process Fps</summary>
		public NumericSensorEntity EntranceProcessFps => new(_haContext, "sensor.entrance_process_fps");
		///<summary>Entrance Skipped Fps</summary>
		public NumericSensorEntity EntranceSkippedFps => new(_haContext, "sensor.entrance_skipped_fps");
		///<summary>Freyja Battery Level</summary>
		public NumericSensorEntity FreyjaBatteryLevel => new(_haContext, "sensor.freyja_battery_level");
		///<summary>Freyja Battery Temperature</summary>
		public NumericSensorEntity FreyjaBatteryTemperature => new(_haContext, "sensor.freyja_battery_temperature");
		///<summary>Front Door Camera Fps</summary>
		public NumericSensorEntity FrontDoorCameraFps => new(_haContext, "sensor.front_door_camera_fps");
		///<summary>Front Door Detection Fps</summary>
		public NumericSensorEntity FrontDoorDetectionFps => new(_haContext, "sensor.front_door_detection_fps");
		///<summary>Front Door Person</summary>
		public NumericSensorEntity FrontDoorPerson => new(_haContext, "sensor.front_door_person");
		///<summary>Front Door Process Fps</summary>
		public NumericSensorEntity FrontDoorProcessFps => new(_haContext, "sensor.front_door_process_fps");
		///<summary>Front Door Skipped Fps</summary>
		public NumericSensorEntity FrontDoorSkippedFps => new(_haContext, "sensor.front_door_skipped_fps");
		///<summary>Garage Disk Write Rate</summary>
		public NumericSensorEntity G3FlexDiskWriteRate2 => new(_haContext, "sensor.g3_flex_disk_write_rate_2");
		///<summary>Patio Disk Write Rate</summary>
		public NumericSensorEntity G3FlexDiskWriteRate3 => new(_haContext, "sensor.g3_flex_disk_write_rate_3");
		///<summary>Garage Storage Used</summary>
		public NumericSensorEntity G3FlexStorageUsed2 => new(_haContext, "sensor.g3_flex_storage_used_2");
		///<summary>Patio Storage Used</summary>
		public NumericSensorEntity G3FlexStorageUsed3 => new(_haContext, "sensor.g3_flex_storage_used_3");
		///<summary>Gustavito Battery Level</summary>
		public NumericSensorEntity GustavitoBatteryLevel => new(_haContext, "sensor.gustavito_battery_level");
		///<summary>hacs</summary>
		public NumericSensorEntity Hacs => new(_haContext, "sensor.hacs");
		///<summary>Living Room Disk Write Rate</summary>
		public NumericSensorEntity LivingRoomDiskWriteRate => new(_haContext, "sensor.living_room_disk_write_rate");
		///<summary>Living Room Storage Used</summary>
		public NumericSensorEntity LivingRoomStorageUsed => new(_haContext, "sensor.living_room_storage_used");
		///<summary>LUMI lumi.sensor_magnet.aq2 25aae207 device_temperature</summary>
		public NumericSensorEntity LumiLumiSensorMagnetAq225aae207DeviceTemperature => new(_haContext, "sensor.lumi_lumi_sensor_magnet_aq2_25aae207_device_temperature");
		///<summary>LUMI lumi.sensor_magnet.aq2 25aae207 power</summary>
		public NumericSensorEntity LumiLumiSensorMagnetAq225aae207Power => new(_haContext, "sensor.lumi_lumi_sensor_magnet_aq2_25aae207_power");
		///<summary>LUMI lumi.sensor_magnet.aq2 500af807 device_temperature</summary>
		public NumericSensorEntity LumiLumiSensorMagnetAq2500af807DeviceTemperature => new(_haContext, "sensor.lumi_lumi_sensor_magnet_aq2_500af807_device_temperature");
		///<summary>Downstairs Bathroom Door Sensor Battery</summary>
		public NumericSensorEntity LumiLumiSensorMagnetAq2500af807Power => new(_haContext, "sensor.lumi_lumi_sensor_magnet_aq2_500af807_power");
		///<summary>LUMI lumi.sensor_magnet.aq2 9862e007 device_temperature</summary>
		public NumericSensorEntity LumiLumiSensorMagnetAq29862e007DeviceTemperature => new(_haContext, "sensor.lumi_lumi_sensor_magnet_aq2_9862e007_device_temperature");
		///<summary>Dressing Room Door Sensor Battery</summary>
		public NumericSensorEntity LumiLumiSensorMagnetAq29862e007Power => new(_haContext, "sensor.lumi_lumi_sensor_magnet_aq2_9862e007_power");
		///<summary>LUMI lumi.sensor_magnet.aq2 b194e307 device_temperature</summary>
		public NumericSensorEntity LumiLumiSensorMagnetAq2B194e307DeviceTemperature => new(_haContext, "sensor.lumi_lumi_sensor_magnet_aq2_b194e307_device_temperature");
		///<summary>Main Bathroom Sensor Battery</summary>
		public NumericSensorEntity LumiLumiSensorMagnetAq2B194e307Power => new(_haContext, "sensor.lumi_lumi_sensor_magnet_aq2_b194e307_power");
		///<summary>LUMI lumi.sensor_magnet.aq2 c770e007 device_temperature</summary>
		public NumericSensorEntity LumiLumiSensorMagnetAq2C770e007DeviceTemperature => new(_haContext, "sensor.lumi_lumi_sensor_magnet_aq2_c770e007_device_temperature");
		///<summary>Bedroom Secondary Window Sensor Battery</summary>
		public NumericSensorEntity LumiLumiSensorMagnetAq2C770e007Power => new(_haContext, "sensor.lumi_lumi_sensor_magnet_aq2_c770e007_power");
		///<summary>Bedroom Main Window Sensor Battery</summary>
		public NumericSensorEntity LumiLumiSensorMagnetAq2D221e307Power => new(_haContext, "sensor.lumi_lumi_sensor_magnet_aq2_d221e307_power");
		///<summary>Bedroom Main Window device_temperature</summary>
		public NumericSensorEntity LumiLumiSensorMagnetAq2DeviceTemperature => new(_haContext, "sensor.lumi_lumi_sensor_magnet_aq2_device_temperature");
		///<summary>LUMI lumi.sensor_magnet.aq2 e370e007 device_temperature</summary>
		public NumericSensorEntity LumiLumiSensorMagnetAq2E370e007DeviceTemperature => new(_haContext, "sensor.lumi_lumi_sensor_magnet_aq2_e370e007_device_temperature");
		///<summary>Sliding Door Sensor Battery</summary>
		public NumericSensorEntity LumiLumiSensorMagnetAq2E370e007Power => new(_haContext, "sensor.lumi_lumi_sensor_magnet_aq2_e370e007_power");
		///<summary>LUMI lumi.sensor_magnet.aq2 fa09e307 device_temperature</summary>
		public NumericSensorEntity LumiLumiSensorMagnetAq2Fa09e307DeviceTemperature => new(_haContext, "sensor.lumi_lumi_sensor_magnet_aq2_fa09e307_device_temperature");
		///<summary>Main Door Sensor Power</summary>
		public NumericSensorEntity LumiLumiSensorMagnetAq2Power => new(_haContext, "sensor.lumi_lumi_sensor_magnet_aq2_power");
		///<summary>LUMI lumi.sensor_motion.aq2 25c1ec07 device_temperature</summary>
		public NumericSensorEntity LumiLumiSensorMotionAq225c1ec07DeviceTemperature => new(_haContext, "sensor.lumi_lumi_sensor_motion_aq2_25c1ec07_device_temperature");
		///<summary>LUMI lumi.sensor_motion.aq2 25c1ec07 illuminance</summary>
		public NumericSensorEntity LumiLumiSensorMotionAq225c1ec07Illuminance => new(_haContext, "sensor.lumi_lumi_sensor_motion_aq2_25c1ec07_illuminance");
		///<summary>LUMI lumi.sensor_motion.aq2 25c1ec07 power</summary>
		public NumericSensorEntity LumiLumiSensorMotionAq225c1ec07Power => new(_haContext, "sensor.lumi_lumi_sensor_motion_aq2_25c1ec07_power");
		///<summary>LUMI lumi.sensor_motion.aq2 dc4ded07 device_temperature</summary>
		public NumericSensorEntity LumiLumiSensorMotionAq2Dc4ded07DeviceTemperature => new(_haContext, "sensor.lumi_lumi_sensor_motion_aq2_dc4ded07_device_temperature");
		///<summary>LUMI lumi.sensor_motion.aq2 dc4ded07 illuminance</summary>
		public NumericSensorEntity LumiLumiSensorMotionAq2Dc4ded07Illuminance => new(_haContext, "sensor.lumi_lumi_sensor_motion_aq2_dc4ded07_illuminance");
		///<summary>LUMI lumi.sensor_motion.aq2 dc4ded07 power</summary>
		public NumericSensorEntity LumiLumiSensorMotionAq2Dc4ded07Power => new(_haContext, "sensor.lumi_lumi_sensor_motion_aq2_dc4ded07_power");
		///<summary>Kitchen Motion Sensor device_temperature</summary>
		public NumericSensorEntity LumiLumiSensorMotionAq2DeviceTemperature => new(_haContext, "sensor.lumi_lumi_sensor_motion_aq2_device_temperature");
		///<summary>Kitchen Motion Sensor illuminance</summary>
		public NumericSensorEntity LumiLumiSensorMotionAq2Illuminance => new(_haContext, "sensor.lumi_lumi_sensor_motion_aq2_illuminance");
		///<summary>Kitchen Motion Sensor power</summary>
		public NumericSensorEntity LumiLumiSensorMotionAq2Power => new(_haContext, "sensor.lumi_lumi_sensor_motion_aq2_power");
		///<summary>Guest Room Humidity Sensor</summary>
		public NumericSensorEntity LumiLumiWeather1a7aed07Humidity => new(_haContext, "sensor.lumi_lumi_weather_1a7aed07_humidity");
		///<summary>LUMI lumi.weather 1a7aed07 power</summary>
		public NumericSensorEntity LumiLumiWeather1a7aed07Power => new(_haContext, "sensor.lumi_lumi_weather_1a7aed07_power");
		///<summary>Guest Room Pressure Sensor</summary>
		public NumericSensorEntity LumiLumiWeather1a7aed07Pressure => new(_haContext, "sensor.lumi_lumi_weather_1a7aed07_pressure");
		///<summary>Guest Room Temperature Sensor</summary>
		public NumericSensorEntity LumiLumiWeather1a7aed07Temperature => new(_haContext, "sensor.lumi_lumi_weather_1a7aed07_temperature");
		///<summary>Downstairs Bathroom Humidity Sensor</summary>
		public NumericSensorEntity LumiLumiWeather2c86e407Humidity => new(_haContext, "sensor.lumi_lumi_weather_2c86e407_humidity");
		///<summary>LUMI lumi.weather 2c86e407 power</summary>
		public NumericSensorEntity LumiLumiWeather2c86e407Power => new(_haContext, "sensor.lumi_lumi_weather_2c86e407_power");
		///<summary>Downstairs Bathroom Pressure Sensor</summary>
		public NumericSensorEntity LumiLumiWeather2c86e407Pressure => new(_haContext, "sensor.lumi_lumi_weather_2c86e407_pressure");
		///<summary>Downstairs Bathroom Temperature Sensor</summary>
		public NumericSensorEntity LumiLumiWeather2c86e407Temperature => new(_haContext, "sensor.lumi_lumi_weather_2c86e407_temperature");
		///<summary>Dressing Room Humidity Sensor</summary>
		public NumericSensorEntity LumiLumiWeather3872ed07Humidity => new(_haContext, "sensor.lumi_lumi_weather_3872ed07_humidity");
		///<summary>LUMI lumi.weather 3872ed07 power</summary>
		public NumericSensorEntity LumiLumiWeather3872ed07Power => new(_haContext, "sensor.lumi_lumi_weather_3872ed07_power");
		///<summary>Dressing Room Pressure Sensor</summary>
		public NumericSensorEntity LumiLumiWeather3872ed07Pressure => new(_haContext, "sensor.lumi_lumi_weather_3872ed07_pressure");
		///<summary>Dressing Room Temperature Sensor</summary>
		public NumericSensorEntity LumiLumiWeather3872ed07Temperature => new(_haContext, "sensor.lumi_lumi_weather_3872ed07_temperature");
		///<summary>Main Bathroom Humidity Sensor</summary>
		public NumericSensorEntity LumiLumiWeatherHumidity => new(_haContext, "sensor.lumi_lumi_weather_humidity");
		///<summary>Main Bathroom Sensor power</summary>
		public NumericSensorEntity LumiLumiWeatherPower => new(_haContext, "sensor.lumi_lumi_weather_power");
		///<summary>Main Bathroom Pressure Sensor</summary>
		public NumericSensorEntity LumiLumiWeatherPressure => new(_haContext, "sensor.lumi_lumi_weather_pressure");
		///<summary>Main Bathroom Temperature Sensor</summary>
		public NumericSensorEntity LumiLumiWeatherTemperature => new(_haContext, "sensor.lumi_lumi_weather_temperature");
		///<summary>Main Bedroom Temperature</summary>
		public NumericSensorEntity MainBedroomTemperature => new(_haContext, "sensor.main_bedroom_temperature");
		///<summary>Memory use (percent)</summary>
		public NumericSensorEntity MemoryUsePercent => new(_haContext, "sensor.memory_use_percent");
		///<summary>NostalgiaDrive Battery Level</summary>
		public NumericSensorEntity NostalgiadriveBatteryLevel => new(_haContext, "sensor.nostalgiadrive_battery_level");
		///<summary>NostalgiaDrive Battery Temperature</summary>
		public NumericSensorEntity NostalgiadriveBatteryTemperature => new(_haContext, "sensor.nostalgiadrive_battery_temperature");
		///<summary>NostalgiaDrive Bluetooth Connection</summary>
		public NumericSensorEntity NostalgiadriveBluetoothConnection2 => new(_haContext, "sensor.nostalgiadrive_bluetooth_connection_2");
		///<summary>Office Disk Write Rate</summary>
		public NumericSensorEntity OfficeDiskWriteRate => new(_haContext, "sensor.office_disk_write_rate");
		///<summary>Office Storage Used</summary>
		public NumericSensorEntity OfficeStorageUsed => new(_haContext, "sensor.office_storage_used");
		///<summary>Office Temperature</summary>
		public NumericSensorEntity OfficeTemperature => new(_haContext, "sensor.office_temperature");
		///<summary>Processor temperature</summary>
		public NumericSensorEntity ProcessorTemperature => new(_haContext, "sensor.processor_temperature");
		///<summary>Processor use</summary>
		public NumericSensorEntity ProcessorUse => new(_haContext, "sensor.processor_use");
		///<summary>WLED Estimated Current</summary>
		public NumericSensorEntity WledEstimatedCurrent => new(_haContext, "sensor.wled_estimated_current");
		///<summary>WLED Max Current</summary>
		public NumericSensorEntity WledMaxCurrent => new(_haContext, "sensor.wled_max_current");
	}

	public partial class SunEntities
	{
		private readonly IHaContext _haContext;
		public SunEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sun</summary>
		public SunEntity Sun => new(_haContext, "sun.sun");
	}

	public partial class SwitchEntities
	{
		private readonly IHaContext _haContext;
		public SwitchEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Alejandro's Hamburg do not disturb switch</summary>
		public SwitchEntity AlejandroSHamburgDoNotDisturbSwitch => new(_haContext, "switch.alejandro_s_hamburg_do_not_disturb_switch");
		///<summary>Alejandro's Hamburg repeat switch</summary>
		public SwitchEntity AlejandroSHamburgRepeatSwitch => new(_haContext, "switch.alejandro_s_hamburg_repeat_switch");
		///<summary>Alejandro's Hamburg shuffle switch</summary>
		public SwitchEntity AlejandroSHamburgShuffleSwitch => new(_haContext, "switch.alejandro_s_hamburg_shuffle_switch");
		///<summary>Bedroom Detections: Motion</summary>
		public SwitchEntity BedroomDetectionsMotion => new(_haContext, "switch.bedroom_detections_motion");
		///<summary>Bedroom HDR Mode</summary>
		public SwitchEntity BedroomHdrMode => new(_haContext, "switch.bedroom_hdr_mode");
		///<summary>Bedroom Outlet on_off</summary>
		public SwitchEntity BedroomOutletOnOff => new(_haContext, "switch.bedroom_outlet_on_off");
		///<summary>Bedroom Overlay: Show Bitrate</summary>
		public SwitchEntity BedroomOverlayShowBitrate => new(_haContext, "switch.bedroom_overlay_show_bitrate");
		///<summary>Bedroom Overlay: Show Date</summary>
		public SwitchEntity BedroomOverlayShowDate => new(_haContext, "switch.bedroom_overlay_show_date");
		///<summary>Bedroom Overlay: Show Logo</summary>
		public SwitchEntity BedroomOverlayShowLogo => new(_haContext, "switch.bedroom_overlay_show_logo");
		///<summary>Bedroom Overlay: Show Name</summary>
		public SwitchEntity BedroomOverlayShowName => new(_haContext, "switch.bedroom_overlay_show_name");
		///<summary>Bedroom Privacy Mode</summary>
		public SwitchEntity BedroomPrivacyMode => new(_haContext, "switch.bedroom_privacy_mode");
		///<summary>Bedroom Status Light On</summary>
		public SwitchEntity BedroomStatusLightOn => new(_haContext, "switch.bedroom_status_light_on");
		///<summary>Buzzer</summary>
		public SwitchEntity Buzzer => new(_haContext, "switch.buzzer");
		///<summary>Camera Motion Detections</summary>
		public SwitchEntity CameraMotionDetections => new(_haContext, "switch.camera_motion_detections");
		///<summary>Cuarto do not disturb switch</summary>
		public SwitchEntity CuartoDoNotDisturbSwitch => new(_haContext, "switch.cuarto_do_not_disturb_switch");
		///<summary>Cuarto repeat switch</summary>
		public SwitchEntity CuartoRepeatSwitch => new(_haContext, "switch.cuarto_repeat_switch");
		///<summary>Cuarto shuffle switch</summary>
		public SwitchEntity CuartoShuffleSwitch => new(_haContext, "switch.cuarto_shuffle_switch");
		///<summary>Downstairs Room Detections: Motion</summary>
		public SwitchEntity DownstairsRoomDetectionsMotion => new(_haContext, "switch.downstairs_room_detections_motion");
		///<summary>Downstairs Room Fan Restart</summary>
		public SwitchEntity DownstairsRoomFanRestart => new(_haContext, "switch.downstairs_room_fan_restart");
		///<summary>Downstairs Room HDR Mode</summary>
		public SwitchEntity DownstairsRoomHdrMode => new(_haContext, "switch.downstairs_room_hdr_mode");
		///<summary>Downstairs Room Overlay: Show Bitrate</summary>
		public SwitchEntity DownstairsRoomOverlayShowBitrate => new(_haContext, "switch.downstairs_room_overlay_show_bitrate");
		///<summary>Downstairs Room Overlay: Show Date</summary>
		public SwitchEntity DownstairsRoomOverlayShowDate => new(_haContext, "switch.downstairs_room_overlay_show_date");
		///<summary>Downstairs Room Overlay: Show Logo</summary>
		public SwitchEntity DownstairsRoomOverlayShowLogo => new(_haContext, "switch.downstairs_room_overlay_show_logo");
		///<summary>Downstairs Room Overlay: Show Name</summary>
		public SwitchEntity DownstairsRoomOverlayShowName => new(_haContext, "switch.downstairs_room_overlay_show_name");
		///<summary>Downstairs Room Privacy Mode</summary>
		public SwitchEntity DownstairsRoomPrivacyMode => new(_haContext, "switch.downstairs_room_privacy_mode");
		///<summary>Downstairs Room Status Light On</summary>
		public SwitchEntity DownstairsRoomStatusLightOn => new(_haContext, "switch.downstairs_room_status_light_on");
		///<summary>Downstairs Room Switch Btn3</summary>
		public SwitchEntity DownstairsRoomSwitchBtn3 => new(_haContext, "switch.downstairs_room_switch_btn3");
		///<summary>Cocina do not disturb switch</summary>
		public SwitchEntity EchoDeAlejandroDoNotDisturbSwitch => new(_haContext, "switch.echo_de_alejandro_do_not_disturb_switch");
		///<summary>Cocina repeat switch</summary>
		public SwitchEntity EchoDeAlejandroRepeatSwitch => new(_haContext, "switch.echo_de_alejandro_repeat_switch");
		///<summary>Cocina shuffle switch</summary>
		public SwitchEntity EchoDeAlejandroShuffleSwitch => new(_haContext, "switch.echo_de_alejandro_shuffle_switch");
		///<summary>Entrance Detect</summary>
		public SwitchEntity EntranceDetect => new(_haContext, "switch.entrance_detect");
		///<summary>Entrance Recordings</summary>
		public SwitchEntity EntranceRecordings => new(_haContext, "switch.entrance_recordings");
		///<summary>Entrance Snapshots</summary>
		public SwitchEntity EntranceSnapshots => new(_haContext, "switch.entrance_snapshots");
		///<summary>Front Door Detect</summary>
		public SwitchEntity FrontDoorDetect => new(_haContext, "switch.front_door_detect");
		///<summary>Front Door Recordings</summary>
		public SwitchEntity FrontDoorRecordings => new(_haContext, "switch.front_door_recordings");
		///<summary>Front Door Snapshots</summary>
		public SwitchEntity FrontDoorSnapshots => new(_haContext, "switch.front_door_snapshots");
		///<summary>Garage Detections: Motion</summary>
		public SwitchEntity G3FlexDetectionsMotion2 => new(_haContext, "switch.g3_flex_detections_motion_2");
		///<summary>Patio Detections: Motion</summary>
		public SwitchEntity G3FlexDetectionsMotion3 => new(_haContext, "switch.g3_flex_detections_motion_3");
		///<summary>Garage Overlay: Show Bitrate</summary>
		public SwitchEntity G3FlexOverlayShowBitrate2 => new(_haContext, "switch.g3_flex_overlay_show_bitrate_2");
		///<summary>Patio Overlay: Show Bitrate</summary>
		public SwitchEntity G3FlexOverlayShowBitrate3 => new(_haContext, "switch.g3_flex_overlay_show_bitrate_3");
		///<summary>Garage Overlay: Show Date</summary>
		public SwitchEntity G3FlexOverlayShowDate2 => new(_haContext, "switch.g3_flex_overlay_show_date_2");
		///<summary>Patio Overlay: Show Date</summary>
		public SwitchEntity G3FlexOverlayShowDate3 => new(_haContext, "switch.g3_flex_overlay_show_date_3");
		///<summary>Garage Overlay: Show Logo</summary>
		public SwitchEntity G3FlexOverlayShowLogo2 => new(_haContext, "switch.g3_flex_overlay_show_logo_2");
		///<summary>Patio Overlay: Show Logo</summary>
		public SwitchEntity G3FlexOverlayShowLogo3 => new(_haContext, "switch.g3_flex_overlay_show_logo_3");
		///<summary>Garage Overlay: Show Name</summary>
		public SwitchEntity G3FlexOverlayShowName2 => new(_haContext, "switch.g3_flex_overlay_show_name_2");
		///<summary>Patio Overlay: Show Name</summary>
		public SwitchEntity G3FlexOverlayShowName3 => new(_haContext, "switch.g3_flex_overlay_show_name_3");
		///<summary>Garage Privacy Mode</summary>
		public SwitchEntity G3FlexPrivacyMode2 => new(_haContext, "switch.g3_flex_privacy_mode_2");
		///<summary>Patio Privacy Mode</summary>
		public SwitchEntity G3FlexPrivacyMode3 => new(_haContext, "switch.g3_flex_privacy_mode_3");
		///<summary>Garage HDR Mode</summary>
		public SwitchEntity GarageHdrMode => new(_haContext, "switch.garage_hdr_mode");
		///<summary>Garage Status Light On</summary>
		public SwitchEntity GarageStatusLightOn => new(_haContext, "switch.garage_status_light_on");
		///<summary>Hallway Lights</summary>
		public SwitchEntity HallwayLights => new(_haContext, "switch.hallway_lights");
		///<summary>Indoor Camera Motion Detections</summary>
		public SwitchEntity IndoorCameraMotionDetections => new(_haContext, "switch.indoor_camera_motion_detections");
		///<summary>Living Room Detections: Motion</summary>
		public SwitchEntity LivingRoomDetectionsMotion => new(_haContext, "switch.living_room_detections_motion");
		///<summary>Living Room Fan 1 Buzzer</summary>
		public SwitchEntity LivingRoomFan1Buzzer => new(_haContext, "switch.living_room_fan_1_buzzer");
		///<summary>Living Room Fan 1 Restart</summary>
		public SwitchEntity LivingRoomFan1Restart => new(_haContext, "switch.living_room_fan_1_restart");
		///<summary>Living Room Fan 2 Buzzer</summary>
		public SwitchEntity LivingRoomFan2Buzzer => new(_haContext, "switch.living_room_fan_2_buzzer");
		///<summary>Living Room Fan 2 Restart</summary>
		public SwitchEntity LivingRoomFan2Restart => new(_haContext, "switch.living_room_fan_2_restart");
		///<summary>Living Room HDR Mode</summary>
		public SwitchEntity LivingRoomHdrMode => new(_haContext, "switch.living_room_hdr_mode");
		///<summary>Living Room Overlay: Show Bitrate</summary>
		public SwitchEntity LivingRoomOverlayShowBitrate => new(_haContext, "switch.living_room_overlay_show_bitrate");
		///<summary>Living Room Overlay: Show Date</summary>
		public SwitchEntity LivingRoomOverlayShowDate => new(_haContext, "switch.living_room_overlay_show_date");
		///<summary>Living Room Overlay: Show Logo</summary>
		public SwitchEntity LivingRoomOverlayShowLogo => new(_haContext, "switch.living_room_overlay_show_logo");
		///<summary>Living Room Overlay: Show Name</summary>
		public SwitchEntity LivingRoomOverlayShowName => new(_haContext, "switch.living_room_overlay_show_name");
		///<summary>Living Room Privacy Mode</summary>
		public SwitchEntity LivingRoomPrivacyMode => new(_haContext, "switch.living_room_privacy_mode");
		///<summary>Living Room Status Light On</summary>
		public SwitchEntity LivingRoomStatusLightOn => new(_haContext, "switch.living_room_status_light_on");
		///<summary>Office Detections: Motion</summary>
		public SwitchEntity OfficeDetectionsMotion => new(_haContext, "switch.office_detections_motion");
		///<summary>Office HDR Mode</summary>
		public SwitchEntity OfficeHdrMode => new(_haContext, "switch.office_hdr_mode");
		///<summary>Office outlet on_off</summary>
		public SwitchEntity OfficeOutletOnOff => new(_haContext, "switch.office_outlet_on_off");
		///<summary>Office Overlay: Show Bitrate</summary>
		public SwitchEntity OfficeOverlayShowBitrate => new(_haContext, "switch.office_overlay_show_bitrate");
		///<summary>Office Overlay: Show Date</summary>
		public SwitchEntity OfficeOverlayShowDate => new(_haContext, "switch.office_overlay_show_date");
		///<summary>Office Overlay: Show Logo</summary>
		public SwitchEntity OfficeOverlayShowLogo => new(_haContext, "switch.office_overlay_show_logo");
		///<summary>Office Overlay: Show Name</summary>
		public SwitchEntity OfficeOverlayShowName => new(_haContext, "switch.office_overlay_show_name");
		///<summary>Office Privacy Mode</summary>
		public SwitchEntity OfficePrivacyMode => new(_haContext, "switch.office_privacy_mode");
		///<summary>Office Status Light On</summary>
		public SwitchEntity OfficeStatusLightOn => new(_haContext, "switch.office_status_light_on");
		///<summary>Oficina do not disturb switch</summary>
		public SwitchEntity OficinaDoNotDisturbSwitch => new(_haContext, "switch.oficina_do_not_disturb_switch");
		///<summary>Oficina repeat switch</summary>
		public SwitchEntity OficinaRepeatSwitch => new(_haContext, "switch.oficina_repeat_switch");
		///<summary>Oficina shuffle switch</summary>
		public SwitchEntity OficinaShuffleSwitch => new(_haContext, "switch.oficina_shuffle_switch");
		///<summary>Outdoor Camera Motion Detections</summary>
		public SwitchEntity OutdoorCameraMotionDetections => new(_haContext, "switch.outdoor_camera_motion_detections");
		///<summary>Patio HDR Mode</summary>
		public SwitchEntity PatioHdrMode => new(_haContext, "switch.patio_hdr_mode");
		///<summary>Patio Status Light On</summary>
		public SwitchEntity PatioStatusLightOn => new(_haContext, "switch.patio_status_light_on");
		///<summary>Rho Aias WOL</summary>
		public SwitchEntity RhoAiasWol => new(_haContext, "switch.rho_aias_wol");
		///<summary>shelly1-98CDAC245A11</summary>
		public SwitchEntity Shelly198cdac245a11 => new(_haContext, "switch.shelly1_98cdac245a11");
		///<summary>SONOFF S31 Lite zb cef42125 on_off</summary>
		public SwitchEntity SonoffS31LiteZbCef42125OnOff => new(_haContext, "switch.sonoff_s31_lite_zb_cef42125_on_off");
		///<summary>Stairs Light Switch</summary>
		public SwitchEntity StairsLightSwitch => new(_haContext, "switch.stairs_light_switch");
		///<summary>Stairs Outlet</summary>
		public SwitchEntity StairsOutletOnOff => new(_haContext, "switch.stairs_outlet_on_off");
		///<summary>Upstairs Bathroom Switch Btn2</summary>
		public SwitchEntity UpstairsBathroomSwitchBtn2 => new(_haContext, "switch.upstairs_bathroom_switch_btn2");
		///<summary>Upstairs Bedroom Switch Btn3</summary>
		public SwitchEntity UpstairsBedroomSwitchBtn32 => new(_haContext, "switch.upstairs_bedroom_switch_btn3_2");
		///<summary>Upstairs Dressing Room Switch Btn2</summary>
		public SwitchEntity UpstairsDressingRoomSwitchBtn2 => new(_haContext, "switch.upstairs_dressing_room_switch_btn2");
		///<summary>Upstairs Room Switch Btn2</summary>
		public SwitchEntity UpstairsRoomSwitchBtn2 => new(_haContext, "switch.upstairs_room_switch_btn2");
		///<summary>Water Heater</summary>
		public SwitchEntity WaterHeater => new(_haContext, "switch.water_heater");
		///<summary>WLED Nightlight</summary>
		public SwitchEntity WledNightlight => new(_haContext, "switch.wled_nightlight");
		///<summary>WLED Reverse</summary>
		public SwitchEntity WledReverse => new(_haContext, "switch.wled_reverse");
		///<summary>WLED Sync Receive</summary>
		public SwitchEntity WledSyncReceive => new(_haContext, "switch.wled_sync_receive");
		///<summary>WLED Sync Send</summary>
		public SwitchEntity WledSyncSend => new(_haContext, "switch.wled_sync_send");
	}

	public partial class UpdateEntities
	{
		private readonly IHaContext _haContext;
		public UpdateEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bedroom AP</summary>
		public UpdateEntity BedroomAp => new(_haContext, "update.bedroom_ap");
		///<summary>Check Home Assistant configuration: Update</summary>
		public UpdateEntity CheckHomeAssistantConfigurationUpdate => new(_haContext, "update.check_home_assistant_configuration_update");
		///<summary>Downstairs AP</summary>
		public UpdateEntity DownstairsAp => new(_haContext, "update.downstairs_ap");
		///<summary>ESPHome: Update</summary>
		public UpdateEntity EsphomeUpdate => new(_haContext, "update.esphome_update");
		///<summary>Frigate NVR: Update</summary>
		public UpdateEntity FrigateNvrUpdate => new(_haContext, "update.frigate_nvr_update");
		///<summary>Frigate Server</summary>
		public UpdateEntity FrigateServer => new(_haContext, "update.frigate_server");
		///<summary>Hikvision-SDK: Update</summary>
		public UpdateEntity HikvisionSdkUpdate => new(_haContext, "update.hikvision_sdk_update");
		///<summary>Home Assistant Core: Update</summary>
		public UpdateEntity HomeAssistantCoreUpdate => new(_haContext, "update.home_assistant_core_update");
		///<summary>Home Assistant Supervisor: Update</summary>
		public UpdateEntity HomeAssistantSupervisorUpdate => new(_haContext, "update.home_assistant_supervisor_update");
		///<summary>MariaDB: Update</summary>
		public UpdateEntity MariadbUpdate => new(_haContext, "update.mariadb_update");
		///<summary>Mosquitto broker: Update</summary>
		public UpdateEntity MosquittoBrokerUpdate => new(_haContext, "update.mosquitto_broker_update");
		///<summary>NetDaemon V3 - beta: Update</summary>
		public UpdateEntity NetdaemonV3BetaUpdate => new(_haContext, "update.netdaemon_v3_beta_update");
		///<summary>Node-RED: Update</summary>
		public UpdateEntity NodeRedUpdate => new(_haContext, "update.node_red_update");
		///<summary>Office AP</summary>
		public UpdateEntity OfficeAp => new(_haContext, "update.office_ap");
		///<summary>Portainer: Update</summary>
		public UpdateEntity PortainerUpdate => new(_haContext, "update.portainer_update");
		///<summary>Samba share: Update</summary>
		public UpdateEntity SambaShareUpdate => new(_haContext, "update.samba_share_update");
		///<summary>Terminal & SSH: Update</summary>
		public UpdateEntity TerminalSshUpdate => new(_haContext, "update.terminal_ssh_update");
		///<summary>UDMPRO</summary>
		public UpdateEntity Udmpro => new(_haContext, "update.udmpro");
		///<summary>Garage AP</summary>
		public UpdateEntity UpstairsAp => new(_haContext, "update.upstairs_ap");
		///<summary>US8P60</summary>
		public UpdateEntity Us8p60 => new(_haContext, "update.us8p60");
		///<summary>Studio Code Server: Update</summary>
		public UpdateEntity VisualStudioCodeUpdate => new(_haContext, "update.visual_studio_code_update");
		///<summary>WLED Firmware</summary>
		public UpdateEntity WledFirmware => new(_haContext, "update.wled_firmware");
	}

	public partial class VacuumEntities
	{
		private readonly IHaContext _haContext;
		public VacuumEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Gustavito</summary>
		public VacuumEntity Gustavito => new(_haContext, "vacuum.gustavito");
	}

	public partial class ZoneEntities
	{
		private readonly IHaContext _haContext;
		public ZoneEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Home</summary>
		public ZoneEntity Home => new(_haContext, "zone.home");
	}

	public partial record AlarmControlPanelEntity : Entity<AlarmControlPanelEntity, EntityState<AlarmControlPanelAttributes>, AlarmControlPanelAttributes>
	{
		public AlarmControlPanelEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public AlarmControlPanelEntity(Entity entity) : base(entity)
		{
		}
	}

	public record AlarmControlPanelAttributes
	{
		[JsonPropertyName("changed_by")]
		public object? ChangedBy { get; init; }

		[JsonPropertyName("code_arm_required")]
		public bool? CodeArmRequired { get; init; }

		[JsonPropertyName("code_format")]
		public object? CodeFormat { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record AutomationEntity : Entity<AutomationEntity, EntityState<AutomationAttributes>, AutomationAttributes>
	{
		public AutomationEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public AutomationEntity(Entity entity) : base(entity)
		{
		}
	}

	public record AutomationAttributes
	{
		[JsonPropertyName("current")]
		public double? Current { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }

		[JsonPropertyName("last_triggered")]
		public string? LastTriggered { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public partial record BinarySensorEntity : Entity<BinarySensorEntity, EntityState<BinarySensorAttributes>, BinarySensorAttributes>
	{
		public BinarySensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public BinarySensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record BinarySensorAttributes
	{
		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("entity_id")]
		public IReadOnlyList<string>? EntityId { get; init; }

		[JsonPropertyName("event_score")]
		public double? EventScore { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("ignoring_battery_optimizations")]
		public bool? IgnoringBatteryOptimizations { get; init; }

		[JsonPropertyName("observations")]
		public IReadOnlyList<object>? Observations { get; init; }

		[JsonPropertyName("occurred_observation_entities")]
		public IReadOnlyList<string>? OccurredObservationEntities { get; init; }

		[JsonPropertyName("probability")]
		public double? Probability { get; init; }

		[JsonPropertyName("probability_threshold")]
		public double? ProbabilityThreshold { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record ButtonEntity : Entity<ButtonEntity, EntityState<ButtonAttributes>, ButtonAttributes>
	{
		public ButtonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ButtonEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ButtonAttributes
	{
		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }
	}

	public partial record CalendarEntity : Entity<CalendarEntity, EntityState<CalendarAttributes>, CalendarAttributes>
	{
		public CalendarEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CalendarEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CalendarAttributes
	{
		[JsonPropertyName("all_day")]
		public bool? AllDay { get; init; }

		[JsonPropertyName("description")]
		public string? Description { get; init; }

		[JsonPropertyName("end_time")]
		public string? EndTime { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("location")]
		public string? Location { get; init; }

		[JsonPropertyName("message")]
		public string? Message { get; init; }

		[JsonPropertyName("offset_reached")]
		public bool? OffsetReached { get; init; }

		[JsonPropertyName("start_time")]
		public string? StartTime { get; init; }
	}

	public partial record CameraEntity : Entity<CameraEntity, EntityState<CameraAttributes>, CameraAttributes>
	{
		public CameraEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CameraEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CameraAttributes
	{
		[JsonPropertyName("access_token")]
		public string? AccessToken { get; init; }

		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("bitrate")]
		public double? Bitrate { get; init; }

		[JsonPropertyName("channel_id")]
		public double? ChannelId { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("fps")]
		public double? Fps { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("frontend_stream_type")]
		public string? FrontendStreamType { get; init; }

		[JsonPropertyName("height")]
		public double? Height { get; init; }

		[JsonPropertyName("motion_detection")]
		public bool? MotionDetection { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("width")]
		public double? Width { get; init; }
	}

	public partial record ClimateEntity : Entity<ClimateEntity, EntityState<ClimateAttributes>, ClimateAttributes>
	{
		public ClimateEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ClimateEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ClimateAttributes
	{
		[JsonPropertyName("current_temperature")]
		public double? CurrentTemperature { get; init; }

		[JsonPropertyName("fan_mode")]
		public string? FanMode { get; init; }

		[JsonPropertyName("fan_modes")]
		public IReadOnlyList<string>? FanModes { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("hvac_modes")]
		public IReadOnlyList<string>? HvacModes { get; init; }

		[JsonPropertyName("max_temp")]
		public double? MaxTemp { get; init; }

		[JsonPropertyName("min_temp")]
		public double? MinTemp { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("swing_mode")]
		public string? SwingMode { get; init; }

		[JsonPropertyName("swing_modes")]
		public IReadOnlyList<string>? SwingModes { get; init; }

		[JsonPropertyName("swing_mode_vertical")]
		public string? SwingModeVertical { get; init; }

		[JsonPropertyName("target_temp_step")]
		public double? TargetTempStep { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }
	}

	public partial record CoverEntity : Entity<CoverEntity, EntityState<CoverAttributes>, CoverAttributes>
	{
		public CoverEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CoverEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CoverAttributes
	{
		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record DeviceTrackerEntity : Entity<DeviceTrackerEntity, EntityState<DeviceTrackerAttributes>, DeviceTrackerAttributes>
	{
		public DeviceTrackerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public DeviceTrackerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record DeviceTrackerAttributes
	{
		[JsonPropertyName("altitude")]
		public double? Altitude { get; init; }

		[JsonPropertyName("ap_mac")]
		public string? ApMac { get; init; }

		[JsonPropertyName("authorized")]
		public bool? Authorized { get; init; }

		[JsonPropertyName("battery_level")]
		public double? BatteryLevel { get; init; }

		[JsonPropertyName("course")]
		public double? Course { get; init; }

		[JsonPropertyName("essid")]
		public string? Essid { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("gps_accuracy")]
		public double? GpsAccuracy { get; init; }

		[JsonPropertyName("hostname")]
		public string? Hostname { get; init; }

		[JsonPropertyName("host_name")]
		public string? HostName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("ip")]
		public string? Ip { get; init; }

		[JsonPropertyName("is_11r")]
		public bool? Is11r { get; init; }

		[JsonPropertyName("is_guest")]
		public bool? IsGuest { get; init; }

		[JsonPropertyName("_is_guest_by_uap")]
		public bool? IsGuestByUap { get; init; }

		[JsonPropertyName("is_wired")]
		public bool? IsWired { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("mac")]
		public string? Mac { get; init; }

		[JsonPropertyName("name")]
		public string? Name { get; init; }

		[JsonPropertyName("oui")]
		public string? Oui { get; init; }

		[JsonPropertyName("qos_policy_applied")]
		public bool? QosPolicyApplied { get; init; }

		[JsonPropertyName("radio")]
		public string? Radio { get; init; }

		[JsonPropertyName("radio_proto")]
		public string? RadioProto { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("source_type")]
		public string? SourceType { get; init; }

		[JsonPropertyName("speed")]
		public double? Speed { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("vertical_accuracy")]
		public double? VerticalAccuracy { get; init; }

		[JsonPropertyName("vlan")]
		public double? Vlan { get; init; }
	}

	public partial record FanEntity : Entity<FanEntity, EntityState<FanAttributes>, FanAttributes>
	{
		public FanEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public FanEntity(Entity entity) : base(entity)
		{
		}
	}

	public record FanAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("percentage")]
		public double? Percentage { get; init; }

		[JsonPropertyName("percentage_step")]
		public double? PercentageStep { get; init; }

		[JsonPropertyName("preset_mode")]
		public object? PresetMode { get; init; }

		[JsonPropertyName("preset_modes")]
		public object? PresetModes { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record InputBooleanEntity : Entity<InputBooleanEntity, EntityState<InputBooleanAttributes>, InputBooleanAttributes>
	{
		public InputBooleanEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputBooleanEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputBooleanAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }
	}

	public partial record InputDatetimeEntity : Entity<InputDatetimeEntity, EntityState<InputDatetimeAttributes>, InputDatetimeAttributes>
	{
		public InputDatetimeEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputDatetimeEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputDatetimeAttributes
	{
		[JsonPropertyName("day")]
		public double? Day { get; init; }

		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("has_date")]
		public bool? HasDate { get; init; }

		[JsonPropertyName("has_time")]
		public bool? HasTime { get; init; }

		[JsonPropertyName("hour")]
		public double? Hour { get; init; }

		[JsonPropertyName("minute")]
		public double? Minute { get; init; }

		[JsonPropertyName("month")]
		public double? Month { get; init; }

		[JsonPropertyName("second")]
		public double? Second { get; init; }

		[JsonPropertyName("timestamp")]
		public double? Timestamp { get; init; }

		[JsonPropertyName("year")]
		public double? Year { get; init; }
	}

	public partial record InputNumberEntity : NumericEntity<InputNumberEntity, NumericEntityState<InputNumberAttributes>, InputNumberAttributes>
	{
		public InputNumberEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputNumberEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputNumberAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("initial")]
		public object? Initial { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("min")]
		public double? Min { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("step")]
		public double? Step { get; init; }

		[JsonPropertyName("unit_of_measurement")]
		public string? UnitOfMeasurement { get; init; }
	}

	public partial record InputSelectEntity : Entity<InputSelectEntity, EntityState<InputSelectAttributes>, InputSelectAttributes>
	{
		public InputSelectEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputSelectEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputSelectAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("options")]
		public IReadOnlyList<string>? Options { get; init; }
	}

	public partial record LightEntity : Entity<LightEntity, EntityState<LightAttributes>, LightAttributes>
	{
		public LightEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public LightEntity(Entity entity) : base(entity)
		{
		}
	}

	public record LightAttributes
	{
		[JsonPropertyName("color_mode")]
		public string? ColorMode { get; init; }

		[JsonPropertyName("deviceID")]
		public string? DeviceID { get; init; }

		[JsonPropertyName("effect_list")]
		public IReadOnlyList<string>? EffectList { get; init; }

		[JsonPropertyName("entity_id")]
		public IReadOnlyList<string>? EntityId { get; init; }

		[JsonPropertyName("flowing")]
		public bool? Flowing { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("max_mireds")]
		public double? MaxMireds { get; init; }

		[JsonPropertyName("min_mireds")]
		public double? MinMireds { get; init; }

		[JsonPropertyName("music_mode")]
		public bool? MusicMode { get; init; }

		[JsonPropertyName("off_brightness")]
		public double? OffBrightness { get; init; }

		[JsonPropertyName("off_with_transition")]
		public bool? OffWithTransition { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_color_modes")]
		public IReadOnlyList<string>? SupportedColorModes { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("type")]
		public string? Type { get; init; }
	}

	public partial record LockEntity : Entity<LockEntity, EntityState<LockAttributes>, LockAttributes>
	{
		public LockEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public LockEntity(Entity entity) : base(entity)
		{
		}
	}

	public record LockAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }
	}

	public partial record MediaPlayerEntity : Entity<MediaPlayerEntity, EntityState<MediaPlayerAttributes>, MediaPlayerAttributes>
	{
		public MediaPlayerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public MediaPlayerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record MediaPlayerAttributes
	{
		[JsonPropertyName("available")]
		public bool? Available { get; init; }

		[JsonPropertyName("bluetooth_list")]
		public IReadOnlyList<string>? BluetoothList { get; init; }

		[JsonPropertyName("connected_bluetooth")]
		public object? ConnectedBluetooth { get; init; }

		[JsonPropertyName("deviceID")]
		public string? DeviceID { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("is_volume_muted")]
		public bool? IsVolumeMuted { get; init; }

		[JsonPropertyName("last_called")]
		public bool? LastCalled { get; init; }

		[JsonPropertyName("last_called_summary")]
		public string? LastCalledSummary { get; init; }

		[JsonPropertyName("last_called_timestamp")]
		public double? LastCalledTimestamp { get; init; }

		[JsonPropertyName("media_content_id")]
		public string? MediaContentId { get; init; }

		[JsonPropertyName("media_content_type")]
		public string? MediaContentType { get; init; }

		[JsonPropertyName("media_position_updated_at")]
		public string? MediaPositionUpdatedAt { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("source")]
		public string? Source { get; init; }

		[JsonPropertyName("source_list")]
		public IReadOnlyList<string>? SourceList { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("type")]
		public string? Type { get; init; }

		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }
	}

	public partial record NumberEntity : NumericEntity<NumberEntity, NumericEntityState<NumberAttributes>, NumberAttributes>
	{
		public NumberEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public NumberEntity(Entity entity) : base(entity)
		{
		}
	}

	public record NumberAttributes
	{
		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("min")]
		public double? Min { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("step")]
		public double? Step { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("unit_of_measurement")]
		public string? UnitOfMeasurement { get; init; }
	}

	public partial record PersistentNotificationEntity : Entity<PersistentNotificationEntity, EntityState<PersistentNotificationAttributes>, PersistentNotificationAttributes>
	{
		public PersistentNotificationEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public PersistentNotificationEntity(Entity entity) : base(entity)
		{
		}
	}

	public record PersistentNotificationAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("message")]
		public string? Message { get; init; }

		[JsonPropertyName("title")]
		public string? Title { get; init; }
	}

	public partial record PersonEntity : Entity<PersonEntity, EntityState<PersonAttributes>, PersonAttributes>
	{
		public PersonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public PersonEntity(Entity entity) : base(entity)
		{
		}
	}

	public record PersonAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("gps_accuracy")]
		public double? GpsAccuracy { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("source")]
		public string? Source { get; init; }

		[JsonPropertyName("user_id")]
		public string? UserId { get; init; }
	}

	public partial record ScriptEntity : Entity<ScriptEntity, EntityState<ScriptAttributes>, ScriptAttributes>
	{
		public ScriptEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ScriptEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ScriptAttributes
	{
		[JsonPropertyName("current")]
		public double? Current { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("last_triggered")]
		public string? LastTriggered { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public partial record SelectEntity : Entity<SelectEntity, EntityState<SelectAttributes>, SelectAttributes>
	{
		public SelectEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SelectEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SelectAttributes
	{
		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("options")]
		public IReadOnlyList<string>? Options { get; init; }
	}

	public partial record SensorEntity : Entity<SensorEntity, EntityState<SensorAttributes>, SensorAttributes>
	{
		public SensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SensorAttributes
	{
		[JsonPropertyName("Administrative Area")]
		public string? AdministrativeArea_0 { get; init; }

		[JsonPropertyName("administrative_area")]
		public string? AdministrativeArea_1 { get; init; }

		[JsonPropertyName("Areas Of Interest")]
		public string? AreasOfInterest { get; init; }

		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("battery_level")]
		public double? BatteryLevel { get; init; }

		[JsonPropertyName("charging")]
		public bool? Charging { get; init; }

		[JsonPropertyName("config")]
		public object? Config { get; init; }

		[JsonPropertyName("country")]
		public string? Country_0 { get; init; }

		[JsonPropertyName("Country")]
		public string? Country_1 { get; init; }

		[JsonPropertyName("currentUser")]
		public string? CurrentUser { get; init; }

		[JsonPropertyName("darkMode")]
		public bool? DarkMode { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("deviceID")]
		public string? DeviceID { get; init; }

		[JsonPropertyName("dismissed")]
		public string? Dismissed { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("fullyKiosk")]
		public bool? FullyKiosk { get; init; }

		[JsonPropertyName("height")]
		public double? Height { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("Inland Water")]
		public string? InlandWater { get; init; }

		[JsonPropertyName("in_vehicle")]
		public double? InVehicle { get; init; }

		[JsonPropertyName("is_hidden")]
		public bool? IsHidden { get; init; }

		[JsonPropertyName("iso_country_code")]
		public string? IsoCountryCode { get; init; }

		[JsonPropertyName("ISO Country Code")]
		public string? ISOCountryCode { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("locality")]
		public string? Locality_0 { get; init; }

		[JsonPropertyName("Locality")]
		public string? Locality_1 { get; init; }

		[JsonPropertyName("Location")]
		public IReadOnlyList<double>? Location { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("Name")]
		public string? Name { get; init; }

		[JsonPropertyName("Ocean")]
		public string? Ocean { get; init; }

		[JsonPropertyName("on_bicycle")]
		public double? OnBicycle { get; init; }

		[JsonPropertyName("on_foot")]
		public double? OnFoot { get; init; }

		[JsonPropertyName("path")]
		public string? Path { get; init; }

		[JsonPropertyName("Postal Code")]
		public string? PostalCode_0 { get; init; }

		[JsonPropertyName("postal_code")]
		public string? PostalCode_1 { get; init; }

		[JsonPropertyName("prior_value")]
		public string? PriorValue { get; init; }

		[JsonPropertyName("process_timestamp")]
		public string? ProcessTimestamp { get; init; }

		[JsonPropertyName("recurrence")]
		public object? Recurrence { get; init; }

		[JsonPropertyName("reminder")]
		public object? Reminder { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("sorted_active")]
		public string? SortedActive { get; init; }

		[JsonPropertyName("sorted_all")]
		public string? SortedAll { get; init; }

		[JsonPropertyName("status")]
		public string? Status { get; init; }

		[JsonPropertyName("still")]
		public double? Still { get; init; }

		[JsonPropertyName("Sub Administrative Area")]
		public string? SubAdministrativeArea_0 { get; init; }

		[JsonPropertyName("sub_administrative_area")]
		public string? SubAdministrativeArea_1 { get; init; }

		[JsonPropertyName("Sub Locality")]
		public string? SubLocality_0 { get; init; }

		[JsonPropertyName("sub_locality")]
		public string? SubLocality_1 { get; init; }

		[JsonPropertyName("Sub Thoroughfare")]
		public string? SubThoroughfare_0 { get; init; }

		[JsonPropertyName("sub_thoroughfare")]
		public string? SubThoroughfare_1 { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("thoroughfare")]
		public string? Thoroughfare_0 { get; init; }

		[JsonPropertyName("Thoroughfare")]
		public string? Thoroughfare_1 { get; init; }

		[JsonPropertyName("Time Zone")]
		public string? TimeZone { get; init; }

		[JsonPropertyName("total_active")]
		public double? TotalActive { get; init; }

		[JsonPropertyName("total_all")]
		public double? TotalAll { get; init; }

		[JsonPropertyName("type")]
		public string? Type { get; init; }

		[JsonPropertyName("unknown")]
		public double? Unknown { get; init; }

		[JsonPropertyName("userAgent")]
		public string? UserAgent { get; init; }

		[JsonPropertyName("userData")]
		public object? UserData { get; init; }

		[JsonPropertyName("visibility")]
		public string? Visibility { get; init; }

		[JsonPropertyName("walking")]
		public double? Walking { get; init; }

		[JsonPropertyName("width")]
		public double? Width { get; init; }

		[JsonPropertyName("Zones")]
		public IReadOnlyList<object>? Zones { get; init; }
	}

	public partial record NumericSensorEntity : NumericEntity<NumericSensorEntity, NumericEntityState<NumericSensorAttributes>, NumericSensorAttributes>
	{
		public NumericSensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public NumericSensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record NumericSensorAttributes
	{
		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("battery_voltage")]
		public double? BatteryVoltage { get; init; }

		[JsonPropertyName("connected_not_paired_devices")]
		public IReadOnlyList<object>? ConnectedNotPairedDevices { get; init; }

		[JsonPropertyName("connected_paired_devices")]
		public IReadOnlyList<object>? ConnectedPairedDevices { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("paired_devices")]
		public IReadOnlyList<object>? PairedDevices { get; init; }

		[JsonPropertyName("repositories")]
		public IReadOnlyList<object>? Repositories { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("state_class")]
		public string? StateClass { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("unit_of_measurement")]
		public string? UnitOfMeasurement { get; init; }
	}

	public partial record SunEntity : Entity<SunEntity, EntityState<SunAttributes>, SunAttributes>
	{
		public SunEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SunEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SunAttributes
	{
		[JsonPropertyName("azimuth")]
		public double? Azimuth { get; init; }

		[JsonPropertyName("elevation")]
		public double? Elevation { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("next_dawn")]
		public string? NextDawn { get; init; }

		[JsonPropertyName("next_dusk")]
		public string? NextDusk { get; init; }

		[JsonPropertyName("next_midnight")]
		public string? NextMidnight { get; init; }

		[JsonPropertyName("next_noon")]
		public string? NextNoon { get; init; }

		[JsonPropertyName("next_rising")]
		public string? NextRising { get; init; }

		[JsonPropertyName("next_setting")]
		public string? NextSetting { get; init; }

		[JsonPropertyName("rising")]
		public bool? Rising { get; init; }
	}

	public partial record SwitchEntity : Entity<SwitchEntity, EntityState<SwitchAttributes>, SwitchAttributes>
	{
		public SwitchEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SwitchEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SwitchAttributes
	{
		[JsonPropertyName("assumed_state")]
		public bool? AssumedState { get; init; }

		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("duration")]
		public double? Duration { get; init; }

		[JsonPropertyName("entity_id")]
		public IReadOnlyList<string>? EntityId { get; init; }

		[JsonPropertyName("fade")]
		public bool? Fade { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("target_brightness")]
		public double? TargetBrightness { get; init; }

		[JsonPropertyName("udp_port")]
		public double? UdpPort { get; init; }
	}

	public partial record UpdateEntity : Entity<UpdateEntity, EntityState<UpdateAttributes>, UpdateAttributes>
	{
		public UpdateEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public UpdateEntity(Entity entity) : base(entity)
		{
		}
	}

	public record UpdateAttributes
	{
		[JsonPropertyName("auto_update")]
		public bool? AutoUpdate { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("in_progress")]
		public bool? InProgress { get; init; }

		[JsonPropertyName("installed_version")]
		public string? InstalledVersion { get; init; }

		[JsonPropertyName("latest_version")]
		public string? LatestVersion { get; init; }

		[JsonPropertyName("release_summary")]
		public string? ReleaseSummary { get; init; }

		[JsonPropertyName("release_url")]
		public string? ReleaseUrl { get; init; }

		[JsonPropertyName("skipped_version")]
		public object? SkippedVersion { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("title")]
		public string? Title { get; init; }
	}

	public partial record VacuumEntity : Entity<VacuumEntity, EntityState<VacuumAttributes>, VacuumAttributes>
	{
		public VacuumEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public VacuumEntity(Entity entity) : base(entity)
		{
		}
	}

	public record VacuumAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record ZoneEntity : Entity<ZoneEntity, EntityState<ZoneAttributes>, ZoneAttributes>
	{
		public ZoneEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ZoneEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ZoneAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("passive")]
		public bool? Passive { get; init; }

		[JsonPropertyName("persons")]
		public IReadOnlyList<string>? Persons { get; init; }

		[JsonPropertyName("radius")]
		public double? Radius { get; init; }
	}

	public interface IServices
	{
		AlarmControlPanelServices AlarmControlPanel { get; }

		AlexaMediaServices AlexaMedia { get; }

		AutomationServices Automation { get; }

		BayesianServices Bayesian { get; }

		BrowserModServices BrowserMod { get; }

		ButtonServices Button { get; }

		CameraServices Camera { get; }

		ClimateServices Climate { get; }

		CloudServices Cloud { get; }

		ConversationServices Conversation { get; }

		CounterServices Counter { get; }

		CoverServices Cover { get; }

		DeviceTrackerServices DeviceTracker { get; }

		EsphomeServices Esphome { get; }

		FanServices Fan { get; }

		FfmpegServices Ffmpeg { get; }

		FrontendServices Frontend { get; }

		GoogleServices Google { get; }

		GroupServices Group { get; }

		HassioServices Hassio { get; }

		HomeassistantServices Homeassistant { get; }

		HumidifierServices Humidifier { get; }

		InputBooleanServices InputBoolean { get; }

		InputButtonServices InputButton { get; }

		InputDatetimeServices InputDatetime { get; }

		InputNumberServices InputNumber { get; }

		InputSelectServices InputSelect { get; }

		InputTextServices InputText { get; }

		LightServices Light { get; }

		LockServices Lock { get; }

		LogbookServices Logbook { get; }

		MediaPlayerServices MediaPlayer { get; }

		MqttServices Mqtt { get; }

		NotifyServices Notify { get; }

		NumberServices Number { get; }

		PersistentNotificationServices PersistentNotification { get; }

		PersonServices Person { get; }

		RecorderServices Recorder { get; }

		SceneServices Scene { get; }

		ScriptServices Script { get; }

		SelectServices Select { get; }

		ShoppingListServices ShoppingList { get; }

		SirenServices Siren { get; }

		SmartthinqSensorsServices SmartthinqSensors { get; }

		SwitchServices Switch { get; }

		SystemLogServices SystemLog { get; }

		TelegramServices Telegram { get; }

		TelegramBotServices TelegramBot { get; }

		TemplateServices Template { get; }

		TimerServices Timer { get; }

		TtsServices Tts { get; }

		UiLovelaceMinimalistServices UiLovelaceMinimalist { get; }

		UnifiServices Unifi { get; }

		UnifiprotectServices Unifiprotect { get; }

		UpdateServices Update { get; }

		VacuumServices Vacuum { get; }

		WakeOnLanServices WakeOnLan { get; }

		YeelightServices Yeelight { get; }

		ZhaServices Zha { get; }

		ZoneServices Zone { get; }
	}

	public class Services : IServices
	{
		private readonly IHaContext _haContext;
		public Services(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AlarmControlPanelServices AlarmControlPanel => new(_haContext);
		public AlexaMediaServices AlexaMedia => new(_haContext);
		public AutomationServices Automation => new(_haContext);
		public BayesianServices Bayesian => new(_haContext);
		public BrowserModServices BrowserMod => new(_haContext);
		public ButtonServices Button => new(_haContext);
		public CameraServices Camera => new(_haContext);
		public ClimateServices Climate => new(_haContext);
		public CloudServices Cloud => new(_haContext);
		public ConversationServices Conversation => new(_haContext);
		public CounterServices Counter => new(_haContext);
		public CoverServices Cover => new(_haContext);
		public DeviceTrackerServices DeviceTracker => new(_haContext);
		public EsphomeServices Esphome => new(_haContext);
		public FanServices Fan => new(_haContext);
		public FfmpegServices Ffmpeg => new(_haContext);
		public FrontendServices Frontend => new(_haContext);
		public GoogleServices Google => new(_haContext);
		public GroupServices Group => new(_haContext);
		public HassioServices Hassio => new(_haContext);
		public HomeassistantServices Homeassistant => new(_haContext);
		public HumidifierServices Humidifier => new(_haContext);
		public InputBooleanServices InputBoolean => new(_haContext);
		public InputButtonServices InputButton => new(_haContext);
		public InputDatetimeServices InputDatetime => new(_haContext);
		public InputNumberServices InputNumber => new(_haContext);
		public InputSelectServices InputSelect => new(_haContext);
		public InputTextServices InputText => new(_haContext);
		public LightServices Light => new(_haContext);
		public LockServices Lock => new(_haContext);
		public LogbookServices Logbook => new(_haContext);
		public MediaPlayerServices MediaPlayer => new(_haContext);
		public MqttServices Mqtt => new(_haContext);
		public NotifyServices Notify => new(_haContext);
		public NumberServices Number => new(_haContext);
		public PersistentNotificationServices PersistentNotification => new(_haContext);
		public PersonServices Person => new(_haContext);
		public RecorderServices Recorder => new(_haContext);
		public SceneServices Scene => new(_haContext);
		public ScriptServices Script => new(_haContext);
		public SelectServices Select => new(_haContext);
		public ShoppingListServices ShoppingList => new(_haContext);
		public SirenServices Siren => new(_haContext);
		public SmartthinqSensorsServices SmartthinqSensors => new(_haContext);
		public SwitchServices Switch => new(_haContext);
		public SystemLogServices SystemLog => new(_haContext);
		public TelegramServices Telegram => new(_haContext);
		public TelegramBotServices TelegramBot => new(_haContext);
		public TemplateServices Template => new(_haContext);
		public TimerServices Timer => new(_haContext);
		public TtsServices Tts => new(_haContext);
		public UiLovelaceMinimalistServices UiLovelaceMinimalist => new(_haContext);
		public UnifiServices Unifi => new(_haContext);
		public UnifiprotectServices Unifiprotect => new(_haContext);
		public UpdateServices Update => new(_haContext);
		public VacuumServices Vacuum => new(_haContext);
		public WakeOnLanServices WakeOnLan => new(_haContext);
		public YeelightServices Yeelight => new(_haContext);
		public ZhaServices Zha => new(_haContext);
		public ZoneServices Zone => new(_haContext);
	}

	public class AlarmControlPanelServices
	{
		private readonly IHaContext _haContext;
		public AlarmControlPanelServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmAway(ServiceTarget target, AlarmControlPanelAlarmArmAwayParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, data);
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
		public void AlarmArmAway(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, new AlarmControlPanelAlarmArmAwayParameters{Code = @code});
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmCustomBypass(ServiceTarget target, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, data);
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
		public void AlarmArmCustomBypass(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, new AlarmControlPanelAlarmArmCustomBypassParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmHome(ServiceTarget target, AlarmControlPanelAlarmArmHomeParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, data);
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
		public void AlarmArmHome(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, new AlarmControlPanelAlarmArmHomeParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmNight(ServiceTarget target, AlarmControlPanelAlarmArmNightParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, data);
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
		public void AlarmArmNight(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, new AlarmControlPanelAlarmArmNightParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmVacation(ServiceTarget target, AlarmControlPanelAlarmArmVacationParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, data);
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm vacation the alarm control panel with. eg: 1234</param>
		public void AlarmArmVacation(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, new AlarmControlPanelAlarmArmVacationParameters{Code = @code});
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmDisarm(ServiceTarget target, AlarmControlPanelAlarmDisarmParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, data);
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
		public void AlarmDisarm(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, new AlarmControlPanelAlarmDisarmParameters{Code = @code});
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmTrigger(ServiceTarget target, AlarmControlPanelAlarmTriggerParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, data);
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
		public void AlarmTrigger(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, new AlarmControlPanelAlarmTriggerParameters{Code = @code});
		}
	}

	public record AlarmControlPanelAlarmArmAwayParameters
	{
		///<summary>An optional code to arm away the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmCustomBypassParameters
	{
		///<summary>An optional code to arm custom bypass the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmHomeParameters
	{
		///<summary>An optional code to arm home the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmNightParameters
	{
		///<summary>An optional code to arm night the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmVacationParameters
	{
		///<summary>An optional code to arm vacation the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmDisarmParameters
	{
		///<summary>An optional code to disarm the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmTriggerParameters
	{
		///<summary>An optional code to trigger the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public class AlexaMediaServices
	{
		private readonly IHaContext _haContext;
		public AlexaMediaServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Clear last entries from Alexa history for each Alexa account.</summary>
		public void ClearHistory(AlexaMediaClearHistoryParameters data)
		{
			_haContext.CallService("alexa_media", "clear_history", null, data);
		}

		///<summary>Clear last entries from Alexa history for each Alexa account.</summary>
		///<param name="email">List of Alexa accounts to update. If empty, will delete from all known accounts. eg: my_email@alexa.com</param>
		///<param name="entries">Number of entries to clear from 1 to 50. If empty, clear 50. eg: 50</param>
		public void ClearHistory(object? @email = null, object? @entries = null)
		{
			_haContext.CallService("alexa_media", "clear_history", null, new AlexaMediaClearHistoryParameters{Email = @email, Entries = @entries});
		}

		///<summary>Force logout of Alexa Login account and deletion of .pickle. Intended for debugging use.</summary>
		public void ForceLogout(AlexaMediaForceLogoutParameters data)
		{
			_haContext.CallService("alexa_media", "force_logout", null, data);
		}

		///<summary>Force logout of Alexa Login account and deletion of .pickle. Intended for debugging use.</summary>
		///<param name="email">List of Alexa accounts to log out. If empty, will log out from all known accounts. eg: my_email@alexa.com</param>
		public void ForceLogout(object? @email = null)
		{
			_haContext.CallService("alexa_media", "force_logout", null, new AlexaMediaForceLogoutParameters{Email = @email});
		}

		///<summary>Forces update of last_called echo device for each Alexa account.</summary>
		public void UpdateLastCalled(AlexaMediaUpdateLastCalledParameters data)
		{
			_haContext.CallService("alexa_media", "update_last_called", null, data);
		}

		///<summary>Forces update of last_called echo device for each Alexa account.</summary>
		///<param name="email">List of Alexa accounts to update. If empty, will update all known accounts. eg: my_email@alexa.com</param>
		public void UpdateLastCalled(object? @email = null)
		{
			_haContext.CallService("alexa_media", "update_last_called", null, new AlexaMediaUpdateLastCalledParameters{Email = @email});
		}
	}

	public record AlexaMediaClearHistoryParameters
	{
		///<summary>List of Alexa accounts to update. If empty, will delete from all known accounts. eg: my_email@alexa.com</summary>
		[JsonPropertyName("email")]
		public object? Email { get; init; }

		///<summary>Number of entries to clear from 1 to 50. If empty, clear 50. eg: 50</summary>
		[JsonPropertyName("entries")]
		public object? Entries { get; init; }
	}

	public record AlexaMediaForceLogoutParameters
	{
		///<summary>List of Alexa accounts to log out. If empty, will log out from all known accounts. eg: my_email@alexa.com</summary>
		[JsonPropertyName("email")]
		public object? Email { get; init; }
	}

	public record AlexaMediaUpdateLastCalledParameters
	{
		///<summary>List of Alexa accounts to update. If empty, will update all known accounts. eg: my_email@alexa.com</summary>
		[JsonPropertyName("email")]
		public object? Email { get; init; }
	}

	public class AutomationServices
	{
		private readonly IHaContext _haContext;
		public AutomationServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the automation configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("automation", "reload", null);
		}

		///<summary>Toggle (enable / disable) an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("automation", "toggle", target);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void Trigger(ServiceTarget target, AutomationTriggerParameters data)
		{
			_haContext.CallService("automation", "trigger", target, data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public void Trigger(ServiceTarget target, bool? @skipCondition = null)
		{
			_haContext.CallService("automation", "trigger", target, new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target, AutomationTurnOffParameters data)
		{
			_haContext.CallService("automation", "turn_off", target, data);
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public void TurnOff(ServiceTarget target, bool? @stopActions = null)
		{
			_haContext.CallService("automation", "turn_off", target, new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Enable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("automation", "turn_on", target);
		}
	}

	public record AutomationTriggerParameters
	{
		///<summary>Whether or not the conditions will be skipped.</summary>
		[JsonPropertyName("skip_condition")]
		public bool? SkipCondition { get; init; }
	}

	public record AutomationTurnOffParameters
	{
		///<summary>Stop currently running actions.</summary>
		[JsonPropertyName("stop_actions")]
		public bool? StopActions { get; init; }
	}

	public class BayesianServices
	{
		private readonly IHaContext _haContext;
		public BayesianServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all bayesian entities</summary>
		public void Reload()
		{
			_haContext.CallService("bayesian", "reload", null);
		}
	}

	public class BrowserModServices
	{
		private readonly IHaContext _haContext;
		public BrowserModServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Cover screen in black until the mouse is moved or a key is pressed.</summary>
		public void Blackout(BrowserModBlackoutParameters data)
		{
			_haContext.CallService("browser_mod", "blackout", null, data);
		}

		///<summary>Cover screen in black until the mouse is moved or a key is pressed.</summary>
		///<param name="time">(optional) The blackout will turn on automatically after the specified number of seconds. It works kind of like a screensaver and will keep turning on until blackout is called again with time: -1. eg: 20</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Blackout(object? @time = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "blackout", null, new BrowserModBlackoutParameters{Time = @time, DeviceID = @deviceID});
		}

		public void CallService()
		{
			_haContext.CallService("browser_mod", "call_service", null);
		}

		public void CleanDevices()
		{
			_haContext.CallService("browser_mod", "clean_devices", null);
		}

		///<summary>Close all popups on all browsers.</summary>
		public void ClosePopup(BrowserModClosePopupParameters data)
		{
			_haContext.CallService("browser_mod", "close_popup", null, data);
		}

		///<summary>Close all popups on all browsers.</summary>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void ClosePopup(object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "close_popup", null, new BrowserModClosePopupParameters{DeviceID = @deviceID});
		}

		///<summary>Send a command to a browser.</summary>
		public void Command(BrowserModCommandParameters data)
		{
			_haContext.CallService("browser_mod", "command", null, data);
		}

		///<summary>Send a command to a browser.</summary>
		///<param name="command">Command to send eg: navigate</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Command(object? @command = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "command", null, new BrowserModCommandParameters{Command = @command, DeviceID = @deviceID});
		}

		///<summary>Send several commands to a browser</summary>
		public void Commands(BrowserModCommandsParameters data)
		{
			_haContext.CallService("browser_mod", "commands", null, data);
		}

		///<summary>Send several commands to a browser</summary>
		///<param name="commands">List of commands to send</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Commands(object? @commands = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "commands", null, new BrowserModCommandsParameters{Commands = @commands, DeviceID = @deviceID});
		}

		///<summary>On all browsers, show a popup, and a javascript alert with the current device ID.</summary>
		public void Debug(BrowserModDebugParameters data)
		{
			_haContext.CallService("browser_mod", "debug", null, data);
		}

		///<summary>On all browsers, show a popup, and a javascript alert with the current device ID.</summary>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Debug(object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "debug", null, new BrowserModDebugParameters{DeviceID = @deviceID});
		}

		///<summary>Do nothing for a while</summary>
		public void Delay(BrowserModDelayParameters data)
		{
			_haContext.CallService("browser_mod", "delay", null, data);
		}

		///<summary>Do nothing for a while</summary>
		///<param name="seconds">Number of seconds to delay eg: 5</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Delay(object? @seconds = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "delay", null, new BrowserModDelayParameters{Seconds = @seconds, DeviceID = @deviceID});
		}

		///<summary>Refresh the lovelace configuration.</summary>
		public void LovelaceReload(BrowserModLovelaceReloadParameters data)
		{
			_haContext.CallService("browser_mod", "lovelace_reload", null, data);
		}

		///<summary>Refresh the lovelace configuration.</summary>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void LovelaceReload(object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "lovelace_reload", null, new BrowserModLovelaceReloadParameters{DeviceID = @deviceID});
		}

		///<summary>Open the more info dialog of an entity on a browser.</summary>
		public void MoreInfo(BrowserModMoreInfoParameters data)
		{
			_haContext.CallService("browser_mod", "more_info", null, data);
		}

		///<summary>Open the more info dialog of an entity on a browser.</summary>
		///<param name="entityId">Entity to show more info for eg: camera.front_door</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		///<param name="large">(optional) Set to true to make wider eg: true</param>
		public void MoreInfo(object? @entityId = null, object? @deviceID = null, object? @large = null)
		{
			_haContext.CallService("browser_mod", "more_info", null, new BrowserModMoreInfoParameters{EntityId = @entityId, DeviceID = @deviceID, Large = @large});
		}

		///<summary>Navigate to a path on a browser.</summary>
		public void Navigate(BrowserModNavigateParameters data)
		{
			_haContext.CallService("browser_mod", "navigate", null, data);
		}

		///<summary>Navigate to a path on a browser.</summary>
		///<param name="navigationPath">Path to navigate to eg: /lovelace/1</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Navigate(object? @navigationPath = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "navigate", null, new BrowserModNavigateParameters{NavigationPath = @navigationPath, DeviceID = @deviceID});
		}

		///<summary>Remove a blackout from a browser.</summary>
		public void NoBlackout(BrowserModNoBlackoutParameters data)
		{
			_haContext.CallService("browser_mod", "no_blackout", null, data);
		}

		///<summary>Remove a blackout from a browser.</summary>
		///<param name="brightness">(optional) On a Fully Kiosk Browser Plus set the screen brightness from 0 - 255.</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void NoBlackout(object? @brightness = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "no_blackout", null, new BrowserModNoBlackoutParameters{Brightness = @brightness, DeviceID = @deviceID});
		}

		///<summary>Pop up a card on a browser.</summary>
		public void Popup(BrowserModPopupParameters data)
		{
			_haContext.CallService("browser_mod", "popup", null, data);
		}

		///<summary>Pop up a card on a browser.</summary>
		///<param name="title">Name to show in popup bar eg: Popup example</param>
		///<param name="card">YAML config for card to show</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		///<param name="large">(optional) Set to true to make wider eg: true</param>
		///<param name="hideHeader">(optional) Hide header title and close button eg: true</param>
		///<param name="autoClose">(optional) Close popup when mouse is moved or key is pressed. Also hides header eg: true</param>
		///<param name="time">(optional) When mouse isn't moved or keys aren't pressed for this amount of seconds, reopen. Only usable with auto_close. See blackout eg: 20</param>
		public void Popup(object? @title = null, object? @card = null, object? @deviceID = null, object? @large = null, object? @hideHeader = null, object? @autoClose = null, object? @time = null)
		{
			_haContext.CallService("browser_mod", "popup", null, new BrowserModPopupParameters{Title = @title, Card = @card, DeviceID = @deviceID, Large = @large, HideHeader = @hideHeader, AutoClose = @autoClose, Time = @time});
		}

		///<summary>On all browsers, change the theme.</summary>
		public void SetTheme(BrowserModSetThemeParameters data)
		{
			_haContext.CallService("browser_mod", "set_theme", null, data);
		}

		///<summary>On all browsers, change the theme.</summary>
		///<param name="theme">Theme to change to eg: {theme: "clear_light"}</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void SetTheme(object? @theme = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "set_theme", null, new BrowserModSetThemeParameters{Theme = @theme, DeviceID = @deviceID});
		}

		///<summary>Show a toast message in the bottom left on all browsers.</summary>
		public void Toast(BrowserModToastParameters data)
		{
			_haContext.CallService("browser_mod", "toast", null, data);
		}

		///<summary>Show a toast message in the bottom left on all browsers.</summary>
		///<param name="message">Message to show eg: Short message</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		///<param name="duration">(optional) Time in milliseconds to show message for. Set to 0 for persistent display. eg: 10000</param>
		public void Toast(object? @message = null, object? @deviceID = null, object? @duration = null)
		{
			_haContext.CallService("browser_mod", "toast", null, new BrowserModToastParameters{Message = @message, DeviceID = @deviceID, Duration = @duration});
		}

		///<summary>Forces the browser to reload the page. Same as clicking your browser's refresh button. Note: This is not guaranteed to clear the frontend cache.</summary>
		public void WindowReload(BrowserModWindowReloadParameters data)
		{
			_haContext.CallService("browser_mod", "window_reload", null, data);
		}

		///<summary>Forces the browser to reload the page. Same as clicking your browser's refresh button. Note: This is not guaranteed to clear the frontend cache.</summary>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void WindowReload(object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "window_reload", null, new BrowserModWindowReloadParameters{DeviceID = @deviceID});
		}
	}

	public record BrowserModBlackoutParameters
	{
		///<summary>(optional) The blackout will turn on automatically after the specified number of seconds. It works kind of like a screensaver and will keep turning on until blackout is called again with time: -1. eg: 20</summary>
		[JsonPropertyName("time")]
		public object? Time { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModClosePopupParameters
	{
		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModCommandParameters
	{
		///<summary>Command to send eg: navigate</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModCommandsParameters
	{
		///<summary>List of commands to send</summary>
		[JsonPropertyName("commands")]
		public object? Commands { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModDebugParameters
	{
		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModDelayParameters
	{
		///<summary>Number of seconds to delay eg: 5</summary>
		[JsonPropertyName("seconds")]
		public object? Seconds { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModLovelaceReloadParameters
	{
		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModMoreInfoParameters
	{
		///<summary>Entity to show more info for eg: camera.front_door</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }

		///<summary>(optional) Set to true to make wider eg: true</summary>
		[JsonPropertyName("large")]
		public object? Large { get; init; }
	}

	public record BrowserModNavigateParameters
	{
		///<summary>Path to navigate to eg: /lovelace/1</summary>
		[JsonPropertyName("navigation_path")]
		public object? NavigationPath { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModNoBlackoutParameters
	{
		///<summary>(optional) On a Fully Kiosk Browser Plus set the screen brightness from 0 - 255.</summary>
		[JsonPropertyName("brightness")]
		public object? Brightness { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModPopupParameters
	{
		///<summary>Name to show in popup bar eg: Popup example</summary>
		[JsonPropertyName("title")]
		public object? Title { get; init; }

		///<summary>YAML config for card to show</summary>
		[JsonPropertyName("card")]
		public object? Card { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }

		///<summary>(optional) Set to true to make wider eg: true</summary>
		[JsonPropertyName("large")]
		public object? Large { get; init; }

		///<summary>(optional) Hide header title and close button eg: true</summary>
		[JsonPropertyName("hide_header")]
		public object? HideHeader { get; init; }

		///<summary>(optional) Close popup when mouse is moved or key is pressed. Also hides header eg: true</summary>
		[JsonPropertyName("auto_close")]
		public object? AutoClose { get; init; }

		///<summary>(optional) When mouse isn't moved or keys aren't pressed for this amount of seconds, reopen. Only usable with auto_close. See blackout eg: 20</summary>
		[JsonPropertyName("time")]
		public object? Time { get; init; }
	}

	public record BrowserModSetThemeParameters
	{
		///<summary>Theme to change to eg: {theme: "clear_light"}</summary>
		[JsonPropertyName("theme")]
		public object? Theme { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModToastParameters
	{
		///<summary>Message to show eg: Short message</summary>
		[JsonPropertyName("message")]
		public object? Message { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }

		///<summary>(optional) Time in milliseconds to show message for. Set to 0 for persistent display. eg: 10000</summary>
		[JsonPropertyName("duration")]
		public object? Duration { get; init; }
	}

	public record BrowserModWindowReloadParameters
	{
		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public class ButtonServices
	{
		private readonly IHaContext _haContext;
		public ButtonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Press the button entity.</summary>
		///<param name="target">The target for this service call</param>
		public void Press(ServiceTarget target)
		{
			_haContext.CallService("button", "press", target);
		}
	}

	public class CameraServices
	{
		private readonly IHaContext _haContext;
		public CameraServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Disable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void DisableMotionDetection(ServiceTarget target)
		{
			_haContext.CallService("camera", "disable_motion_detection", target);
		}

		///<summary>Enable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void EnableMotionDetection(ServiceTarget target)
		{
			_haContext.CallService("camera", "enable_motion_detection", target);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayStream(ServiceTarget target, CameraPlayStreamParameters data)
		{
			_haContext.CallService("camera", "play_stream", target, data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public void PlayStream(ServiceTarget target, string @mediaPlayer, object? @format = null)
		{
			_haContext.CallService("camera", "play_stream", target, new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		public void Record(ServiceTarget target, CameraRecordParameters data)
		{
			_haContext.CallService("camera", "record", target, data);
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public void Record(ServiceTarget target, string @filename, long? @duration = null, long? @lookback = null)
		{
			_haContext.CallService("camera", "record", target, new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void Snapshot(ServiceTarget target, CameraSnapshotParameters data)
		{
			_haContext.CallService("camera", "snapshot", target, data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public void Snapshot(ServiceTarget target, string @filename)
		{
			_haContext.CallService("camera", "snapshot", target, new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Turn off camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_off", target);
		}

		///<summary>Turn on camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_on", target);
		}
	}

	public record CameraPlayStreamParameters
	{
		///<summary>Name(s) of media player to stream to.</summary>
		[JsonPropertyName("media_player")]
		public string? MediaPlayer { get; init; }

		///<summary>Stream format supported by media player.</summary>
		[JsonPropertyName("format")]
		public object? Format { get; init; }
	}

	public record CameraRecordParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</summary>
		[JsonPropertyName("filename")]
		public string? Filename { get; init; }

		///<summary>Target recording length.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }

		///<summary>Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</summary>
		[JsonPropertyName("lookback")]
		public long? Lookback { get; init; }
	}

	public record CameraSnapshotParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</summary>
		[JsonPropertyName("filename")]
		public string? Filename { get; init; }
	}

	public class ClimateServices
	{
		private readonly IHaContext _haContext;
		public ClimateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetAuxHeat(ServiceTarget target, ClimateSetAuxHeatParameters data)
		{
			_haContext.CallService("climate", "set_aux_heat", target, data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public void SetAuxHeat(ServiceTarget target, bool @auxHeat)
		{
			_haContext.CallService("climate", "set_aux_heat", target, new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanMode(ServiceTarget target, ClimateSetFanModeParameters data)
		{
			_haContext.CallService("climate", "set_fan_mode", target, data);
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public void SetFanMode(ServiceTarget target, string @fanMode)
		{
			_haContext.CallService("climate", "set_fan_mode", target, new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHumidity(ServiceTarget target, ClimateSetHumidityParameters data)
		{
			_haContext.CallService("climate", "set_humidity", target, data);
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public void SetHumidity(ServiceTarget target, long @humidity)
		{
			_haContext.CallService("climate", "set_humidity", target, new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHvacMode(ServiceTarget target, ClimateSetHvacModeParameters data)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public void SetHvacMode(ServiceTarget target, object? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPresetMode(ServiceTarget target, ClimateSetPresetModeParameters data)
		{
			_haContext.CallService("climate", "set_preset_mode", target, data);
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public void SetPresetMode(ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("climate", "set_preset_mode", target, new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetSwingMode(ServiceTarget target, ClimateSetSwingModeParameters data)
		{
			_haContext.CallService("climate", "set_swing_mode", target, data);
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public void SetSwingMode(ServiceTarget target, string @swingMode)
		{
			_haContext.CallService("climate", "set_swing_mode", target, new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetTemperature(ServiceTarget target, ClimateSetTemperatureParameters data)
		{
			_haContext.CallService("climate", "set_temperature", target, data);
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public void SetTemperature(ServiceTarget target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, object? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_temperature", target, new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Turn climate device off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_off", target);
		}

		///<summary>Turn climate device on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_on", target);
		}
	}

	public record ClimateSetAuxHeatParameters
	{
		///<summary>New value of auxiliary heater.</summary>
		[JsonPropertyName("aux_heat")]
		public bool? AuxHeat { get; init; }
	}

	public record ClimateSetFanModeParameters
	{
		///<summary>New value of fan mode. eg: low</summary>
		[JsonPropertyName("fan_mode")]
		public string? FanMode { get; init; }
	}

	public record ClimateSetHumidityParameters
	{
		///<summary>New target humidity for climate device.</summary>
		[JsonPropertyName("humidity")]
		public long? Humidity { get; init; }
	}

	public record ClimateSetHvacModeParameters
	{
		///<summary>New value of operation mode.</summary>
		[JsonPropertyName("hvac_mode")]
		public object? HvacMode { get; init; }
	}

	public record ClimateSetPresetModeParameters
	{
		///<summary>New value of preset mode. eg: away</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public record ClimateSetSwingModeParameters
	{
		///<summary>New value of swing mode. eg: horizontal</summary>
		[JsonPropertyName("swing_mode")]
		public string? SwingMode { get; init; }
	}

	public record ClimateSetTemperatureParameters
	{
		///<summary>New target temperature for HVAC.</summary>
		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		///<summary>New target high temperature for HVAC.</summary>
		[JsonPropertyName("target_temp_high")]
		public double? TargetTempHigh { get; init; }

		///<summary>New target low temperature for HVAC.</summary>
		[JsonPropertyName("target_temp_low")]
		public double? TargetTempLow { get; init; }

		///<summary>HVAC operation mode to set temperature to.</summary>
		[JsonPropertyName("hvac_mode")]
		public object? HvacMode { get; init; }
	}

	public class CloudServices
	{
		private readonly IHaContext _haContext;
		public CloudServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Make instance UI available outside over NabuCasa cloud</summary>
		public void RemoteConnect()
		{
			_haContext.CallService("cloud", "remote_connect", null);
		}

		///<summary>Disconnect UI from NabuCasa cloud</summary>
		public void RemoteDisconnect()
		{
			_haContext.CallService("cloud", "remote_disconnect", null);
		}
	}

	public class ConversationServices
	{
		private readonly IHaContext _haContext;
		public ConversationServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Launch a conversation from a transcribed text.</summary>
		public void Process(ConversationProcessParameters data)
		{
			_haContext.CallService("conversation", "process", null, data);
		}

		///<summary>Launch a conversation from a transcribed text.</summary>
		///<param name="text">Transcribed text eg: Turn all lights on</param>
		public void Process(string? @text = null)
		{
			_haContext.CallService("conversation", "process", null, new ConversationProcessParameters{Text = @text});
		}
	}

	public record ConversationProcessParameters
	{
		///<summary>Transcribed text eg: Turn all lights on</summary>
		[JsonPropertyName("text")]
		public string? Text { get; init; }
	}

	public class CounterServices
	{
		private readonly IHaContext _haContext;
		public CounterServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The target for this service call</param>
		public void Configure(ServiceTarget target, CounterConfigureParameters data)
		{
			_haContext.CallService("counter", "configure", target, data);
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="minimum">New minimum value for the counter or None to remove minimum.</param>
		///<param name="maximum">New maximum value for the counter or None to remove maximum.</param>
		///<param name="step">New value for step.</param>
		///<param name="initial">New value for initial.</param>
		///<param name="value">New state value.</param>
		public void Configure(ServiceTarget target, long? @minimum = null, long? @maximum = null, long? @step = null, long? @initial = null, long? @value = null)
		{
			_haContext.CallService("counter", "configure", target, new CounterConfigureParameters{Minimum = @minimum, Maximum = @maximum, Step = @step, Initial = @initial, Value = @value});
		}

		///<summary>Decrement a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(ServiceTarget target)
		{
			_haContext.CallService("counter", "decrement", target);
		}

		///<summary>Increment a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(ServiceTarget target)
		{
			_haContext.CallService("counter", "increment", target);
		}

		///<summary>Reset a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Reset(ServiceTarget target)
		{
			_haContext.CallService("counter", "reset", target);
		}
	}

	public record CounterConfigureParameters
	{
		///<summary>New minimum value for the counter or None to remove minimum.</summary>
		[JsonPropertyName("minimum")]
		public long? Minimum { get; init; }

		///<summary>New maximum value for the counter or None to remove maximum.</summary>
		[JsonPropertyName("maximum")]
		public long? Maximum { get; init; }

		///<summary>New value for step.</summary>
		[JsonPropertyName("step")]
		public long? Step { get; init; }

		///<summary>New value for initial.</summary>
		[JsonPropertyName("initial")]
		public long? Initial { get; init; }

		///<summary>New state value.</summary>
		[JsonPropertyName("value")]
		public long? Value { get; init; }
	}

	public class CoverServices
	{
		private readonly IHaContext _haContext;
		public CoverServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Close all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover", target);
		}

		///<summary>Close all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover_tilt", target);
		}

		///<summary>Open all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover", target);
		}

		///<summary>Open all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover_tilt", target);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverPosition(ServiceTarget target, CoverSetCoverPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_position", target, data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="position">Position of the cover</param>
		public void SetCoverPosition(ServiceTarget target, long @position)
		{
			_haContext.CallService("cover", "set_cover_position", target, new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverTiltPosition(ServiceTarget target, CoverSetCoverTiltPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public void SetCoverTiltPosition(ServiceTarget target, long @tiltPosition)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover", target);
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover_tilt", target);
		}

		///<summary>Toggle a cover open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle", target);
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void ToggleCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle_cover_tilt", target);
		}
	}

	public record CoverSetCoverPositionParameters
	{
		///<summary>Position of the cover</summary>
		[JsonPropertyName("position")]
		public long? Position { get; init; }
	}

	public record CoverSetCoverTiltPositionParameters
	{
		///<summary>Tilt position of the cover.</summary>
		[JsonPropertyName("tilt_position")]
		public long? TiltPosition { get; init; }
	}

	public class DeviceTrackerServices
	{
		private readonly IHaContext _haContext;
		public DeviceTrackerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Control tracked device.</summary>
		public void See(DeviceTrackerSeeParameters data)
		{
			_haContext.CallService("device_tracker", "see", null, data);
		}

		///<summary>Control tracked device.</summary>
		///<param name="mac">MAC address of device eg: FF:FF:FF:FF:FF:FF</param>
		///<param name="devId">Id of device (find id in known_devices.yaml). eg: phonedave</param>
		///<param name="hostName">Hostname of device eg: Dave</param>
		///<param name="locationName">Name of location where device is located (not_home is away). eg: home</param>
		///<param name="gps">GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</param>
		///<param name="gpsAccuracy">Accuracy of GPS coordinates.</param>
		///<param name="battery">Battery level of device.</param>
		public void See(string? @mac = null, string? @devId = null, string? @hostName = null, string? @locationName = null, object? @gps = null, long? @gpsAccuracy = null, long? @battery = null)
		{
			_haContext.CallService("device_tracker", "see", null, new DeviceTrackerSeeParameters{Mac = @mac, DevId = @devId, HostName = @hostName, LocationName = @locationName, Gps = @gps, GpsAccuracy = @gpsAccuracy, Battery = @battery});
		}
	}

	public record DeviceTrackerSeeParameters
	{
		///<summary>MAC address of device eg: FF:FF:FF:FF:FF:FF</summary>
		[JsonPropertyName("mac")]
		public string? Mac { get; init; }

		///<summary>Id of device (find id in known_devices.yaml). eg: phonedave</summary>
		[JsonPropertyName("dev_id")]
		public string? DevId { get; init; }

		///<summary>Hostname of device eg: Dave</summary>
		[JsonPropertyName("host_name")]
		public string? HostName { get; init; }

		///<summary>Name of location where device is located (not_home is away). eg: home</summary>
		[JsonPropertyName("location_name")]
		public string? LocationName { get; init; }

		///<summary>GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</summary>
		[JsonPropertyName("gps")]
		public object? Gps { get; init; }

		///<summary>Accuracy of GPS coordinates.</summary>
		[JsonPropertyName("gps_accuracy")]
		public long? GpsAccuracy { get; init; }

		///<summary>Battery level of device.</summary>
		[JsonPropertyName("battery")]
		public long? Battery { get; init; }
	}

	public class EsphomeServices
	{
		private readonly IHaContext _haContext;
		public EsphomeServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Calls the service control_servo of the node office_switch</summary>
		public void OfficeSwitchControlServo(EsphomeOfficeSwitchControlServoParameters data)
		{
			_haContext.CallService("esphome", "office_switch_control_servo", null, data);
		}

		///<summary>Calls the service control_servo of the node office_switch</summary>
		///<param name="level"> eg: 12.3</param>
		public void OfficeSwitchControlServo(double @level)
		{
			_haContext.CallService("esphome", "office_switch_control_servo", null, new EsphomeOfficeSwitchControlServoParameters{Level = @level});
		}

		///<summary>Calls the service control_servo of the node shitty_motor</summary>
		public void ShittyMotorControlServo(EsphomeShittyMotorControlServoParameters data)
		{
			_haContext.CallService("esphome", "shitty_motor_control_servo", null, data);
		}

		///<summary>Calls the service control_servo of the node shitty_motor</summary>
		///<param name="level"> eg: 12.3</param>
		public void ShittyMotorControlServo(double @level)
		{
			_haContext.CallService("esphome", "shitty_motor_control_servo", null, new EsphomeShittyMotorControlServoParameters{Level = @level});
		}
	}

	public record EsphomeOfficeSwitchControlServoParameters
	{
		///<summary> eg: 12.3</summary>
		[JsonPropertyName("level")]
		public double? Level { get; init; }
	}

	public record EsphomeShittyMotorControlServoParameters
	{
		///<summary> eg: 12.3</summary>
		[JsonPropertyName("level")]
		public double? Level { get; init; }
	}

	public class FanServices
	{
		private readonly IHaContext _haContext;
		public FanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		public void DecreaseSpeed(ServiceTarget target, FanDecreaseSpeedParameters data)
		{
			_haContext.CallService("fan", "decrease_speed", target, data);
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentageStep">Decrease speed by a percentage.</param>
		public void DecreaseSpeed(ServiceTarget target, long? @percentageStep = null)
		{
			_haContext.CallService("fan", "decrease_speed", target, new FanDecreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		public void IncreaseSpeed(ServiceTarget target, FanIncreaseSpeedParameters data)
		{
			_haContext.CallService("fan", "increase_speed", target, data);
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentageStep">Increase speed by a percentage.</param>
		public void IncreaseSpeed(ServiceTarget target, long? @percentageStep = null)
		{
			_haContext.CallService("fan", "increase_speed", target, new FanIncreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The target for this service call</param>
		public void Oscillate(ServiceTarget target, FanOscillateParameters data)
		{
			_haContext.CallService("fan", "oscillate", target, data);
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="oscillating">Flag to turn on/off oscillation.</param>
		public void Oscillate(ServiceTarget target, bool @oscillating)
		{
			_haContext.CallService("fan", "oscillate", target, new FanOscillateParameters{Oscillating = @oscillating});
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDirection(ServiceTarget target, FanSetDirectionParameters data)
		{
			_haContext.CallService("fan", "set_direction", target, data);
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="direction">The direction to rotate.</param>
		public void SetDirection(ServiceTarget target, object @direction)
		{
			_haContext.CallService("fan", "set_direction", target, new FanSetDirectionParameters{Direction = @direction});
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPercentage(ServiceTarget target, FanSetPercentageParameters data)
		{
			_haContext.CallService("fan", "set_percentage", target, data);
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentage">Percentage speed setting.</param>
		public void SetPercentage(ServiceTarget target, long @percentage)
		{
			_haContext.CallService("fan", "set_percentage", target, new FanSetPercentageParameters{Percentage = @percentage});
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPresetMode(ServiceTarget target, FanSetPresetModeParameters data)
		{
			_haContext.CallService("fan", "set_preset_mode", target, data);
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetMode">New value of preset mode. eg: auto</param>
		public void SetPresetMode(ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("fan", "set_preset_mode", target, new FanSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Toggle the fan on/off.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("fan", "toggle", target);
		}

		///<summary>Turn fan off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("fan", "turn_off", target);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, FanTurnOnParameters data)
		{
			_haContext.CallService("fan", "turn_on", target, data);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="speed">Speed setting. eg: high</param>
		///<param name="percentage">Percentage speed setting.</param>
		///<param name="presetMode">Preset mode setting. eg: auto</param>
		public void TurnOn(ServiceTarget target, string? @speed = null, long? @percentage = null, string? @presetMode = null)
		{
			_haContext.CallService("fan", "turn_on", target, new FanTurnOnParameters{Speed = @speed, Percentage = @percentage, PresetMode = @presetMode});
		}
	}

	public record FanDecreaseSpeedParameters
	{
		///<summary>Decrease speed by a percentage.</summary>
		[JsonPropertyName("percentage_step")]
		public long? PercentageStep { get; init; }
	}

	public record FanIncreaseSpeedParameters
	{
		///<summary>Increase speed by a percentage.</summary>
		[JsonPropertyName("percentage_step")]
		public long? PercentageStep { get; init; }
	}

	public record FanOscillateParameters
	{
		///<summary>Flag to turn on/off oscillation.</summary>
		[JsonPropertyName("oscillating")]
		public bool? Oscillating { get; init; }
	}

	public record FanSetDirectionParameters
	{
		///<summary>The direction to rotate.</summary>
		[JsonPropertyName("direction")]
		public object? Direction { get; init; }
	}

	public record FanSetPercentageParameters
	{
		///<summary>Percentage speed setting.</summary>
		[JsonPropertyName("percentage")]
		public long? Percentage { get; init; }
	}

	public record FanSetPresetModeParameters
	{
		///<summary>New value of preset mode. eg: auto</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public record FanTurnOnParameters
	{
		///<summary>Speed setting. eg: high</summary>
		[JsonPropertyName("speed")]
		public string? Speed { get; init; }

		///<summary>Percentage speed setting.</summary>
		[JsonPropertyName("percentage")]
		public long? Percentage { get; init; }

		///<summary>Preset mode setting. eg: auto</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public class FfmpegServices
	{
		private readonly IHaContext _haContext;
		public FfmpegServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send a restart command to a ffmpeg based sensor.</summary>
		public void Restart(FfmpegRestartParameters data)
		{
			_haContext.CallService("ffmpeg", "restart", null, data);
		}

		///<summary>Send a restart command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will restart. Platform dependent.</param>
		public void Restart(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "restart", null, new FfmpegRestartParameters{EntityId = @entityId});
		}

		///<summary>Send a start command to a ffmpeg based sensor.</summary>
		public void Start(FfmpegStartParameters data)
		{
			_haContext.CallService("ffmpeg", "start", null, data);
		}

		///<summary>Send a start command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will start. Platform dependent.</param>
		public void Start(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "start", null, new FfmpegStartParameters{EntityId = @entityId});
		}

		///<summary>Send a stop command to a ffmpeg based sensor.</summary>
		public void Stop(FfmpegStopParameters data)
		{
			_haContext.CallService("ffmpeg", "stop", null, data);
		}

		///<summary>Send a stop command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will stop. Platform dependent.</param>
		public void Stop(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "stop", null, new FfmpegStopParameters{EntityId = @entityId});
		}
	}

	public record FfmpegRestartParameters
	{
		///<summary>Name of entity that will restart. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record FfmpegStartParameters
	{
		///<summary>Name of entity that will start. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record FfmpegStopParameters
	{
		///<summary>Name of entity that will stop. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public class FrontendServices
	{
		private readonly IHaContext _haContext;
		public FrontendServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload themes from YAML configuration.</summary>
		public void ReloadThemes()
		{
			_haContext.CallService("frontend", "reload_themes", null);
		}

		///<summary>Set a theme unless the client selected per-device theme.</summary>
		public void SetTheme(FrontendSetThemeParameters data)
		{
			_haContext.CallService("frontend", "set_theme", null, data);
		}

		///<summary>Set a theme unless the client selected per-device theme.</summary>
		///<param name="name">Name of a predefined theme eg: default</param>
		///<param name="mode">The mode the theme is for.</param>
		public void SetTheme(object @name, object? @mode = null)
		{
			_haContext.CallService("frontend", "set_theme", null, new FrontendSetThemeParameters{Name = @name, Mode = @mode});
		}
	}

	public record FrontendSetThemeParameters
	{
		///<summary>Name of a predefined theme eg: default</summary>
		[JsonPropertyName("name")]
		public object? Name { get; init; }

		///<summary>The mode the theme is for.</summary>
		[JsonPropertyName("mode")]
		public object? Mode { get; init; }
	}

	public class GoogleServices
	{
		private readonly IHaContext _haContext;
		public GoogleServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Add a new calendar event.</summary>
		public void AddEvent(GoogleAddEventParameters data)
		{
			_haContext.CallService("google", "add_event", null, data);
		}

		///<summary>Add a new calendar event.</summary>
		///<param name="calendarId">The id of the calendar you want. eg: Your email</param>
		///<param name="summary">Acts as the title of the event. eg: Bowling</param>
		///<param name="description">The description of the event. Optional. eg: Birthday bowling</param>
		///<param name="startDateTime">The date and time the event should start. eg: 2019-03-22 20:00:00</param>
		///<param name="endDateTime">The date and time the event should end. eg: 2019-03-22 22:00:00</param>
		///<param name="startDate">The date the whole day event should start. eg: 2019-03-10</param>
		///<param name="endDate">The date the whole day event should end. eg: 2019-03-11</param>
		///<param name="in">Days or weeks that you want to create the event in. eg: "days": 2 or "weeks": 2</param>
		public void AddEvent(string @calendarId, string @summary, string? @description = null, string? @startDateTime = null, string? @endDateTime = null, string? @startDate = null, string? @endDate = null, object? @in = null)
		{
			_haContext.CallService("google", "add_event", null, new GoogleAddEventParameters{CalendarId = @calendarId, Summary = @summary, Description = @description, StartDateTime = @startDateTime, EndDateTime = @endDateTime, StartDate = @startDate, EndDate = @endDate, In = @in});
		}

		///<summary>Add a new calendar event.</summary>
		///<param name="target">The target for this service call</param>
		public void CreateEvent(ServiceTarget target, GoogleCreateEventParameters data)
		{
			_haContext.CallService("google", "create_event", target, data);
		}

		///<summary>Add a new calendar event.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="summary">Acts as the title of the event. eg: Bowling</param>
		///<param name="description">The description of the event. Optional. eg: Birthday bowling</param>
		///<param name="startDateTime">The date and time the event should start. eg: 2022-03-22 20:00:00</param>
		///<param name="endDateTime">The date and time the event should end. eg: 2022-03-22 22:00:00</param>
		///<param name="startDate">The date the whole day event should start. eg: 2022-03-10</param>
		///<param name="endDate">The date the whole day event should end. eg: 2022-03-11</param>
		///<param name="in">Days or weeks that you want to create the event in. eg: "days": 2 or "weeks": 2</param>
		public void CreateEvent(ServiceTarget target, string @summary, string? @description = null, string? @startDateTime = null, string? @endDateTime = null, string? @startDate = null, string? @endDate = null, object? @in = null)
		{
			_haContext.CallService("google", "create_event", target, new GoogleCreateEventParameters{Summary = @summary, Description = @description, StartDateTime = @startDateTime, EndDateTime = @endDateTime, StartDate = @startDate, EndDate = @endDate, In = @in});
		}
	}

	public record GoogleAddEventParameters
	{
		///<summary>The id of the calendar you want. eg: Your email</summary>
		[JsonPropertyName("calendar_id")]
		public string? CalendarId { get; init; }

		///<summary>Acts as the title of the event. eg: Bowling</summary>
		[JsonPropertyName("summary")]
		public string? Summary { get; init; }

		///<summary>The description of the event. Optional. eg: Birthday bowling</summary>
		[JsonPropertyName("description")]
		public string? Description { get; init; }

		///<summary>The date and time the event should start. eg: 2019-03-22 20:00:00</summary>
		[JsonPropertyName("start_date_time")]
		public string? StartDateTime { get; init; }

		///<summary>The date and time the event should end. eg: 2019-03-22 22:00:00</summary>
		[JsonPropertyName("end_date_time")]
		public string? EndDateTime { get; init; }

		///<summary>The date the whole day event should start. eg: 2019-03-10</summary>
		[JsonPropertyName("start_date")]
		public string? StartDate { get; init; }

		///<summary>The date the whole day event should end. eg: 2019-03-11</summary>
		[JsonPropertyName("end_date")]
		public string? EndDate { get; init; }

		///<summary>Days or weeks that you want to create the event in. eg: "days": 2 or "weeks": 2</summary>
		[JsonPropertyName("in")]
		public object? In { get; init; }
	}

	public record GoogleCreateEventParameters
	{
		///<summary>Acts as the title of the event. eg: Bowling</summary>
		[JsonPropertyName("summary")]
		public string? Summary { get; init; }

		///<summary>The description of the event. Optional. eg: Birthday bowling</summary>
		[JsonPropertyName("description")]
		public string? Description { get; init; }

		///<summary>The date and time the event should start. eg: 2022-03-22 20:00:00</summary>
		[JsonPropertyName("start_date_time")]
		public string? StartDateTime { get; init; }

		///<summary>The date and time the event should end. eg: 2022-03-22 22:00:00</summary>
		[JsonPropertyName("end_date_time")]
		public string? EndDateTime { get; init; }

		///<summary>The date the whole day event should start. eg: 2022-03-10</summary>
		[JsonPropertyName("start_date")]
		public string? StartDate { get; init; }

		///<summary>The date the whole day event should end. eg: 2022-03-11</summary>
		[JsonPropertyName("end_date")]
		public string? EndDate { get; init; }

		///<summary>Days or weeks that you want to create the event in. eg: "days": 2 or "weeks": 2</summary>
		[JsonPropertyName("in")]
		public object? In { get; init; }
	}

	public class GroupServices
	{
		private readonly IHaContext _haContext;
		public GroupServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload group configuration, entities, and notify services.</summary>
		public void Reload()
		{
			_haContext.CallService("group", "reload", null);
		}

		///<summary>Remove a user group.</summary>
		public void Remove(GroupRemoveParameters data)
		{
			_haContext.CallService("group", "remove", null, data);
		}

		///<summary>Remove a user group.</summary>
		///<param name="objectId">Group id and part of entity id. eg: test_group</param>
		public void Remove(object @objectId)
		{
			_haContext.CallService("group", "remove", null, new GroupRemoveParameters{ObjectId = @objectId});
		}

		///<summary>Create/Update a user group.</summary>
		public void Set(GroupSetParameters data)
		{
			_haContext.CallService("group", "set", null, data);
		}

		///<summary>Create/Update a user group.</summary>
		///<param name="objectId">Group id and part of entity id. eg: test_group</param>
		///<param name="name">Name of group eg: My test group</param>
		///<param name="icon">Name of icon for the group. eg: mdi:camera</param>
		///<param name="entities">List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</param>
		///<param name="addEntities">List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</param>
		///<param name="all">Enable this option if the group should only turn on when all entities are on.</param>
		public void Set(string @objectId, string? @name = null, object? @icon = null, object? @entities = null, object? @addEntities = null, bool? @all = null)
		{
			_haContext.CallService("group", "set", null, new GroupSetParameters{ObjectId = @objectId, Name = @name, Icon = @icon, Entities = @entities, AddEntities = @addEntities, All = @all});
		}
	}

	public record GroupRemoveParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[JsonPropertyName("object_id")]
		public object? ObjectId { get; init; }
	}

	public record GroupSetParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[JsonPropertyName("object_id")]
		public string? ObjectId { get; init; }

		///<summary>Name of group eg: My test group</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Name of icon for the group. eg: mdi:camera</summary>
		[JsonPropertyName("icon")]
		public object? Icon { get; init; }

		///<summary>List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</summary>
		[JsonPropertyName("add_entities")]
		public object? AddEntities { get; init; }

		///<summary>Enable this option if the group should only turn on when all entities are on.</summary>
		[JsonPropertyName("all")]
		public bool? All { get; init; }
	}

	public class HassioServices
	{
		private readonly IHaContext _haContext;
		public HassioServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Restart add-on.</summary>
		public void AddonRestart(HassioAddonRestartParameters data)
		{
			_haContext.CallService("hassio", "addon_restart", null, data);
		}

		///<summary>Restart add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonRestart(string @addon)
		{
			_haContext.CallService("hassio", "addon_restart", null, new HassioAddonRestartParameters{Addon = @addon});
		}

		///<summary>Start add-on.</summary>
		public void AddonStart(HassioAddonStartParameters data)
		{
			_haContext.CallService("hassio", "addon_start", null, data);
		}

		///<summary>Start add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStart(string @addon)
		{
			_haContext.CallService("hassio", "addon_start", null, new HassioAddonStartParameters{Addon = @addon});
		}

		///<summary>Write data to add-on stdin.</summary>
		public void AddonStdin(HassioAddonStdinParameters data)
		{
			_haContext.CallService("hassio", "addon_stdin", null, data);
		}

		///<summary>Write data to add-on stdin.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStdin(string @addon)
		{
			_haContext.CallService("hassio", "addon_stdin", null, new HassioAddonStdinParameters{Addon = @addon});
		}

		///<summary>Stop add-on.</summary>
		public void AddonStop(HassioAddonStopParameters data)
		{
			_haContext.CallService("hassio", "addon_stop", null, data);
		}

		///<summary>Stop add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStop(string @addon)
		{
			_haContext.CallService("hassio", "addon_stop", null, new HassioAddonStopParameters{Addon = @addon});
		}

		///<summary>Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
		public void AddonUpdate(HassioAddonUpdateParameters data)
		{
			_haContext.CallService("hassio", "addon_update", null, data);
		}

		///<summary>Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonUpdate(string @addon)
		{
			_haContext.CallService("hassio", "addon_update", null, new HassioAddonUpdateParameters{Addon = @addon});
		}

		///<summary>Create a full backup.</summary>
		public void BackupFull(HassioBackupFullParameters data)
		{
			_haContext.CallService("hassio", "backup_full", null, data);
		}

		///<summary>Create a full backup.</summary>
		///<param name="name">Optional (default = current date and time). eg: Backup 1</param>
		///<param name="password">Optional password. eg: password</param>
		///<param name="compressed">Use compressed archives</param>
		public void BackupFull(string? @name = null, string? @password = null, bool? @compressed = null)
		{
			_haContext.CallService("hassio", "backup_full", null, new HassioBackupFullParameters{Name = @name, Password = @password, Compressed = @compressed});
		}

		///<summary>Create a partial backup.</summary>
		public void BackupPartial(HassioBackupPartialParameters data)
		{
			_haContext.CallService("hassio", "backup_partial", null, data);
		}

		///<summary>Create a partial backup.</summary>
		///<param name="homeassistant">Backup Home Assistant settings</param>
		///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</param>
		///<param name="folders">Optional list of directories. eg: ["homeassistant","share"]</param>
		///<param name="name">Optional (default = current date and time). eg: Partial backup 1</param>
		///<param name="password">Optional password. eg: password</param>
		///<param name="compressed">Use compressed archives</param>
		public void BackupPartial(bool? @homeassistant = null, object? @addons = null, object? @folders = null, string? @name = null, string? @password = null, bool? @compressed = null)
		{
			_haContext.CallService("hassio", "backup_partial", null, new HassioBackupPartialParameters{Homeassistant = @homeassistant, Addons = @addons, Folders = @folders, Name = @name, Password = @password, Compressed = @compressed});
		}

		///<summary>Reboot the host system.</summary>
		public void HostReboot()
		{
			_haContext.CallService("hassio", "host_reboot", null);
		}

		///<summary>Poweroff the host system.</summary>
		public void HostShutdown()
		{
			_haContext.CallService("hassio", "host_shutdown", null);
		}

		///<summary>Restore from full backup.</summary>
		public void RestoreFull(HassioRestoreFullParameters data)
		{
			_haContext.CallService("hassio", "restore_full", null, data);
		}

		///<summary>Restore from full backup.</summary>
		///<param name="slug">Slug of backup to restore from.</param>
		///<param name="password">Optional password. eg: password</param>
		public void RestoreFull(string @slug, string? @password = null)
		{
			_haContext.CallService("hassio", "restore_full", null, new HassioRestoreFullParameters{Slug = @slug, Password = @password});
		}

		///<summary>Restore from partial backup.</summary>
		public void RestorePartial(HassioRestorePartialParameters data)
		{
			_haContext.CallService("hassio", "restore_partial", null, data);
		}

		///<summary>Restore from partial backup.</summary>
		///<param name="slug">Slug of backup to restore from.</param>
		///<param name="homeassistant">Restore Home Assistant</param>
		///<param name="folders">Optional list of directories. eg: ["homeassistant","share"]</param>
		///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</param>
		///<param name="password">Optional password. eg: password</param>
		public void RestorePartial(string @slug, bool? @homeassistant = null, object? @folders = null, object? @addons = null, string? @password = null)
		{
			_haContext.CallService("hassio", "restore_partial", null, new HassioRestorePartialParameters{Slug = @slug, Homeassistant = @homeassistant, Folders = @folders, Addons = @addons, Password = @password});
		}
	}

	public record HassioAddonRestartParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStartParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStdinParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStopParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonUpdateParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioBackupFullParameters
	{
		///<summary>Optional (default = current date and time). eg: Backup 1</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }

		///<summary>Use compressed archives</summary>
		[JsonPropertyName("compressed")]
		public bool? Compressed { get; init; }
	}

	public record HassioBackupPartialParameters
	{
		///<summary>Backup Home Assistant settings</summary>
		[JsonPropertyName("homeassistant")]
		public bool? Homeassistant { get; init; }

		///<summary>Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</summary>
		[JsonPropertyName("addons")]
		public object? Addons { get; init; }

		///<summary>Optional list of directories. eg: ["homeassistant","share"]</summary>
		[JsonPropertyName("folders")]
		public object? Folders { get; init; }

		///<summary>Optional (default = current date and time). eg: Partial backup 1</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }

		///<summary>Use compressed archives</summary>
		[JsonPropertyName("compressed")]
		public bool? Compressed { get; init; }
	}

	public record HassioRestoreFullParameters
	{
		///<summary>Slug of backup to restore from.</summary>
		[JsonPropertyName("slug")]
		public string? Slug { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public record HassioRestorePartialParameters
	{
		///<summary>Slug of backup to restore from.</summary>
		[JsonPropertyName("slug")]
		public string? Slug { get; init; }

		///<summary>Restore Home Assistant</summary>
		[JsonPropertyName("homeassistant")]
		public bool? Homeassistant { get; init; }

		///<summary>Optional list of directories. eg: ["homeassistant","share"]</summary>
		[JsonPropertyName("folders")]
		public object? Folders { get; init; }

		///<summary>Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</summary>
		[JsonPropertyName("addons")]
		public object? Addons { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public class HomeassistantServices
	{
		private readonly IHaContext _haContext;
		public HomeassistantServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Check the Home Assistant configuration files for errors. Errors will be displayed in the Home Assistant log.</summary>
		public void CheckConfig()
		{
			_haContext.CallService("homeassistant", "check_config", null);
		}

		///<summary>Reload a config entry that matches a target.</summary>
		///<param name="target">The target for this service call</param>
		public void ReloadConfigEntry(ServiceTarget target, HomeassistantReloadConfigEntryParameters data)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, data);
		}

		///<summary>Reload a config entry that matches a target.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entryId">A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</param>
		public void ReloadConfigEntry(ServiceTarget target, string? @entryId = null)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, new HomeassistantReloadConfigEntryParameters{EntryId = @entryId});
		}

		///<summary>Reload the core configuration.</summary>
		public void ReloadCoreConfig()
		{
			_haContext.CallService("homeassistant", "reload_core_config", null);
		}

		///<summary>Restart the Home Assistant service.</summary>
		public void Restart()
		{
			_haContext.CallService("homeassistant", "restart", null);
		}

		///<summary>Save the persistent states (for entities derived from RestoreEntity) immediately. Maintain the normal periodic saving interval.</summary>
		public void SavePersistentStates()
		{
			_haContext.CallService("homeassistant", "save_persistent_states", null);
		}

		///<summary>Update the Home Assistant location.</summary>
		public void SetLocation(HomeassistantSetLocationParameters data)
		{
			_haContext.CallService("homeassistant", "set_location", null, data);
		}

		///<summary>Update the Home Assistant location.</summary>
		///<param name="latitude">Latitude of your location. eg: 32.87336</param>
		///<param name="longitude">Longitude of your location. eg: 117.22743</param>
		public void SetLocation(string @latitude, string @longitude)
		{
			_haContext.CallService("homeassistant", "set_location", null, new HomeassistantSetLocationParameters{Latitude = @latitude, Longitude = @longitude});
		}

		///<summary>Stop the Home Assistant service.</summary>
		public void Stop()
		{
			_haContext.CallService("homeassistant", "stop", null);
		}

		///<summary>Generic service to toggle devices on/off under any domain</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "toggle", target);
		}

		///<summary>Generic service to turn devices off under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_off", target);
		}

		///<summary>Generic service to turn devices on under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_on", target);
		}

		///<summary>Force one or more entities to update its data</summary>
		///<param name="target">The target for this service call</param>
		public void UpdateEntity(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "update_entity", target);
		}
	}

	public record HomeassistantReloadConfigEntryParameters
	{
		///<summary>A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</summary>
		[JsonPropertyName("entry_id")]
		public string? EntryId { get; init; }
	}

	public record HomeassistantSetLocationParameters
	{
		///<summary>Latitude of your location. eg: 32.87336</summary>
		[JsonPropertyName("latitude")]
		public string? Latitude { get; init; }

		///<summary>Longitude of your location. eg: 117.22743</summary>
		[JsonPropertyName("longitude")]
		public string? Longitude { get; init; }
	}

	public class HumidifierServices
	{
		private readonly IHaContext _haContext;
		public HumidifierServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set target humidity of humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHumidity(ServiceTarget target, HumidifierSetHumidityParameters data)
		{
			_haContext.CallService("humidifier", "set_humidity", target, data);
		}

		///<summary>Set target humidity of humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="humidity">New target humidity for humidifier device.</param>
		public void SetHumidity(ServiceTarget target, long @humidity)
		{
			_haContext.CallService("humidifier", "set_humidity", target, new HumidifierSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set mode for humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetMode(ServiceTarget target, HumidifierSetModeParameters data)
		{
			_haContext.CallService("humidifier", "set_mode", target, data);
		}

		///<summary>Set mode for humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mode">New mode eg: away</param>
		public void SetMode(ServiceTarget target, string @mode)
		{
			_haContext.CallService("humidifier", "set_mode", target, new HumidifierSetModeParameters{Mode = @mode});
		}

		///<summary>Toggles a humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "toggle", target);
		}

		///<summary>Turn humidifier device off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "turn_off", target);
		}

		///<summary>Turn humidifier device on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "turn_on", target);
		}
	}

	public record HumidifierSetHumidityParameters
	{
		///<summary>New target humidity for humidifier device.</summary>
		[JsonPropertyName("humidity")]
		public long? Humidity { get; init; }
	}

	public record HumidifierSetModeParameters
	{
		///<summary>New mode eg: away</summary>
		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public class InputBooleanServices
	{
		private readonly IHaContext _haContext;
		public InputBooleanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_boolean configuration</summary>
		public void Reload()
		{
			_haContext.CallService("input_boolean", "reload", null);
		}

		///<summary>Toggle an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "toggle", target);
		}

		///<summary>Turn off an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_off", target);
		}

		///<summary>Turn on an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_on", target);
		}
	}

	public class InputButtonServices
	{
		private readonly IHaContext _haContext;
		public InputButtonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Press the input button entity.</summary>
		///<param name="target">The target for this service call</param>
		public void Press(ServiceTarget target)
		{
			_haContext.CallService("input_button", "press", target);
		}

		public void Reload()
		{
			_haContext.CallService("input_button", "reload", null);
		}
	}

	public class InputDatetimeServices
	{
		private readonly IHaContext _haContext;
		public InputDatetimeServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_datetime configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_datetime", "reload", null);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDatetime(ServiceTarget target, InputDatetimeSetDatetimeParameters data)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public void SetDatetime(ServiceTarget target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}
	}

	public record InputDatetimeSetDatetimeParameters
	{
		///<summary>The target date the entity should be set to. eg: "2019-04-20"</summary>
		[JsonPropertyName("date")]
		public string? Date { get; init; }

		///<summary>The target time the entity should be set to. eg: "05:04:20"</summary>
		[JsonPropertyName("time")]
		public DateTime? Time { get; init; }

		///<summary>The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</summary>
		[JsonPropertyName("datetime")]
		public string? Datetime { get; init; }

		///<summary>The target date & time the entity should be set to as expressed by a UNIX timestamp.</summary>
		[JsonPropertyName("timestamp")]
		public long? Timestamp { get; init; }
	}

	public class InputNumberServices
	{
		private readonly IHaContext _haContext;
		public InputNumberServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(ServiceTarget target)
		{
			_haContext.CallService("input_number", "decrement", target);
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(ServiceTarget target)
		{
			_haContext.CallService("input_number", "increment", target);
		}

		///<summary>Reload the input_number configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_number", "reload", null);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, InputNumberSetValueParameters data)
		{
			_haContext.CallService("input_number", "set_value", target, data);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to.</param>
		public void SetValue(ServiceTarget target, double @value)
		{
			_haContext.CallService("input_number", "set_value", target, new InputNumberSetValueParameters{Value = @value});
		}
	}

	public record InputNumberSetValueParameters
	{
		///<summary>The target value the entity should be set to.</summary>
		[JsonPropertyName("value")]
		public double? Value { get; init; }
	}

	public class InputSelectServices
	{
		private readonly IHaContext _haContext;
		public InputSelectServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_select configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_select", "reload", null);
		}

		///<summary>Select the first option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectFirst(ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_first", target);
		}

		///<summary>Select the last option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectLast(ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_last", target);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectNext(ServiceTarget target, InputSelectSelectNextParameters data)
		{
			_haContext.CallService("input_select", "select_next", target, data);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the last to the first.</param>
		public void SelectNext(ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_next", target, new InputSelectSelectNextParameters{Cycle = @cycle});
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectOption(ServiceTarget target, InputSelectSelectOptionParameters data)
		{
			_haContext.CallService("input_select", "select_option", target, data);
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public void SelectOption(ServiceTarget target, string @option)
		{
			_haContext.CallService("input_select", "select_option", target, new InputSelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectPrevious(ServiceTarget target, InputSelectSelectPreviousParameters data)
		{
			_haContext.CallService("input_select", "select_previous", target, data);
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the first to the last.</param>
		public void SelectPrevious(ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_previous", target, new InputSelectSelectPreviousParameters{Cycle = @cycle});
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetOptions(ServiceTarget target, InputSelectSetOptionsParameters data)
		{
			_haContext.CallService("input_select", "set_options", target, data);
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
		public void SetOptions(ServiceTarget target, object @options)
		{
			_haContext.CallService("input_select", "set_options", target, new InputSelectSetOptionsParameters{Options = @options});
		}
	}

	public record InputSelectSelectNextParameters
	{
		///<summary>If the option should cycle from the last to the first.</summary>
		[JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSelectOptionParameters
	{
		///<summary>Option to be selected. eg: "Item A"</summary>
		[JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public record InputSelectSelectPreviousParameters
	{
		///<summary>If the option should cycle from the first to the last.</summary>
		[JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSetOptionsParameters
	{
		///<summary>Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public class InputTextServices
	{
		private readonly IHaContext _haContext;
		public InputTextServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_text configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_text", "reload", null);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, InputTextSetValueParameters data)
		{
			_haContext.CallService("input_text", "set_value", target, data);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
		public void SetValue(ServiceTarget target, string @value)
		{
			_haContext.CallService("input_text", "set_value", target, new InputTextSetValueParameters{Value = @value});
		}
	}

	public record InputTextSetValueParameters
	{
		///<summary>The target value the entity should be set to. eg: This is an example text</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class LightServices
	{
		private readonly IHaContext _haContext;
		public LightServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target, LightToggleParameters data)
		{
			_haContext.CallService("light", "toggle", target, data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public void Toggle(ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "toggle", target, new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target, LightTurnOffParameters data)
		{
			_haContext.CallService("light", "turn_off", target, data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public void TurnOff(ServiceTarget target, long? @transition = null, object? @flash = null)
		{
			_haContext.CallService("light", "turn_off", target, new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, LightTurnOnParameters data)
		{
			_haContext.CallService("light", "turn_on", target, data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public void TurnOn(ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "turn_on", target, new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public record LightToggleParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>Color for the light in RGB-format. eg: [255, 100, 100]</summary>
		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>A human readable color name.</summary>
		[JsonPropertyName("color_name")]
		public object? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[JsonPropertyName("color_temp")]
		public object? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating level of white.</summary>
		[JsonPropertyName("white_value")]
		public long? WhiteValue { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness_pct")]
		public long? BrightnessPct { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public object? Flash { get; init; }

		///<summary>Light effect.</summary>
		[JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public record LightTurnOffParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public object? Flash { get; init; }
	}

	public record LightTurnOnParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>The color for the light (based on RGB - red, green, blue).</summary>
		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</summary>
		[JsonPropertyName("rgbw_color")]
		public object? RgbwColor { get; init; }

		///<summary>A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</summary>
		[JsonPropertyName("rgbww_color")]
		public object? RgbwwColor { get; init; }

		///<summary>A human readable color name.</summary>
		[JsonPropertyName("color_name")]
		public object? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[JsonPropertyName("color_temp")]
		public object? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness_pct")]
		public long? BrightnessPct { get; init; }

		///<summary>Change brightness by an amount.</summary>
		[JsonPropertyName("brightness_step")]
		public long? BrightnessStep { get; init; }

		///<summary>Change brightness by a percentage.</summary>
		[JsonPropertyName("brightness_step_pct")]
		public long? BrightnessStepPct { get; init; }

		///<summary>Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("white")]
		public long? White { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public object? Flash { get; init; }

		///<summary>Light effect.</summary>
		[JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public class LockServices
	{
		private readonly IHaContext _haContext;
		public LockServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Lock(ServiceTarget target, LockLockParameters data)
		{
			_haContext.CallService("lock", "lock", target, data);
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to lock the lock with. eg: 1234</param>
		public void Lock(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "lock", target, new LockLockParameters{Code = @code});
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Open(ServiceTarget target, LockOpenParameters data)
		{
			_haContext.CallService("lock", "open", target, data);
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to open the lock with. eg: 1234</param>
		public void Open(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "open", target, new LockOpenParameters{Code = @code});
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Unlock(ServiceTarget target, LockUnlockParameters data)
		{
			_haContext.CallService("lock", "unlock", target, data);
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
		public void Unlock(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "unlock", target, new LockUnlockParameters{Code = @code});
		}
	}

	public record LockLockParameters
	{
		///<summary>An optional code to lock the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record LockOpenParameters
	{
		///<summary>An optional code to open the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record LockUnlockParameters
	{
		///<summary>An optional code to unlock the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public class LogbookServices
	{
		private readonly IHaContext _haContext;
		public LogbookServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Create a custom entry in your logbook.</summary>
		public void Log(LogbookLogParameters data)
		{
			_haContext.CallService("logbook", "log", null, data);
		}

		///<summary>Create a custom entry in your logbook.</summary>
		///<param name="name">Custom name for an entity, can be referenced with entity_id. eg: Kitchen</param>
		///<param name="message">Message of the custom logbook entry. eg: is being used</param>
		///<param name="entityId">Entity to reference in custom logbook entry.</param>
		///<param name="domain">Icon of domain to display in custom logbook entry. eg: light</param>
		public void Log(string @name, string @message, string? @entityId = null, string? @domain = null)
		{
			_haContext.CallService("logbook", "log", null, new LogbookLogParameters{Name = @name, Message = @message, EntityId = @entityId, Domain = @domain});
		}
	}

	public record LogbookLogParameters
	{
		///<summary>Custom name for an entity, can be referenced with entity_id. eg: Kitchen</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Message of the custom logbook entry. eg: is being used</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Entity to reference in custom logbook entry.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Icon of domain to display in custom logbook entry. eg: light</summary>
		[JsonPropertyName("domain")]
		public string? Domain { get; init; }
	}

	public class MediaPlayerServices
	{
		private readonly IHaContext _haContext;
		public MediaPlayerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send the media player the command to clear players playlist.</summary>
		///<param name="target">The target for this service call</param>
		public void ClearPlaylist(ServiceTarget target)
		{
			_haContext.CallService("media_player", "clear_playlist", target);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Join(ServiceTarget target, MediaPlayerJoinParameters data)
		{
			_haContext.CallService("media_player", "join", target, data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</param>
		public void Join(ServiceTarget target, object? @groupMembers = null)
		{
			_haContext.CallService("media_player", "join", target, new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaNextTrack(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_next_track", target);
		}

		///<summary>Send the media player the command for pause.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPause(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_pause", target);
		}

		///<summary>Send the media player the command for play.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlay(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play", target);
		}

		///<summary>Toggle media player play/pause state.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlayPause(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play_pause", target);
		}

		///<summary>Send the media player the command for previous track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPreviousTrack(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_previous_track", target);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaSeek(ServiceTarget target, MediaPlayerMediaSeekParameters data)
		{
			_haContext.CallService("media_player", "media_seek", target, data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public void MediaSeek(ServiceTarget target, double @seekPosition)
		{
			_haContext.CallService("media_player", "media_seek", target, new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaStop(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_stop", target);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayMedia(ServiceTarget target, MediaPlayerPlayMediaParameters data)
		{
			_haContext.CallService("media_player", "play_media", target, data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		///<param name="enqueue">If the content should be played now or be added to the queue.</param>
		///<param name="announce">If the media should be played as an announcement. eg: true</param>
		public void PlayMedia(ServiceTarget target, string @mediaContentId, string @mediaContentType, object? @enqueue = null, bool? @announce = null)
		{
			_haContext.CallService("media_player", "play_media", target, new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType, Enqueue = @enqueue, Announce = @announce});
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		public void RepeatSet(ServiceTarget target, MediaPlayerRepeatSetParameters data)
		{
			_haContext.CallService("media_player", "repeat_set", target, data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		///<param name="repeat">Repeat mode to set.</param>
		public void RepeatSet(ServiceTarget target, object @repeat)
		{
			_haContext.CallService("media_player", "repeat_set", target, new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSoundMode(ServiceTarget target, MediaPlayerSelectSoundModeParameters data)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public void SelectSoundMode(ServiceTarget target, string? @soundMode = null)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSource(ServiceTarget target, MediaPlayerSelectSourceParameters data)
		{
			_haContext.CallService("media_player", "select_source", target, data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public void SelectSource(ServiceTarget target, string @source)
		{
			_haContext.CallService("media_player", "select_source", target, new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		public void ShuffleSet(ServiceTarget target, MediaPlayerShuffleSetParameters data)
		{
			_haContext.CallService("media_player", "shuffle_set", target, data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public void ShuffleSet(ServiceTarget target, bool @shuffle)
		{
			_haContext.CallService("media_player", "shuffle_set", target, new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("media_player", "toggle", target);
		}

		///<summary>Turn a media player power off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_off", target);
		}

		///<summary>Turn a media player power on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_on", target);
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Unjoin(ServiceTarget target)
		{
			_haContext.CallService("media_player", "unjoin", target);
		}

		///<summary>Turn a media player volume down.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeDown(ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_down", target);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeMute(ServiceTarget target, MediaPlayerVolumeMuteParameters data)
		{
			_haContext.CallService("media_player", "volume_mute", target, data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public void VolumeMute(ServiceTarget target, bool @isVolumeMuted)
		{
			_haContext.CallService("media_player", "volume_mute", target, new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeSet(ServiceTarget target, MediaPlayerVolumeSetParameters data)
		{
			_haContext.CallService("media_player", "volume_set", target, data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public void VolumeSet(ServiceTarget target, double @volumeLevel)
		{
			_haContext.CallService("media_player", "volume_set", target, new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeUp(ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_up", target);
		}
	}

	public record MediaPlayerJoinParameters
	{
		///<summary>The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</summary>
		[JsonPropertyName("group_members")]
		public object? GroupMembers { get; init; }
	}

	public record MediaPlayerMediaSeekParameters
	{
		///<summary>Position to seek to. The format is platform dependent.</summary>
		[JsonPropertyName("seek_position")]
		public double? SeekPosition { get; init; }
	}

	public record MediaPlayerPlayMediaParameters
	{
		///<summary>The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</summary>
		[JsonPropertyName("media_content_id")]
		public string? MediaContentId { get; init; }

		///<summary>The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</summary>
		[JsonPropertyName("media_content_type")]
		public string? MediaContentType { get; init; }

		///<summary>If the content should be played now or be added to the queue.</summary>
		[JsonPropertyName("enqueue")]
		public object? Enqueue { get; init; }

		///<summary>If the media should be played as an announcement. eg: true</summary>
		[JsonPropertyName("announce")]
		public bool? Announce { get; init; }
	}

	public record MediaPlayerRepeatSetParameters
	{
		///<summary>Repeat mode to set.</summary>
		[JsonPropertyName("repeat")]
		public object? Repeat { get; init; }
	}

	public record MediaPlayerSelectSoundModeParameters
	{
		///<summary>Name of the sound mode to switch to. eg: Music</summary>
		[JsonPropertyName("sound_mode")]
		public string? SoundMode { get; init; }
	}

	public record MediaPlayerSelectSourceParameters
	{
		///<summary>Name of the source to switch to. Platform dependent. eg: video1</summary>
		[JsonPropertyName("source")]
		public string? Source { get; init; }
	}

	public record MediaPlayerShuffleSetParameters
	{
		///<summary>True/false for enabling/disabling shuffle.</summary>
		[JsonPropertyName("shuffle")]
		public bool? Shuffle { get; init; }
	}

	public record MediaPlayerVolumeMuteParameters
	{
		///<summary>True/false for mute/unmute.</summary>
		[JsonPropertyName("is_volume_muted")]
		public bool? IsVolumeMuted { get; init; }
	}

	public record MediaPlayerVolumeSetParameters
	{
		///<summary>Volume level to set as float.</summary>
		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }
	}

	public class MqttServices
	{
		private readonly IHaContext _haContext;
		public MqttServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Dump messages on a topic selector to the 'mqtt_dump.txt' file in your configuration folder.</summary>
		public void Dump(MqttDumpParameters data)
		{
			_haContext.CallService("mqtt", "dump", null, data);
		}

		///<summary>Dump messages on a topic selector to the 'mqtt_dump.txt' file in your configuration folder.</summary>
		///<param name="topic">topic to listen to eg: OpenZWave/#</param>
		///<param name="duration">how long we should listen for messages in seconds</param>
		public void Dump(string? @topic = null, long? @duration = null)
		{
			_haContext.CallService("mqtt", "dump", null, new MqttDumpParameters{Topic = @topic, Duration = @duration});
		}

		///<summary>Publish a message to an MQTT topic.</summary>
		public void Publish(MqttPublishParameters data)
		{
			_haContext.CallService("mqtt", "publish", null, data);
		}

		///<summary>Publish a message to an MQTT topic.</summary>
		///<param name="topic">Topic to publish payload. eg: /homeassistant/hello</param>
		///<param name="payload">Payload to publish. eg: This is great</param>
		///<param name="payloadTemplate">Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</param>
		///<param name="qos">Quality of Service to use.</param>
		///<param name="retain">If message should have the retain flag set.</param>
		public void Publish(string @topic, string? @payload = null, object? @payloadTemplate = null, object? @qos = null, bool? @retain = null)
		{
			_haContext.CallService("mqtt", "publish", null, new MqttPublishParameters{Topic = @topic, Payload = @payload, PayloadTemplate = @payloadTemplate, Qos = @qos, Retain = @retain});
		}

		///<summary>Reload all MQTT entities from YAML.</summary>
		public void Reload()
		{
			_haContext.CallService("mqtt", "reload", null);
		}
	}

	public record MqttDumpParameters
	{
		///<summary>topic to listen to eg: OpenZWave/#</summary>
		[JsonPropertyName("topic")]
		public string? Topic { get; init; }

		///<summary>how long we should listen for messages in seconds</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public record MqttPublishParameters
	{
		///<summary>Topic to publish payload. eg: /homeassistant/hello</summary>
		[JsonPropertyName("topic")]
		public string? Topic { get; init; }

		///<summary>Payload to publish. eg: This is great</summary>
		[JsonPropertyName("payload")]
		public string? Payload { get; init; }

		///<summary>Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</summary>
		[JsonPropertyName("payload_template")]
		public object? PayloadTemplate { get; init; }

		///<summary>Quality of Service to use.</summary>
		[JsonPropertyName("qos")]
		public object? Qos { get; init; }

		///<summary>If message should have the retain flag set.</summary>
		[JsonPropertyName("retain")]
		public bool? Retain { get; init; }
	}

	public class NotifyServices
	{
		private readonly IHaContext _haContext;
		public NotifyServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sends a notification message using the alexa_media service.</summary>
		public void AlexaMedia(NotifyAlexaMediaParameters data)
		{
			_haContext.CallService("notify", "alexa_media", null, data);
		}

		///<summary>Sends a notification message using the alexa_media service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMedia(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media", null, new NotifyAlexaMediaParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_alejandro_s_hamburg integration.</summary>
		public void AlexaMediaAlejandroSHamburg(NotifyAlexaMediaAlejandroSHamburgParameters data)
		{
			_haContext.CallService("notify", "alexa_media_alejandro_s_hamburg", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_alejandro_s_hamburg integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaAlejandroSHamburg(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_alejandro_s_hamburg", null, new NotifyAlexaMediaAlejandroSHamburgParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_cuarto integration.</summary>
		public void AlexaMediaCuarto(NotifyAlexaMediaCuartoParameters data)
		{
			_haContext.CallService("notify", "alexa_media_cuarto", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_cuarto integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaCuarto(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_cuarto", null, new NotifyAlexaMediaCuartoParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_echo_de_alejandro integration.</summary>
		public void AlexaMediaEchoDeAlejandro(NotifyAlexaMediaEchoDeAlejandroParameters data)
		{
			_haContext.CallService("notify", "alexa_media_echo_de_alejandro", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_echo_de_alejandro integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaEchoDeAlejandro(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_echo_de_alejandro", null, new NotifyAlexaMediaEchoDeAlejandroParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_last_called integration.</summary>
		public void AlexaMediaLastCalled(NotifyAlexaMediaLastCalledParameters data)
		{
			_haContext.CallService("notify", "alexa_media_last_called", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_last_called integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaLastCalled(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_last_called", null, new NotifyAlexaMediaLastCalledParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_oficina integration.</summary>
		public void AlexaMediaOficina(NotifyAlexaMediaOficinaParameters data)
		{
			_haContext.CallService("notify", "alexa_media_oficina", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_oficina integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaOficina(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_oficina", null, new NotifyAlexaMediaOficinaParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_edcmxenlt0251 integration.</summary>
		public void MobileAppEdcmxenlt0251(NotifyMobileAppEdcmxenlt0251Parameters data)
		{
			_haContext.CallService("notify", "mobile_app_edcmxenlt0251", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_edcmxenlt0251 integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppEdcmxenlt0251(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_edcmxenlt0251", null, new NotifyMobileAppEdcmxenlt0251Parameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_freyja integration.</summary>
		public void MobileAppFreyja(NotifyMobileAppFreyjaParameters data)
		{
			_haContext.CallService("notify", "mobile_app_freyja", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_freyja integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppFreyja(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_freyja", null, new NotifyMobileAppFreyjaParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_nostalgiadrive integration.</summary>
		public void MobileAppNostalgiadrive(NotifyMobileAppNostalgiadriveParameters data)
		{
			_haContext.CallService("notify", "mobile_app_nostalgiadrive", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_nostalgiadrive integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppNostalgiadrive(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_nostalgiadrive", null, new NotifyMobileAppNostalgiadriveParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the notify service.</summary>
		public void Notify(NotifyNotifyParameters data)
		{
			_haContext.CallService("notify", "notify", null, data);
		}

		///<summary>Sends a notification message using the notify service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void Notify(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "notify", null, new NotifyNotifyParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification that is visible in the front-end.</summary>
		public void PersistentNotification(NotifyPersistentNotificationParameters data)
		{
			_haContext.CallService("notify", "persistent_notification", null, data);
		}

		///<summary>Sends a notification that is visible in the front-end.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		public void PersistentNotification(string @message, string? @title = null)
		{
			_haContext.CallService("notify", "persistent_notification", null, new NotifyPersistentNotificationParameters{Message = @message, Title = @title});
		}

		///<summary>Sends a notification message using the telegram service.</summary>
		public void Telegram(NotifyTelegramParameters data)
		{
			_haContext.CallService("notify", "telegram", null, data);
		}

		///<summary>Sends a notification message using the telegram service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void Telegram(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "telegram", null, new NotifyTelegramParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}
	}

	public record NotifyAlexaMediaParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaAlejandroSHamburgParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaCuartoParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaEchoDeAlejandroParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaLastCalledParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaOficinaParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppEdcmxenlt0251Parameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppFreyjaParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppNostalgiadriveParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyNotifyParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyPersistentNotificationParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
	}

	public record NotifyTelegramParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public class NumberServices
	{
		private readonly IHaContext _haContext;
		public NumberServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, NumberSetValueParameters data)
		{
			_haContext.CallService("number", "set_value", target, data);
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public void SetValue(ServiceTarget target, string? @value = null)
		{
			_haContext.CallService("number", "set_value", target, new NumberSetValueParameters{Value = @value});
		}
	}

	public record NumberSetValueParameters
	{
		///<summary>The target value the entity should be set to. eg: 42</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class PersistentNotificationServices
	{
		private readonly IHaContext _haContext;
		public PersistentNotificationServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Show a notification in the frontend.</summary>
		public void Create(PersistentNotificationCreateParameters data)
		{
			_haContext.CallService("persistent_notification", "create", null, data);
		}

		///<summary>Show a notification in the frontend.</summary>
		///<param name="message">Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</param>
		///<param name="title">Optional title for your notification. [Templates accepted] eg: Test notification</param>
		///<param name="notificationId">Target ID of the notification, will replace a notification with the same ID. eg: 1234</param>
		public void Create(string @message, string? @title = null, string? @notificationId = null)
		{
			_haContext.CallService("persistent_notification", "create", null, new PersistentNotificationCreateParameters{Message = @message, Title = @title, NotificationId = @notificationId});
		}

		///<summary>Remove a notification from the frontend.</summary>
		public void Dismiss(PersistentNotificationDismissParameters data)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, data);
		}

		///<summary>Remove a notification from the frontend.</summary>
		///<param name="notificationId">Target ID of the notification, which should be removed. eg: 1234</param>
		public void Dismiss(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, new PersistentNotificationDismissParameters{NotificationId = @notificationId});
		}

		///<summary>Mark a notification read.</summary>
		public void MarkRead(PersistentNotificationMarkReadParameters data)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, data);
		}

		///<summary>Mark a notification read.</summary>
		///<param name="notificationId">Target ID of the notification, which should be mark read. eg: 1234</param>
		public void MarkRead(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, new PersistentNotificationMarkReadParameters{NotificationId = @notificationId});
		}
	}

	public record PersistentNotificationCreateParameters
	{
		///<summary>Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Optional title for your notification. [Templates accepted] eg: Test notification</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>Target ID of the notification, will replace a notification with the same ID. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationDismissParameters
	{
		///<summary>Target ID of the notification, which should be removed. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationMarkReadParameters
	{
		///<summary>Target ID of the notification, which should be mark read. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public class PersonServices
	{
		private readonly IHaContext _haContext;
		public PersonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the person configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("person", "reload", null);
		}
	}

	public class RecorderServices
	{
		private readonly IHaContext _haContext;
		public RecorderServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Stop the recording of events and state changes</summary>
		public void Disable()
		{
			_haContext.CallService("recorder", "disable", null);
		}

		///<summary>Start the recording of events and state changes</summary>
		public void Enable()
		{
			_haContext.CallService("recorder", "enable", null);
		}

		///<summary>Start purge task - to clean up old data from your database.</summary>
		public void Purge(RecorderPurgeParameters data)
		{
			_haContext.CallService("recorder", "purge", null, data);
		}

		///<summary>Start purge task - to clean up old data from your database.</summary>
		///<param name="keepDays">Number of history days to keep in database after purge.</param>
		///<param name="repack">Attempt to save disk space by rewriting the entire database file.</param>
		///<param name="applyFilter">Apply entity_id and event_type filter in addition to time based purge.</param>
		public void Purge(long? @keepDays = null, bool? @repack = null, bool? @applyFilter = null)
		{
			_haContext.CallService("recorder", "purge", null, new RecorderPurgeParameters{KeepDays = @keepDays, Repack = @repack, ApplyFilter = @applyFilter});
		}

		///<summary>Start purge task to remove specific entities from your database.</summary>
		///<param name="target">The target for this service call</param>
		public void PurgeEntities(ServiceTarget target, RecorderPurgeEntitiesParameters data)
		{
			_haContext.CallService("recorder", "purge_entities", target, data);
		}

		///<summary>Start purge task to remove specific entities from your database.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="domains">List the domains that need to be removed from the recorder database. eg: sun</param>
		///<param name="entityGlobs">List the glob patterns to select entities for removal from the recorder database. eg: domain*.object_id*</param>
		public void PurgeEntities(ServiceTarget target, object? @domains = null, object? @entityGlobs = null)
		{
			_haContext.CallService("recorder", "purge_entities", target, new RecorderPurgeEntitiesParameters{Domains = @domains, EntityGlobs = @entityGlobs});
		}
	}

	public record RecorderPurgeParameters
	{
		///<summary>Number of history days to keep in database after purge.</summary>
		[JsonPropertyName("keep_days")]
		public long? KeepDays { get; init; }

		///<summary>Attempt to save disk space by rewriting the entire database file.</summary>
		[JsonPropertyName("repack")]
		public bool? Repack { get; init; }

		///<summary>Apply entity_id and event_type filter in addition to time based purge.</summary>
		[JsonPropertyName("apply_filter")]
		public bool? ApplyFilter { get; init; }
	}

	public record RecorderPurgeEntitiesParameters
	{
		///<summary>List the domains that need to be removed from the recorder database. eg: sun</summary>
		[JsonPropertyName("domains")]
		public object? Domains { get; init; }

		///<summary>List the glob patterns to select entities for removal from the recorder database. eg: domain*.object_id*</summary>
		[JsonPropertyName("entity_globs")]
		public object? EntityGlobs { get; init; }
	}

	public class SceneServices
	{
		private readonly IHaContext _haContext;
		public SceneServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Activate a scene with configuration.</summary>
		public void Apply(SceneApplyParameters data)
		{
			_haContext.CallService("scene", "apply", null, data);
		}

		///<summary>Activate a scene with configuration.</summary>
		///<param name="entities">The entities and the state that they need to be. eg: {"light.kitchen":"on","light.ceiling":{"state":"on","brightness":80}}</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public void Apply(object @entities, long? @transition = null)
		{
			_haContext.CallService("scene", "apply", null, new SceneApplyParameters{Entities = @entities, Transition = @transition});
		}

		///<summary>Creates a new scene.</summary>
		public void Create(SceneCreateParameters data)
		{
			_haContext.CallService("scene", "create", null, data);
		}

		///<summary>Creates a new scene.</summary>
		///<param name="sceneId">The entity_id of the new scene. eg: all_lights</param>
		///<param name="entities">The entities to control with the scene. eg: {"light.tv_back_light":"on","light.ceiling":{"state":"on","brightness":200}}</param>
		///<param name="snapshotEntities">The entities of which a snapshot is to be taken eg: ["light.ceiling","light.kitchen"]</param>
		public void Create(string @sceneId, object? @entities = null, object? @snapshotEntities = null)
		{
			_haContext.CallService("scene", "create", null, new SceneCreateParameters{SceneId = @sceneId, Entities = @entities, SnapshotEntities = @snapshotEntities});
		}

		///<summary>Reload the scene configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("scene", "reload", null);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, SceneTurnOnParameters data)
		{
			_haContext.CallService("scene", "turn_on", target, data);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public void TurnOn(ServiceTarget target, long? @transition = null)
		{
			_haContext.CallService("scene", "turn_on", target, new SceneTurnOnParameters{Transition = @transition});
		}
	}

	public record SceneApplyParameters
	{
		///<summary>The entities and the state that they need to be. eg: {"light.kitchen":"on","light.ceiling":{"state":"on","brightness":80}}</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public record SceneCreateParameters
	{
		///<summary>The entity_id of the new scene. eg: all_lights</summary>
		[JsonPropertyName("scene_id")]
		public string? SceneId { get; init; }

		///<summary>The entities to control with the scene. eg: {"light.tv_back_light":"on","light.ceiling":{"state":"on","brightness":200}}</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>The entities of which a snapshot is to be taken eg: ["light.ceiling","light.kitchen"]</summary>
		[JsonPropertyName("snapshot_entities")]
		public object? SnapshotEntities { get; init; }
	}

	public record SceneTurnOnParameters
	{
		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public class ScriptServices
	{
		private readonly IHaContext _haContext;
		public ScriptServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void MediaPlayerGradualVolumeIncrease(ScriptMediaPlayerGradualVolumeIncreaseParameters data)
		{
			_haContext.CallService("script", "media_player_gradual_volume_increase", null, data);
		}

		///<param name="mediaTarget">The media player to target eg: media_player.oficina</param>
		///<param name="volumeTarget">The target volume to increase to eg: 0.95</param>
		public void MediaPlayerGradualVolumeIncrease(object? @mediaTarget = null, object? @volumeTarget = null)
		{
			_haContext.CallService("script", "media_player_gradual_volume_increase", null, new ScriptMediaPlayerGradualVolumeIncreaseParameters{MediaTarget = @mediaTarget, VolumeTarget = @volumeTarget});
		}

		public void Noop()
		{
			_haContext.CallService("script", "noop", null);
		}

		///<summary>Reload all the available scripts</summary>
		public void Reload()
		{
			_haContext.CallService("script", "reload", null);
		}

		///<summary>Toggle script</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("script", "toggle", target);
		}

		///<summary>Turn off script</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("script", "turn_off", target);
		}

		///<summary>Turn on script</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("script", "turn_on", target);
		}
	}

	public record ScriptMediaPlayerGradualVolumeIncreaseParameters
	{
		///<summary>The media player to target eg: media_player.oficina</summary>
		[JsonPropertyName("media_target")]
		public object? MediaTarget { get; init; }

		///<summary>The target volume to increase to eg: 0.95</summary>
		[JsonPropertyName("volume_target")]
		public object? VolumeTarget { get; init; }
	}

	public class SelectServices
	{
		private readonly IHaContext _haContext;
		public SelectServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectOption(ServiceTarget target, SelectSelectOptionParameters data)
		{
			_haContext.CallService("select", "select_option", target, data);
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public void SelectOption(ServiceTarget target, string @option)
		{
			_haContext.CallService("select", "select_option", target, new SelectSelectOptionParameters{Option = @option});
		}
	}

	public record SelectSelectOptionParameters
	{
		///<summary>Option to be selected. eg: "Item A"</summary>
		[JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public class ShoppingListServices
	{
		private readonly IHaContext _haContext;
		public ShoppingListServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Add an item to the shopping list.</summary>
		public void AddItem(ShoppingListAddItemParameters data)
		{
			_haContext.CallService("shopping_list", "add_item", null, data);
		}

		///<summary>Add an item to the shopping list.</summary>
		///<param name="name">The name of the item to add. eg: Beer</param>
		public void AddItem(string @name)
		{
			_haContext.CallService("shopping_list", "add_item", null, new ShoppingListAddItemParameters{Name = @name});
		}

		///<summary>Clear completed items from the shopping list.</summary>
		public void ClearCompletedItems()
		{
			_haContext.CallService("shopping_list", "clear_completed_items", null);
		}

		///<summary>Marks all items as completed in the shopping list. It does not remove the items.</summary>
		public void CompleteAll()
		{
			_haContext.CallService("shopping_list", "complete_all", null);
		}

		///<summary>Mark an item as completed in the shopping list.</summary>
		public void CompleteItem(ShoppingListCompleteItemParameters data)
		{
			_haContext.CallService("shopping_list", "complete_item", null, data);
		}

		///<summary>Mark an item as completed in the shopping list.</summary>
		///<param name="name">The name of the item to mark as completed (without removing). eg: Beer</param>
		public void CompleteItem(string @name)
		{
			_haContext.CallService("shopping_list", "complete_item", null, new ShoppingListCompleteItemParameters{Name = @name});
		}

		///<summary>Marks all items as incomplete in the shopping list.</summary>
		public void IncompleteAll()
		{
			_haContext.CallService("shopping_list", "incomplete_all", null);
		}

		///<summary>Marks an item as incomplete in the shopping list.</summary>
		public void IncompleteItem(ShoppingListIncompleteItemParameters data)
		{
			_haContext.CallService("shopping_list", "incomplete_item", null, data);
		}

		///<summary>Marks an item as incomplete in the shopping list.</summary>
		///<param name="name">The name of the item to mark as incomplete. eg: Beer</param>
		public void IncompleteItem(string @name)
		{
			_haContext.CallService("shopping_list", "incomplete_item", null, new ShoppingListIncompleteItemParameters{Name = @name});
		}
	}

	public record ShoppingListAddItemParameters
	{
		///<summary>The name of the item to add. eg: Beer</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public record ShoppingListCompleteItemParameters
	{
		///<summary>The name of the item to mark as completed (without removing). eg: Beer</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public record ShoppingListIncompleteItemParameters
	{
		///<summary>The name of the item to mark as incomplete. eg: Beer</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public class SirenServices
	{
		private readonly IHaContext _haContext;
		public SirenServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles a siren.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("siren", "toggle", target);
		}

		///<summary>Turn siren off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("siren", "turn_off", target);
		}

		///<summary>Turn siren on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, SirenTurnOnParameters data)
		{
			_haContext.CallService("siren", "turn_on", target, data);
		}

		///<summary>Turn siren on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tone">The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</param>
		///<param name="volumeLevel">The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0.5</param>
		///<param name="duration">The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</param>
		public void TurnOn(ServiceTarget target, string? @tone = null, double? @volumeLevel = null, string? @duration = null)
		{
			_haContext.CallService("siren", "turn_on", target, new SirenTurnOnParameters{Tone = @tone, VolumeLevel = @volumeLevel, Duration = @duration});
		}
	}

	public record SirenTurnOnParameters
	{
		///<summary>The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</summary>
		[JsonPropertyName("tone")]
		public string? Tone { get; init; }

		///<summary>The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0.5</summary>
		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }

		///<summary>The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</summary>
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public class SmartthinqSensorsServices
	{
		private readonly IHaContext _haContext;
		public SmartthinqSensorsServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send to ThinQ device the remote start command.</summary>
		///<param name="target">The target for this service call</param>
		public void RemoteStart(ServiceTarget target)
		{
			_haContext.CallService("smartthinq_sensors", "remote_start", target);
		}

		///<summary>Set fan operation for dehumidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanMode(ServiceTarget target, SmartthinqSensorsSetFanModeParameters data)
		{
			_haContext.CallService("smartthinq_sensors", "set_fan_mode", target, data);
		}

		///<summary>Set fan operation for dehumidifier device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public void SetFanMode(ServiceTarget target, string @fanMode)
		{
			_haContext.CallService("smartthinq_sensors", "set_fan_mode", target, new SmartthinqSensorsSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Send to ThinQ device the wakeup command.</summary>
		///<param name="target">The target for this service call</param>
		public void WakeUp(ServiceTarget target)
		{
			_haContext.CallService("smartthinq_sensors", "wake_up", target);
		}
	}

	public record SmartthinqSensorsSetFanModeParameters
	{
		///<summary>New value of fan mode. eg: low</summary>
		[JsonPropertyName("fan_mode")]
		public string? FanMode { get; init; }
	}

	public class SwitchServices
	{
		private readonly IHaContext _haContext;
		public SwitchServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles a switch state</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("switch", "toggle", target);
		}

		///<summary>Turn a switch off</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_off", target);
		}

		///<summary>Turn a switch on</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_on", target);
		}
	}

	public class SystemLogServices
	{
		private readonly IHaContext _haContext;
		public SystemLogServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Clear all log entries.</summary>
		public void Clear()
		{
			_haContext.CallService("system_log", "clear", null);
		}

		///<summary>Write log entry.</summary>
		public void Write(SystemLogWriteParameters data)
		{
			_haContext.CallService("system_log", "write", null, data);
		}

		///<summary>Write log entry.</summary>
		///<param name="message">Message to log. eg: Something went wrong</param>
		///<param name="level">Log level.</param>
		///<param name="logger">Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</param>
		public void Write(string @message, object? @level = null, string? @logger = null)
		{
			_haContext.CallService("system_log", "write", null, new SystemLogWriteParameters{Message = @message, Level = @level, Logger = @logger});
		}
	}

	public record SystemLogWriteParameters
	{
		///<summary>Message to log. eg: Something went wrong</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Log level.</summary>
		[JsonPropertyName("level")]
		public object? Level { get; init; }

		///<summary>Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</summary>
		[JsonPropertyName("logger")]
		public string? Logger { get; init; }
	}

	public class TelegramServices
	{
		private readonly IHaContext _haContext;
		public TelegramServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload telegram notify services.</summary>
		public void Reload()
		{
			_haContext.CallService("telegram", "reload", null);
		}
	}

	public class TelegramBotServices
	{
		private readonly IHaContext _haContext;
		public TelegramBotServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Respond to a callback query originated by clicking on an online keyboard button. The answer will be displayed to the user as a notification at the top of the chat screen or as an alert.</summary>
		public void AnswerCallbackQuery(TelegramBotAnswerCallbackQueryParameters data)
		{
			_haContext.CallService("telegram_bot", "answer_callback_query", null, data);
		}

		///<summary>Respond to a callback query originated by clicking on an online keyboard button. The answer will be displayed to the user as a notification at the top of the chat screen or as an alert.</summary>
		///<param name="message">Unformatted text message body of the notification. eg: OK, I'm listening</param>
		///<param name="callbackQueryId">Unique id of the callback response. eg: {{ trigger.event.data.id }}</param>
		///<param name="showAlert">Show a permanent notification.</param>
		///<param name="timeout">Timeout for sending the answer. Will help with timeout errors (poor internet connection, etc)</param>
		public void AnswerCallbackQuery(string @message, string @callbackQueryId, bool @showAlert, long? @timeout = null)
		{
			_haContext.CallService("telegram_bot", "answer_callback_query", null, new TelegramBotAnswerCallbackQueryParameters{Message = @message, CallbackQueryId = @callbackQueryId, ShowAlert = @showAlert, Timeout = @timeout});
		}

		///<summary>Delete a previously sent message.</summary>
		public void DeleteMessage(TelegramBotDeleteMessageParameters data)
		{
			_haContext.CallService("telegram_bot", "delete_message", null, data);
		}

		///<summary>Delete a previously sent message.</summary>
		///<param name="messageId">id of the message to delete. eg: {{ trigger.event.data.message.message_id }}</param>
		///<param name="chatId">The chat_id where to delete the message. eg: 12345</param>
		public void DeleteMessage(string @messageId, string @chatId)
		{
			_haContext.CallService("telegram_bot", "delete_message", null, new TelegramBotDeleteMessageParameters{MessageId = @messageId, ChatId = @chatId});
		}

		///<summary>Edit the caption of a previously sent message.</summary>
		public void EditCaption(TelegramBotEditCaptionParameters data)
		{
			_haContext.CallService("telegram_bot", "edit_caption", null, data);
		}

		///<summary>Edit the caption of a previously sent message.</summary>
		///<param name="messageId">id of the message to edit. eg: {{ trigger.event.data.message.message_id }}</param>
		///<param name="chatId">The chat_id where to edit the caption. eg: 12345</param>
		///<param name="caption">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="inlineKeyboard">List of rows of commands, comma-separated, to make a custom inline keyboard with buttons with associated callback data. eg: ["/button1, /button2", "/button3"] or [[["Text button1", "/button1"], ["Text button2", "/button2"]], [["Text button3", "/button3"]]]</param>
		public void EditCaption(string @messageId, string @chatId, string @caption, object? @inlineKeyboard = null)
		{
			_haContext.CallService("telegram_bot", "edit_caption", null, new TelegramBotEditCaptionParameters{MessageId = @messageId, ChatId = @chatId, Caption = @caption, InlineKeyboard = @inlineKeyboard});
		}

		///<summary>Edit a previously sent message.</summary>
		public void EditMessage(TelegramBotEditMessageParameters data)
		{
			_haContext.CallService("telegram_bot", "edit_message", null, data);
		}

		///<summary>Edit a previously sent message.</summary>
		///<param name="messageId">id of the message to edit. eg: {{ trigger.event.data.message.message_id }}</param>
		///<param name="chatId">The chat_id where to edit the message. eg: 12345</param>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Optional title for your notification. Will be composed as '%title\n%message' eg: Your Garage Door Friend</param>
		///<param name="parseMode">Parser for the message text.</param>
		///<param name="disableWebPagePreview">Disables link previews for links in the message.</param>
		///<param name="inlineKeyboard">List of rows of commands, comma-separated, to make a custom inline keyboard with buttons with associated callback data. eg: ["/button1, /button2", "/button3"] or [[["Text button1", "/button1"], ["Text button2", "/button2"]], [["Text button3", "/button3"]]]</param>
		public void EditMessage(string @messageId, string @chatId, string? @message = null, string? @title = null, object? @parseMode = null, bool? @disableWebPagePreview = null, object? @inlineKeyboard = null)
		{
			_haContext.CallService("telegram_bot", "edit_message", null, new TelegramBotEditMessageParameters{MessageId = @messageId, ChatId = @chatId, Message = @message, Title = @title, ParseMode = @parseMode, DisableWebPagePreview = @disableWebPagePreview, InlineKeyboard = @inlineKeyboard});
		}

		///<summary>Edit the inline keyboard of a previously sent message.</summary>
		public void EditReplymarkup(TelegramBotEditReplymarkupParameters data)
		{
			_haContext.CallService("telegram_bot", "edit_replymarkup", null, data);
		}

		///<summary>Edit the inline keyboard of a previously sent message.</summary>
		///<param name="messageId">id of the message to edit. eg: {{ trigger.event.data.message.message_id }}</param>
		///<param name="chatId">The chat_id where to edit the reply_markup. eg: 12345</param>
		///<param name="inlineKeyboard">List of rows of commands, comma-separated, to make a custom inline keyboard with buttons with associated callback data. eg: ["/button1, /button2", "/button3"] or [[["Text button1", "/button1"], ["Text button2", "/button2"]], [["Text button3", "/button3"]]]</param>
		public void EditReplymarkup(string @messageId, string @chatId, object @inlineKeyboard)
		{
			_haContext.CallService("telegram_bot", "edit_replymarkup", null, new TelegramBotEditReplymarkupParameters{MessageId = @messageId, ChatId = @chatId, InlineKeyboard = @inlineKeyboard});
		}

		public void LeaveChat()
		{
			_haContext.CallService("telegram_bot", "leave_chat", null);
		}

		///<summary>Send an anmiation.</summary>
		public void SendAnimation(TelegramBotSendAnimationParameters data)
		{
			_haContext.CallService("telegram_bot", "send_animation", null, data);
		}

		///<summary>Send an anmiation.</summary>
		///<param name="url">Remote path to a GIF or H.264/MPEG-4 AVC video without sound. eg: http://example.org/path/to/the/animation.gif</param>
		///<param name="file">Local path to a GIF or H.264/MPEG-4 AVC video without sound. eg: /path/to/the/animation.gif</param>
		///<param name="caption">The title of the animation. eg: My animation</param>
		///<param name="username">Username for a URL which require HTTP authentication. eg: myuser</param>
		///<param name="password">Password (or bearer token) for a URL which require HTTP authentication. eg: myuser_pwd</param>
		///<param name="authentication">Define which authentication method to use. Set to `digest` to use HTTP digest authentication, or `bearer_token` for OAuth 2.0 bearer token authentication. Defaults to `basic`.</param>
		///<param name="target">An array of pre-authorized chat_ids to send the document to. If not present, first allowed chat_id is the default. eg: [12345, 67890] or 12345</param>
		///<param name="parseMode">Parser for the message text.</param>
		///<param name="disableNotification">Sends the message silently. iOS users and Web users will not receive a notification, Android users will receive a notification with no sound.</param>
		///<param name="verifySsl">Enable or disable SSL certificate verification. Set to false if you're downloading the file from a URL and you don't want to validate the SSL certificate of the server.</param>
		///<param name="timeout">Timeout for send sticker. Will help with timeout errors (poor internet connection, etc)</param>
		///<param name="keyboard">List of rows of commands, comma-separated, to make a custom keyboard. eg: ["/command1, /command2", "/command3"]</param>
		///<param name="inlineKeyboard">List of rows of commands, comma-separated, to make a custom inline keyboard with buttons with associated callback data. eg: ["/button1, /button2", "/button3"] or [[["Text button1", "/button1"], ["Text button2", "/button2"]], [["Text button3", "/button3"]]]</param>
		public void SendAnimation(string? @url = null, string? @file = null, string? @caption = null, string? @username = null, string? @password = null, object? @authentication = null, object? @target = null, object? @parseMode = null, bool? @disableNotification = null, bool? @verifySsl = null, long? @timeout = null, object? @keyboard = null, object? @inlineKeyboard = null)
		{
			_haContext.CallService("telegram_bot", "send_animation", null, new TelegramBotSendAnimationParameters{Url = @url, File = @file, Caption = @caption, Username = @username, Password = @password, Authentication = @authentication, Target = @target, ParseMode = @parseMode, DisableNotification = @disableNotification, VerifySsl = @verifySsl, Timeout = @timeout, Keyboard = @keyboard, InlineKeyboard = @inlineKeyboard});
		}

		///<summary>Send a document.</summary>
		public void SendDocument(TelegramBotSendDocumentParameters data)
		{
			_haContext.CallService("telegram_bot", "send_document", null, data);
		}

		///<summary>Send a document.</summary>
		///<param name="url">Remote path to a document. eg: http://example.org/path/to/the/document.odf</param>
		///<param name="file">Local path to a document. eg: /tmp/whatever.odf</param>
		///<param name="caption">The title of the document. eg: Document Title xy</param>
		///<param name="username">Username for a URL which require HTTP authentication. eg: myuser</param>
		///<param name="password">Password (or bearer token) for a URL which require HTTP authentication. eg: myuser_pwd</param>
		///<param name="authentication">Define which authentication method to use. Set to `digest` to use HTTP digest authentication, or `bearer_token` for OAuth 2.0 bearer token authentication. Defaults to `basic`.</param>
		///<param name="target">An array of pre-authorized chat_ids to send the document to. If not present, first allowed chat_id is the default. eg: [12345, 67890] or 12345</param>
		///<param name="parseMode">Parser for the message text.</param>
		///<param name="disableNotification">Sends the message silently. iOS users and Web users will not receive a notification, Android users will receive a notification with no sound.</param>
		///<param name="verifySsl">Enable or disable SSL certificate verification. Set to false if you're downloading the file from a URL and you don't want to validate the SSL certificate of the server.</param>
		///<param name="timeout">Timeout for send document. Will help with timeout errors (poor internet connection, etc)</param>
		///<param name="keyboard">List of rows of commands, comma-separated, to make a custom keyboard. eg: ["/command1, /command2", "/command3"]</param>
		///<param name="inlineKeyboard">List of rows of commands, comma-separated, to make a custom inline keyboard with buttons with associated callback data. eg: ["/button1, /button2", "/button3"] or [[["Text button1", "/button1"], ["Text button2", "/button2"]], [["Text button3", "/button3"]]]</param>
		///<param name="messageTag">Tag for sent message. In telegram_sent event data: {{trigger.event.data.message_tag}} eg: msg_to_edit</param>
		public void SendDocument(string? @url = null, string? @file = null, string? @caption = null, string? @username = null, string? @password = null, object? @authentication = null, object? @target = null, object? @parseMode = null, bool? @disableNotification = null, bool? @verifySsl = null, long? @timeout = null, object? @keyboard = null, object? @inlineKeyboard = null, string? @messageTag = null)
		{
			_haContext.CallService("telegram_bot", "send_document", null, new TelegramBotSendDocumentParameters{Url = @url, File = @file, Caption = @caption, Username = @username, Password = @password, Authentication = @authentication, Target = @target, ParseMode = @parseMode, DisableNotification = @disableNotification, VerifySsl = @verifySsl, Timeout = @timeout, Keyboard = @keyboard, InlineKeyboard = @inlineKeyboard, MessageTag = @messageTag});
		}

		///<summary>Send a location.</summary>
		public void SendLocation(TelegramBotSendLocationParameters data)
		{
			_haContext.CallService("telegram_bot", "send_location", null, data);
		}

		///<summary>Send a location.</summary>
		///<param name="latitude">The latitude to send.</param>
		///<param name="longitude">The longitude to send.</param>
		///<param name="target">An array of pre-authorized chat_ids to send the location to. If not present, first allowed chat_id is the default. eg: [12345, 67890] or 12345</param>
		///<param name="disableNotification">Sends the message silently. iOS users and Web users will not receive a notification, Android users will receive a notification with no sound.</param>
		///<param name="timeout">Timeout for send photo. Will help with timeout errors (poor internet connection, etc)</param>
		///<param name="keyboard">List of rows of commands, comma-separated, to make a custom keyboard. eg: ["/command1, /command2", "/command3"]</param>
		///<param name="inlineKeyboard">List of rows of commands, comma-separated, to make a custom inline keyboard with buttons with associated callback data. eg: ["/button1, /button2", "/button3"] or [[["Text button1", "/button1"], ["Text button2", "/button2"]], [["Text button3", "/button3"]]]</param>
		///<param name="messageTag">Tag for sent message. In telegram_sent event data: {{trigger.event.data.message_tag}} eg: msg_to_edit</param>
		public void SendLocation(double @latitude, double @longitude, object? @target = null, bool? @disableNotification = null, long? @timeout = null, object? @keyboard = null, object? @inlineKeyboard = null, string? @messageTag = null)
		{
			_haContext.CallService("telegram_bot", "send_location", null, new TelegramBotSendLocationParameters{Latitude = @latitude, Longitude = @longitude, Target = @target, DisableNotification = @disableNotification, Timeout = @timeout, Keyboard = @keyboard, InlineKeyboard = @inlineKeyboard, MessageTag = @messageTag});
		}

		///<summary>Send a notification.</summary>
		public void SendMessage(TelegramBotSendMessageParameters data)
		{
			_haContext.CallService("telegram_bot", "send_message", null, data);
		}

		///<summary>Send a notification.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Optional title for your notification. Will be composed as '%title\n%message' eg: Your Garage Door Friend</param>
		///<param name="target">An array of pre-authorized chat_ids to send the notification to. If not present, first allowed chat_id is the default. eg: [12345, 67890] or 12345</param>
		///<param name="parseMode">Parser for the message text.</param>
		///<param name="disableNotification">Sends the message silently. iOS users and Web users will not receive a notification, Android users will receive a notification with no sound.</param>
		///<param name="disableWebPagePreview">Disables link previews for links in the message.</param>
		///<param name="timeout">Timeout for send message. Will help with timeout errors (poor internet connection, etc)s</param>
		///<param name="keyboard">List of rows of commands, comma-separated, to make a custom keyboard. Empty list clears a previously set keyboard. eg: ["/command1, /command2", "/command3"]</param>
		///<param name="inlineKeyboard">List of rows of commands, comma-separated, to make a custom inline keyboard with buttons with associated callback data. eg: ["/button1, /button2", "/button3"] or ["Text button1:/button1, Text button2:/button2", "Text button3:/button3"] or [[["Text button1", "/button1"], ["Text button2", "/button2"]], [["Text button3", "/button3"]]]</param>
		///<param name="messageTag">Tag for sent message. In telegram_sent event data: {{trigger.event.data.message_tag}} eg: msg_to_edit</param>
		public void SendMessage(string @message, string? @title = null, object? @target = null, object? @parseMode = null, bool? @disableNotification = null, bool? @disableWebPagePreview = null, long? @timeout = null, object? @keyboard = null, object? @inlineKeyboard = null, string? @messageTag = null)
		{
			_haContext.CallService("telegram_bot", "send_message", null, new TelegramBotSendMessageParameters{Message = @message, Title = @title, Target = @target, ParseMode = @parseMode, DisableNotification = @disableNotification, DisableWebPagePreview = @disableWebPagePreview, Timeout = @timeout, Keyboard = @keyboard, InlineKeyboard = @inlineKeyboard, MessageTag = @messageTag});
		}

		///<summary>Send a photo.</summary>
		public void SendPhoto(TelegramBotSendPhotoParameters data)
		{
			_haContext.CallService("telegram_bot", "send_photo", null, data);
		}

		///<summary>Send a photo.</summary>
		///<param name="url">Remote path to an image. eg: http://example.org/path/to/the/image.png</param>
		///<param name="file">Local path to an image. eg: /path/to/the/image.png</param>
		///<param name="caption">The title of the image. eg: My image</param>
		///<param name="username">Username for a URL which require HTTP authentication. eg: myuser</param>
		///<param name="password">Password (or bearer token) for a URL which require HTTP authentication. eg: myuser_pwd</param>
		///<param name="authentication">Define which authentication method to use. Set to `digest` to use HTTP digest authentication, or `bearer_token` for OAuth 2.0 bearer token authentication. Defaults to `basic`.</param>
		///<param name="target">An array of pre-authorized chat_ids to send the document to. If not present, first allowed chat_id is the default. eg: [12345, 67890] or 12345</param>
		///<param name="parseMode">Parser for the message text.</param>
		///<param name="disableNotification">Sends the message silently. iOS users and Web users will not receive a notification, Android users will receive a notification with no sound.</param>
		///<param name="verifySsl">Enable or disable SSL certificate verification. Set to false if you're downloading the file from a URL and you don't want to validate the SSL certificate of the server.</param>
		///<param name="timeout">Timeout for send photo. Will help with timeout errors (poor internet connection, etc)</param>
		///<param name="keyboard">List of rows of commands, comma-separated, to make a custom keyboard. eg: ["/command1, /command2", "/command3"]</param>
		///<param name="inlineKeyboard">List of rows of commands, comma-separated, to make a custom inline keyboard with buttons with associated callback data. eg: ["/button1, /button2", "/button3"] or [[["Text button1", "/button1"], ["Text button2", "/button2"]], [["Text button3", "/button3"]]]</param>
		///<param name="messageTag">Tag for sent message. In telegram_sent event data: {{trigger.event.data.message_tag}} eg: msg_to_edit</param>
		public void SendPhoto(string? @url = null, string? @file = null, string? @caption = null, string? @username = null, string? @password = null, object? @authentication = null, object? @target = null, object? @parseMode = null, bool? @disableNotification = null, bool? @verifySsl = null, long? @timeout = null, object? @keyboard = null, object? @inlineKeyboard = null, string? @messageTag = null)
		{
			_haContext.CallService("telegram_bot", "send_photo", null, new TelegramBotSendPhotoParameters{Url = @url, File = @file, Caption = @caption, Username = @username, Password = @password, Authentication = @authentication, Target = @target, ParseMode = @parseMode, DisableNotification = @disableNotification, VerifySsl = @verifySsl, Timeout = @timeout, Keyboard = @keyboard, InlineKeyboard = @inlineKeyboard, MessageTag = @messageTag});
		}

		///<summary>Send a poll.</summary>
		public void SendPoll(TelegramBotSendPollParameters data)
		{
			_haContext.CallService("telegram_bot", "send_poll", null, data);
		}

		///<summary>Send a poll.</summary>
		///<param name="target">An array of pre-authorized chat_ids to send the location to. If not present, first allowed chat_id is the default. eg: [12345, 67890] or 12345</param>
		///<param name="question">Poll question, 1-300 characters</param>
		///<param name="options">List of answer options, 2-10 strings 1-100 characters each</param>
		///<param name="isAnonymous">If the poll needs to be anonymous, defaults to True</param>
		///<param name="allowsMultipleAnswers">If the poll allows multiple answers, defaults to False</param>
		///<param name="openPeriod">Amount of time in seconds the poll will be active after creation, 5-600.</param>
		///<param name="disableNotification">Sends the message silently. iOS users and Web users will not receive a notification, Android users will receive a notification with no sound.</param>
		///<param name="timeout">Timeout for send poll. Will help with timeout errors (poor internet connection, etc)</param>
		public void SendPoll(string @question, object @options, object? @target = null, bool? @isAnonymous = null, bool? @allowsMultipleAnswers = null, long? @openPeriod = null, bool? @disableNotification = null, long? @timeout = null)
		{
			_haContext.CallService("telegram_bot", "send_poll", null, new TelegramBotSendPollParameters{Target = @target, Question = @question, Options = @options, IsAnonymous = @isAnonymous, AllowsMultipleAnswers = @allowsMultipleAnswers, OpenPeriod = @openPeriod, DisableNotification = @disableNotification, Timeout = @timeout});
		}

		///<summary>Send a sticker.</summary>
		public void SendSticker(TelegramBotSendStickerParameters data)
		{
			_haContext.CallService("telegram_bot", "send_sticker", null, data);
		}

		///<summary>Send a sticker.</summary>
		///<param name="url">Remote path to a static .webp or animated .tgs sticker. eg: http://example.org/path/to/the/sticker.webp</param>
		///<param name="file">Local path to a static .webp or animated .tgs sticker. eg: /path/to/the/sticker.webp</param>
		///<param name="stickerId">ID of a sticker that exists on telegram servers eg: CAACAgIAAxkBAAEDDldhZD-hqWclr6krLq-FWSfCrGNmOQAC9gAD9HsZAAFeYY-ltPYnrCEE</param>
		///<param name="username">Username for a URL which require HTTP authentication. eg: myuser</param>
		///<param name="password">Password (or bearer token) for a URL which require HTTP authentication. eg: myuser_pwd</param>
		///<param name="authentication">Define which authentication method to use. Set to `digest` to use HTTP digest authentication, or `bearer_token` for OAuth 2.0 bearer token authentication. Defaults to `basic`.</param>
		///<param name="target">An array of pre-authorized chat_ids to send the document to. If not present, first allowed chat_id is the default. eg: [12345, 67890] or 12345</param>
		///<param name="disableNotification">Sends the message silently. iOS users and Web users will not receive a notification, Android users will receive a notification with no sound.</param>
		///<param name="verifySsl">Enable or disable SSL certificate verification. Set to false if you're downloading the file from a URL and you don't want to validate the SSL certificate of the server.</param>
		///<param name="timeout">Timeout for send sticker. Will help with timeout errors (poor internet connection, etc)</param>
		///<param name="keyboard">List of rows of commands, comma-separated, to make a custom keyboard. eg: ["/command1, /command2", "/command3"]</param>
		///<param name="inlineKeyboard">List of rows of commands, comma-separated, to make a custom inline keyboard with buttons with associated callback data. eg: ["/button1, /button2", "/button3"] or [[["Text button1", "/button1"], ["Text button2", "/button2"]], [["Text button3", "/button3"]]]</param>
		///<param name="messageTag">Tag for sent message. In telegram_sent event data: {{trigger.event.data.message_tag}} eg: msg_to_edit</param>
		public void SendSticker(string? @url = null, string? @file = null, string? @stickerId = null, string? @username = null, string? @password = null, object? @authentication = null, object? @target = null, bool? @disableNotification = null, bool? @verifySsl = null, long? @timeout = null, object? @keyboard = null, object? @inlineKeyboard = null, string? @messageTag = null)
		{
			_haContext.CallService("telegram_bot", "send_sticker", null, new TelegramBotSendStickerParameters{Url = @url, File = @file, StickerId = @stickerId, Username = @username, Password = @password, Authentication = @authentication, Target = @target, DisableNotification = @disableNotification, VerifySsl = @verifySsl, Timeout = @timeout, Keyboard = @keyboard, InlineKeyboard = @inlineKeyboard, MessageTag = @messageTag});
		}

		///<summary>Send a video.</summary>
		public void SendVideo(TelegramBotSendVideoParameters data)
		{
			_haContext.CallService("telegram_bot", "send_video", null, data);
		}

		///<summary>Send a video.</summary>
		///<param name="url">Remote path to a video. eg: http://example.org/path/to/the/video.mp4</param>
		///<param name="file">Local path to a video. eg: /path/to/the/video.mp4</param>
		///<param name="caption">The title of the video. eg: My video</param>
		///<param name="username">Username for a URL which require HTTP authentication. eg: myuser</param>
		///<param name="password">Password (or bearer token) for a URL which require HTTP authentication. eg: myuser_pwd</param>
		///<param name="authentication">Define which authentication method to use. Set to `digest` to use HTTP digest authentication, or `bearer_token` for OAuth 2.0 bearer token authentication. Defaults to `basic`.</param>
		///<param name="target">An array of pre-authorized chat_ids to send the document to. If not present, first allowed chat_id is the default. eg: [12345, 67890] or 12345</param>
		///<param name="parseMode">Parser for the message text.</param>
		///<param name="disableNotification">Sends the message silently. iOS users and Web users will not receive a notification, Android users will receive a notification with no sound.</param>
		///<param name="verifySsl">Enable or disable SSL certificate verification. Set to false if you're downloading the file from a URL and you don't want to validate the SSL certificate of the server.</param>
		///<param name="timeout">Timeout for send video. Will help with timeout errors (poor internet connection, etc)</param>
		///<param name="keyboard">List of rows of commands, comma-separated, to make a custom keyboard. eg: ["/command1, /command2", "/command3"]</param>
		///<param name="inlineKeyboard">List of rows of commands, comma-separated, to make a custom inline keyboard with buttons with associated callback data. eg: ["/button1, /button2", "/button3"] or [[["Text button1", "/button1"], ["Text button2", "/button2"]], [["Text button3", "/button3"]]]</param>
		///<param name="messageTag">Tag for sent message. In telegram_sent event data: {{trigger.event.data.message_tag}} eg: msg_to_edit</param>
		public void SendVideo(string? @url = null, string? @file = null, string? @caption = null, string? @username = null, string? @password = null, object? @authentication = null, object? @target = null, object? @parseMode = null, bool? @disableNotification = null, bool? @verifySsl = null, long? @timeout = null, object? @keyboard = null, object? @inlineKeyboard = null, string? @messageTag = null)
		{
			_haContext.CallService("telegram_bot", "send_video", null, new TelegramBotSendVideoParameters{Url = @url, File = @file, Caption = @caption, Username = @username, Password = @password, Authentication = @authentication, Target = @target, ParseMode = @parseMode, DisableNotification = @disableNotification, VerifySsl = @verifySsl, Timeout = @timeout, Keyboard = @keyboard, InlineKeyboard = @inlineKeyboard, MessageTag = @messageTag});
		}

		///<summary>Send a voice message.</summary>
		public void SendVoice(TelegramBotSendVoiceParameters data)
		{
			_haContext.CallService("telegram_bot", "send_voice", null, data);
		}

		///<summary>Send a voice message.</summary>
		///<param name="url">Remote path to a voice message. eg: http://example.org/path/to/the/voice.opus</param>
		///<param name="file">Local path to a voice message. eg: /path/to/the/voice.opus</param>
		///<param name="caption">The title of the voice message. eg: My microphone recording</param>
		///<param name="username">Username for a URL which require HTTP authentication. eg: myuser</param>
		///<param name="password">Password (or bearer token) for a URL which require HTTP authentication. eg: myuser_pwd</param>
		///<param name="authentication">Define which authentication method to use. Set to `digest` to use HTTP digest authentication, or `bearer_token` for OAuth 2.0 bearer token authentication. Defaults to `basic`.</param>
		///<param name="target">An array of pre-authorized chat_ids to send the document to. If not present, first allowed chat_id is the default. eg: [12345, 67890] or 12345</param>
		///<param name="disableNotification">Sends the message silently. iOS users and Web users will not receive a notification, Android users will receive a notification with no sound.</param>
		///<param name="verifySsl">Enable or disable SSL certificate verification. Set to false if you're downloading the file from a URL and you don't want to validate the SSL certificate of the server.</param>
		///<param name="timeout">Timeout for send voice. Will help with timeout errors (poor internet connection, etc)</param>
		///<param name="keyboard">List of rows of commands, comma-separated, to make a custom keyboard. eg: ["/command1, /command2", "/command3"]</param>
		///<param name="inlineKeyboard">List of rows of commands, comma-separated, to make a custom inline keyboard with buttons with associated callback data. eg: ["/button1, /button2", "/button3"] or [[["Text button1", "/button1"], ["Text button2", "/button2"]], [["Text button3", "/button3"]]]</param>
		///<param name="messageTag">Tag for sent message. In telegram_sent event data: {{trigger.event.data.message_tag}} eg: msg_to_edit</param>
		public void SendVoice(string? @url = null, string? @file = null, string? @caption = null, string? @username = null, string? @password = null, object? @authentication = null, object? @target = null, bool? @disableNotification = null, bool? @verifySsl = null, long? @timeout = null, object? @keyboard = null, object? @inlineKeyboard = null, string? @messageTag = null)
		{
			_haContext.CallService("telegram_bot", "send_voice", null, new TelegramBotSendVoiceParameters{Url = @url, File = @file, Caption = @caption, Username = @username, Password = @password, Authentication = @authentication, Target = @target, DisableNotification = @disableNotification, VerifySsl = @verifySsl, Timeout = @timeout, Keyboard = @keyboard, InlineKeyboard = @inlineKeyboard, MessageTag = @messageTag});
		}
	}

	public record TelegramBotAnswerCallbackQueryParameters
	{
		///<summary>Unformatted text message body of the notification. eg: OK, I'm listening</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Unique id of the callback response. eg: {{ trigger.event.data.id }}</summary>
		[JsonPropertyName("callback_query_id")]
		public string? CallbackQueryId { get; init; }

		///<summary>Show a permanent notification.</summary>
		[JsonPropertyName("show_alert")]
		public bool? ShowAlert { get; init; }

		///<summary>Timeout for sending the answer. Will help with timeout errors (poor internet connection, etc)</summary>
		[JsonPropertyName("timeout")]
		public long? Timeout { get; init; }
	}

	public record TelegramBotDeleteMessageParameters
	{
		///<summary>id of the message to delete. eg: {{ trigger.event.data.message.message_id }}</summary>
		[JsonPropertyName("message_id")]
		public string? MessageId { get; init; }

		///<summary>The chat_id where to delete the message. eg: 12345</summary>
		[JsonPropertyName("chat_id")]
		public string? ChatId { get; init; }
	}

	public record TelegramBotEditCaptionParameters
	{
		///<summary>id of the message to edit. eg: {{ trigger.event.data.message.message_id }}</summary>
		[JsonPropertyName("message_id")]
		public string? MessageId { get; init; }

		///<summary>The chat_id where to edit the caption. eg: 12345</summary>
		[JsonPropertyName("chat_id")]
		public string? ChatId { get; init; }

		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("caption")]
		public string? Caption { get; init; }

		///<summary>List of rows of commands, comma-separated, to make a custom inline keyboard with buttons with associated callback data. eg: ["/button1, /button2", "/button3"] or [[["Text button1", "/button1"], ["Text button2", "/button2"]], [["Text button3", "/button3"]]]</summary>
		[JsonPropertyName("inline_keyboard")]
		public object? InlineKeyboard { get; init; }
	}

	public record TelegramBotEditMessageParameters
	{
		///<summary>id of the message to edit. eg: {{ trigger.event.data.message.message_id }}</summary>
		[JsonPropertyName("message_id")]
		public string? MessageId { get; init; }

		///<summary>The chat_id where to edit the message. eg: 12345</summary>
		[JsonPropertyName("chat_id")]
		public string? ChatId { get; init; }

		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Optional title for your notification. Will be composed as '%title\n%message' eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>Parser for the message text.</summary>
		[JsonPropertyName("parse_mode")]
		public object? ParseMode { get; init; }

		///<summary>Disables link previews for links in the message.</summary>
		[JsonPropertyName("disable_web_page_preview")]
		public bool? DisableWebPagePreview { get; init; }

		///<summary>List of rows of commands, comma-separated, to make a custom inline keyboard with buttons with associated callback data. eg: ["/button1, /button2", "/button3"] or [[["Text button1", "/button1"], ["Text button2", "/button2"]], [["Text button3", "/button3"]]]</summary>
		[JsonPropertyName("inline_keyboard")]
		public object? InlineKeyboard { get; init; }
	}

	public record TelegramBotEditReplymarkupParameters
	{
		///<summary>id of the message to edit. eg: {{ trigger.event.data.message.message_id }}</summary>
		[JsonPropertyName("message_id")]
		public string? MessageId { get; init; }

		///<summary>The chat_id where to edit the reply_markup. eg: 12345</summary>
		[JsonPropertyName("chat_id")]
		public string? ChatId { get; init; }

		///<summary>List of rows of commands, comma-separated, to make a custom inline keyboard with buttons with associated callback data. eg: ["/button1, /button2", "/button3"] or [[["Text button1", "/button1"], ["Text button2", "/button2"]], [["Text button3", "/button3"]]]</summary>
		[JsonPropertyName("inline_keyboard")]
		public object? InlineKeyboard { get; init; }
	}

	public record TelegramBotSendAnimationParameters
	{
		///<summary>Remote path to a GIF or H.264/MPEG-4 AVC video without sound. eg: http://example.org/path/to/the/animation.gif</summary>
		[JsonPropertyName("url")]
		public string? Url { get; init; }

		///<summary>Local path to a GIF or H.264/MPEG-4 AVC video without sound. eg: /path/to/the/animation.gif</summary>
		[JsonPropertyName("file")]
		public string? File { get; init; }

		///<summary>The title of the animation. eg: My animation</summary>
		[JsonPropertyName("caption")]
		public string? Caption { get; init; }

		///<summary>Username for a URL which require HTTP authentication. eg: myuser</summary>
		[JsonPropertyName("username")]
		public string? Username { get; init; }

		///<summary>Password (or bearer token) for a URL which require HTTP authentication. eg: myuser_pwd</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }

		///<summary>Define which authentication method to use. Set to `digest` to use HTTP digest authentication, or `bearer_token` for OAuth 2.0 bearer token authentication. Defaults to `basic`.</summary>
		[JsonPropertyName("authentication")]
		public object? Authentication { get; init; }

		///<summary>An array of pre-authorized chat_ids to send the document to. If not present, first allowed chat_id is the default. eg: [12345, 67890] or 12345</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Parser for the message text.</summary>
		[JsonPropertyName("parse_mode")]
		public object? ParseMode { get; init; }

		///<summary>Sends the message silently. iOS users and Web users will not receive a notification, Android users will receive a notification with no sound.</summary>
		[JsonPropertyName("disable_notification")]
		public bool? DisableNotification { get; init; }

		///<summary>Enable or disable SSL certificate verification. Set to false if you're downloading the file from a URL and you don't want to validate the SSL certificate of the server.</summary>
		[JsonPropertyName("verify_ssl")]
		public bool? VerifySsl { get; init; }

		///<summary>Timeout for send sticker. Will help with timeout errors (poor internet connection, etc)</summary>
		[JsonPropertyName("timeout")]
		public long? Timeout { get; init; }

		///<summary>List of rows of commands, comma-separated, to make a custom keyboard. eg: ["/command1, /command2", "/command3"]</summary>
		[JsonPropertyName("keyboard")]
		public object? Keyboard { get; init; }

		///<summary>List of rows of commands, comma-separated, to make a custom inline keyboard with buttons with associated callback data. eg: ["/button1, /button2", "/button3"] or [[["Text button1", "/button1"], ["Text button2", "/button2"]], [["Text button3", "/button3"]]]</summary>
		[JsonPropertyName("inline_keyboard")]
		public object? InlineKeyboard { get; init; }
	}

	public record TelegramBotSendDocumentParameters
	{
		///<summary>Remote path to a document. eg: http://example.org/path/to/the/document.odf</summary>
		[JsonPropertyName("url")]
		public string? Url { get; init; }

		///<summary>Local path to a document. eg: /tmp/whatever.odf</summary>
		[JsonPropertyName("file")]
		public string? File { get; init; }

		///<summary>The title of the document. eg: Document Title xy</summary>
		[JsonPropertyName("caption")]
		public string? Caption { get; init; }

		///<summary>Username for a URL which require HTTP authentication. eg: myuser</summary>
		[JsonPropertyName("username")]
		public string? Username { get; init; }

		///<summary>Password (or bearer token) for a URL which require HTTP authentication. eg: myuser_pwd</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }

		///<summary>Define which authentication method to use. Set to `digest` to use HTTP digest authentication, or `bearer_token` for OAuth 2.0 bearer token authentication. Defaults to `basic`.</summary>
		[JsonPropertyName("authentication")]
		public object? Authentication { get; init; }

		///<summary>An array of pre-authorized chat_ids to send the document to. If not present, first allowed chat_id is the default. eg: [12345, 67890] or 12345</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Parser for the message text.</summary>
		[JsonPropertyName("parse_mode")]
		public object? ParseMode { get; init; }

		///<summary>Sends the message silently. iOS users and Web users will not receive a notification, Android users will receive a notification with no sound.</summary>
		[JsonPropertyName("disable_notification")]
		public bool? DisableNotification { get; init; }

		///<summary>Enable or disable SSL certificate verification. Set to false if you're downloading the file from a URL and you don't want to validate the SSL certificate of the server.</summary>
		[JsonPropertyName("verify_ssl")]
		public bool? VerifySsl { get; init; }

		///<summary>Timeout for send document. Will help with timeout errors (poor internet connection, etc)</summary>
		[JsonPropertyName("timeout")]
		public long? Timeout { get; init; }

		///<summary>List of rows of commands, comma-separated, to make a custom keyboard. eg: ["/command1, /command2", "/command3"]</summary>
		[JsonPropertyName("keyboard")]
		public object? Keyboard { get; init; }

		///<summary>List of rows of commands, comma-separated, to make a custom inline keyboard with buttons with associated callback data. eg: ["/button1, /button2", "/button3"] or [[["Text button1", "/button1"], ["Text button2", "/button2"]], [["Text button3", "/button3"]]]</summary>
		[JsonPropertyName("inline_keyboard")]
		public object? InlineKeyboard { get; init; }

		///<summary>Tag for sent message. In telegram_sent event data: {{trigger.event.data.message_tag}} eg: msg_to_edit</summary>
		[JsonPropertyName("message_tag")]
		public string? MessageTag { get; init; }
	}

	public record TelegramBotSendLocationParameters
	{
		///<summary>The latitude to send.</summary>
		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		///<summary>The longitude to send.</summary>
		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		///<summary>An array of pre-authorized chat_ids to send the location to. If not present, first allowed chat_id is the default. eg: [12345, 67890] or 12345</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Sends the message silently. iOS users and Web users will not receive a notification, Android users will receive a notification with no sound.</summary>
		[JsonPropertyName("disable_notification")]
		public bool? DisableNotification { get; init; }

		///<summary>Timeout for send photo. Will help with timeout errors (poor internet connection, etc)</summary>
		[JsonPropertyName("timeout")]
		public long? Timeout { get; init; }

		///<summary>List of rows of commands, comma-separated, to make a custom keyboard. eg: ["/command1, /command2", "/command3"]</summary>
		[JsonPropertyName("keyboard")]
		public object? Keyboard { get; init; }

		///<summary>List of rows of commands, comma-separated, to make a custom inline keyboard with buttons with associated callback data. eg: ["/button1, /button2", "/button3"] or [[["Text button1", "/button1"], ["Text button2", "/button2"]], [["Text button3", "/button3"]]]</summary>
		[JsonPropertyName("inline_keyboard")]
		public object? InlineKeyboard { get; init; }

		///<summary>Tag for sent message. In telegram_sent event data: {{trigger.event.data.message_tag}} eg: msg_to_edit</summary>
		[JsonPropertyName("message_tag")]
		public string? MessageTag { get; init; }
	}

	public record TelegramBotSendMessageParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Optional title for your notification. Will be composed as '%title\n%message' eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of pre-authorized chat_ids to send the notification to. If not present, first allowed chat_id is the default. eg: [12345, 67890] or 12345</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Parser for the message text.</summary>
		[JsonPropertyName("parse_mode")]
		public object? ParseMode { get; init; }

		///<summary>Sends the message silently. iOS users and Web users will not receive a notification, Android users will receive a notification with no sound.</summary>
		[JsonPropertyName("disable_notification")]
		public bool? DisableNotification { get; init; }

		///<summary>Disables link previews for links in the message.</summary>
		[JsonPropertyName("disable_web_page_preview")]
		public bool? DisableWebPagePreview { get; init; }

		///<summary>Timeout for send message. Will help with timeout errors (poor internet connection, etc)s</summary>
		[JsonPropertyName("timeout")]
		public long? Timeout { get; init; }

		///<summary>List of rows of commands, comma-separated, to make a custom keyboard. Empty list clears a previously set keyboard. eg: ["/command1, /command2", "/command3"]</summary>
		[JsonPropertyName("keyboard")]
		public object? Keyboard { get; init; }

		///<summary>List of rows of commands, comma-separated, to make a custom inline keyboard with buttons with associated callback data. eg: ["/button1, /button2", "/button3"] or ["Text button1:/button1, Text button2:/button2", "Text button3:/button3"] or [[["Text button1", "/button1"], ["Text button2", "/button2"]], [["Text button3", "/button3"]]]</summary>
		[JsonPropertyName("inline_keyboard")]
		public object? InlineKeyboard { get; init; }

		///<summary>Tag for sent message. In telegram_sent event data: {{trigger.event.data.message_tag}} eg: msg_to_edit</summary>
		[JsonPropertyName("message_tag")]
		public string? MessageTag { get; init; }
	}

	public record TelegramBotSendPhotoParameters
	{
		///<summary>Remote path to an image. eg: http://example.org/path/to/the/image.png</summary>
		[JsonPropertyName("url")]
		public string? Url { get; init; }

		///<summary>Local path to an image. eg: /path/to/the/image.png</summary>
		[JsonPropertyName("file")]
		public string? File { get; init; }

		///<summary>The title of the image. eg: My image</summary>
		[JsonPropertyName("caption")]
		public string? Caption { get; init; }

		///<summary>Username for a URL which require HTTP authentication. eg: myuser</summary>
		[JsonPropertyName("username")]
		public string? Username { get; init; }

		///<summary>Password (or bearer token) for a URL which require HTTP authentication. eg: myuser_pwd</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }

		///<summary>Define which authentication method to use. Set to `digest` to use HTTP digest authentication, or `bearer_token` for OAuth 2.0 bearer token authentication. Defaults to `basic`.</summary>
		[JsonPropertyName("authentication")]
		public object? Authentication { get; init; }

		///<summary>An array of pre-authorized chat_ids to send the document to. If not present, first allowed chat_id is the default. eg: [12345, 67890] or 12345</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Parser for the message text.</summary>
		[JsonPropertyName("parse_mode")]
		public object? ParseMode { get; init; }

		///<summary>Sends the message silently. iOS users and Web users will not receive a notification, Android users will receive a notification with no sound.</summary>
		[JsonPropertyName("disable_notification")]
		public bool? DisableNotification { get; init; }

		///<summary>Enable or disable SSL certificate verification. Set to false if you're downloading the file from a URL and you don't want to validate the SSL certificate of the server.</summary>
		[JsonPropertyName("verify_ssl")]
		public bool? VerifySsl { get; init; }

		///<summary>Timeout for send photo. Will help with timeout errors (poor internet connection, etc)</summary>
		[JsonPropertyName("timeout")]
		public long? Timeout { get; init; }

		///<summary>List of rows of commands, comma-separated, to make a custom keyboard. eg: ["/command1, /command2", "/command3"]</summary>
		[JsonPropertyName("keyboard")]
		public object? Keyboard { get; init; }

		///<summary>List of rows of commands, comma-separated, to make a custom inline keyboard with buttons with associated callback data. eg: ["/button1, /button2", "/button3"] or [[["Text button1", "/button1"], ["Text button2", "/button2"]], [["Text button3", "/button3"]]]</summary>
		[JsonPropertyName("inline_keyboard")]
		public object? InlineKeyboard { get; init; }

		///<summary>Tag for sent message. In telegram_sent event data: {{trigger.event.data.message_tag}} eg: msg_to_edit</summary>
		[JsonPropertyName("message_tag")]
		public string? MessageTag { get; init; }
	}

	public record TelegramBotSendPollParameters
	{
		///<summary>An array of pre-authorized chat_ids to send the location to. If not present, first allowed chat_id is the default. eg: [12345, 67890] or 12345</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Poll question, 1-300 characters</summary>
		[JsonPropertyName("question")]
		public string? Question { get; init; }

		///<summary>List of answer options, 2-10 strings 1-100 characters each</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }

		///<summary>If the poll needs to be anonymous, defaults to True</summary>
		[JsonPropertyName("is_anonymous")]
		public bool? IsAnonymous { get; init; }

		///<summary>If the poll allows multiple answers, defaults to False</summary>
		[JsonPropertyName("allows_multiple_answers")]
		public bool? AllowsMultipleAnswers { get; init; }

		///<summary>Amount of time in seconds the poll will be active after creation, 5-600.</summary>
		[JsonPropertyName("open_period")]
		public long? OpenPeriod { get; init; }

		///<summary>Sends the message silently. iOS users and Web users will not receive a notification, Android users will receive a notification with no sound.</summary>
		[JsonPropertyName("disable_notification")]
		public bool? DisableNotification { get; init; }

		///<summary>Timeout for send poll. Will help with timeout errors (poor internet connection, etc)</summary>
		[JsonPropertyName("timeout")]
		public long? Timeout { get; init; }
	}

	public record TelegramBotSendStickerParameters
	{
		///<summary>Remote path to a static .webp or animated .tgs sticker. eg: http://example.org/path/to/the/sticker.webp</summary>
		[JsonPropertyName("url")]
		public string? Url { get; init; }

		///<summary>Local path to a static .webp or animated .tgs sticker. eg: /path/to/the/sticker.webp</summary>
		[JsonPropertyName("file")]
		public string? File { get; init; }

		///<summary>ID of a sticker that exists on telegram servers eg: CAACAgIAAxkBAAEDDldhZD-hqWclr6krLq-FWSfCrGNmOQAC9gAD9HsZAAFeYY-ltPYnrCEE</summary>
		[JsonPropertyName("sticker_id")]
		public string? StickerId { get; init; }

		///<summary>Username for a URL which require HTTP authentication. eg: myuser</summary>
		[JsonPropertyName("username")]
		public string? Username { get; init; }

		///<summary>Password (or bearer token) for a URL which require HTTP authentication. eg: myuser_pwd</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }

		///<summary>Define which authentication method to use. Set to `digest` to use HTTP digest authentication, or `bearer_token` for OAuth 2.0 bearer token authentication. Defaults to `basic`.</summary>
		[JsonPropertyName("authentication")]
		public object? Authentication { get; init; }

		///<summary>An array of pre-authorized chat_ids to send the document to. If not present, first allowed chat_id is the default. eg: [12345, 67890] or 12345</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Sends the message silently. iOS users and Web users will not receive a notification, Android users will receive a notification with no sound.</summary>
		[JsonPropertyName("disable_notification")]
		public bool? DisableNotification { get; init; }

		///<summary>Enable or disable SSL certificate verification. Set to false if you're downloading the file from a URL and you don't want to validate the SSL certificate of the server.</summary>
		[JsonPropertyName("verify_ssl")]
		public bool? VerifySsl { get; init; }

		///<summary>Timeout for send sticker. Will help with timeout errors (poor internet connection, etc)</summary>
		[JsonPropertyName("timeout")]
		public long? Timeout { get; init; }

		///<summary>List of rows of commands, comma-separated, to make a custom keyboard. eg: ["/command1, /command2", "/command3"]</summary>
		[JsonPropertyName("keyboard")]
		public object? Keyboard { get; init; }

		///<summary>List of rows of commands, comma-separated, to make a custom inline keyboard with buttons with associated callback data. eg: ["/button1, /button2", "/button3"] or [[["Text button1", "/button1"], ["Text button2", "/button2"]], [["Text button3", "/button3"]]]</summary>
		[JsonPropertyName("inline_keyboard")]
		public object? InlineKeyboard { get; init; }

		///<summary>Tag for sent message. In telegram_sent event data: {{trigger.event.data.message_tag}} eg: msg_to_edit</summary>
		[JsonPropertyName("message_tag")]
		public string? MessageTag { get; init; }
	}

	public record TelegramBotSendVideoParameters
	{
		///<summary>Remote path to a video. eg: http://example.org/path/to/the/video.mp4</summary>
		[JsonPropertyName("url")]
		public string? Url { get; init; }

		///<summary>Local path to a video. eg: /path/to/the/video.mp4</summary>
		[JsonPropertyName("file")]
		public string? File { get; init; }

		///<summary>The title of the video. eg: My video</summary>
		[JsonPropertyName("caption")]
		public string? Caption { get; init; }

		///<summary>Username for a URL which require HTTP authentication. eg: myuser</summary>
		[JsonPropertyName("username")]
		public string? Username { get; init; }

		///<summary>Password (or bearer token) for a URL which require HTTP authentication. eg: myuser_pwd</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }

		///<summary>Define which authentication method to use. Set to `digest` to use HTTP digest authentication, or `bearer_token` for OAuth 2.0 bearer token authentication. Defaults to `basic`.</summary>
		[JsonPropertyName("authentication")]
		public object? Authentication { get; init; }

		///<summary>An array of pre-authorized chat_ids to send the document to. If not present, first allowed chat_id is the default. eg: [12345, 67890] or 12345</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Parser for the message text.</summary>
		[JsonPropertyName("parse_mode")]
		public object? ParseMode { get; init; }

		///<summary>Sends the message silently. iOS users and Web users will not receive a notification, Android users will receive a notification with no sound.</summary>
		[JsonPropertyName("disable_notification")]
		public bool? DisableNotification { get; init; }

		///<summary>Enable or disable SSL certificate verification. Set to false if you're downloading the file from a URL and you don't want to validate the SSL certificate of the server.</summary>
		[JsonPropertyName("verify_ssl")]
		public bool? VerifySsl { get; init; }

		///<summary>Timeout for send video. Will help with timeout errors (poor internet connection, etc)</summary>
		[JsonPropertyName("timeout")]
		public long? Timeout { get; init; }

		///<summary>List of rows of commands, comma-separated, to make a custom keyboard. eg: ["/command1, /command2", "/command3"]</summary>
		[JsonPropertyName("keyboard")]
		public object? Keyboard { get; init; }

		///<summary>List of rows of commands, comma-separated, to make a custom inline keyboard with buttons with associated callback data. eg: ["/button1, /button2", "/button3"] or [[["Text button1", "/button1"], ["Text button2", "/button2"]], [["Text button3", "/button3"]]]</summary>
		[JsonPropertyName("inline_keyboard")]
		public object? InlineKeyboard { get; init; }

		///<summary>Tag for sent message. In telegram_sent event data: {{trigger.event.data.message_tag}} eg: msg_to_edit</summary>
		[JsonPropertyName("message_tag")]
		public string? MessageTag { get; init; }
	}

	public record TelegramBotSendVoiceParameters
	{
		///<summary>Remote path to a voice message. eg: http://example.org/path/to/the/voice.opus</summary>
		[JsonPropertyName("url")]
		public string? Url { get; init; }

		///<summary>Local path to a voice message. eg: /path/to/the/voice.opus</summary>
		[JsonPropertyName("file")]
		public string? File { get; init; }

		///<summary>The title of the voice message. eg: My microphone recording</summary>
		[JsonPropertyName("caption")]
		public string? Caption { get; init; }

		///<summary>Username for a URL which require HTTP authentication. eg: myuser</summary>
		[JsonPropertyName("username")]
		public string? Username { get; init; }

		///<summary>Password (or bearer token) for a URL which require HTTP authentication. eg: myuser_pwd</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }

		///<summary>Define which authentication method to use. Set to `digest` to use HTTP digest authentication, or `bearer_token` for OAuth 2.0 bearer token authentication. Defaults to `basic`.</summary>
		[JsonPropertyName("authentication")]
		public object? Authentication { get; init; }

		///<summary>An array of pre-authorized chat_ids to send the document to. If not present, first allowed chat_id is the default. eg: [12345, 67890] or 12345</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Sends the message silently. iOS users and Web users will not receive a notification, Android users will receive a notification with no sound.</summary>
		[JsonPropertyName("disable_notification")]
		public bool? DisableNotification { get; init; }

		///<summary>Enable or disable SSL certificate verification. Set to false if you're downloading the file from a URL and you don't want to validate the SSL certificate of the server.</summary>
		[JsonPropertyName("verify_ssl")]
		public bool? VerifySsl { get; init; }

		///<summary>Timeout for send voice. Will help with timeout errors (poor internet connection, etc)</summary>
		[JsonPropertyName("timeout")]
		public long? Timeout { get; init; }

		///<summary>List of rows of commands, comma-separated, to make a custom keyboard. eg: ["/command1, /command2", "/command3"]</summary>
		[JsonPropertyName("keyboard")]
		public object? Keyboard { get; init; }

		///<summary>List of rows of commands, comma-separated, to make a custom inline keyboard with buttons with associated callback data. eg: ["/button1, /button2", "/button3"] or [[["Text button1", "/button1"], ["Text button2", "/button2"]], [["Text button3", "/button3"]]]</summary>
		[JsonPropertyName("inline_keyboard")]
		public object? InlineKeyboard { get; init; }

		///<summary>Tag for sent message. In telegram_sent event data: {{trigger.event.data.message_tag}} eg: msg_to_edit</summary>
		[JsonPropertyName("message_tag")]
		public string? MessageTag { get; init; }
	}

	public class TemplateServices
	{
		private readonly IHaContext _haContext;
		public TemplateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all template entities.</summary>
		public void Reload()
		{
			_haContext.CallService("template", "reload", null);
		}
	}

	public class TimerServices
	{
		private readonly IHaContext _haContext;
		public TimerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Cancel a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Cancel(ServiceTarget target)
		{
			_haContext.CallService("timer", "cancel", target);
		}

		///<summary>Finish a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Finish(ServiceTarget target)
		{
			_haContext.CallService("timer", "finish", target);
		}

		///<summary>Pause a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(ServiceTarget target)
		{
			_haContext.CallService("timer", "pause", target);
		}

		public void Reload()
		{
			_haContext.CallService("timer", "reload", null);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		public void Start(ServiceTarget target, TimerStartParameters data)
		{
			_haContext.CallService("timer", "start", target, data);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
		public void Start(ServiceTarget target, string? @duration = null)
		{
			_haContext.CallService("timer", "start", target, new TimerStartParameters{Duration = @duration});
		}
	}

	public record TimerStartParameters
	{
		///<summary>Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</summary>
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public class TtsServices
	{
		private readonly IHaContext _haContext;
		public TtsServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Remove all text-to-speech cache files and RAM cache.</summary>
		public void ClearCache()
		{
			_haContext.CallService("tts", "clear_cache", null);
		}

		///<summary>Say something using text-to-speech on a media player with cloud.</summary>
		public void CloudSay(TtsCloudSayParameters data)
		{
			_haContext.CallService("tts", "cloud_say", null, data);
		}

		///<summary>Say something using text-to-speech on a media player with cloud.</summary>
		///<param name="entityId">Name(s) of media player entities.</param>
		///<param name="message">Text to speak on devices. eg: My name is hanna</param>
		///<param name="cache">Control file cache of this message.</param>
		///<param name="language">Language to use for speech generation. eg: ru</param>
		///<param name="options">A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</param>
		public void CloudSay(string @entityId, string @message, bool? @cache = null, string? @language = null, object? @options = null)
		{
			_haContext.CallService("tts", "cloud_say", null, new TtsCloudSayParameters{EntityId = @entityId, Message = @message, Cache = @cache, Language = @language, Options = @options});
		}

		///<summary>Say something using text-to-speech on a media player with google_translate.</summary>
		public void GoogleSay(TtsGoogleSayParameters data)
		{
			_haContext.CallService("tts", "google_say", null, data);
		}

		///<summary>Say something using text-to-speech on a media player with google_translate.</summary>
		///<param name="entityId">Name(s) of media player entities.</param>
		///<param name="message">Text to speak on devices. eg: My name is hanna</param>
		///<param name="cache">Control file cache of this message.</param>
		///<param name="language">Language to use for speech generation. eg: ru</param>
		///<param name="options">A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</param>
		public void GoogleSay(string @entityId, string @message, bool? @cache = null, string? @language = null, object? @options = null)
		{
			_haContext.CallService("tts", "google_say", null, new TtsGoogleSayParameters{EntityId = @entityId, Message = @message, Cache = @cache, Language = @language, Options = @options});
		}
	}

	public record TtsCloudSayParameters
	{
		///<summary>Name(s) of media player entities.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Text to speak on devices. eg: My name is hanna</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Control file cache of this message.</summary>
		[JsonPropertyName("cache")]
		public bool? Cache { get; init; }

		///<summary>Language to use for speech generation. eg: ru</summary>
		[JsonPropertyName("language")]
		public string? Language { get; init; }

		///<summary>A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public record TtsGoogleSayParameters
	{
		///<summary>Name(s) of media player entities.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Text to speak on devices. eg: My name is hanna</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Control file cache of this message.</summary>
		[JsonPropertyName("cache")]
		public bool? Cache { get; init; }

		///<summary>Language to use for speech generation. eg: ru</summary>
		[JsonPropertyName("language")]
		public string? Language { get; init; }

		///<summary>A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public class UiLovelaceMinimalistServices
	{
		private readonly IHaContext _haContext;
		public UiLovelaceMinimalistServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload dashboard configuration for UI Lovelace Minimalist</summary>
		public void Reload()
		{
			_haContext.CallService("ui_lovelace_minimalist", "reload", null);
		}
	}

	public class UnifiServices
	{
		private readonly IHaContext _haContext;
		public UnifiServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Try to get wireless client to reconnect to UniFi Network</summary>
		public void ReconnectClient(UnifiReconnectClientParameters data)
		{
			_haContext.CallService("unifi", "reconnect_client", null, data);
		}

		///<summary>Try to get wireless client to reconnect to UniFi Network</summary>
		///<param name="deviceId">Try reconnect client to wireless network</param>
		public void ReconnectClient(string @deviceId)
		{
			_haContext.CallService("unifi", "reconnect_client", null, new UnifiReconnectClientParameters{DeviceId = @deviceId});
		}

		///<summary>Clean up clients that has only been associated with the controller for a short period of time.</summary>
		public void RemoveClients()
		{
			_haContext.CallService("unifi", "remove_clients", null);
		}
	}

	public record UnifiReconnectClientParameters
	{
		///<summary>Try reconnect client to wireless network</summary>
		[JsonPropertyName("device_id")]
		public string? DeviceId { get; init; }
	}

	public class UnifiprotectServices
	{
		private readonly IHaContext _haContext;
		public UnifiprotectServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Adds a new custom message for Doorbells.</summary>
		public void AddDoorbellText(UnifiprotectAddDoorbellTextParameters data)
		{
			_haContext.CallService("unifiprotect", "add_doorbell_text", null, data);
		}

		///<summary>Adds a new custom message for Doorbells.</summary>
		///<param name="deviceId">Any device from the UniFi Protect instance you want to change. In case you have multiple Protect Instances.</param>
		///<param name="message">New custom message to add for Doorbells. Must be less than 30 characters. eg: Come In</param>
		public void AddDoorbellText(string @deviceId, string @message)
		{
			_haContext.CallService("unifiprotect", "add_doorbell_text", null, new UnifiprotectAddDoorbellTextParameters{DeviceId = @deviceId, Message = @message});
		}

		///<summary>Removes an existing message for Doorbells.</summary>
		public void RemoveDoorbellText(UnifiprotectRemoveDoorbellTextParameters data)
		{
			_haContext.CallService("unifiprotect", "remove_doorbell_text", null, data);
		}

		///<summary>Removes an existing message for Doorbells.</summary>
		///<param name="deviceId">Any device from the UniFi Protect instance you want to change. In case you have multiple Protect Instances.</param>
		///<param name="message">Existing custom message to remove for Doorbells. eg: Go Away!</param>
		public void RemoveDoorbellText(string @deviceId, string @message)
		{
			_haContext.CallService("unifiprotect", "remove_doorbell_text", null, new UnifiprotectRemoveDoorbellTextParameters{DeviceId = @deviceId, Message = @message});
		}

		///<summary>Use to set the paired doorbell(s) with a smart chime. </summary>
		public void SetChimePairedDoorbells(UnifiprotectSetChimePairedDoorbellsParameters data)
		{
			_haContext.CallService("unifiprotect", "set_chime_paired_doorbells", null, data);
		}

		///<summary>Use to set the paired doorbell(s) with a smart chime. </summary>
		///<param name="deviceId">The Chimes to link to the doorbells to</param>
		///<param name="doorbells">The Doorbells to link to the chime eg: binary_sensor.front_doorbell_doorbell</param>
		public void SetChimePairedDoorbells(string @deviceId, string? @doorbells = null)
		{
			_haContext.CallService("unifiprotect", "set_chime_paired_doorbells", null, new UnifiprotectSetChimePairedDoorbellsParameters{DeviceId = @deviceId, Doorbells = @doorbells});
		}

		///<summary>Sets the default doorbell message. This will be the message that is automatically selected when a message "expires".</summary>
		public void SetDefaultDoorbellText(UnifiprotectSetDefaultDoorbellTextParameters data)
		{
			_haContext.CallService("unifiprotect", "set_default_doorbell_text", null, data);
		}

		///<summary>Sets the default doorbell message. This will be the message that is automatically selected when a message "expires".</summary>
		///<param name="deviceId">Any device from the UniFi Protect instance you want to change. In case you have multiple Protect Instances.</param>
		///<param name="message">The default message for your Doorbell. Must be less than 30 characters. eg: Welcome!</param>
		public void SetDefaultDoorbellText(string @deviceId, string @message)
		{
			_haContext.CallService("unifiprotect", "set_default_doorbell_text", null, new UnifiprotectSetDefaultDoorbellTextParameters{DeviceId = @deviceId, Message = @message});
		}

		///<summary>Use to dynamically set the message on a Doorbell LCD screen. This service should only be used to set dynamic messages (i.e. setting the current outdoor temperature on your Doorbell). Static messages should still be set using the Select entity and can be added/removed using the add_doorbell_text/remove_doorbell_text services. </summary>
		public void SetDoorbellMessage(UnifiprotectSetDoorbellMessageParameters data)
		{
			_haContext.CallService("unifiprotect", "set_doorbell_message", null, data);
		}

		///<summary>Use to dynamically set the message on a Doorbell LCD screen. This service should only be used to set dynamic messages (i.e. setting the current outdoor temperature on your Doorbell). Static messages should still be set using the Select entity and can be added/removed using the add_doorbell_text/remove_doorbell_text services. </summary>
		///<param name="entityId">The Doorbell Text select entity for your Doorbell. eg: select.front_doorbell_camera_doorbell_text</param>
		///<param name="message">The message you would like to display on the LCD screen of your Doorbell. Must be less than 30 characters. eg: Welcome | 09:23 | 25°C</param>
		///<param name="duration">Number of minutes to display the message for before returning to the default message. The default is to not expire. eg: 5</param>
		public void SetDoorbellMessage(string @entityId, string @message, long? @duration = null)
		{
			_haContext.CallService("unifiprotect", "set_doorbell_message", null, new UnifiprotectSetDoorbellMessageParameters{EntityId = @entityId, Message = @message, Duration = @duration});
		}
	}

	public record UnifiprotectAddDoorbellTextParameters
	{
		///<summary>Any device from the UniFi Protect instance you want to change. In case you have multiple Protect Instances.</summary>
		[JsonPropertyName("device_id")]
		public string? DeviceId { get; init; }

		///<summary>New custom message to add for Doorbells. Must be less than 30 characters. eg: Come In</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }
	}

	public record UnifiprotectRemoveDoorbellTextParameters
	{
		///<summary>Any device from the UniFi Protect instance you want to change. In case you have multiple Protect Instances.</summary>
		[JsonPropertyName("device_id")]
		public string? DeviceId { get; init; }

		///<summary>Existing custom message to remove for Doorbells. eg: Go Away!</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }
	}

	public record UnifiprotectSetChimePairedDoorbellsParameters
	{
		///<summary>The Chimes to link to the doorbells to</summary>
		[JsonPropertyName("device_id")]
		public string? DeviceId { get; init; }

		///<summary>The Doorbells to link to the chime eg: binary_sensor.front_doorbell_doorbell</summary>
		[JsonPropertyName("doorbells")]
		public string? Doorbells { get; init; }
	}

	public record UnifiprotectSetDefaultDoorbellTextParameters
	{
		///<summary>Any device from the UniFi Protect instance you want to change. In case you have multiple Protect Instances.</summary>
		[JsonPropertyName("device_id")]
		public string? DeviceId { get; init; }

		///<summary>The default message for your Doorbell. Must be less than 30 characters. eg: Welcome!</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }
	}

	public record UnifiprotectSetDoorbellMessageParameters
	{
		///<summary>The Doorbell Text select entity for your Doorbell. eg: select.front_doorbell_camera_doorbell_text</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>The message you would like to display on the LCD screen of your Doorbell. Must be less than 30 characters. eg: Welcome | 09:23 | 25°C</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Number of minutes to display the message for before returning to the default message. The default is to not expire. eg: 5</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public class UpdateServices
	{
		private readonly IHaContext _haContext;
		public UpdateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Removes the skipped version marker from an update.</summary>
		///<param name="target">The target for this service call</param>
		public void ClearSkipped(ServiceTarget target)
		{
			_haContext.CallService("update", "clear_skipped", target);
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The target for this service call</param>
		public void Install(ServiceTarget target, UpdateInstallParameters data)
		{
			_haContext.CallService("update", "install", target, data);
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The target for this service call</param>
		///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
		///<param name="backup">Backup before installing the update, if supported by the integration.</param>
		public void Install(ServiceTarget target, string? @version = null, bool? @backup = null)
		{
			_haContext.CallService("update", "install", target, new UpdateInstallParameters{Version = @version, Backup = @backup});
		}

		///<summary>Mark currently available update as skipped.</summary>
		///<param name="target">The target for this service call</param>
		public void Skip(ServiceTarget target)
		{
			_haContext.CallService("update", "skip", target);
		}
	}

	public record UpdateInstallParameters
	{
		///<summary>Version to install, if omitted, the latest version will be installed. eg: 1.0.0</summary>
		[JsonPropertyName("version")]
		public string? Version { get; init; }

		///<summary>Backup before installing the update, if supported by the integration.</summary>
		[JsonPropertyName("backup")]
		public bool? Backup { get; init; }
	}

	public class VacuumServices
	{
		private readonly IHaContext _haContext;
		public VacuumServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		///<param name="target">The target for this service call</param>
		public void CleanSpot(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "clean_spot", target);
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		///<param name="target">The target for this service call</param>
		public void Locate(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "locate", target);
		}

		///<summary>Pause the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "pause", target);
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		///<param name="target">The target for this service call</param>
		public void ReturnToBase(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "return_to_base", target);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SendCommand(ServiceTarget target, VacuumSendCommandParameters data)
		{
			_haContext.CallService("vacuum", "send_command", target, data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public void SendCommand(ServiceTarget target, string @command, object? @params = null)
		{
			_haContext.CallService("vacuum", "send_command", target, new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanSpeed(ServiceTarget target, VacuumSetFanSpeedParameters data)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public void SetFanSpeed(ServiceTarget target, string @fanSpeed)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Start or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Start(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start", target);
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void StartPause(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start_pause", target);
		}

		///<summary>Stop the current cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Stop(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "stop", target);
		}

		public void Toggle()
		{
			_haContext.CallService("vacuum", "toggle", null);
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_off", target);
		}

		///<summary>Start a new cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_on", target);
		}
	}

	public record VacuumSendCommandParameters
	{
		///<summary>Command to execute. eg: set_dnd_timer</summary>
		[JsonPropertyName("command")]
		public string? Command { get; init; }

		///<summary>Parameters for the command. eg: { "key": "value" }</summary>
		[JsonPropertyName("params")]
		public object? Params { get; init; }
	}

	public record VacuumSetFanSpeedParameters
	{
		///<summary>Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</summary>
		[JsonPropertyName("fan_speed")]
		public string? FanSpeed { get; init; }
	}

	public class WakeOnLanServices
	{
		private readonly IHaContext _haContext;
		public WakeOnLanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send a 'magic packet' to wake up a device with 'Wake-On-LAN' capabilities.</summary>
		public void SendMagicPacket(WakeOnLanSendMagicPacketParameters data)
		{
			_haContext.CallService("wake_on_lan", "send_magic_packet", null, data);
		}

		///<summary>Send a 'magic packet' to wake up a device with 'Wake-On-LAN' capabilities.</summary>
		///<param name="mac">MAC address of the device to wake up. eg: aa:bb:cc:dd:ee:ff</param>
		///<param name="broadcastAddress">Broadcast IP where to send the magic packet. eg: 192.168.255.255</param>
		///<param name="broadcastPort">Port where to send the magic packet.</param>
		public void SendMagicPacket(string @mac, string? @broadcastAddress = null, long? @broadcastPort = null)
		{
			_haContext.CallService("wake_on_lan", "send_magic_packet", null, new WakeOnLanSendMagicPacketParameters{Mac = @mac, BroadcastAddress = @broadcastAddress, BroadcastPort = @broadcastPort});
		}
	}

	public record WakeOnLanSendMagicPacketParameters
	{
		///<summary>MAC address of the device to wake up. eg: aa:bb:cc:dd:ee:ff</summary>
		[JsonPropertyName("mac")]
		public string? Mac { get; init; }

		///<summary>Broadcast IP where to send the magic packet. eg: 192.168.255.255</summary>
		[JsonPropertyName("broadcast_address")]
		public string? BroadcastAddress { get; init; }

		///<summary>Port where to send the magic packet.</summary>
		[JsonPropertyName("broadcast_port")]
		public long? BroadcastPort { get; init; }
	}

	public class YeelightServices
	{
		private readonly IHaContext _haContext;
		public YeelightServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Turns the light on to the specified brightness and sets a timer to turn it back off after the given number of minutes. If the light is off, Set a color scene, if light is off, it will be turned on.</summary>
		///<param name="target">The target for this service call</param>
		public void SetAutoDelayOffScene(ServiceTarget target, YeelightSetAutoDelayOffSceneParameters data)
		{
			_haContext.CallService("yeelight", "set_auto_delay_off_scene", target, data);
		}

		///<summary>Turns the light on to the specified brightness and sets a timer to turn it back off after the given number of minutes. If the light is off, Set a color scene, if light is off, it will be turned on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="minutes">The time to wait before automatically turning the light off.</param>
		///<param name="brightness">The brightness value to set.</param>
		public void SetAutoDelayOffScene(ServiceTarget target, long? @minutes = null, long? @brightness = null)
		{
			_haContext.CallService("yeelight", "set_auto_delay_off_scene", target, new YeelightSetAutoDelayOffSceneParameters{Minutes = @minutes, Brightness = @brightness});
		}

		///<summary>starts a color flow. If the light is off, it will be turned on.</summary>
		///<param name="target">The target for this service call</param>
		public void SetColorFlowScene(ServiceTarget target, YeelightSetColorFlowSceneParameters data)
		{
			_haContext.CallService("yeelight", "set_color_flow_scene", target, data);
		}

		///<summary>starts a color flow. If the light is off, it will be turned on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="count">The number of times to run this flow (0 to run forever).</param>
		///<param name="action">The action to take after the flow stops.</param>
		///<param name="transitions">Array of transitions, for desired effect. Examples https://yeelight.readthedocs.io/en/stable/flow.html eg: [{ "TemperatureTransition": [1900, 1000, 80] }, { "TemperatureTransition": [1900, 1000, 10] }]</param>
		public void SetColorFlowScene(ServiceTarget target, long? @count = null, object? @action = null, object? @transitions = null)
		{
			_haContext.CallService("yeelight", "set_color_flow_scene", target, new YeelightSetColorFlowSceneParameters{Count = @count, Action = @action, Transitions = @transitions});
		}

		///<summary>Changes the light to the specified RGB color and brightness. If the light is off, it will be turned on.</summary>
		///<param name="target">The target for this service call</param>
		public void SetColorScene(ServiceTarget target, YeelightSetColorSceneParameters data)
		{
			_haContext.CallService("yeelight", "set_color_scene", target, data);
		}

		///<summary>Changes the light to the specified RGB color and brightness. If the light is off, it will be turned on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="brightness">The brightness value to set.</param>
		public void SetColorScene(ServiceTarget target, object? @rgbColor = null, long? @brightness = null)
		{
			_haContext.CallService("yeelight", "set_color_scene", target, new YeelightSetColorSceneParameters{RgbColor = @rgbColor, Brightness = @brightness});
		}

		///<summary>Changes the light to the specified color temperature. If the light is off, it will be turned on.</summary>
		///<param name="target">The target for this service call</param>
		public void SetColorTempScene(ServiceTarget target, YeelightSetColorTempSceneParameters data)
		{
			_haContext.CallService("yeelight", "set_color_temp_scene", target, data);
		}

		///<summary>Changes the light to the specified color temperature. If the light is off, it will be turned on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">The brightness value to set.</param>
		public void SetColorTempScene(ServiceTarget target, long? @kelvin = null, long? @brightness = null)
		{
			_haContext.CallService("yeelight", "set_color_temp_scene", target, new YeelightSetColorTempSceneParameters{Kelvin = @kelvin, Brightness = @brightness});
		}

		///<summary>Changes the light to the specified HSV color and brightness. If the light is off, it will be turned on.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHsvScene(ServiceTarget target, YeelightSetHsvSceneParameters data)
		{
			_haContext.CallService("yeelight", "set_hsv_scene", target, data);
		}

		///<summary>Changes the light to the specified HSV color and brightness. If the light is off, it will be turned on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-359 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="brightness">The brightness value to set.</param>
		public void SetHsvScene(ServiceTarget target, object? @hsColor = null, long? @brightness = null)
		{
			_haContext.CallService("yeelight", "set_hsv_scene", target, new YeelightSetHsvSceneParameters{HsColor = @hsColor, Brightness = @brightness});
		}

		///<summary>Set a operation mode.</summary>
		///<param name="target">The target for this service call</param>
		public void SetMode(ServiceTarget target, YeelightSetModeParameters data)
		{
			_haContext.CallService("yeelight", "set_mode", target, data);
		}

		///<summary>Set a operation mode.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mode">Operation mode.</param>
		public void SetMode(ServiceTarget target, object @mode)
		{
			_haContext.CallService("yeelight", "set_mode", target, new YeelightSetModeParameters{Mode = @mode});
		}

		///<summary>Enable or disable music_mode</summary>
		///<param name="target">The target for this service call</param>
		public void SetMusicMode(ServiceTarget target, YeelightSetMusicModeParameters data)
		{
			_haContext.CallService("yeelight", "set_music_mode", target, data);
		}

		///<summary>Enable or disable music_mode</summary>
		///<param name="target">The target for this service call</param>
		///<param name="musicMode">Use true or false to enable / disable music_mode</param>
		public void SetMusicMode(ServiceTarget target, bool @musicMode)
		{
			_haContext.CallService("yeelight", "set_music_mode", target, new YeelightSetMusicModeParameters{MusicMode = @musicMode});
		}

		///<summary>Start a custom flow, using transitions from https://yeelight.readthedocs.io/en/stable/yeelight.html#flow-objects</summary>
		///<param name="target">The target for this service call</param>
		public void StartFlow(ServiceTarget target, YeelightStartFlowParameters data)
		{
			_haContext.CallService("yeelight", "start_flow", target, data);
		}

		///<summary>Start a custom flow, using transitions from https://yeelight.readthedocs.io/en/stable/yeelight.html#flow-objects</summary>
		///<param name="target">The target for this service call</param>
		///<param name="count">The number of times to run this flow (0 to run forever).</param>
		///<param name="action">The action to take after the flow stops.</param>
		///<param name="transitions">Array of transitions, for desired effect. Examples https://yeelight.readthedocs.io/en/stable/flow.html eg: [{ "TemperatureTransition": [1900, 1000, 80] }, { "TemperatureTransition": [1900, 1000, 10] }]</param>
		public void StartFlow(ServiceTarget target, long? @count = null, object? @action = null, object? @transitions = null)
		{
			_haContext.CallService("yeelight", "start_flow", target, new YeelightStartFlowParameters{Count = @count, Action = @action, Transitions = @transitions});
		}
	}

	public record YeelightSetAutoDelayOffSceneParameters
	{
		///<summary>The time to wait before automatically turning the light off.</summary>
		[JsonPropertyName("minutes")]
		public long? Minutes { get; init; }

		///<summary>The brightness value to set.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }
	}

	public record YeelightSetColorFlowSceneParameters
	{
		///<summary>The number of times to run this flow (0 to run forever).</summary>
		[JsonPropertyName("count")]
		public long? Count { get; init; }

		///<summary>The action to take after the flow stops.</summary>
		[JsonPropertyName("action")]
		public object? Action { get; init; }

		///<summary>Array of transitions, for desired effect. Examples https://yeelight.readthedocs.io/en/stable/flow.html eg: [{ "TemperatureTransition": [1900, 1000, 80] }, { "TemperatureTransition": [1900, 1000, 10] }]</summary>
		[JsonPropertyName("transitions")]
		public object? Transitions { get; init; }
	}

	public record YeelightSetColorSceneParameters
	{
		///<summary>Color for the light in RGB-format. eg: [255, 100, 100]</summary>
		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>The brightness value to set.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }
	}

	public record YeelightSetColorTempSceneParameters
	{
		///<summary>Color temperature for the light in Kelvin.</summary>
		[JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>The brightness value to set.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }
	}

	public record YeelightSetHsvSceneParameters
	{
		///<summary>Color for the light in hue/sat format. Hue is 0-359 and Sat is 0-100. eg: [300, 70]</summary>
		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>The brightness value to set.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }
	}

	public record YeelightSetModeParameters
	{
		///<summary>Operation mode.</summary>
		[JsonPropertyName("mode")]
		public object? Mode { get; init; }
	}

	public record YeelightSetMusicModeParameters
	{
		///<summary>Use true or false to enable / disable music_mode</summary>
		[JsonPropertyName("music_mode")]
		public bool? MusicMode { get; init; }
	}

	public record YeelightStartFlowParameters
	{
		///<summary>The number of times to run this flow (0 to run forever).</summary>
		[JsonPropertyName("count")]
		public long? Count { get; init; }

		///<summary>The action to take after the flow stops.</summary>
		[JsonPropertyName("action")]
		public object? Action { get; init; }

		///<summary>Array of transitions, for desired effect. Examples https://yeelight.readthedocs.io/en/stable/flow.html eg: [{ "TemperatureTransition": [1900, 1000, 80] }, { "TemperatureTransition": [1900, 1000, 10] }]</summary>
		[JsonPropertyName("transitions")]
		public object? Transitions { get; init; }
	}

	public class ZhaServices
	{
		private readonly IHaContext _haContext;
		public ZhaServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Clear a user code from a lock</summary>
		///<param name="target">The target for this service call</param>
		public void ClearLockUserCode(ServiceTarget target, ZhaClearLockUserCodeParameters data)
		{
			_haContext.CallService("zha", "clear_lock_user_code", target, data);
		}

		///<summary>Clear a user code from a lock</summary>
		///<param name="target">The target for this service call</param>
		///<param name="codeSlot">Code slot to clear code from eg: 1</param>
		public void ClearLockUserCode(ServiceTarget target, string @codeSlot)
		{
			_haContext.CallService("zha", "clear_lock_user_code", target, new ZhaClearLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Disable a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		public void DisableLockUserCode(ServiceTarget target, ZhaDisableLockUserCodeParameters data)
		{
			_haContext.CallService("zha", "disable_lock_user_code", target, data);
		}

		///<summary>Disable a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		///<param name="codeSlot">Code slot to disable eg: 1</param>
		public void DisableLockUserCode(ServiceTarget target, string @codeSlot)
		{
			_haContext.CallService("zha", "disable_lock_user_code", target, new ZhaDisableLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Enable a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		public void EnableLockUserCode(ServiceTarget target, ZhaEnableLockUserCodeParameters data)
		{
			_haContext.CallService("zha", "enable_lock_user_code", target, data);
		}

		///<summary>Enable a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		///<param name="codeSlot">Code slot to enable eg: 1</param>
		public void EnableLockUserCode(ServiceTarget target, string @codeSlot)
		{
			_haContext.CallService("zha", "enable_lock_user_code", target, new ZhaEnableLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Issue command on the specified cluster on the specified entity.</summary>
		public void IssueZigbeeClusterCommand(ZhaIssueZigbeeClusterCommandParameters data)
		{
			_haContext.CallService("zha", "issue_zigbee_cluster_command", null, data);
		}

		///<summary>Issue command on the specified cluster on the specified entity.</summary>
		///<param name="ieee">IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</param>
		///<param name="endpointId">Endpoint id for the cluster</param>
		///<param name="clusterId">ZCL cluster to retrieve attributes for</param>
		///<param name="clusterType">type of the cluster</param>
		///<param name="command">id of the command to execute</param>
		///<param name="commandType">type of the command to execute</param>
		///<param name="args">args to pass to the command eg: [arg1, arg2, argN]</param>
		///<param name="manufacturer">manufacturer code eg: 252</param>
		public void IssueZigbeeClusterCommand(string @ieee, long @endpointId, long @clusterId, long @command, object @commandType, object? @clusterType = null, object? @args = null, string? @manufacturer = null)
		{
			_haContext.CallService("zha", "issue_zigbee_cluster_command", null, new ZhaIssueZigbeeClusterCommandParameters{Ieee = @ieee, EndpointId = @endpointId, ClusterId = @clusterId, ClusterType = @clusterType, Command = @command, CommandType = @commandType, Args = @args, Manufacturer = @manufacturer});
		}

		///<summary>Issue command on the specified cluster on the specified group.</summary>
		public void IssueZigbeeGroupCommand(ZhaIssueZigbeeGroupCommandParameters data)
		{
			_haContext.CallService("zha", "issue_zigbee_group_command", null, data);
		}

		///<summary>Issue command on the specified cluster on the specified group.</summary>
		///<param name="group">Hexadecimal address of the group eg: 546</param>
		///<param name="clusterId">ZCL cluster to send command to</param>
		///<param name="clusterType">type of the cluster</param>
		///<param name="command">id of the command to execute</param>
		///<param name="args">args to pass to the command eg: [arg1, arg2, argN]</param>
		///<param name="manufacturer">manufacturer code eg: 252</param>
		public void IssueZigbeeGroupCommand(string @group, long @clusterId, long @command, object? @clusterType = null, object? @args = null, string? @manufacturer = null)
		{
			_haContext.CallService("zha", "issue_zigbee_group_command", null, new ZhaIssueZigbeeGroupCommandParameters{Group = @group, ClusterId = @clusterId, ClusterType = @clusterType, Command = @command, Args = @args, Manufacturer = @manufacturer});
		}

		///<summary>Allow nodes to join the Zigbee network.</summary>
		public void Permit(ZhaPermitParameters data)
		{
			_haContext.CallService("zha", "permit", null, data);
		}

		///<summary>Allow nodes to join the Zigbee network.</summary>
		///<param name="duration">Time to permit joins, in seconds</param>
		///<param name="ieee">IEEE address of the node permitting new joins eg: 00:0d:6f:00:05:7d:2d:34</param>
		///<param name="sourceIeee">IEEE address of the joining device (must be used with install code) eg: 00:0a:bf:00:01:10:23:35</param>
		///<param name="installCode">Install code of the joining device (must be used with source_ieee) eg: 1234-5678-1234-5678-AABB-CCDD-AABB-CCDD-EEFF</param>
		///<param name="qrCode">value of the QR install code (different between vendors) eg: Z:000D6FFFFED4163B$I:52797BF4A5084DAA8E1712B61741CA024051</param>
		public void Permit(long? @duration = null, string? @ieee = null, string? @sourceIeee = null, string? @installCode = null, string? @qrCode = null)
		{
			_haContext.CallService("zha", "permit", null, new ZhaPermitParameters{Duration = @duration, Ieee = @ieee, SourceIeee = @sourceIeee, InstallCode = @installCode, QrCode = @qrCode});
		}

		///<summary>Remove a node from the Zigbee network.</summary>
		public void Remove(ZhaRemoveParameters data)
		{
			_haContext.CallService("zha", "remove", null, data);
		}

		///<summary>Remove a node from the Zigbee network.</summary>
		///<param name="ieee">IEEE address of the node to remove eg: 00:0d:6f:00:05:7d:2d:34</param>
		public void Remove(string @ieee)
		{
			_haContext.CallService("zha", "remove", null, new ZhaRemoveParameters{Ieee = @ieee});
		}

		///<summary>Set a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		public void SetLockUserCode(ServiceTarget target, ZhaSetLockUserCodeParameters data)
		{
			_haContext.CallService("zha", "set_lock_user_code", target, data);
		}

		///<summary>Set a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		///<param name="codeSlot">Code slot to set the code in eg: 1</param>
		///<param name="userCode">Code to set eg: 1234</param>
		public void SetLockUserCode(ServiceTarget target, string @codeSlot, string @userCode)
		{
			_haContext.CallService("zha", "set_lock_user_code", target, new ZhaSetLockUserCodeParameters{CodeSlot = @codeSlot, UserCode = @userCode});
		}

		///<summary>Set attribute value for the specified cluster on the specified entity.</summary>
		public void SetZigbeeClusterAttribute(ZhaSetZigbeeClusterAttributeParameters data)
		{
			_haContext.CallService("zha", "set_zigbee_cluster_attribute", null, data);
		}

		///<summary>Set attribute value for the specified cluster on the specified entity.</summary>
		///<param name="ieee">IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</param>
		///<param name="endpointId">Endpoint id for the cluster</param>
		///<param name="clusterId">ZCL cluster to retrieve attributes for</param>
		///<param name="clusterType">type of the cluster</param>
		///<param name="attribute">id of the attribute to set eg: 0</param>
		///<param name="value">value to write to the attribute eg: 1</param>
		///<param name="manufacturer">manufacturer code eg: 252</param>
		public void SetZigbeeClusterAttribute(string @ieee, long @endpointId, long @clusterId, long @attribute, string @value, object? @clusterType = null, string? @manufacturer = null)
		{
			_haContext.CallService("zha", "set_zigbee_cluster_attribute", null, new ZhaSetZigbeeClusterAttributeParameters{Ieee = @ieee, EndpointId = @endpointId, ClusterId = @clusterId, ClusterType = @clusterType, Attribute = @attribute, Value = @value, Manufacturer = @manufacturer});
		}

		///<summary>This service uses the WD capabilities to emit a quick audible/visible pulse called a "squawk". The squawk command has no effect if the WD is currently active (warning in progress).</summary>
		public void WarningDeviceSquawk(ZhaWarningDeviceSquawkParameters data)
		{
			_haContext.CallService("zha", "warning_device_squawk", null, data);
		}

		///<summary>This service uses the WD capabilities to emit a quick audible/visible pulse called a "squawk". The squawk command has no effect if the WD is currently active (warning in progress).</summary>
		///<param name="ieee">IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</param>
		///<param name="mode">The Squawk Mode field is used as a 4-bit enumeration, and can have one of the values shown in Table 8-24 of the ZCL spec - Squawk Mode Field. The exact operation of each mode (how the WD “squawks”) is implementation specific.</param>
		///<param name="strobe">The strobe field is used as a Boolean, and determines if the visual indication is also required in addition to the audible squawk, as shown in Table 8-25 of the ZCL spec - Strobe Bit.</param>
		///<param name="level">The squawk level field is used as a 2-bit enumeration, and determines the intensity of audible squawk sound as shown in Table 8-26 of the ZCL spec - Squawk Level Field Values.</param>
		public void WarningDeviceSquawk(string @ieee, long? @mode = null, long? @strobe = null, long? @level = null)
		{
			_haContext.CallService("zha", "warning_device_squawk", null, new ZhaWarningDeviceSquawkParameters{Ieee = @ieee, Mode = @mode, Strobe = @strobe, Level = @level});
		}

		///<summary>This service starts the WD operation. The WD alerts the surrounding area by audible (siren) and visual (strobe) signals.</summary>
		public void WarningDeviceWarn(ZhaWarningDeviceWarnParameters data)
		{
			_haContext.CallService("zha", "warning_device_warn", null, data);
		}

		///<summary>This service starts the WD operation. The WD alerts the surrounding area by audible (siren) and visual (strobe) signals.</summary>
		///<param name="ieee">IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</param>
		///<param name="mode">The Warning Mode field is used as an 4-bit enumeration, can have one of the values 0-6 defined below in table 8-20 of the ZCL spec. The exact behavior of the WD device in each mode is according to the relevant security standards.</param>
		///<param name="strobe">The Strobe field is used as a 2-bit enumeration, and determines if the visual indication is required in addition to the audible siren, as indicated in Table 8-21 of the ZCL spec. "0" means no strobe, "1" means strobe. If the strobe field is “1” and the Warning Mode is “0” (“Stop”) then only the strobe is activated.</param>
		///<param name="level">The Siren Level field is used as a 2-bit enumeration, and indicates the intensity of audible squawk sound as shown in Table 8-22 of the ZCL spec.</param>
		///<param name="duration">Requested duration of warning, in seconds (16 bit). If both Strobe and Warning Mode are "0" this field SHALL be ignored.</param>
		///<param name="dutyCycle">Indicates the length of the flash cycle. This provides a means of varying the flash duration for different alarm types (e.g., fire, police, burglar). Valid range is 0-100 in increments of 10. All other values SHALL be rounded to the nearest valid value. Strobe SHALL calculate duty cycle over a duration of one second. The ON state SHALL precede the OFF state. For example, if Strobe Duty Cycle Field specifies “40,” then the strobe SHALL flash ON for 4/10ths of a second and then turn OFF for 6/10ths of a second.</param>
		///<param name="intensity">Indicates the intensity of the strobe as shown in Table 8-23 of the ZCL spec. This attribute is designed to vary the output of the strobe (i.e., brightness) and not its frequency, which is detailed in section 8.4.2.3.1.6 of the ZCL spec.</param>
		public void WarningDeviceWarn(string @ieee, long? @mode = null, long? @strobe = null, long? @level = null, long? @duration = null, long? @dutyCycle = null, long? @intensity = null)
		{
			_haContext.CallService("zha", "warning_device_warn", null, new ZhaWarningDeviceWarnParameters{Ieee = @ieee, Mode = @mode, Strobe = @strobe, Level = @level, Duration = @duration, DutyCycle = @dutyCycle, Intensity = @intensity});
		}
	}

	public record ZhaClearLockUserCodeParameters
	{
		///<summary>Code slot to clear code from eg: 1</summary>
		[JsonPropertyName("code_slot")]
		public string? CodeSlot { get; init; }
	}

	public record ZhaDisableLockUserCodeParameters
	{
		///<summary>Code slot to disable eg: 1</summary>
		[JsonPropertyName("code_slot")]
		public string? CodeSlot { get; init; }
	}

	public record ZhaEnableLockUserCodeParameters
	{
		///<summary>Code slot to enable eg: 1</summary>
		[JsonPropertyName("code_slot")]
		public string? CodeSlot { get; init; }
	}

	public record ZhaIssueZigbeeClusterCommandParameters
	{
		///<summary>IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }

		///<summary>Endpoint id for the cluster</summary>
		[JsonPropertyName("endpoint_id")]
		public long? EndpointId { get; init; }

		///<summary>ZCL cluster to retrieve attributes for</summary>
		[JsonPropertyName("cluster_id")]
		public long? ClusterId { get; init; }

		///<summary>type of the cluster</summary>
		[JsonPropertyName("cluster_type")]
		public object? ClusterType { get; init; }

		///<summary>id of the command to execute</summary>
		[JsonPropertyName("command")]
		public long? Command { get; init; }

		///<summary>type of the command to execute</summary>
		[JsonPropertyName("command_type")]
		public object? CommandType { get; init; }

		///<summary>args to pass to the command eg: [arg1, arg2, argN]</summary>
		[JsonPropertyName("args")]
		public object? Args { get; init; }

		///<summary>manufacturer code eg: 252</summary>
		[JsonPropertyName("manufacturer")]
		public string? Manufacturer { get; init; }
	}

	public record ZhaIssueZigbeeGroupCommandParameters
	{
		///<summary>Hexadecimal address of the group eg: 546</summary>
		[JsonPropertyName("group")]
		public string? Group { get; init; }

		///<summary>ZCL cluster to send command to</summary>
		[JsonPropertyName("cluster_id")]
		public long? ClusterId { get; init; }

		///<summary>type of the cluster</summary>
		[JsonPropertyName("cluster_type")]
		public object? ClusterType { get; init; }

		///<summary>id of the command to execute</summary>
		[JsonPropertyName("command")]
		public long? Command { get; init; }

		///<summary>args to pass to the command eg: [arg1, arg2, argN]</summary>
		[JsonPropertyName("args")]
		public object? Args { get; init; }

		///<summary>manufacturer code eg: 252</summary>
		[JsonPropertyName("manufacturer")]
		public string? Manufacturer { get; init; }
	}

	public record ZhaPermitParameters
	{
		///<summary>Time to permit joins, in seconds</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }

		///<summary>IEEE address of the node permitting new joins eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }

		///<summary>IEEE address of the joining device (must be used with install code) eg: 00:0a:bf:00:01:10:23:35</summary>
		[JsonPropertyName("source_ieee")]
		public string? SourceIeee { get; init; }

		///<summary>Install code of the joining device (must be used with source_ieee) eg: 1234-5678-1234-5678-AABB-CCDD-AABB-CCDD-EEFF</summary>
		[JsonPropertyName("install_code")]
		public string? InstallCode { get; init; }

		///<summary>value of the QR install code (different between vendors) eg: Z:000D6FFFFED4163B$I:52797BF4A5084DAA8E1712B61741CA024051</summary>
		[JsonPropertyName("qr_code")]
		public string? QrCode { get; init; }
	}

	public record ZhaRemoveParameters
	{
		///<summary>IEEE address of the node to remove eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }
	}

	public record ZhaSetLockUserCodeParameters
	{
		///<summary>Code slot to set the code in eg: 1</summary>
		[JsonPropertyName("code_slot")]
		public string? CodeSlot { get; init; }

		///<summary>Code to set eg: 1234</summary>
		[JsonPropertyName("user_code")]
		public string? UserCode { get; init; }
	}

	public record ZhaSetZigbeeClusterAttributeParameters
	{
		///<summary>IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }

		///<summary>Endpoint id for the cluster</summary>
		[JsonPropertyName("endpoint_id")]
		public long? EndpointId { get; init; }

		///<summary>ZCL cluster to retrieve attributes for</summary>
		[JsonPropertyName("cluster_id")]
		public long? ClusterId { get; init; }

		///<summary>type of the cluster</summary>
		[JsonPropertyName("cluster_type")]
		public object? ClusterType { get; init; }

		///<summary>id of the attribute to set eg: 0</summary>
		[JsonPropertyName("attribute")]
		public long? Attribute { get; init; }

		///<summary>value to write to the attribute eg: 1</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }

		///<summary>manufacturer code eg: 252</summary>
		[JsonPropertyName("manufacturer")]
		public string? Manufacturer { get; init; }
	}

	public record ZhaWarningDeviceSquawkParameters
	{
		///<summary>IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }

		///<summary>The Squawk Mode field is used as a 4-bit enumeration, and can have one of the values shown in Table 8-24 of the ZCL spec - Squawk Mode Field. The exact operation of each mode (how the WD “squawks”) is implementation specific.</summary>
		[JsonPropertyName("mode")]
		public long? Mode { get; init; }

		///<summary>The strobe field is used as a Boolean, and determines if the visual indication is also required in addition to the audible squawk, as shown in Table 8-25 of the ZCL spec - Strobe Bit.</summary>
		[JsonPropertyName("strobe")]
		public long? Strobe { get; init; }

		///<summary>The squawk level field is used as a 2-bit enumeration, and determines the intensity of audible squawk sound as shown in Table 8-26 of the ZCL spec - Squawk Level Field Values.</summary>
		[JsonPropertyName("level")]
		public long? Level { get; init; }
	}

	public record ZhaWarningDeviceWarnParameters
	{
		///<summary>IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }

		///<summary>The Warning Mode field is used as an 4-bit enumeration, can have one of the values 0-6 defined below in table 8-20 of the ZCL spec. The exact behavior of the WD device in each mode is according to the relevant security standards.</summary>
		[JsonPropertyName("mode")]
		public long? Mode { get; init; }

		///<summary>The Strobe field is used as a 2-bit enumeration, and determines if the visual indication is required in addition to the audible siren, as indicated in Table 8-21 of the ZCL spec. "0" means no strobe, "1" means strobe. If the strobe field is “1” and the Warning Mode is “0” (“Stop”) then only the strobe is activated.</summary>
		[JsonPropertyName("strobe")]
		public long? Strobe { get; init; }

		///<summary>The Siren Level field is used as a 2-bit enumeration, and indicates the intensity of audible squawk sound as shown in Table 8-22 of the ZCL spec.</summary>
		[JsonPropertyName("level")]
		public long? Level { get; init; }

		///<summary>Requested duration of warning, in seconds (16 bit). If both Strobe and Warning Mode are "0" this field SHALL be ignored.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }

		///<summary>Indicates the length of the flash cycle. This provides a means of varying the flash duration for different alarm types (e.g., fire, police, burglar). Valid range is 0-100 in increments of 10. All other values SHALL be rounded to the nearest valid value. Strobe SHALL calculate duty cycle over a duration of one second. The ON state SHALL precede the OFF state. For example, if Strobe Duty Cycle Field specifies “40,” then the strobe SHALL flash ON for 4/10ths of a second and then turn OFF for 6/10ths of a second.</summary>
		[JsonPropertyName("duty_cycle")]
		public long? DutyCycle { get; init; }

		///<summary>Indicates the intensity of the strobe as shown in Table 8-23 of the ZCL spec. This attribute is designed to vary the output of the strobe (i.e., brightness) and not its frequency, which is detailed in section 8.4.2.3.1.6 of the ZCL spec.</summary>
		[JsonPropertyName("intensity")]
		public long? Intensity { get; init; }
	}

	public class ZoneServices
	{
		private readonly IHaContext _haContext;
		public ZoneServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the YAML-based zone configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("zone", "reload", null);
		}
	}

	public static class AlarmControlPanelEntityExtensionMethods
	{
		///<summary>Send the alarm the command for arm away.</summary>
		public static void AlarmArmAway(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmAwayParameters data)
		{
			target.CallService("alarm_arm_away", data);
		}

		///<summary>Send the alarm the command for arm away.</summary>
		public static void AlarmArmAway(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmAwayParameters data)
		{
			target.CallService("alarm_arm_away", data);
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
		public static void AlarmArmAway(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_away", new AlarmControlPanelAlarmArmAwayParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
		public static void AlarmArmAway(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_away", new AlarmControlPanelAlarmArmAwayParameters{Code = @code});
		}

		///<summary>Send arm custom bypass command.</summary>
		public static void AlarmArmCustomBypass(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			target.CallService("alarm_arm_custom_bypass", data);
		}

		///<summary>Send arm custom bypass command.</summary>
		public static void AlarmArmCustomBypass(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			target.CallService("alarm_arm_custom_bypass", data);
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
		public static void AlarmArmCustomBypass(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_custom_bypass", new AlarmControlPanelAlarmArmCustomBypassParameters{Code = @code});
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
		public static void AlarmArmCustomBypass(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_custom_bypass", new AlarmControlPanelAlarmArmCustomBypassParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm home.</summary>
		public static void AlarmArmHome(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmHomeParameters data)
		{
			target.CallService("alarm_arm_home", data);
		}

		///<summary>Send the alarm the command for arm home.</summary>
		public static void AlarmArmHome(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmHomeParameters data)
		{
			target.CallService("alarm_arm_home", data);
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
		public static void AlarmArmHome(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_home", new AlarmControlPanelAlarmArmHomeParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
		public static void AlarmArmHome(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_home", new AlarmControlPanelAlarmArmHomeParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm night.</summary>
		public static void AlarmArmNight(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmNightParameters data)
		{
			target.CallService("alarm_arm_night", data);
		}

		///<summary>Send the alarm the command for arm night.</summary>
		public static void AlarmArmNight(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmNightParameters data)
		{
			target.CallService("alarm_arm_night", data);
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
		public static void AlarmArmNight(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_night", new AlarmControlPanelAlarmArmNightParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
		public static void AlarmArmNight(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_night", new AlarmControlPanelAlarmArmNightParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		public static void AlarmArmVacation(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmVacationParameters data)
		{
			target.CallService("alarm_arm_vacation", data);
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		public static void AlarmArmVacation(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmVacationParameters data)
		{
			target.CallService("alarm_arm_vacation", data);
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm vacation the alarm control panel with. eg: 1234</param>
		public static void AlarmArmVacation(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_vacation", new AlarmControlPanelAlarmArmVacationParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm vacation the alarm control panel with. eg: 1234</param>
		public static void AlarmArmVacation(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_vacation", new AlarmControlPanelAlarmArmVacationParameters{Code = @code});
		}

		///<summary>Send the alarm the command for disarm.</summary>
		public static void AlarmDisarm(this AlarmControlPanelEntity target, AlarmControlPanelAlarmDisarmParameters data)
		{
			target.CallService("alarm_disarm", data);
		}

		///<summary>Send the alarm the command for disarm.</summary>
		public static void AlarmDisarm(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmDisarmParameters data)
		{
			target.CallService("alarm_disarm", data);
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
		public static void AlarmDisarm(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_disarm", new AlarmControlPanelAlarmDisarmParameters{Code = @code});
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
		public static void AlarmDisarm(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_disarm", new AlarmControlPanelAlarmDisarmParameters{Code = @code});
		}

		///<summary>Send the alarm the command for trigger.</summary>
		public static void AlarmTrigger(this AlarmControlPanelEntity target, AlarmControlPanelAlarmTriggerParameters data)
		{
			target.CallService("alarm_trigger", data);
		}

		///<summary>Send the alarm the command for trigger.</summary>
		public static void AlarmTrigger(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmTriggerParameters data)
		{
			target.CallService("alarm_trigger", data);
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
		public static void AlarmTrigger(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_trigger", new AlarmControlPanelAlarmTriggerParameters{Code = @code});
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
		public static void AlarmTrigger(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_trigger", new AlarmControlPanelAlarmTriggerParameters{Code = @code});
		}
	}

	public static class AutomationEntityExtensionMethods
	{
		///<summary>Toggle (enable / disable) an automation.</summary>
		public static void Toggle(this AutomationEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle (enable / disable) an automation.</summary>
		public static void Toggle(this IEnumerable<AutomationEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Trigger the actions of an automation.</summary>
		public static void Trigger(this AutomationEntity target, AutomationTriggerParameters data)
		{
			target.CallService("trigger", data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		public static void Trigger(this IEnumerable<AutomationEntity> target, AutomationTriggerParameters data)
		{
			target.CallService("trigger", data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The AutomationEntity to call this service for</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public static void Trigger(this AutomationEntity target, bool? @skipCondition = null)
		{
			target.CallService("trigger", new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The IEnumerable<AutomationEntity> to call this service for</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public static void Trigger(this IEnumerable<AutomationEntity> target, bool? @skipCondition = null)
		{
			target.CallService("trigger", new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Disable an automation.</summary>
		public static void TurnOff(this AutomationEntity target, AutomationTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Disable an automation.</summary>
		public static void TurnOff(this IEnumerable<AutomationEntity> target, AutomationTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The AutomationEntity to call this service for</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public static void TurnOff(this AutomationEntity target, bool? @stopActions = null)
		{
			target.CallService("turn_off", new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The IEnumerable<AutomationEntity> to call this service for</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public static void TurnOff(this IEnumerable<AutomationEntity> target, bool? @stopActions = null)
		{
			target.CallService("turn_off", new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Enable an automation.</summary>
		public static void TurnOn(this AutomationEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Enable an automation.</summary>
		public static void TurnOn(this IEnumerable<AutomationEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class ButtonEntityExtensionMethods
	{
		///<summary>Press the button entity.</summary>
		public static void Press(this ButtonEntity target)
		{
			target.CallService("press");
		}

		///<summary>Press the button entity.</summary>
		public static void Press(this IEnumerable<ButtonEntity> target)
		{
			target.CallService("press");
		}
	}

	public static class CameraEntityExtensionMethods
	{
		///<summary>Disable the motion detection in a camera.</summary>
		public static void DisableMotionDetection(this CameraEntity target)
		{
			target.CallService("disable_motion_detection");
		}

		///<summary>Disable the motion detection in a camera.</summary>
		public static void DisableMotionDetection(this IEnumerable<CameraEntity> target)
		{
			target.CallService("disable_motion_detection");
		}

		///<summary>Enable the motion detection in a camera.</summary>
		public static void EnableMotionDetection(this CameraEntity target)
		{
			target.CallService("enable_motion_detection");
		}

		///<summary>Enable the motion detection in a camera.</summary>
		public static void EnableMotionDetection(this IEnumerable<CameraEntity> target)
		{
			target.CallService("enable_motion_detection");
		}

		///<summary>Play camera stream on supported media player.</summary>
		public static void PlayStream(this CameraEntity target, CameraPlayStreamParameters data)
		{
			target.CallService("play_stream", data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		public static void PlayStream(this IEnumerable<CameraEntity> target, CameraPlayStreamParameters data)
		{
			target.CallService("play_stream", data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public static void PlayStream(this CameraEntity target, string @mediaPlayer, object? @format = null)
		{
			target.CallService("play_stream", new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public static void PlayStream(this IEnumerable<CameraEntity> target, string @mediaPlayer, object? @format = null)
		{
			target.CallService("play_stream", new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Record live camera feed.</summary>
		public static void Record(this CameraEntity target, CameraRecordParameters data)
		{
			target.CallService("record", data);
		}

		///<summary>Record live camera feed.</summary>
		public static void Record(this IEnumerable<CameraEntity> target, CameraRecordParameters data)
		{
			target.CallService("record", data);
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public static void Record(this CameraEntity target, string @filename, long? @duration = null, long? @lookback = null)
		{
			target.CallService("record", new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public static void Record(this IEnumerable<CameraEntity> target, string @filename, long? @duration = null, long? @lookback = null)
		{
			target.CallService("record", new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Take a snapshot from a camera.</summary>
		public static void Snapshot(this CameraEntity target, CameraSnapshotParameters data)
		{
			target.CallService("snapshot", data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		public static void Snapshot(this IEnumerable<CameraEntity> target, CameraSnapshotParameters data)
		{
			target.CallService("snapshot", data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public static void Snapshot(this CameraEntity target, string @filename)
		{
			target.CallService("snapshot", new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public static void Snapshot(this IEnumerable<CameraEntity> target, string @filename)
		{
			target.CallService("snapshot", new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Turn off camera.</summary>
		public static void TurnOff(this CameraEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off camera.</summary>
		public static void TurnOff(this IEnumerable<CameraEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on camera.</summary>
		public static void TurnOn(this CameraEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on camera.</summary>
		public static void TurnOn(this IEnumerable<CameraEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class ClimateEntityExtensionMethods
	{
		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		public static void SetAuxHeat(this ClimateEntity target, ClimateSetAuxHeatParameters data)
		{
			target.CallService("set_aux_heat", data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		public static void SetAuxHeat(this IEnumerable<ClimateEntity> target, ClimateSetAuxHeatParameters data)
		{
			target.CallService("set_aux_heat", data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public static void SetAuxHeat(this ClimateEntity target, bool @auxHeat)
		{
			target.CallService("set_aux_heat", new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public static void SetAuxHeat(this IEnumerable<ClimateEntity> target, bool @auxHeat)
		{
			target.CallService("set_aux_heat", new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Set fan operation for climate device.</summary>
		public static void SetFanMode(this ClimateEntity target, ClimateSetFanModeParameters data)
		{
			target.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for climate device.</summary>
		public static void SetFanMode(this IEnumerable<ClimateEntity> target, ClimateSetFanModeParameters data)
		{
			target.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this ClimateEntity target, string @fanMode)
		{
			target.CallService("set_fan_mode", new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this IEnumerable<ClimateEntity> target, string @fanMode)
		{
			target.CallService("set_fan_mode", new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set target humidity of climate device.</summary>
		public static void SetHumidity(this ClimateEntity target, ClimateSetHumidityParameters data)
		{
			target.CallService("set_humidity", data);
		}

		///<summary>Set target humidity of climate device.</summary>
		public static void SetHumidity(this IEnumerable<ClimateEntity> target, ClimateSetHumidityParameters data)
		{
			target.CallService("set_humidity", data);
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public static void SetHumidity(this ClimateEntity target, long @humidity)
		{
			target.CallService("set_humidity", new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public static void SetHumidity(this IEnumerable<ClimateEntity> target, long @humidity)
		{
			target.CallService("set_humidity", new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		public static void SetHvacMode(this ClimateEntity target, ClimateSetHvacModeParameters data)
		{
			target.CallService("set_hvac_mode", data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		public static void SetHvacMode(this IEnumerable<ClimateEntity> target, ClimateSetHvacModeParameters data)
		{
			target.CallService("set_hvac_mode", data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public static void SetHvacMode(this ClimateEntity target, object? @hvacMode = null)
		{
			target.CallService("set_hvac_mode", new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public static void SetHvacMode(this IEnumerable<ClimateEntity> target, object? @hvacMode = null)
		{
			target.CallService("set_hvac_mode", new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		public static void SetPresetMode(this ClimateEntity target, ClimateSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for climate device.</summary>
		public static void SetPresetMode(this IEnumerable<ClimateEntity> target, ClimateSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public static void SetPresetMode(this ClimateEntity target, string @presetMode)
		{
			target.CallService("set_preset_mode", new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public static void SetPresetMode(this IEnumerable<ClimateEntity> target, string @presetMode)
		{
			target.CallService("set_preset_mode", new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		public static void SetSwingMode(this ClimateEntity target, ClimateSetSwingModeParameters data)
		{
			target.CallService("set_swing_mode", data);
		}

		///<summary>Set swing operation for climate device.</summary>
		public static void SetSwingMode(this IEnumerable<ClimateEntity> target, ClimateSetSwingModeParameters data)
		{
			target.CallService("set_swing_mode", data);
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public static void SetSwingMode(this ClimateEntity target, string @swingMode)
		{
			target.CallService("set_swing_mode", new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public static void SetSwingMode(this IEnumerable<ClimateEntity> target, string @swingMode)
		{
			target.CallService("set_swing_mode", new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		public static void SetTemperature(this ClimateEntity target, ClimateSetTemperatureParameters data)
		{
			target.CallService("set_temperature", data);
		}

		///<summary>Set target temperature of climate device.</summary>
		public static void SetTemperature(this IEnumerable<ClimateEntity> target, ClimateSetTemperatureParameters data)
		{
			target.CallService("set_temperature", data);
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public static void SetTemperature(this ClimateEntity target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, object? @hvacMode = null)
		{
			target.CallService("set_temperature", new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public static void SetTemperature(this IEnumerable<ClimateEntity> target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, object? @hvacMode = null)
		{
			target.CallService("set_temperature", new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Turn climate device off.</summary>
		public static void TurnOff(this ClimateEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn climate device off.</summary>
		public static void TurnOff(this IEnumerable<ClimateEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn climate device on.</summary>
		public static void TurnOn(this ClimateEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn climate device on.</summary>
		public static void TurnOn(this IEnumerable<ClimateEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class CoverEntityExtensionMethods
	{
		///<summary>Close all or specified cover.</summary>
		public static void CloseCover(this CoverEntity target)
		{
			target.CallService("close_cover");
		}

		///<summary>Close all or specified cover.</summary>
		public static void CloseCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("close_cover");
		}

		///<summary>Close all or specified cover tilt.</summary>
		public static void CloseCoverTilt(this CoverEntity target)
		{
			target.CallService("close_cover_tilt");
		}

		///<summary>Close all or specified cover tilt.</summary>
		public static void CloseCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("close_cover_tilt");
		}

		///<summary>Open all or specified cover.</summary>
		public static void OpenCover(this CoverEntity target)
		{
			target.CallService("open_cover");
		}

		///<summary>Open all or specified cover.</summary>
		public static void OpenCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("open_cover");
		}

		///<summary>Open all or specified cover tilt.</summary>
		public static void OpenCoverTilt(this CoverEntity target)
		{
			target.CallService("open_cover_tilt");
		}

		///<summary>Open all or specified cover tilt.</summary>
		public static void OpenCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("open_cover_tilt");
		}

		///<summary>Move to specific position all or specified cover.</summary>
		public static void SetCoverPosition(this CoverEntity target, CoverSetCoverPositionParameters data)
		{
			target.CallService("set_cover_position", data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		public static void SetCoverPosition(this IEnumerable<CoverEntity> target, CoverSetCoverPositionParameters data)
		{
			target.CallService("set_cover_position", data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The CoverEntity to call this service for</param>
		///<param name="position">Position of the cover</param>
		public static void SetCoverPosition(this CoverEntity target, long @position)
		{
			target.CallService("set_cover_position", new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The IEnumerable<CoverEntity> to call this service for</param>
		///<param name="position">Position of the cover</param>
		public static void SetCoverPosition(this IEnumerable<CoverEntity> target, long @position)
		{
			target.CallService("set_cover_position", new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		public static void SetCoverTiltPosition(this CoverEntity target, CoverSetCoverTiltPositionParameters data)
		{
			target.CallService("set_cover_tilt_position", data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		public static void SetCoverTiltPosition(this IEnumerable<CoverEntity> target, CoverSetCoverTiltPositionParameters data)
		{
			target.CallService("set_cover_tilt_position", data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The CoverEntity to call this service for</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public static void SetCoverTiltPosition(this CoverEntity target, long @tiltPosition)
		{
			target.CallService("set_cover_tilt_position", new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The IEnumerable<CoverEntity> to call this service for</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public static void SetCoverTiltPosition(this IEnumerable<CoverEntity> target, long @tiltPosition)
		{
			target.CallService("set_cover_tilt_position", new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCover(this CoverEntity target)
		{
			target.CallService("stop_cover");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("stop_cover");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCoverTilt(this CoverEntity target)
		{
			target.CallService("stop_cover_tilt");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("stop_cover_tilt");
		}

		///<summary>Toggle a cover open/closed.</summary>
		public static void Toggle(this CoverEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle a cover open/closed.</summary>
		public static void Toggle(this IEnumerable<CoverEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		public static void ToggleCoverTilt(this CoverEntity target)
		{
			target.CallService("toggle_cover_tilt");
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		public static void ToggleCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("toggle_cover_tilt");
		}
	}

	public static class FanEntityExtensionMethods
	{
		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		public static void DecreaseSpeed(this FanEntity target, FanDecreaseSpeedParameters data)
		{
			target.CallService("decrease_speed", data);
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		public static void DecreaseSpeed(this IEnumerable<FanEntity> target, FanDecreaseSpeedParameters data)
		{
			target.CallService("decrease_speed", data);
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The FanEntity to call this service for</param>
		///<param name="percentageStep">Decrease speed by a percentage.</param>
		public static void DecreaseSpeed(this FanEntity target, long? @percentageStep = null)
		{
			target.CallService("decrease_speed", new FanDecreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The IEnumerable<FanEntity> to call this service for</param>
		///<param name="percentageStep">Decrease speed by a percentage.</param>
		public static void DecreaseSpeed(this IEnumerable<FanEntity> target, long? @percentageStep = null)
		{
			target.CallService("decrease_speed", new FanDecreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		public static void IncreaseSpeed(this FanEntity target, FanIncreaseSpeedParameters data)
		{
			target.CallService("increase_speed", data);
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		public static void IncreaseSpeed(this IEnumerable<FanEntity> target, FanIncreaseSpeedParameters data)
		{
			target.CallService("increase_speed", data);
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The FanEntity to call this service for</param>
		///<param name="percentageStep">Increase speed by a percentage.</param>
		public static void IncreaseSpeed(this FanEntity target, long? @percentageStep = null)
		{
			target.CallService("increase_speed", new FanIncreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The IEnumerable<FanEntity> to call this service for</param>
		///<param name="percentageStep">Increase speed by a percentage.</param>
		public static void IncreaseSpeed(this IEnumerable<FanEntity> target, long? @percentageStep = null)
		{
			target.CallService("increase_speed", new FanIncreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Oscillate the fan.</summary>
		public static void Oscillate(this FanEntity target, FanOscillateParameters data)
		{
			target.CallService("oscillate", data);
		}

		///<summary>Oscillate the fan.</summary>
		public static void Oscillate(this IEnumerable<FanEntity> target, FanOscillateParameters data)
		{
			target.CallService("oscillate", data);
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The FanEntity to call this service for</param>
		///<param name="oscillating">Flag to turn on/off oscillation.</param>
		public static void Oscillate(this FanEntity target, bool @oscillating)
		{
			target.CallService("oscillate", new FanOscillateParameters{Oscillating = @oscillating});
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The IEnumerable<FanEntity> to call this service for</param>
		///<param name="oscillating">Flag to turn on/off oscillation.</param>
		public static void Oscillate(this IEnumerable<FanEntity> target, bool @oscillating)
		{
			target.CallService("oscillate", new FanOscillateParameters{Oscillating = @oscillating});
		}

		///<summary>Set the fan rotation.</summary>
		public static void SetDirection(this FanEntity target, FanSetDirectionParameters data)
		{
			target.CallService("set_direction", data);
		}

		///<summary>Set the fan rotation.</summary>
		public static void SetDirection(this IEnumerable<FanEntity> target, FanSetDirectionParameters data)
		{
			target.CallService("set_direction", data);
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The FanEntity to call this service for</param>
		///<param name="direction">The direction to rotate.</param>
		public static void SetDirection(this FanEntity target, object @direction)
		{
			target.CallService("set_direction", new FanSetDirectionParameters{Direction = @direction});
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The IEnumerable<FanEntity> to call this service for</param>
		///<param name="direction">The direction to rotate.</param>
		public static void SetDirection(this IEnumerable<FanEntity> target, object @direction)
		{
			target.CallService("set_direction", new FanSetDirectionParameters{Direction = @direction});
		}

		///<summary>Set fan speed percentage.</summary>
		public static void SetPercentage(this FanEntity target, FanSetPercentageParameters data)
		{
			target.CallService("set_percentage", data);
		}

		///<summary>Set fan speed percentage.</summary>
		public static void SetPercentage(this IEnumerable<FanEntity> target, FanSetPercentageParameters data)
		{
			target.CallService("set_percentage", data);
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The FanEntity to call this service for</param>
		///<param name="percentage">Percentage speed setting.</param>
		public static void SetPercentage(this FanEntity target, long @percentage)
		{
			target.CallService("set_percentage", new FanSetPercentageParameters{Percentage = @percentage});
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The IEnumerable<FanEntity> to call this service for</param>
		///<param name="percentage">Percentage speed setting.</param>
		public static void SetPercentage(this IEnumerable<FanEntity> target, long @percentage)
		{
			target.CallService("set_percentage", new FanSetPercentageParameters{Percentage = @percentage});
		}

		///<summary>Set preset mode for a fan device.</summary>
		public static void SetPresetMode(this FanEntity target, FanSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for a fan device.</summary>
		public static void SetPresetMode(this IEnumerable<FanEntity> target, FanSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The FanEntity to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: auto</param>
		public static void SetPresetMode(this FanEntity target, string @presetMode)
		{
			target.CallService("set_preset_mode", new FanSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The IEnumerable<FanEntity> to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: auto</param>
		public static void SetPresetMode(this IEnumerable<FanEntity> target, string @presetMode)
		{
			target.CallService("set_preset_mode", new FanSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Toggle the fan on/off.</summary>
		public static void Toggle(this FanEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle the fan on/off.</summary>
		public static void Toggle(this IEnumerable<FanEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn fan off.</summary>
		public static void TurnOff(this FanEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn fan off.</summary>
		public static void TurnOff(this IEnumerable<FanEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn fan on.</summary>
		public static void TurnOn(this FanEntity target, FanTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn fan on.</summary>
		public static void TurnOn(this IEnumerable<FanEntity> target, FanTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The FanEntity to call this service for</param>
		///<param name="speed">Speed setting. eg: high</param>
		///<param name="percentage">Percentage speed setting.</param>
		///<param name="presetMode">Preset mode setting. eg: auto</param>
		public static void TurnOn(this FanEntity target, string? @speed = null, long? @percentage = null, string? @presetMode = null)
		{
			target.CallService("turn_on", new FanTurnOnParameters{Speed = @speed, Percentage = @percentage, PresetMode = @presetMode});
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The IEnumerable<FanEntity> to call this service for</param>
		///<param name="speed">Speed setting. eg: high</param>
		///<param name="percentage">Percentage speed setting.</param>
		///<param name="presetMode">Preset mode setting. eg: auto</param>
		public static void TurnOn(this IEnumerable<FanEntity> target, string? @speed = null, long? @percentage = null, string? @presetMode = null)
		{
			target.CallService("turn_on", new FanTurnOnParameters{Speed = @speed, Percentage = @percentage, PresetMode = @presetMode});
		}
	}

	public static class GoogleEntityExtensionMethods
	{
		///<summary>Add a new calendar event.</summary>
		public static void CreateEvent(this CalendarEntity target, GoogleCreateEventParameters data)
		{
			target.CallService("create_event", data);
		}

		///<summary>Add a new calendar event.</summary>
		public static void CreateEvent(this IEnumerable<CalendarEntity> target, GoogleCreateEventParameters data)
		{
			target.CallService("create_event", data);
		}

		///<summary>Add a new calendar event.</summary>
		///<param name="target">The CalendarEntity to call this service for</param>
		///<param name="summary">Acts as the title of the event. eg: Bowling</param>
		///<param name="description">The description of the event. Optional. eg: Birthday bowling</param>
		///<param name="startDateTime">The date and time the event should start. eg: 2022-03-22 20:00:00</param>
		///<param name="endDateTime">The date and time the event should end. eg: 2022-03-22 22:00:00</param>
		///<param name="startDate">The date the whole day event should start. eg: 2022-03-10</param>
		///<param name="endDate">The date the whole day event should end. eg: 2022-03-11</param>
		///<param name="in">Days or weeks that you want to create the event in. eg: "days": 2 or "weeks": 2</param>
		public static void CreateEvent(this CalendarEntity target, string @summary, string? @description = null, string? @startDateTime = null, string? @endDateTime = null, string? @startDate = null, string? @endDate = null, object? @in = null)
		{
			target.CallService("create_event", new GoogleCreateEventParameters{Summary = @summary, Description = @description, StartDateTime = @startDateTime, EndDateTime = @endDateTime, StartDate = @startDate, EndDate = @endDate, In = @in});
		}

		///<summary>Add a new calendar event.</summary>
		///<param name="target">The IEnumerable<CalendarEntity> to call this service for</param>
		///<param name="summary">Acts as the title of the event. eg: Bowling</param>
		///<param name="description">The description of the event. Optional. eg: Birthday bowling</param>
		///<param name="startDateTime">The date and time the event should start. eg: 2022-03-22 20:00:00</param>
		///<param name="endDateTime">The date and time the event should end. eg: 2022-03-22 22:00:00</param>
		///<param name="startDate">The date the whole day event should start. eg: 2022-03-10</param>
		///<param name="endDate">The date the whole day event should end. eg: 2022-03-11</param>
		///<param name="in">Days or weeks that you want to create the event in. eg: "days": 2 or "weeks": 2</param>
		public static void CreateEvent(this IEnumerable<CalendarEntity> target, string @summary, string? @description = null, string? @startDateTime = null, string? @endDateTime = null, string? @startDate = null, string? @endDate = null, object? @in = null)
		{
			target.CallService("create_event", new GoogleCreateEventParameters{Summary = @summary, Description = @description, StartDateTime = @startDateTime, EndDateTime = @endDateTime, StartDate = @startDate, EndDate = @endDate, In = @in});
		}
	}

	public static class InputBooleanEntityExtensionMethods
	{
		///<summary>Toggle an input boolean</summary>
		public static void Toggle(this InputBooleanEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle an input boolean</summary>
		public static void Toggle(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn off an input boolean</summary>
		public static void TurnOff(this InputBooleanEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off an input boolean</summary>
		public static void TurnOff(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on an input boolean</summary>
		public static void TurnOn(this InputBooleanEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on an input boolean</summary>
		public static void TurnOn(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class InputDatetimeEntityExtensionMethods
	{
		///<summary>This can be used to dynamically set the date and/or time.</summary>
		public static void SetDatetime(this InputDatetimeEntity target, InputDatetimeSetDatetimeParameters data)
		{
			target.CallService("set_datetime", data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		public static void SetDatetime(this IEnumerable<InputDatetimeEntity> target, InputDatetimeSetDatetimeParameters data)
		{
			target.CallService("set_datetime", data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The InputDatetimeEntity to call this service for</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public static void SetDatetime(this InputDatetimeEntity target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			target.CallService("set_datetime", new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The IEnumerable<InputDatetimeEntity> to call this service for</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public static void SetDatetime(this IEnumerable<InputDatetimeEntity> target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			target.CallService("set_datetime", new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}
	}

	public static class InputNumberEntityExtensionMethods
	{
		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		public static void Decrement(this InputNumberEntity target)
		{
			target.CallService("decrement");
		}

		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		public static void Decrement(this IEnumerable<InputNumberEntity> target)
		{
			target.CallService("decrement");
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		public static void Increment(this InputNumberEntity target)
		{
			target.CallService("increment");
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		public static void Increment(this IEnumerable<InputNumberEntity> target)
		{
			target.CallService("increment");
		}

		///<summary>Set the value of an input number entity.</summary>
		public static void SetValue(this InputNumberEntity target, InputNumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input number entity.</summary>
		public static void SetValue(this IEnumerable<InputNumberEntity> target, InputNumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The InputNumberEntity to call this service for</param>
		///<param name="value">The target value the entity should be set to.</param>
		public static void SetValue(this InputNumberEntity target, double @value)
		{
			target.CallService("set_value", new InputNumberSetValueParameters{Value = @value});
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The IEnumerable<InputNumberEntity> to call this service for</param>
		///<param name="value">The target value the entity should be set to.</param>
		public static void SetValue(this IEnumerable<InputNumberEntity> target, double @value)
		{
			target.CallService("set_value", new InputNumberSetValueParameters{Value = @value});
		}
	}

	public static class InputSelectEntityExtensionMethods
	{
		///<summary>Select the first option of an input select entity.</summary>
		public static void SelectFirst(this InputSelectEntity target)
		{
			target.CallService("select_first");
		}

		///<summary>Select the first option of an input select entity.</summary>
		public static void SelectFirst(this IEnumerable<InputSelectEntity> target)
		{
			target.CallService("select_first");
		}

		///<summary>Select the last option of an input select entity.</summary>
		public static void SelectLast(this InputSelectEntity target)
		{
			target.CallService("select_last");
		}

		///<summary>Select the last option of an input select entity.</summary>
		public static void SelectLast(this IEnumerable<InputSelectEntity> target)
		{
			target.CallService("select_last");
		}

		///<summary>Select the next options of an input select entity.</summary>
		public static void SelectNext(this InputSelectEntity target, InputSelectSelectNextParameters data)
		{
			target.CallService("select_next", data);
		}

		///<summary>Select the next options of an input select entity.</summary>
		public static void SelectNext(this IEnumerable<InputSelectEntity> target, InputSelectSelectNextParameters data)
		{
			target.CallService("select_next", data);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The InputSelectEntity to call this service for</param>
		///<param name="cycle">If the option should cycle from the last to the first.</param>
		public static void SelectNext(this InputSelectEntity target, bool? @cycle = null)
		{
			target.CallService("select_next", new InputSelectSelectNextParameters{Cycle = @cycle});
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
		///<param name="cycle">If the option should cycle from the last to the first.</param>
		public static void SelectNext(this IEnumerable<InputSelectEntity> target, bool? @cycle = null)
		{
			target.CallService("select_next", new InputSelectSelectNextParameters{Cycle = @cycle});
		}

		///<summary>Select an option of an input select entity.</summary>
		public static void SelectOption(this InputSelectEntity target, InputSelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an input select entity.</summary>
		public static void SelectOption(this IEnumerable<InputSelectEntity> target, InputSelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The InputSelectEntity to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this InputSelectEntity target, string @option)
		{
			target.CallService("select_option", new InputSelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this IEnumerable<InputSelectEntity> target, string @option)
		{
			target.CallService("select_option", new InputSelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select the previous options of an input select entity.</summary>
		public static void SelectPrevious(this InputSelectEntity target, InputSelectSelectPreviousParameters data)
		{
			target.CallService("select_previous", data);
		}

		///<summary>Select the previous options of an input select entity.</summary>
		public static void SelectPrevious(this IEnumerable<InputSelectEntity> target, InputSelectSelectPreviousParameters data)
		{
			target.CallService("select_previous", data);
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The InputSelectEntity to call this service for</param>
		///<param name="cycle">If the option should cycle from the first to the last.</param>
		public static void SelectPrevious(this InputSelectEntity target, bool? @cycle = null)
		{
			target.CallService("select_previous", new InputSelectSelectPreviousParameters{Cycle = @cycle});
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
		///<param name="cycle">If the option should cycle from the first to the last.</param>
		public static void SelectPrevious(this IEnumerable<InputSelectEntity> target, bool? @cycle = null)
		{
			target.CallService("select_previous", new InputSelectSelectPreviousParameters{Cycle = @cycle});
		}

		///<summary>Set the options of an input select entity.</summary>
		public static void SetOptions(this InputSelectEntity target, InputSelectSetOptionsParameters data)
		{
			target.CallService("set_options", data);
		}

		///<summary>Set the options of an input select entity.</summary>
		public static void SetOptions(this IEnumerable<InputSelectEntity> target, InputSelectSetOptionsParameters data)
		{
			target.CallService("set_options", data);
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The InputSelectEntity to call this service for</param>
		///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
		public static void SetOptions(this InputSelectEntity target, object @options)
		{
			target.CallService("set_options", new InputSelectSetOptionsParameters{Options = @options});
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
		///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
		public static void SetOptions(this IEnumerable<InputSelectEntity> target, object @options)
		{
			target.CallService("set_options", new InputSelectSetOptionsParameters{Options = @options});
		}
	}

	public static class LightEntityExtensionMethods
	{
		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		public static void Toggle(this LightEntity target, LightToggleParameters data)
		{
			target.CallService("toggle", data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		public static void Toggle(this IEnumerable<LightEntity> target, LightToggleParameters data)
		{
			target.CallService("toggle", data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void Toggle(this LightEntity target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void Toggle(this IEnumerable<LightEntity> target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		public static void TurnOff(this LightEntity target, LightTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Turns off one or more lights.</summary>
		public static void TurnOff(this IEnumerable<LightEntity> target, LightTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public static void TurnOff(this LightEntity target, long? @transition = null, object? @flash = null)
		{
			target.CallService("turn_off", new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public static void TurnOff(this IEnumerable<LightEntity> target, long? @transition = null, object? @flash = null)
		{
			target.CallService("turn_off", new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		public static void TurnOn(this LightEntity target, LightTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		public static void TurnOn(this IEnumerable<LightEntity> target, LightTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void TurnOn(this LightEntity target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("turn_on", new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void TurnOn(this IEnumerable<LightEntity> target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("turn_on", new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public static class LockEntityExtensionMethods
	{
		///<summary>Lock all or specified locks.</summary>
		public static void Lock(this LockEntity target, LockLockParameters data)
		{
			target.CallService("lock", data);
		}

		///<summary>Lock all or specified locks.</summary>
		public static void Lock(this IEnumerable<LockEntity> target, LockLockParameters data)
		{
			target.CallService("lock", data);
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="code">An optional code to lock the lock with. eg: 1234</param>
		public static void Lock(this LockEntity target, string? @code = null)
		{
			target.CallService("lock", new LockLockParameters{Code = @code});
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="code">An optional code to lock the lock with. eg: 1234</param>
		public static void Lock(this IEnumerable<LockEntity> target, string? @code = null)
		{
			target.CallService("lock", new LockLockParameters{Code = @code});
		}

		///<summary>Open all or specified locks.</summary>
		public static void Open(this LockEntity target, LockOpenParameters data)
		{
			target.CallService("open", data);
		}

		///<summary>Open all or specified locks.</summary>
		public static void Open(this IEnumerable<LockEntity> target, LockOpenParameters data)
		{
			target.CallService("open", data);
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="code">An optional code to open the lock with. eg: 1234</param>
		public static void Open(this LockEntity target, string? @code = null)
		{
			target.CallService("open", new LockOpenParameters{Code = @code});
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="code">An optional code to open the lock with. eg: 1234</param>
		public static void Open(this IEnumerable<LockEntity> target, string? @code = null)
		{
			target.CallService("open", new LockOpenParameters{Code = @code});
		}

		///<summary>Unlock all or specified locks.</summary>
		public static void Unlock(this LockEntity target, LockUnlockParameters data)
		{
			target.CallService("unlock", data);
		}

		///<summary>Unlock all or specified locks.</summary>
		public static void Unlock(this IEnumerable<LockEntity> target, LockUnlockParameters data)
		{
			target.CallService("unlock", data);
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
		public static void Unlock(this LockEntity target, string? @code = null)
		{
			target.CallService("unlock", new LockUnlockParameters{Code = @code});
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
		public static void Unlock(this IEnumerable<LockEntity> target, string? @code = null)
		{
			target.CallService("unlock", new LockUnlockParameters{Code = @code});
		}
	}

	public static class MediaPlayerEntityExtensionMethods
	{
		///<summary>Send the media player the command to clear players playlist.</summary>
		public static void ClearPlaylist(this MediaPlayerEntity target)
		{
			target.CallService("clear_playlist");
		}

		///<summary>Send the media player the command to clear players playlist.</summary>
		public static void ClearPlaylist(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("clear_playlist");
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		public static void Join(this MediaPlayerEntity target, MediaPlayerJoinParameters data)
		{
			target.CallService("join", data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		public static void Join(this IEnumerable<MediaPlayerEntity> target, MediaPlayerJoinParameters data)
		{
			target.CallService("join", data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</param>
		public static void Join(this MediaPlayerEntity target, object? @groupMembers = null)
		{
			target.CallService("join", new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</param>
		public static void Join(this IEnumerable<MediaPlayerEntity> target, object? @groupMembers = null)
		{
			target.CallService("join", new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		public static void MediaNextTrack(this MediaPlayerEntity target)
		{
			target.CallService("media_next_track");
		}

		///<summary>Send the media player the command for next track.</summary>
		public static void MediaNextTrack(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_next_track");
		}

		///<summary>Send the media player the command for pause.</summary>
		public static void MediaPause(this MediaPlayerEntity target)
		{
			target.CallService("media_pause");
		}

		///<summary>Send the media player the command for pause.</summary>
		public static void MediaPause(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_pause");
		}

		///<summary>Send the media player the command for play.</summary>
		public static void MediaPlay(this MediaPlayerEntity target)
		{
			target.CallService("media_play");
		}

		///<summary>Send the media player the command for play.</summary>
		public static void MediaPlay(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_play");
		}

		///<summary>Toggle media player play/pause state.</summary>
		public static void MediaPlayPause(this MediaPlayerEntity target)
		{
			target.CallService("media_play_pause");
		}

		///<summary>Toggle media player play/pause state.</summary>
		public static void MediaPlayPause(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_play_pause");
		}

		///<summary>Send the media player the command for previous track.</summary>
		public static void MediaPreviousTrack(this MediaPlayerEntity target)
		{
			target.CallService("media_previous_track");
		}

		///<summary>Send the media player the command for previous track.</summary>
		public static void MediaPreviousTrack(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_previous_track");
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		public static void MediaSeek(this MediaPlayerEntity target, MediaPlayerMediaSeekParameters data)
		{
			target.CallService("media_seek", data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		public static void MediaSeek(this IEnumerable<MediaPlayerEntity> target, MediaPlayerMediaSeekParameters data)
		{
			target.CallService("media_seek", data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public static void MediaSeek(this MediaPlayerEntity target, double @seekPosition)
		{
			target.CallService("media_seek", new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public static void MediaSeek(this IEnumerable<MediaPlayerEntity> target, double @seekPosition)
		{
			target.CallService("media_seek", new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		public static void MediaStop(this MediaPlayerEntity target)
		{
			target.CallService("media_stop");
		}

		///<summary>Send the media player the stop command.</summary>
		public static void MediaStop(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_stop");
		}

		///<summary>Send the media player the command for playing media.</summary>
		public static void PlayMedia(this MediaPlayerEntity target, MediaPlayerPlayMediaParameters data)
		{
			target.CallService("play_media", data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		public static void PlayMedia(this IEnumerable<MediaPlayerEntity> target, MediaPlayerPlayMediaParameters data)
		{
			target.CallService("play_media", data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		///<param name="enqueue">If the content should be played now or be added to the queue.</param>
		///<param name="announce">If the media should be played as an announcement. eg: true</param>
		public static void PlayMedia(this MediaPlayerEntity target, string @mediaContentId, string @mediaContentType, object? @enqueue = null, bool? @announce = null)
		{
			target.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType, Enqueue = @enqueue, Announce = @announce});
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		///<param name="enqueue">If the content should be played now or be added to the queue.</param>
		///<param name="announce">If the media should be played as an announcement. eg: true</param>
		public static void PlayMedia(this IEnumerable<MediaPlayerEntity> target, string @mediaContentId, string @mediaContentType, object? @enqueue = null, bool? @announce = null)
		{
			target.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType, Enqueue = @enqueue, Announce = @announce});
		}

		///<summary>Set repeat mode</summary>
		public static void RepeatSet(this MediaPlayerEntity target, MediaPlayerRepeatSetParameters data)
		{
			target.CallService("repeat_set", data);
		}

		///<summary>Set repeat mode</summary>
		public static void RepeatSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerRepeatSetParameters data)
		{
			target.CallService("repeat_set", data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="repeat">Repeat mode to set.</param>
		public static void RepeatSet(this MediaPlayerEntity target, object @repeat)
		{
			target.CallService("repeat_set", new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="repeat">Repeat mode to set.</param>
		public static void RepeatSet(this IEnumerable<MediaPlayerEntity> target, object @repeat)
		{
			target.CallService("repeat_set", new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		public static void SelectSoundMode(this MediaPlayerEntity target, MediaPlayerSelectSoundModeParameters data)
		{
			target.CallService("select_sound_mode", data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		public static void SelectSoundMode(this IEnumerable<MediaPlayerEntity> target, MediaPlayerSelectSoundModeParameters data)
		{
			target.CallService("select_sound_mode", data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public static void SelectSoundMode(this MediaPlayerEntity target, string? @soundMode = null)
		{
			target.CallService("select_sound_mode", new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public static void SelectSoundMode(this IEnumerable<MediaPlayerEntity> target, string? @soundMode = null)
		{
			target.CallService("select_sound_mode", new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		public static void SelectSource(this MediaPlayerEntity target, MediaPlayerSelectSourceParameters data)
		{
			target.CallService("select_source", data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		public static void SelectSource(this IEnumerable<MediaPlayerEntity> target, MediaPlayerSelectSourceParameters data)
		{
			target.CallService("select_source", data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public static void SelectSource(this MediaPlayerEntity target, string @source)
		{
			target.CallService("select_source", new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public static void SelectSource(this IEnumerable<MediaPlayerEntity> target, string @source)
		{
			target.CallService("select_source", new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		public static void ShuffleSet(this MediaPlayerEntity target, MediaPlayerShuffleSetParameters data)
		{
			target.CallService("shuffle_set", data);
		}

		///<summary>Set shuffling state.</summary>
		public static void ShuffleSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerShuffleSetParameters data)
		{
			target.CallService("shuffle_set", data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public static void ShuffleSet(this MediaPlayerEntity target, bool @shuffle)
		{
			target.CallService("shuffle_set", new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public static void ShuffleSet(this IEnumerable<MediaPlayerEntity> target, bool @shuffle)
		{
			target.CallService("shuffle_set", new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		public static void Toggle(this MediaPlayerEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a media player power state.</summary>
		public static void Toggle(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn a media player power off.</summary>
		public static void TurnOff(this MediaPlayerEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a media player power off.</summary>
		public static void TurnOff(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a media player power on.</summary>
		public static void TurnOn(this MediaPlayerEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn a media player power on.</summary>
		public static void TurnOn(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("turn_on");
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		public static void Unjoin(this MediaPlayerEntity target)
		{
			target.CallService("unjoin");
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		public static void Unjoin(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("unjoin");
		}

		///<summary>Turn a media player volume down.</summary>
		public static void VolumeDown(this MediaPlayerEntity target)
		{
			target.CallService("volume_down");
		}

		///<summary>Turn a media player volume down.</summary>
		public static void VolumeDown(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("volume_down");
		}

		///<summary>Mute a media player's volume.</summary>
		public static void VolumeMute(this MediaPlayerEntity target, MediaPlayerVolumeMuteParameters data)
		{
			target.CallService("volume_mute", data);
		}

		///<summary>Mute a media player's volume.</summary>
		public static void VolumeMute(this IEnumerable<MediaPlayerEntity> target, MediaPlayerVolumeMuteParameters data)
		{
			target.CallService("volume_mute", data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public static void VolumeMute(this MediaPlayerEntity target, bool @isVolumeMuted)
		{
			target.CallService("volume_mute", new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public static void VolumeMute(this IEnumerable<MediaPlayerEntity> target, bool @isVolumeMuted)
		{
			target.CallService("volume_mute", new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		public static void VolumeSet(this MediaPlayerEntity target, MediaPlayerVolumeSetParameters data)
		{
			target.CallService("volume_set", data);
		}

		///<summary>Set a media player's volume level.</summary>
		public static void VolumeSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerVolumeSetParameters data)
		{
			target.CallService("volume_set", data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public static void VolumeSet(this MediaPlayerEntity target, double @volumeLevel)
		{
			target.CallService("volume_set", new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public static void VolumeSet(this IEnumerable<MediaPlayerEntity> target, double @volumeLevel)
		{
			target.CallService("volume_set", new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		public static void VolumeUp(this MediaPlayerEntity target)
		{
			target.CallService("volume_up");
		}

		///<summary>Turn a media player volume up.</summary>
		public static void VolumeUp(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("volume_up");
		}
	}

	public static class NumberEntityExtensionMethods
	{
		///<summary>Set the value of a Number entity.</summary>
		public static void SetValue(this NumberEntity target, NumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of a Number entity.</summary>
		public static void SetValue(this IEnumerable<NumberEntity> target, NumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The NumberEntity to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public static void SetValue(this NumberEntity target, string? @value = null)
		{
			target.CallService("set_value", new NumberSetValueParameters{Value = @value});
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The IEnumerable<NumberEntity> to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public static void SetValue(this IEnumerable<NumberEntity> target, string? @value = null)
		{
			target.CallService("set_value", new NumberSetValueParameters{Value = @value});
		}
	}

	public static class ScriptEntityExtensionMethods
	{
		///<summary>Toggle script</summary>
		public static void Toggle(this ScriptEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle script</summary>
		public static void Toggle(this IEnumerable<ScriptEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn off script</summary>
		public static void TurnOff(this ScriptEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off script</summary>
		public static void TurnOff(this IEnumerable<ScriptEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on script</summary>
		public static void TurnOn(this ScriptEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on script</summary>
		public static void TurnOn(this IEnumerable<ScriptEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class SelectEntityExtensionMethods
	{
		///<summary>Select an option of an select entity.</summary>
		public static void SelectOption(this SelectEntity target, SelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an select entity.</summary>
		public static void SelectOption(this IEnumerable<SelectEntity> target, SelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The SelectEntity to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this SelectEntity target, string @option)
		{
			target.CallService("select_option", new SelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The IEnumerable<SelectEntity> to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this IEnumerable<SelectEntity> target, string @option)
		{
			target.CallService("select_option", new SelectSelectOptionParameters{Option = @option});
		}
	}

	public static class SmartthinqSensorsEntityExtensionMethods
	{
		///<summary>Send to ThinQ device the remote start command.</summary>
		public static void RemoteStart(this SensorEntity target)
		{
			target.CallService("remote_start");
		}

		///<summary>Send to ThinQ device the remote start command.</summary>
		public static void RemoteStart(this IEnumerable<SensorEntity> target)
		{
			target.CallService("remote_start");
		}

		///<summary>Set fan operation for dehumidifier device.</summary>
		public static void SetFanMode(this HumidifierEntity target, SmartthinqSensorsSetFanModeParameters data)
		{
			target.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for dehumidifier device.</summary>
		public static void SetFanMode(this IEnumerable<HumidifierEntity> target, SmartthinqSensorsSetFanModeParameters data)
		{
			target.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for dehumidifier device.</summary>
		///<param name="target">The HumidifierEntity to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this HumidifierEntity target, string @fanMode)
		{
			target.CallService("set_fan_mode", new SmartthinqSensorsSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set fan operation for dehumidifier device.</summary>
		///<param name="target">The IEnumerable<HumidifierEntity> to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this IEnumerable<HumidifierEntity> target, string @fanMode)
		{
			target.CallService("set_fan_mode", new SmartthinqSensorsSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Send to ThinQ device the wakeup command.</summary>
		public static void WakeUp(this SensorEntity target)
		{
			target.CallService("wake_up");
		}

		///<summary>Send to ThinQ device the wakeup command.</summary>
		public static void WakeUp(this IEnumerable<SensorEntity> target)
		{
			target.CallService("wake_up");
		}
	}

	public static class SwitchEntityExtensionMethods
	{
		///<summary>Toggles a switch state</summary>
		public static void Toggle(this SwitchEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a switch state</summary>
		public static void Toggle(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn a switch off</summary>
		public static void TurnOff(this SwitchEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a switch off</summary>
		public static void TurnOff(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a switch on</summary>
		public static void TurnOn(this SwitchEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn a switch on</summary>
		public static void TurnOn(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class UpdateEntityExtensionMethods
	{
		///<summary>Removes the skipped version marker from an update.</summary>
		public static void ClearSkipped(this UpdateEntity target)
		{
			target.CallService("clear_skipped");
		}

		///<summary>Removes the skipped version marker from an update.</summary>
		public static void ClearSkipped(this IEnumerable<UpdateEntity> target)
		{
			target.CallService("clear_skipped");
		}

		///<summary>Install an update for this device or service</summary>
		public static void Install(this UpdateEntity target, UpdateInstallParameters data)
		{
			target.CallService("install", data);
		}

		///<summary>Install an update for this device or service</summary>
		public static void Install(this IEnumerable<UpdateEntity> target, UpdateInstallParameters data)
		{
			target.CallService("install", data);
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The UpdateEntity to call this service for</param>
		///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
		///<param name="backup">Backup before installing the update, if supported by the integration.</param>
		public static void Install(this UpdateEntity target, string? @version = null, bool? @backup = null)
		{
			target.CallService("install", new UpdateInstallParameters{Version = @version, Backup = @backup});
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The IEnumerable<UpdateEntity> to call this service for</param>
		///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
		///<param name="backup">Backup before installing the update, if supported by the integration.</param>
		public static void Install(this IEnumerable<UpdateEntity> target, string? @version = null, bool? @backup = null)
		{
			target.CallService("install", new UpdateInstallParameters{Version = @version, Backup = @backup});
		}

		///<summary>Mark currently available update as skipped.</summary>
		public static void Skip(this UpdateEntity target)
		{
			target.CallService("skip");
		}

		///<summary>Mark currently available update as skipped.</summary>
		public static void Skip(this IEnumerable<UpdateEntity> target)
		{
			target.CallService("skip");
		}
	}

	public static class VacuumEntityExtensionMethods
	{
		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		public static void CleanSpot(this VacuumEntity target)
		{
			target.CallService("clean_spot");
		}

		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		public static void CleanSpot(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("clean_spot");
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		public static void Locate(this VacuumEntity target)
		{
			target.CallService("locate");
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		public static void Locate(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("locate");
		}

		///<summary>Pause the cleaning task.</summary>
		public static void Pause(this VacuumEntity target)
		{
			target.CallService("pause");
		}

		///<summary>Pause the cleaning task.</summary>
		public static void Pause(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("pause");
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		public static void ReturnToBase(this VacuumEntity target)
		{
			target.CallService("return_to_base");
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		public static void ReturnToBase(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("return_to_base");
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		public static void SendCommand(this VacuumEntity target, VacuumSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		public static void SendCommand(this IEnumerable<VacuumEntity> target, VacuumSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public static void SendCommand(this VacuumEntity target, string @command, object? @params = null)
		{
			target.CallService("send_command", new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public static void SendCommand(this IEnumerable<VacuumEntity> target, string @command, object? @params = null)
		{
			target.CallService("send_command", new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		public static void SetFanSpeed(this VacuumEntity target, VacuumSetFanSpeedParameters data)
		{
			target.CallService("set_fan_speed", data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		public static void SetFanSpeed(this IEnumerable<VacuumEntity> target, VacuumSetFanSpeedParameters data)
		{
			target.CallService("set_fan_speed", data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public static void SetFanSpeed(this VacuumEntity target, string @fanSpeed)
		{
			target.CallService("set_fan_speed", new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public static void SetFanSpeed(this IEnumerable<VacuumEntity> target, string @fanSpeed)
		{
			target.CallService("set_fan_speed", new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Start or resume the cleaning task.</summary>
		public static void Start(this VacuumEntity target)
		{
			target.CallService("start");
		}

		///<summary>Start or resume the cleaning task.</summary>
		public static void Start(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("start");
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		public static void StartPause(this VacuumEntity target)
		{
			target.CallService("start_pause");
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		public static void StartPause(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("start_pause");
		}

		///<summary>Stop the current cleaning task.</summary>
		public static void Stop(this VacuumEntity target)
		{
			target.CallService("stop");
		}

		///<summary>Stop the current cleaning task.</summary>
		public static void Stop(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("stop");
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		public static void TurnOff(this VacuumEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		public static void TurnOff(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Start a new cleaning task.</summary>
		public static void TurnOn(this VacuumEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Start a new cleaning task.</summary>
		public static void TurnOn(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class YeelightEntityExtensionMethods
	{
		///<summary>Turns the light on to the specified brightness and sets a timer to turn it back off after the given number of minutes. If the light is off, Set a color scene, if light is off, it will be turned on.</summary>
		public static void SetAutoDelayOffScene(this LightEntity target, YeelightSetAutoDelayOffSceneParameters data)
		{
			target.CallService("set_auto_delay_off_scene", data);
		}

		///<summary>Turns the light on to the specified brightness and sets a timer to turn it back off after the given number of minutes. If the light is off, Set a color scene, if light is off, it will be turned on.</summary>
		public static void SetAutoDelayOffScene(this IEnumerable<LightEntity> target, YeelightSetAutoDelayOffSceneParameters data)
		{
			target.CallService("set_auto_delay_off_scene", data);
		}

		///<summary>Turns the light on to the specified brightness and sets a timer to turn it back off after the given number of minutes. If the light is off, Set a color scene, if light is off, it will be turned on.</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="minutes">The time to wait before automatically turning the light off.</param>
		///<param name="brightness">The brightness value to set.</param>
		public static void SetAutoDelayOffScene(this LightEntity target, long? @minutes = null, long? @brightness = null)
		{
			target.CallService("set_auto_delay_off_scene", new YeelightSetAutoDelayOffSceneParameters{Minutes = @minutes, Brightness = @brightness});
		}

		///<summary>Turns the light on to the specified brightness and sets a timer to turn it back off after the given number of minutes. If the light is off, Set a color scene, if light is off, it will be turned on.</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="minutes">The time to wait before automatically turning the light off.</param>
		///<param name="brightness">The brightness value to set.</param>
		public static void SetAutoDelayOffScene(this IEnumerable<LightEntity> target, long? @minutes = null, long? @brightness = null)
		{
			target.CallService("set_auto_delay_off_scene", new YeelightSetAutoDelayOffSceneParameters{Minutes = @minutes, Brightness = @brightness});
		}

		///<summary>starts a color flow. If the light is off, it will be turned on.</summary>
		public static void SetColorFlowScene(this LightEntity target, YeelightSetColorFlowSceneParameters data)
		{
			target.CallService("set_color_flow_scene", data);
		}

		///<summary>starts a color flow. If the light is off, it will be turned on.</summary>
		public static void SetColorFlowScene(this IEnumerable<LightEntity> target, YeelightSetColorFlowSceneParameters data)
		{
			target.CallService("set_color_flow_scene", data);
		}

		///<summary>starts a color flow. If the light is off, it will be turned on.</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="count">The number of times to run this flow (0 to run forever).</param>
		///<param name="action">The action to take after the flow stops.</param>
		///<param name="transitions">Array of transitions, for desired effect. Examples https://yeelight.readthedocs.io/en/stable/flow.html eg: [{ "TemperatureTransition": [1900, 1000, 80] }, { "TemperatureTransition": [1900, 1000, 10] }]</param>
		public static void SetColorFlowScene(this LightEntity target, long? @count = null, object? @action = null, object? @transitions = null)
		{
			target.CallService("set_color_flow_scene", new YeelightSetColorFlowSceneParameters{Count = @count, Action = @action, Transitions = @transitions});
		}

		///<summary>starts a color flow. If the light is off, it will be turned on.</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="count">The number of times to run this flow (0 to run forever).</param>
		///<param name="action">The action to take after the flow stops.</param>
		///<param name="transitions">Array of transitions, for desired effect. Examples https://yeelight.readthedocs.io/en/stable/flow.html eg: [{ "TemperatureTransition": [1900, 1000, 80] }, { "TemperatureTransition": [1900, 1000, 10] }]</param>
		public static void SetColorFlowScene(this IEnumerable<LightEntity> target, long? @count = null, object? @action = null, object? @transitions = null)
		{
			target.CallService("set_color_flow_scene", new YeelightSetColorFlowSceneParameters{Count = @count, Action = @action, Transitions = @transitions});
		}

		///<summary>Changes the light to the specified RGB color and brightness. If the light is off, it will be turned on.</summary>
		public static void SetColorScene(this LightEntity target, YeelightSetColorSceneParameters data)
		{
			target.CallService("set_color_scene", data);
		}

		///<summary>Changes the light to the specified RGB color and brightness. If the light is off, it will be turned on.</summary>
		public static void SetColorScene(this IEnumerable<LightEntity> target, YeelightSetColorSceneParameters data)
		{
			target.CallService("set_color_scene", data);
		}

		///<summary>Changes the light to the specified RGB color and brightness. If the light is off, it will be turned on.</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="brightness">The brightness value to set.</param>
		public static void SetColorScene(this LightEntity target, object? @rgbColor = null, long? @brightness = null)
		{
			target.CallService("set_color_scene", new YeelightSetColorSceneParameters{RgbColor = @rgbColor, Brightness = @brightness});
		}

		///<summary>Changes the light to the specified RGB color and brightness. If the light is off, it will be turned on.</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="brightness">The brightness value to set.</param>
		public static void SetColorScene(this IEnumerable<LightEntity> target, object? @rgbColor = null, long? @brightness = null)
		{
			target.CallService("set_color_scene", new YeelightSetColorSceneParameters{RgbColor = @rgbColor, Brightness = @brightness});
		}

		///<summary>Changes the light to the specified color temperature. If the light is off, it will be turned on.</summary>
		public static void SetColorTempScene(this LightEntity target, YeelightSetColorTempSceneParameters data)
		{
			target.CallService("set_color_temp_scene", data);
		}

		///<summary>Changes the light to the specified color temperature. If the light is off, it will be turned on.</summary>
		public static void SetColorTempScene(this IEnumerable<LightEntity> target, YeelightSetColorTempSceneParameters data)
		{
			target.CallService("set_color_temp_scene", data);
		}

		///<summary>Changes the light to the specified color temperature. If the light is off, it will be turned on.</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">The brightness value to set.</param>
		public static void SetColorTempScene(this LightEntity target, long? @kelvin = null, long? @brightness = null)
		{
			target.CallService("set_color_temp_scene", new YeelightSetColorTempSceneParameters{Kelvin = @kelvin, Brightness = @brightness});
		}

		///<summary>Changes the light to the specified color temperature. If the light is off, it will be turned on.</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">The brightness value to set.</param>
		public static void SetColorTempScene(this IEnumerable<LightEntity> target, long? @kelvin = null, long? @brightness = null)
		{
			target.CallService("set_color_temp_scene", new YeelightSetColorTempSceneParameters{Kelvin = @kelvin, Brightness = @brightness});
		}

		///<summary>Changes the light to the specified HSV color and brightness. If the light is off, it will be turned on.</summary>
		public static void SetHsvScene(this LightEntity target, YeelightSetHsvSceneParameters data)
		{
			target.CallService("set_hsv_scene", data);
		}

		///<summary>Changes the light to the specified HSV color and brightness. If the light is off, it will be turned on.</summary>
		public static void SetHsvScene(this IEnumerable<LightEntity> target, YeelightSetHsvSceneParameters data)
		{
			target.CallService("set_hsv_scene", data);
		}

		///<summary>Changes the light to the specified HSV color and brightness. If the light is off, it will be turned on.</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-359 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="brightness">The brightness value to set.</param>
		public static void SetHsvScene(this LightEntity target, object? @hsColor = null, long? @brightness = null)
		{
			target.CallService("set_hsv_scene", new YeelightSetHsvSceneParameters{HsColor = @hsColor, Brightness = @brightness});
		}

		///<summary>Changes the light to the specified HSV color and brightness. If the light is off, it will be turned on.</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-359 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="brightness">The brightness value to set.</param>
		public static void SetHsvScene(this IEnumerable<LightEntity> target, object? @hsColor = null, long? @brightness = null)
		{
			target.CallService("set_hsv_scene", new YeelightSetHsvSceneParameters{HsColor = @hsColor, Brightness = @brightness});
		}

		///<summary>Set a operation mode.</summary>
		public static void SetMode(this LightEntity target, YeelightSetModeParameters data)
		{
			target.CallService("set_mode", data);
		}

		///<summary>Set a operation mode.</summary>
		public static void SetMode(this IEnumerable<LightEntity> target, YeelightSetModeParameters data)
		{
			target.CallService("set_mode", data);
		}

		///<summary>Set a operation mode.</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="mode">Operation mode.</param>
		public static void SetMode(this LightEntity target, object @mode)
		{
			target.CallService("set_mode", new YeelightSetModeParameters{Mode = @mode});
		}

		///<summary>Set a operation mode.</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="mode">Operation mode.</param>
		public static void SetMode(this IEnumerable<LightEntity> target, object @mode)
		{
			target.CallService("set_mode", new YeelightSetModeParameters{Mode = @mode});
		}

		///<summary>Enable or disable music_mode</summary>
		public static void SetMusicMode(this LightEntity target, YeelightSetMusicModeParameters data)
		{
			target.CallService("set_music_mode", data);
		}

		///<summary>Enable or disable music_mode</summary>
		public static void SetMusicMode(this IEnumerable<LightEntity> target, YeelightSetMusicModeParameters data)
		{
			target.CallService("set_music_mode", data);
		}

		///<summary>Enable or disable music_mode</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="musicMode">Use true or false to enable / disable music_mode</param>
		public static void SetMusicMode(this LightEntity target, bool @musicMode)
		{
			target.CallService("set_music_mode", new YeelightSetMusicModeParameters{MusicMode = @musicMode});
		}

		///<summary>Enable or disable music_mode</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="musicMode">Use true or false to enable / disable music_mode</param>
		public static void SetMusicMode(this IEnumerable<LightEntity> target, bool @musicMode)
		{
			target.CallService("set_music_mode", new YeelightSetMusicModeParameters{MusicMode = @musicMode});
		}

		///<summary>Start a custom flow, using transitions from https://yeelight.readthedocs.io/en/stable/yeelight.html#flow-objects</summary>
		public static void StartFlow(this LightEntity target, YeelightStartFlowParameters data)
		{
			target.CallService("start_flow", data);
		}

		///<summary>Start a custom flow, using transitions from https://yeelight.readthedocs.io/en/stable/yeelight.html#flow-objects</summary>
		public static void StartFlow(this IEnumerable<LightEntity> target, YeelightStartFlowParameters data)
		{
			target.CallService("start_flow", data);
		}

		///<summary>Start a custom flow, using transitions from https://yeelight.readthedocs.io/en/stable/yeelight.html#flow-objects</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="count">The number of times to run this flow (0 to run forever).</param>
		///<param name="action">The action to take after the flow stops.</param>
		///<param name="transitions">Array of transitions, for desired effect. Examples https://yeelight.readthedocs.io/en/stable/flow.html eg: [{ "TemperatureTransition": [1900, 1000, 80] }, { "TemperatureTransition": [1900, 1000, 10] }]</param>
		public static void StartFlow(this LightEntity target, long? @count = null, object? @action = null, object? @transitions = null)
		{
			target.CallService("start_flow", new YeelightStartFlowParameters{Count = @count, Action = @action, Transitions = @transitions});
		}

		///<summary>Start a custom flow, using transitions from https://yeelight.readthedocs.io/en/stable/yeelight.html#flow-objects</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="count">The number of times to run this flow (0 to run forever).</param>
		///<param name="action">The action to take after the flow stops.</param>
		///<param name="transitions">Array of transitions, for desired effect. Examples https://yeelight.readthedocs.io/en/stable/flow.html eg: [{ "TemperatureTransition": [1900, 1000, 80] }, { "TemperatureTransition": [1900, 1000, 10] }]</param>
		public static void StartFlow(this IEnumerable<LightEntity> target, long? @count = null, object? @action = null, object? @transitions = null)
		{
			target.CallService("start_flow", new YeelightStartFlowParameters{Count = @count, Action = @action, Transitions = @transitions});
		}
	}

	public static class ZhaEntityExtensionMethods
	{
		///<summary>Clear a user code from a lock</summary>
		public static void ClearLockUserCode(this LockEntity target, ZhaClearLockUserCodeParameters data)
		{
			target.CallService("clear_lock_user_code", data);
		}

		///<summary>Clear a user code from a lock</summary>
		public static void ClearLockUserCode(this IEnumerable<LockEntity> target, ZhaClearLockUserCodeParameters data)
		{
			target.CallService("clear_lock_user_code", data);
		}

		///<summary>Clear a user code from a lock</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="codeSlot">Code slot to clear code from eg: 1</param>
		public static void ClearLockUserCode(this LockEntity target, string @codeSlot)
		{
			target.CallService("clear_lock_user_code", new ZhaClearLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Clear a user code from a lock</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="codeSlot">Code slot to clear code from eg: 1</param>
		public static void ClearLockUserCode(this IEnumerable<LockEntity> target, string @codeSlot)
		{
			target.CallService("clear_lock_user_code", new ZhaClearLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Disable a user code on a lock</summary>
		public static void DisableLockUserCode(this LockEntity target, ZhaDisableLockUserCodeParameters data)
		{
			target.CallService("disable_lock_user_code", data);
		}

		///<summary>Disable a user code on a lock</summary>
		public static void DisableLockUserCode(this IEnumerable<LockEntity> target, ZhaDisableLockUserCodeParameters data)
		{
			target.CallService("disable_lock_user_code", data);
		}

		///<summary>Disable a user code on a lock</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="codeSlot">Code slot to disable eg: 1</param>
		public static void DisableLockUserCode(this LockEntity target, string @codeSlot)
		{
			target.CallService("disable_lock_user_code", new ZhaDisableLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Disable a user code on a lock</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="codeSlot">Code slot to disable eg: 1</param>
		public static void DisableLockUserCode(this IEnumerable<LockEntity> target, string @codeSlot)
		{
			target.CallService("disable_lock_user_code", new ZhaDisableLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Enable a user code on a lock</summary>
		public static void EnableLockUserCode(this LockEntity target, ZhaEnableLockUserCodeParameters data)
		{
			target.CallService("enable_lock_user_code", data);
		}

		///<summary>Enable a user code on a lock</summary>
		public static void EnableLockUserCode(this IEnumerable<LockEntity> target, ZhaEnableLockUserCodeParameters data)
		{
			target.CallService("enable_lock_user_code", data);
		}

		///<summary>Enable a user code on a lock</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="codeSlot">Code slot to enable eg: 1</param>
		public static void EnableLockUserCode(this LockEntity target, string @codeSlot)
		{
			target.CallService("enable_lock_user_code", new ZhaEnableLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Enable a user code on a lock</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="codeSlot">Code slot to enable eg: 1</param>
		public static void EnableLockUserCode(this IEnumerable<LockEntity> target, string @codeSlot)
		{
			target.CallService("enable_lock_user_code", new ZhaEnableLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Set a user code on a lock</summary>
		public static void SetLockUserCode(this LockEntity target, ZhaSetLockUserCodeParameters data)
		{
			target.CallService("set_lock_user_code", data);
		}

		///<summary>Set a user code on a lock</summary>
		public static void SetLockUserCode(this IEnumerable<LockEntity> target, ZhaSetLockUserCodeParameters data)
		{
			target.CallService("set_lock_user_code", data);
		}

		///<summary>Set a user code on a lock</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="codeSlot">Code slot to set the code in eg: 1</param>
		///<param name="userCode">Code to set eg: 1234</param>
		public static void SetLockUserCode(this LockEntity target, string @codeSlot, string @userCode)
		{
			target.CallService("set_lock_user_code", new ZhaSetLockUserCodeParameters{CodeSlot = @codeSlot, UserCode = @userCode});
		}

		///<summary>Set a user code on a lock</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="codeSlot">Code slot to set the code in eg: 1</param>
		///<param name="userCode">Code to set eg: 1234</param>
		public static void SetLockUserCode(this IEnumerable<LockEntity> target, string @codeSlot, string @userCode)
		{
			target.CallService("set_lock_user_code", new ZhaSetLockUserCodeParameters{CodeSlot = @codeSlot, UserCode = @userCode});
		}
	}
}