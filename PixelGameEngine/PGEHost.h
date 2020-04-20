#pragma once
namespace olc
{
	class PGEHost : public olc::PixelGameEngine
	{
		public:
			static PGEHost* instance;
			static PGEHost* getInstance()
			{
				if (instance != NULL)
				{
					return instance;
				}
				else { return nullptr; }
			}

	public:
		bool OnUserCreate() override;
		void OnUserCreate_setFunc(OnUserCreate_func func);
		void OnUserUpdate_setFunc(OnUserUpdate_func func);
		bool OnUserUpdate(float fElapsedTime) override;


	private:
		OnUserCreate_func remoteOnUserCreate = nullptr;
		OnUserUpdate_func remoteOnUserUpdate = nullptr;

	};

}